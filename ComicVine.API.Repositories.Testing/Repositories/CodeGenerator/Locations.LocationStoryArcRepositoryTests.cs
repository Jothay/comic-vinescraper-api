// <auto-generated>
// <copyright file="Locations.ILocationStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationStoryArcsRepository Class.</summary>
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

    public static class LocationStoryArcsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeLocationStoryArcsData, out Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs, bool markALocationStoryArcInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetLocationStoryArcs = new Mock<IDbSet<LocationStoryArc>>();
            var personData = (!includeLocationStoryArcsData ? new List<LocationStoryArc>() : new List<LocationStoryArc>
            {
                new LocationStoryArc { Id = 1, Active = !markALocationStoryArcInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new LocationStoryArc { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetLocationStoryArcs.As<IQueryable<LocationStoryArc>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetLocationStoryArcs.As<IQueryable<LocationStoryArc>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetLocationStoryArcs.As<IQueryable<LocationStoryArc>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetLocationStoryArcs.As<IQueryable<LocationStoryArc>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.LocationStoryArcs).Returns(mockSetLocationStoryArcs.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class LocationStoryArcsRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(false, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var locationStoryArcs = new LocationStoryArc { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(locationStoryArcs);
            // Assert
            mockSetLocationStoryArcs.Verify(x => x.Add(locationStoryArcs), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var locationStoryArcs = repository.Get(1);
            // Act
            repository.Remove(locationStoryArcs);
            // Assert
            mockSetLocationStoryArcs.Verify(x => x.Remove((LocationStoryArc)locationStoryArcs), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var locationStoryArcs = repository.Get(1);
            // Act
            repository.Deactivate(locationStoryArcs);
            // Assert
            Assert.Equal(false, locationStoryArcs.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var locationStoryArcs = repository.Get(1);
            locationStoryArcs.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(locationStoryArcs);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectLocationStoryArc()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            // Act
            var locationStoryArcs = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", locationStoryArcs.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectLocationStoryArc()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            // Act
            var locationStoryArcs = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", locationStoryArcs.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfLocationStoryArcsWithData()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            // Act
            var locationStoryArcs = repository.List.ToArray();
            // Assert
            Assert.Equal(2, locationStoryArcs.Length);
            Assert.Equal(1, locationStoryArcs[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", locationStoryArcs[0].ApiDetailUrl);
            Assert.Equal(2, locationStoryArcs[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationStoryArcs[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfLocationStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs, true);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<ILocationStoryArcSearchModel>();
            // Act
            var locationStoryArcs = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, locationStoryArcs.Length);
            Assert.Equal(2, locationStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs, true);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<ILocationStoryArcSearchModel>();
            // Act
            var locationStoryArcs = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, locationStoryArcs.Length);
            Assert.Equal(2, locationStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationStoryArcs[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfLocationStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs, true);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ILocationStoryArcSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new LocationStoryArcSearchModel { ModifiedSince = createDate };
            // Act
            var locationStoryArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationStoryArcs.Length);
            Assert.Equal(2, locationStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfLocationStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationStoryArc>> mockSetLocationStoryArcs;
            var mockContext = LocationStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetLocationStoryArcs);
            var repository = new LocationStoryArcsRepository(mockContext.Object);
            var searchModel = new LocationStoryArcSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var locationStoryArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationStoryArcs.Length);
            Assert.Equal(2, locationStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
