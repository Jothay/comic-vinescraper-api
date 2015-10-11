// <auto-generated>
// <copyright file="Locations.ILocationVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationVolumesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Locations
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class LocationVolumesMockingSetup
    {
        public static Mock<ILocationVolumeModel> DoMockingSetupForLocationVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationVolumeModel = new Mock<ILocationVolumeModel>();
            // Mock Functions
            mockLocationVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockLocationVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockLocationVolumeModel.Setup(m => m.Name).Returns(() => name);
            //mockLocationVolumeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockLocationVolumeModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockLocationVolumeModel.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationVolumeModel.Setup(m => m.Location).Returns(() => new LocationModel());
            mockLocationVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockLocationVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockLocationVolumeModel;
        }

        public static Mock<ILocationVolume> DoMockingSetupForLocationVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationVolume = new Mock<ILocationVolume>();
            // Mock Functions
            mockLocationVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationVolume.Setup(m => m.Active).Returns(() => true);
            mockLocationVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockLocationVolume.Setup(m => m.Name).Returns(() => name);
            //mockLocationVolume.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockLocationVolume.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockLocationVolume.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationVolume.Setup(m => m.Location).Returns(() => new Location());
            mockLocationVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockLocationVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockLocationVolume;
        }
    }

    public class LocationVolumeMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<LocationVolumeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ILocationVolumeModel>()));
            var mockModel = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1);
            LocationVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ILocationVolumeModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<LocationVolumeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ILocationVolumeModel>(), ref It.IsAny<ILocationVolume>()));
        //    var mockModel = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1);
        //    var mockEntity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
        //    LocationVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ILocationVolumeModel>(), ref It.IsAny<ILocationVolume>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationVolumeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ILocationVolume>()));
            var mockEntity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            LocationVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ILocationVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ILocationVolume>()));
            var mockEntity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            LocationVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ILocationVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ILocationVolume>()));
            var mockEntity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            LocationVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ILocationVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationVolumeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ILocationVolumeModel>()));
            var mockModel = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1);
            LocationVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ILocationVolumeModel>()), Times.Once);
        }

        public static Mock<ILocationVolume> DoMockingSetupForLocationVolume(int idReturnValue = 0)
        {
            var mockLocationVolume = new Mock<ILocationVolume>();
            // Mock Functions
            mockLocationVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationVolume.Setup(m => m.Active).Returns(() => true);
            mockLocationVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockLocationVolume.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationVolume.Setup(m => m.Location).Returns(() => new Location());
            mockLocationVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockLocationVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockLocationVolume;
        }
    }

    public class LocationVolumesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsLocationVolumeProperties()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.LocationId, entity.LocationId);
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsLocationVolumeProperties()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel();
            // Act
            ILocationVolume existingEntity = new LocationVolume { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.LocationId, existingEntity.LocationId);
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsLocationVolumeProperties()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var entity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyLocationVolumeProperties()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var entity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyLocationVolumeProperties()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var entity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsLocationVolumeSearchProperties()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.LocationId, searchModel.LocationId);
            Assert.Equal(model.Object.Location?.CustomKey, searchModel.LocationCustomKey);
            Assert.Equal(model.Object.Location?.ApiDetailUrl, searchModel.LocationApiDetailUrl);
            Assert.Equal(model.Object.Location?.SiteDetailUrl, searchModel.LocationSiteDetailUrl);
            Assert.Equal(model.Object.Location?.Name, searchModel.LocationName);
            Assert.Equal(model.Object.Location?.ShortDescription, searchModel.LocationShortDescription);
            Assert.Equal(model.Object.Location?.Description, searchModel.LocationDescription);
            Assert.Equal(model.Object.VolumeId, searchModel.VolumeId);
            Assert.Equal(model.Object.Volume?.CustomKey, searchModel.VolumeCustomKey);
            Assert.Equal(model.Object.Volume?.ApiDetailUrl, searchModel.VolumeApiDetailUrl);
            Assert.Equal(model.Object.Volume?.SiteDetailUrl, searchModel.VolumeSiteDetailUrl);
            Assert.Equal(model.Object.Volume?.Name, searchModel.VolumeName);
            Assert.Equal(model.Object.Volume?.ShortDescription, searchModel.VolumeShortDescription);
            Assert.Equal(model.Object.Volume?.Description, searchModel.VolumeDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1);
            var entity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new LocationVolumeMapper();
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1);
            var entity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
