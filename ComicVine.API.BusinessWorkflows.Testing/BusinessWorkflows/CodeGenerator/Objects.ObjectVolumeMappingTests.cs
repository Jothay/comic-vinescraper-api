// <auto-generated>
// <copyright file="Objects.IObjectVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectVolumesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Objects
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ObjectVolumesMockingSetup
    {
        public static Mock<IObjectVolumeModel> DoMockingSetupForObjectVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectVolumeModel = new Mock<IObjectVolumeModel>();
            // Mock Functions
            mockObjectVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockObjectVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockObjectVolumeModel.Setup(m => m.Name).Returns(() => name);
            //mockObjectVolumeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockObjectVolumeModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectVolumeModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectVolumeModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            mockObjectVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockObjectVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockObjectVolumeModel;
        }

        public static Mock<IObjectVolume> DoMockingSetupForObjectVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectVolume = new Mock<IObjectVolume>();
            // Mock Functions
            mockObjectVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectVolume.Setup(m => m.Active).Returns(() => true);
            mockObjectVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockObjectVolume.Setup(m => m.Name).Returns(() => name);
            //mockObjectVolume.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockObjectVolume.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectVolume.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectVolume.Setup(m => m.Object).Returns(() => new Object());
            mockObjectVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockObjectVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockObjectVolume;
        }
    }

    public class ObjectVolumeMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ObjectVolumeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IObjectVolumeModel>()));
            var mockModel = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel(1);
            ObjectVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IObjectVolumeModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ObjectVolumeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IObjectVolumeModel>(), ref It.IsAny<IObjectVolume>()));
        //    var mockModel = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel(1);
        //    var mockEntity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume(1);
        //    ObjectVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IObjectVolumeModel>(), ref It.IsAny<IObjectVolume>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectVolumeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IObjectVolume>()));
            var mockEntity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume(1);
            ObjectVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IObjectVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IObjectVolume>()));
            var mockEntity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume(1);
            ObjectVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IObjectVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IObjectVolume>()));
            var mockEntity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume(1);
            ObjectVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IObjectVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectVolumeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IObjectVolumeModel>()));
            var mockModel = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel(1);
            ObjectVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IObjectVolumeModel>()), Times.Once);
        }

        public static Mock<IObjectVolume> DoMockingSetupForObjectVolume(int idReturnValue = 0)
        {
            var mockObjectVolume = new Mock<IObjectVolume>();
            // Mock Functions
            mockObjectVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectVolume.Setup(m => m.Active).Returns(() => true);
            mockObjectVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockObjectVolume.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectVolume.Setup(m => m.Object).Returns(() => new Object());
            mockObjectVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockObjectVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockObjectVolume;
        }
    }

    public class ObjectVolumesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsObjectVolumeProperties()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var model = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ObjectId, entity.ObjectId);
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsObjectVolumeProperties()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var model = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel();
            // Act
            IObjectVolume existingEntity = new ObjectVolume { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ObjectId, existingEntity.ObjectId);
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsObjectVolumeProperties()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var entity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyObjectVolumeProperties()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var entity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyObjectVolumeProperties()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var entity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsObjectVolumeSearchProperties()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var model = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.ObjectId, searchModel.ObjectId);
            Assert.Equal(model.Object.Object?.CustomKey, searchModel.ObjectCustomKey);
            Assert.Equal(model.Object.Object?.ApiDetailUrl, searchModel.ObjectApiDetailUrl);
            Assert.Equal(model.Object.Object?.SiteDetailUrl, searchModel.ObjectSiteDetailUrl);
            Assert.Equal(model.Object.Object?.Name, searchModel.ObjectName);
            Assert.Equal(model.Object.Object?.ShortDescription, searchModel.ObjectShortDescription);
            Assert.Equal(model.Object.Object?.Description, searchModel.ObjectDescription);
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
            var mapper = new ObjectVolumeMapper();
            var model = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel(1);
            var entity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ObjectVolumeMapper();
            var model = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolumeModel(1);
            var entity = ObjectVolumesMockingSetup.DoMockingSetupForObjectVolume(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
