// <auto-generated>
// <copyright file="Volumes.IVolumeConceptMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeConceptsMappingTests class.</summary>
// <remarks>This file was auto-generated using MappingTestingFileMaster.tt in
// ComicVineScraper.API.Mappings.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Mappings.Volumes
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class VolumeConceptsMockingSetup
    {
        public static Mock<IVolumeConceptModel> DoMockingSetupForVolumeConceptModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeConceptModel = new Mock<IVolumeConceptModel>();
            // Mock Functions
            mockVolumeConceptModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeConceptModel.Setup(m => m.Active).Returns(() => true);
            mockVolumeConceptModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeConceptModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeConceptModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeConceptModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeConceptModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVolumeConceptModel.Setup(m => m.Name).Returns(() => name);
            //mockVolumeConceptModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVolumeConceptModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockVolumeConceptModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeConceptModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            mockVolumeConceptModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockVolumeConceptModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeConceptModel;
        }

        public static Mock<IVolumeConcept> DoMockingSetupForVolumeConcept(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeConcept = new Mock<IVolumeConcept>();
            // Mock Functions
            mockVolumeConcept.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeConcept.Setup(m => m.Active).Returns(() => true);
            mockVolumeConcept.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeConcept.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeConcept.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeConcept.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeConcept.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVolumeConcept.Setup(m => m.Name).Returns(() => name);
            //mockVolumeConcept.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVolumeConcept.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockVolumeConcept.Setup(m => m.VolumeId).Returns(() => 1);
            mockVolumeConcept.Setup(m => m.Volume).Returns(() => new Volume());
            mockVolumeConcept.Setup(m => m.ConceptId).Returns(() => 1);
            mockVolumeConcept.Setup(m => m.Concept).Returns(() => new Concept());
            // Associated Objects
            // <None>
            // Return
            return mockVolumeConcept;
        }
    }

    public class VolumeConceptMappingExtensionsTests
    {
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<VolumeConceptMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVolumeConceptModel>(), It.IsAny<int>()));
            var mockModel = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel(1);
            VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVolumeConceptModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "VolumeConcepts")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<VolumeConceptMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVolumeConceptModel>(), ref It.IsAny<IVolumeConcept>(), It.IsAny<int>()));
        //    var mockModel = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel(1);
        //    var mockEntity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(1);
        //    VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVolumeConceptModel>(), ref It.IsAny<IVolumeConcept>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeConceptMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IVolumeConcept>(), It.IsAny<int>()));
            var mockEntity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(1);
            VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IVolumeConcept>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeConceptMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IVolumeConcept>(), It.IsAny<int>()));
            var mockEntity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(1);
            VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IVolumeConcept>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeConceptMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IVolumeConcept>(), It.IsAny<int>()));
            var mockEntity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(1);
            VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IVolumeConcept>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VolumeConceptMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IVolumeConceptModel>()));
            var mockModel = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel(1);
            VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IVolumeConceptModel>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<VolumeConceptMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IVolumeConceptModel>(), It.IsAny<IVolumeConcept>()));
            VolumeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel(1);
            var mockEntity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IVolumeConceptModel>(), It.IsAny<IVolumeConcept>()), Times.Once);
        }
    }

    public class VolumeConceptsMappingTests
    {
        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToEntity_AssignsVolumeConceptProperties()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var model = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            Assert.Equal(model.Object.ConceptId, entity.ConceptId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsVolumeConceptProperties()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var model = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel();
            // Act
            IVolumeConcept existingEntity = new VolumeConcept { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            Assert.Equal(model.Object.ConceptId, existingEntity.ConceptId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToModel_AssignsVolumeConceptProperties()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var entity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToModelLite_AssignsLiteOnlyVolumeConceptProperties()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var entity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToModelListing_AssignsListingOnlyVolumeConceptProperties()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var entity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            // Return Entity
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_MapToSearchModel_AssignsVolumeConceptSearchProperties()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var model = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel();
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
            Assert.Equal(model.Object.ConceptId, searchModel.ConceptId);
            Assert.Equal(model.Object.Concept?.CustomKey, searchModel.ConceptCustomKey);
            Assert.Equal(model.Object.Concept?.ApiDetailUrl, searchModel.ConceptApiDetailUrl);
            Assert.Equal(model.Object.Concept?.SiteDetailUrl, searchModel.ConceptSiteDetailUrl);
            Assert.Equal(model.Object.Concept?.Name, searchModel.ConceptName);
            Assert.Equal(model.Object.Concept?.ShortDescription, searchModel.ConceptShortDescription);
            Assert.Equal(model.Object.Concept?.Description, searchModel.ConceptDescription);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var model = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel(1);
            var entity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "VolumeConcepts")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new VolumeConceptMapper();
            var model = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConceptModel(1);
            var entity = VolumeConceptsMockingSetup.DoMockingSetupForVolumeConcept(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}