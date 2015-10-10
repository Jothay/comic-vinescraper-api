namespace ComicVine.API.Testing.BusinessWorkflows.Authors
{
    using System;
    using System.Collections.Generic;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Mappings.Authors;
    using Mocking;
    using Models;
    using Moq;
    using ComicVine.API.BusinessWorkflows.Authors;
    using Xunit;

    public class AuthorsBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            // Act
            var author = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<AuthorModel>(author);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            // Act
            var author = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<AuthorModel>(author);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfAuthors()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IAuthorSearchModel>();
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockAuthorsRepository.Verify(m => m.Search(It.IsAny<IAuthorSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfAuthorsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IAuthorSearchModel>();
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockAuthorsRepository.Verify(m => m.Search(It.IsAny<IAuthorSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            mockAuthorsRepository.Setup(m => m.Search(It.IsAny<IAuthorSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IAuthor>>().Object);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockAuthorsRepository.Verify(m => m.Add(It.IsAny<IAuthor>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var mockAuthor = AuthorsMockingSetup.DoMockingSetupForAuthor(1);
            mockAuthorsRepository.Setup(m => m.Search(It.IsAny<IAuthorSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IAuthor> { mockAuthor.Object } );
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockAuthor.Object);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockAuthorsRepository.Verify(m => m.Add(It.IsAny<IAuthor>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockAuthor = AuthorsMockingSetup.DoMockingSetupForAuthor(1);
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockAuthor.Object);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            var expectedName = "Stephen King (2)";
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockAuthor.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor(1);
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel(1);
            IAuthorModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("Stephen King", result.Name);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IAuthor>().Object);
            mockAuthorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockAuthorsRepository.Verify(m => m.Deactivate(It.IsAny<IAuthor>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IAuthor>().Object);
            mockAuthorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockAuthorsRepository.Verify(m => m.Deactivate(It.IsAny<IAuthor>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            // Act/Assert
            Assert.Throws<InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            // Act/Assert
            Assert.Throws<InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IAuthor>().Object);
            mockAuthorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockAuthorsRepository.Verify(m => m.Remove(It.IsAny<IAuthor>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            var mockAuthorsMapper = new Mock<IAuthorMapper>();
            mockAuthorsMapper.Setup(m => m.AreEqual(It.IsAny<IAuthorModel>(), It.IsAny<IAuthor>())).Returns(() => true);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, mockAuthorsMapper.Object);
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IAuthor>().Object);
            mockAuthorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockAuthorsRepository.Verify(m => m.Remove(It.IsAny<IAuthor>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockAuthorsRepository = AuthorsMockingSetup.DoMockingSetupForRepository();
            mockAuthorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new AuthorsBusinessWorkflow(mockAuthorsRepository.Object, new AuthorMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
