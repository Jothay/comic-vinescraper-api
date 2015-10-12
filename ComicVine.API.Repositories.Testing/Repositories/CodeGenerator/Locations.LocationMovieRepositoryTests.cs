// <auto-generated>
// <copyright file="Locations.ILocationMovieRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationMoviesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Locations
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

    public static class LocationMoviesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeLocationMoviesData, out Mock<IDbSet<LocationMovie>> mockSetLocationMovies, bool markALocationMovieInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetLocationMovies = new Mock<IDbSet<LocationMovie>>();
            var personData = (!includeLocationMoviesData ? new List<LocationMovie>() : new List<LocationMovie>
            {
                new LocationMovie { Id = 1, Active = !markALocationMovieInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new LocationMovie { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetLocationMovies.As<IQueryable<LocationMovie>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetLocationMovies.As<IQueryable<LocationMovie>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetLocationMovies.As<IQueryable<LocationMovie>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetLocationMovies.As<IQueryable<LocationMovie>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.LocationMovies).Returns(mockSetLocationMovies.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class LocationMoviesRepositoryTests
    {
        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(false, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var locationMovies = new LocationMovie { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(locationMovies);
            // Assert
            mockSetLocationMovies.Verify(x => x.Add(locationMovies), Times.Once);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var locationMovies = repository.Get(1);
            // Act
            repository.Remove(locationMovies);
            // Assert
            mockSetLocationMovies.Verify(x => x.Remove((LocationMovie)locationMovies), Times.Once);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var locationMovies = repository.Get(1);
            // Act
            repository.Deactivate(locationMovies);
            // Assert
            Assert.Equal(false, locationMovies.Active);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var locationMovies = repository.Get(1);
            locationMovies.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(locationMovies);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectLocationMovie()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            // Act
            var locationMovies = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", locationMovies.ApiDetailUrl);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectLocationMovie()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            // Act
            var locationMovies = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", locationMovies.ApiDetailUrl);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_List_Should_ReturnAListOfLocationMoviesWithData()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            // Act
            var locationMovies = repository.List.ToArray();
            // Assert
            Assert.Equal(2, locationMovies.Length);
            Assert.Equal(1, locationMovies[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", locationMovies[0].ApiDetailUrl);
            Assert.Equal(2, locationMovies[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationMovies[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Search_Should_ReturnAListOfLocationMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies, true);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var searchModel = new Mock<ILocationMovieSearchModel>();
            // Act
            var locationMovies = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, locationMovies.Length);
            Assert.Equal(2, locationMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies, true);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var searchModel = new Mock<ILocationMovieSearchModel>();
            // Act
            var locationMovies = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, locationMovies.Length);
            Assert.Equal(2, locationMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationMovies[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfLocationMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies, true);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ILocationMovieSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new LocationMovieSearchModel { ModifiedSince = createDate };
            // Act
            var locationMovies = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationMovies.Length);
            Assert.Equal(2, locationMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "LocationMovies")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfLocationMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationMovie>> mockSetLocationMovies;
            var mockContext = LocationMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationMovies);
            var repository = new LocationMoviesRepository(mockContext.Object);
            var searchModel = new LocationMovieSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var locationMovies = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationMovies.Length);
            Assert.Equal(2, locationMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
