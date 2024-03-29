// <auto-generated>
// <copyright file="Objects.ObjectMovieRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ObjectMoviesRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Objects
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using API.Repositories;
    using DataModel.Schema;
    using Interfaces.SearchModels;
    using Moq;
    using SearchModels;
    using Xunit;

    public static class ObjectMoviesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeObjectMoviesData, out Mock<IDbSet<ObjectMovie>> mockSetObjectMovies, bool markAObjectMovieInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetObjectMovies = new Mock<IDbSet<ObjectMovie>>();
            var personData = (!includeObjectMoviesData ? new List<ObjectMovie>() : new List<ObjectMovie>
            {
                new ObjectMovie { Id = 1, Active = !markAObjectMovieInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new ObjectMovie { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetObjectMovies.As<IQueryable<ObjectMovie>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetObjectMovies.As<IQueryable<ObjectMovie>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetObjectMovies.As<IQueryable<ObjectMovie>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetObjectMovies.As<IQueryable<ObjectMovie>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.ObjectMovies).Returns(mockSetObjectMovies.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class ObjectMoviesRepositoryTests
    {
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(false, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var objectMovies = new ObjectMovie { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(objectMovies);
            // Assert
            mockSetObjectMovies.Verify(x => x.Add(objectMovies), Times.Once);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var objectMovies = repository.Get(1);
            // Act
            repository.Remove(objectMovies);
            // Assert
            mockSetObjectMovies.Verify(x => x.Remove((ObjectMovie)objectMovies), Times.Once);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var objectMovies = repository.Get(1);
            // Act
            repository.Deactivate(objectMovies);
            // Assert
            Assert.Equal(false, objectMovies.Active);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var objectMovies = repository.Get(1);
            objectMovies.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(objectMovies);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectMovie()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            // Act
            var objectMovies = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", objectMovies.ApiDetailUrl);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObjectMovie()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            // Act
            var objectMovies = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", objectMovies.ApiDetailUrl);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_List_Should_ReturnAListOfObjectMoviesWithData()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            // Act
            var objectMovies = repository.List.ToArray();
            // Assert
            Assert.Equal(2, objectMovies.Length);
            Assert.Equal(1, objectMovies[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", objectMovies[0].ApiDetailUrl);
            Assert.Equal(2, objectMovies[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", objectMovies[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Search_Should_ReturnAListOfObjectMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies, true);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var searchModel = new Mock<IObjectMovieSearchModel>();
            // Act
            var objectMovies = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, objectMovies.Length);
            Assert.Equal(2, objectMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", objectMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies, true);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var searchModel = new Mock<IObjectMovieSearchModel>();
            // Act
            var objectMovies = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, objectMovies.Length);
            Assert.Equal(2, objectMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", objectMovies[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfObjectMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies, true);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IObjectMovieSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new ObjectMovieSearchModel { ModifiedSince = createDate };
            // Act
            var objectMovies = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, objectMovies.Length);
            Assert.Equal(2, objectMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", objectMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfObjectMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<ObjectMovie>> mockSetObjectMovies;
            var mockContext = ObjectMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetObjectMovies);
            var repository = new ObjectMoviesRepository(mockContext.Object);
            var searchModel = new ObjectMovieSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var objectMovies = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, objectMovies.Length);
            Assert.Equal(2, objectMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", objectMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
