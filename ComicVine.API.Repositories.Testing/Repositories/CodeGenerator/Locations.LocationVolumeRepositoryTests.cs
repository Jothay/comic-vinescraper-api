// <auto-generated>
// <copyright file="Locations.ILocationVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationVolumesRepository Class.</summary>
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

    public static class LocationVolumesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeLocationVolumesData, out Mock<IDbSet<LocationVolume>> mockSetLocationVolumes, bool markALocationVolumeInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetLocationVolumes = new Mock<IDbSet<LocationVolume>>();
            var personData = (!includeLocationVolumesData ? new List<LocationVolume>() : new List<LocationVolume>
            {
                new LocationVolume { Id = 1, Active = !markALocationVolumeInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new LocationVolume { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetLocationVolumes.As<IQueryable<LocationVolume>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetLocationVolumes.As<IQueryable<LocationVolume>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetLocationVolumes.As<IQueryable<LocationVolume>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetLocationVolumes.As<IQueryable<LocationVolume>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.LocationVolumes).Returns(mockSetLocationVolumes.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class LocationVolumesRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(false, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var locationVolumes = new LocationVolume { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(locationVolumes);
            // Assert
            mockSetLocationVolumes.Verify(x => x.Add(locationVolumes), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var locationVolumes = repository.Get(1);
            // Act
            repository.Remove(locationVolumes);
            // Assert
            mockSetLocationVolumes.Verify(x => x.Remove((LocationVolume)locationVolumes), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var locationVolumes = repository.Get(1);
            // Act
            repository.Deactivate(locationVolumes);
            // Assert
            Assert.Equal(false, locationVolumes.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var locationVolumes = repository.Get(1);
            locationVolumes.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(locationVolumes);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectLocationVolume()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            // Act
            var locationVolumes = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", locationVolumes.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectLocationVolume()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            // Act
            var locationVolumes = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", locationVolumes.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfLocationVolumesWithData()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            // Act
            var locationVolumes = repository.List.ToArray();
            // Assert
            Assert.Equal(2, locationVolumes.Length);
            Assert.Equal(1, locationVolumes[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", locationVolumes[0].ApiDetailUrl);
            Assert.Equal(2, locationVolumes[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationVolumes[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfLocationVolumesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes, true);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var searchModel = new Mock<ILocationVolumeSearchModel>();
            // Act
            var locationVolumes = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, locationVolumes.Length);
            Assert.Equal(2, locationVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationVolumes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes, true);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var searchModel = new Mock<ILocationVolumeSearchModel>();
            // Act
            var locationVolumes = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, locationVolumes.Length);
            Assert.Equal(2, locationVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationVolumes[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfLocationVolumesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes, true);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ILocationVolumeSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new LocationVolumeSearchModel { ModifiedSince = createDate };
            // Act
            var locationVolumes = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationVolumes.Length);
            Assert.Equal(2, locationVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationVolumes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfLocationVolumesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<LocationVolume>> mockSetLocationVolumes;
            var mockContext = LocationVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetLocationVolumes);
            var repository = new LocationVolumesRepository(mockContext.Object);
            var searchModel = new LocationVolumeSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var locationVolumes = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, locationVolumes.Length);
            Assert.Equal(2, locationVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", locationVolumes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
