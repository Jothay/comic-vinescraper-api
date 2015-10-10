namespace ComicVine.API.Testing.Repositories.Authors
{
    using System;
    using System.Data.Entity;
    using System.Linq;
    using API.Repositories;
    using DataModel.Schema;
    using Interfaces.SearchModels;
    using Mocking;
    using Moq;
    using SearchModels;
    using Xunit;

    public class AuthorsRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(false, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            var author = new Author { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
            // Act
            repository.Add(author);
            // Assert
            mockSetAuthors.Verify(x => x.Add(author), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            var author = repository.Get(1);
            // Act
            repository.Remove(author);
            // Assert
            mockSetAuthors.Verify(x => x.Remove((Author)author), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            var author = repository.Get(1);
            // Act
            repository.Deactivate(author);
            // Assert
            Assert.Equal(false, author.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            var author = repository.Get(1);
            author.Name = "TEST";
            // Act
            repository.Update(author);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectAuthor()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            // Act
            var author = repository.Get(1);
            // Assert
            Assert.Equal("Stephen King", author.Name);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectAuthor()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            // Act
            var author = repository.Get("KING-STEPHEN");
            // Assert
            Assert.Equal("Stephen King", author.Name);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfAuthorsWithData()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            // Act
            var authors = repository.List.ToArray();
            // Assert
            Assert.Equal(2, authors.Length);
            Assert.Equal(1, authors[0].Id);
            Assert.Equal("Stephen King", authors[0].Name);
            Assert.Equal(2, authors[1].Id);
            Assert.Equal("Larry Niven", authors[1].Name);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfAuthorsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors, true);
            var repository = new AuthorsRepository(mockContext.Object);
            var searchModel = new Mock<IAuthorSearchModel>();
            // Act
            var authors = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, authors.Length);
            Assert.Equal(2, authors[0].Id);
            Assert.Equal("Larry Niven", authors[0].Name);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors, true);
            var repository = new AuthorsRepository(mockContext.Object);
            var searchModel = new Mock<IAuthorSearchModel>();
            // Act
            var authors = repository.Search(searchModel.Object, i => new { i.Id, MyName = i.Name }).ToArray();
            // Assert
            Assert.Equal(1, authors.Length);
            Assert.Equal(2, authors[0].Id);
            Assert.Equal("Larry Niven", authors[0].MyName);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfAuthorsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors, true);
            var repository = new AuthorsRepository(mockContext.Object);
            var createDate = new DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IAuthorSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new AuthorSearchModel { ModifiedSince = createDate };
            // Act
            var authors = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, authors.Length);
            Assert.Equal(2, authors[0].Id);
            Assert.Equal("Larry Niven", authors[0].Name);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfAuthorsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Author>> mockSetAuthors;
            var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockSetAuthors);
            var repository = new AuthorsRepository(mockContext.Object);
            var searchModel = new AuthorSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var authors = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, authors.Length);
            Assert.Equal(2, authors[0].Id);
            Assert.Equal("Larry Niven", authors[0].Name);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
