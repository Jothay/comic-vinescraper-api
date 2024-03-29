// <auto-generated>
// <copyright file="Episodes.IEpisodeConceptMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeConceptsMappingTests class.</summary>
// <remarks>This file was auto-generated using MappingTestingFileMaster.tt in
// ComicVineScraper.API.Mappings.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Mappings.Episodes
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class EpisodeConceptsMockingSetup
    {
        public static Mock<IEpisodeConceptModel> DoMockingSetupForEpisodeConceptModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeConceptModel = new Mock<IEpisodeConceptModel>();
            // Mock Functions
            mockEpisodeConceptModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeConceptModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeConceptModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeConceptModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConceptModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConceptModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeConceptModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeConceptModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeConceptModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeConceptModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeConceptModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeConceptModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeConceptModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockEpisodeConceptModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeConceptModel;
        }

        public static Mock<IEpisodeConcept> DoMockingSetupForEpisodeConcept(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeConcept = new Mock<IEpisodeConcept>();
            // Mock Functions
            mockEpisodeConcept.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeConcept.Setup(m => m.Active).Returns(() => true);
            mockEpisodeConcept.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeConcept.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConcept.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConcept.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeConcept.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeConcept.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeConcept.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeConcept.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeConcept.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeConcept.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeConcept.Setup(m => m.ConceptId).Returns(() => 1);
            mockEpisodeConcept.Setup(m => m.Concept).Returns(() => new Concept());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeConcept;
        }
    }

    public class EpisodeConceptMappingExtensionsTests
    {
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeConceptMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeConceptModel>(), It.IsAny<int>()));
            var mockModel = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
            EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeConceptModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "EpisodeConcepts")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeConceptMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeConceptModel>(), ref It.IsAny<IEpisodeConcept>(), It.IsAny<int>()));
        //    var mockModel = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
        //    var mockEntity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
        //    EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeConceptModel>(), ref It.IsAny<IEpisodeConcept>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeConceptMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeConcept>(), It.IsAny<int>()));
            var mockEntity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeConcept>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeConceptMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeConcept>(), It.IsAny<int>()));
            var mockEntity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeConcept>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeConceptMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeConcept>(), It.IsAny<int>()));
            var mockEntity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeConcept>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeConceptMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeConceptModel>()));
            var mockModel = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
            EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeConceptModel>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeConceptMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>()));
            EpisodeConceptMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
            var mockEntity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>()), Times.Once);
        }
    }

    public class EpisodeConceptsMappingTests
    {
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToEntity_AssignsEpisodeConceptProperties()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.ConceptId, entity.ConceptId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeConceptProperties()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel();
            // Act
            IEpisodeConcept existingEntity = new EpisodeConcept { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.ConceptId, existingEntity.ConceptId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToModel_AssignsEpisodeConceptProperties()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var entity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeConceptProperties()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var entity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeConceptProperties()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var entity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            // Return Entity
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_MapToSearchModel_AssignsEpisodeConceptSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.EpisodeId, searchModel.EpisodeId);
            Assert.Equal(model.Object.Episode?.CustomKey, searchModel.EpisodeCustomKey);
            Assert.Equal(model.Object.Episode?.ApiDetailUrl, searchModel.EpisodeApiDetailUrl);
            Assert.Equal(model.Object.Episode?.SiteDetailUrl, searchModel.EpisodeSiteDetailUrl);
            Assert.Equal(model.Object.Episode?.Name, searchModel.EpisodeName);
            Assert.Equal(model.Object.Episode?.ShortDescription, searchModel.EpisodeShortDescription);
            Assert.Equal(model.Object.Episode?.Description, searchModel.EpisodeDescription);
            Assert.Equal(model.Object.ConceptId, searchModel.ConceptId);
            Assert.Equal(model.Object.Concept?.CustomKey, searchModel.ConceptCustomKey);
            Assert.Equal(model.Object.Concept?.ApiDetailUrl, searchModel.ConceptApiDetailUrl);
            Assert.Equal(model.Object.Concept?.SiteDetailUrl, searchModel.ConceptSiteDetailUrl);
            Assert.Equal(model.Object.Concept?.Name, searchModel.ConceptName);
            Assert.Equal(model.Object.Concept?.ShortDescription, searchModel.ConceptShortDescription);
            Assert.Equal(model.Object.Concept?.Description, searchModel.ConceptDescription);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
            var entity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeConceptMapper();
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
            var entity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
