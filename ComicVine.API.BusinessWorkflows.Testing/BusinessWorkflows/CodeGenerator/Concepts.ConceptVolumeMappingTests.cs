// <auto-generated>
// <copyright file="Concepts.IConceptVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptVolumesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Concepts
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ConceptVolumesMockingSetup
    {
        public static Mock<IConceptVolumeModel> DoMockingSetupForConceptVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptVolumeModel = new Mock<IConceptVolumeModel>();
            // Mock Functions
            mockConceptVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockConceptVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockConceptVolumeModel.Setup(m => m.Name).Returns(() => name);
            //mockConceptVolumeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockConceptVolumeModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockConceptVolumeModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptVolumeModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            mockConceptVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockConceptVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockConceptVolumeModel;
        }

        public static Mock<IConceptVolume> DoMockingSetupForConceptVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptVolume = new Mock<IConceptVolume>();
            // Mock Functions
            mockConceptVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptVolume.Setup(m => m.Active).Returns(() => true);
            mockConceptVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockConceptVolume.Setup(m => m.Name).Returns(() => name);
            //mockConceptVolume.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockConceptVolume.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockConceptVolume.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptVolume.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockConceptVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockConceptVolume;
        }
    }

    public class ConceptVolumeMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ConceptVolumeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IConceptVolumeModel>()));
            var mockModel = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1);
            ConceptVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IConceptVolumeModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ConceptVolumeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IConceptVolumeModel>(), ref It.IsAny<IConceptVolume>()));
        //    var mockModel = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1);
        //    var mockEntity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
        //    ConceptVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IConceptVolumeModel>(), ref It.IsAny<IConceptVolume>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptVolumeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IConceptVolume>()));
            var mockEntity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            ConceptVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IConceptVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IConceptVolume>()));
            var mockEntity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            ConceptVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IConceptVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IConceptVolume>()));
            var mockEntity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            ConceptVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IConceptVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptVolumeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IConceptVolumeModel>()));
            var mockModel = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1);
            ConceptVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IConceptVolumeModel>()), Times.Once);
        }

        public static Mock<IConceptVolume> DoMockingSetupForConceptVolume(int idReturnValue = 0)
        {
            var mockConceptVolume = new Mock<IConceptVolume>();
            // Mock Functions
            mockConceptVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptVolume.Setup(m => m.Active).Returns(() => true);
            mockConceptVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptVolume.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptVolume.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockConceptVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockConceptVolume;
        }
    }

    public class ConceptVolumesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsConceptVolumeProperties()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ConceptId, entity.ConceptId);
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsConceptVolumeProperties()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel();
            // Act
            IConceptVolume existingEntity = new ConceptVolume { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ConceptId, existingEntity.ConceptId);
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsConceptVolumeProperties()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var entity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyConceptVolumeProperties()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var entity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyConceptVolumeProperties()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var entity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsConceptVolumeSearchProperties()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.ConceptId, searchModel.ConceptId);
            Assert.Equal(model.Object.Concept?.CustomKey, searchModel.ConceptCustomKey);
            Assert.Equal(model.Object.Concept?.ApiDetailUrl, searchModel.ConceptApiDetailUrl);
            Assert.Equal(model.Object.Concept?.SiteDetailUrl, searchModel.ConceptSiteDetailUrl);
            Assert.Equal(model.Object.Concept?.Name, searchModel.ConceptName);
            Assert.Equal(model.Object.Concept?.ShortDescription, searchModel.ConceptShortDescription);
            Assert.Equal(model.Object.Concept?.Description, searchModel.ConceptDescription);
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
            var mapper = new ConceptVolumeMapper();
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1);
            var entity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ConceptVolumeMapper();
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1);
            var entity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
