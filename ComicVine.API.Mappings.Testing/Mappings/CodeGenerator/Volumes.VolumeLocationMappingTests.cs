// <auto-generated>
// <copyright file="Volumes.IVolumeLocationRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeLocationsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Volumes
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class VolumeLocationsMockingSetup
    {
        public static Mock<IVolumeLocationModel> DoMockingSetupForVolumeLocationModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeLocationModel = new Mock<IVolumeLocationModel>();
            // Mock Functions
            mockVolumeLocationModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeLocationModel.Setup(m => m.Active).Returns(() => true);
            mockVolumeLocationModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeLocationModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeLocationModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeLocationModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeLocationModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVolumeLocationModel.Setup(m => m.Name).Returns(() => name);
            //mockVolumeLocationModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVolumeLocationModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockVolumeLocationModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeLocationModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            mockVolumeLocationModel.Setup(m => m.LocationId).Returns(() => 1);
            mockVolumeLocationModel.Setup(m => m.Location).Returns(() => new LocationModel());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeLocationModel;
        }

        public static Mock<IVolumeLocation> DoMockingSetupForVolumeLocation(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeLocation = new Mock<IVolumeLocation>();
            // Mock Functions
            mockVolumeLocation.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeLocation.Setup(m => m.Active).Returns(() => true);
            mockVolumeLocation.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeLocation.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeLocation.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeLocation.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeLocation.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVolumeLocation.Setup(m => m.Name).Returns(() => name);
            //mockVolumeLocation.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVolumeLocation.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockVolumeLocation.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeLocation.Setup(m => m.Volume).Returns(() => new Volume());
            mockVolumeLocation.Setup(m => m.LocationId).Returns(() => 1);
            mockVolumeLocation.Setup(m => m.Location).Returns(() => new Location());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeLocation;
        }
    }

    public class VolumeLocationMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<VolumeLocationMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVolumeLocationModel>()));
            var mockModel = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel(1);
            VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVolumeLocationModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<VolumeLocationMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVolumeLocationModel>(), ref It.IsAny<IVolumeLocation>()));
        //    var mockModel = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel(1);
        //    var mockEntity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(1);
        //    VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVolumeLocationModel>(), ref It.IsAny<IVolumeLocation>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeLocationMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IVolumeLocation>()));
            var mockEntity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(1);
            VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IVolumeLocation>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeLocationMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IVolumeLocation>()));
            var mockEntity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(1);
            VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IVolumeLocation>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeLocationMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IVolumeLocation>()));
            var mockEntity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(1);
            VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IVolumeLocation>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeLocationMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IVolumeLocationModel>()));
            var mockModel = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel(1);
            VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IVolumeLocationModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<VolumeLocationMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IVolumeLocationModel>(), It.IsAny<IVolumeLocation>()));
            VolumeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel(1);
            var mockEntity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IVolumeLocationModel>(), It.IsAny<IVolumeLocation>()), Times.Once);
        }
    }

    public class VolumeLocationsMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsVolumeLocationProperties()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var model = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            Assert.Equal(model.Object.LocationId, entity.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsVolumeLocationProperties()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var model = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel();
            // Act
            IVolumeLocation existingEntity = new VolumeLocation { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            Assert.Equal(model.Object.LocationId, existingEntity.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsVolumeLocationProperties()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var entity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyVolumeLocationProperties()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var entity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyVolumeLocationProperties()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var entity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsVolumeLocationSearchProperties()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var model = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.VolumeId, searchModel.VolumeId);
            Assert.Equal(model.Object.Volume?.CustomKey, searchModel.VolumeCustomKey);
            Assert.Equal(model.Object.Volume?.ApiDetailUrl, searchModel.VolumeApiDetailUrl);
            Assert.Equal(model.Object.Volume?.SiteDetailUrl, searchModel.VolumeSiteDetailUrl);
            Assert.Equal(model.Object.Volume?.Name, searchModel.VolumeName);
            Assert.Equal(model.Object.Volume?.ShortDescription, searchModel.VolumeShortDescription);
            Assert.Equal(model.Object.Volume?.Description, searchModel.VolumeDescription);
            Assert.Equal(model.Object.LocationId, searchModel.LocationId);
            Assert.Equal(model.Object.Location?.CustomKey, searchModel.LocationCustomKey);
            Assert.Equal(model.Object.Location?.ApiDetailUrl, searchModel.LocationApiDetailUrl);
            Assert.Equal(model.Object.Location?.SiteDetailUrl, searchModel.LocationSiteDetailUrl);
            Assert.Equal(model.Object.Location?.Name, searchModel.LocationName);
            Assert.Equal(model.Object.Location?.ShortDescription, searchModel.LocationShortDescription);
            Assert.Equal(model.Object.Location?.Description, searchModel.LocationDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var model = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel(1);
            var entity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new VolumeLocationMapper();
            var model = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocationModel(1);
            var entity = VolumeLocationsMockingSetup.DoMockingSetupForVolumeLocation(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
