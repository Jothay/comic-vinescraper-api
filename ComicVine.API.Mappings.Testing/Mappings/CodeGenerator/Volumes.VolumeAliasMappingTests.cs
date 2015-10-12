// <auto-generated>
// <copyright file="Volumes.IVolumeAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeAliasesRepository Class.</summary>
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

    public static class VolumeAliasesMockingSetup
    {
        public static Mock<IVolumeAliasModel> DoMockingSetupForVolumeAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeAliasModel = new Mock<IVolumeAliasModel>();
            // Mock Functions
            mockVolumeAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeAliasModel.Setup(m => m.Active).Returns(() => true);
            mockVolumeAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVolumeAliasModel.Setup(m => m.Name).Returns(() => name);
            //mockVolumeAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVolumeAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockVolumeAliasModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeAliasModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeAliasModel;
        }

        public static Mock<IVolumeAlias> DoMockingSetupForVolumeAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeAlias = new Mock<IVolumeAlias>();
            // Mock Functions
            mockVolumeAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeAlias.Setup(m => m.Active).Returns(() => true);
            mockVolumeAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVolumeAlias.Setup(m => m.Name).Returns(() => name);
            //mockVolumeAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVolumeAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockVolumeAlias.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeAlias.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeAlias;
        }
    }

    public class VolumeAliasMappingExtensionsTests
    {
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<VolumeAliasMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVolumeAliasModel>()));
            var mockModel = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel(1);
            VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVolumeAliasModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "VolumeAliases")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<VolumeAliasMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVolumeAliasModel>(), ref It.IsAny<IVolumeAlias>()));
        //    var mockModel = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel(1);
        //    var mockEntity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(1);
        //    VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVolumeAliasModel>(), ref It.IsAny<IVolumeAlias>()), Times.Once);
        //}

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeAliasMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IVolumeAlias>()));
            var mockEntity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(1);
            VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IVolumeAlias>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeAliasMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IVolumeAlias>()));
            var mockEntity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(1);
            VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IVolumeAlias>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeAliasMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IVolumeAlias>()));
            var mockEntity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(1);
            VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IVolumeAlias>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeAliasMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IVolumeAliasModel>()));
            var mockModel = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel(1);
            VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IVolumeAliasModel>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<VolumeAliasMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IVolumeAliasModel>(), It.IsAny<IVolumeAlias>()));
            VolumeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel(1);
            var mockEntity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IVolumeAliasModel>(), It.IsAny<IVolumeAlias>()), Times.Once);
        }
    }

    public class VolumeAliasesMappingTests
    {
        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToEntity_AssignsVolumeAliasProperties()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var model = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsVolumeAliasProperties()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var model = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel();
            // Act
            IVolumeAlias existingEntity = new VolumeAlias { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToModel_AssignsVolumeAliasProperties()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var entity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToModelLite_AssignsLiteOnlyVolumeAliasProperties()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var entity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToModelListing_AssignsListingOnlyVolumeAliasProperties()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var entity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Return Entity
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_MapToSearchModel_AssignsVolumeAliasSearchProperties()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var model = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel();
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
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var model = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel(1);
            var entity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "VolumeAliases")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new VolumeAliasMapper();
            var model = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAliasModel(1);
            var entity = VolumeAliasesMockingSetup.DoMockingSetupForVolumeAlias(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
