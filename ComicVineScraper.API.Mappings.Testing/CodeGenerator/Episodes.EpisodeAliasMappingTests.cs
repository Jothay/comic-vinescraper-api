// <auto-generated>
// <copyright file="Episodes.IEpisodeAliasMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeAliasesMappingTests class.</summary>
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

    public static class EpisodeAliasesMockingSetup
    {
        public static Mock<IEpisodeAliasModel> DoMockingSetupForEpisodeAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeAliasModel = new Mock<IEpisodeAliasModel>();
            // Mock Functions
            mockEpisodeAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeAliasModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeAliasModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeAliasModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeAliasModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeAliasModel;
        }

        public static Mock<IEpisodeAlias> DoMockingSetupForEpisodeAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeAlias = new Mock<IEpisodeAlias>();
            // Mock Functions
            mockEpisodeAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeAlias.Setup(m => m.Active).Returns(() => true);
            mockEpisodeAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeAlias.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeAlias.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeAlias.Setup(m => m.Episode).Returns(() => new Episode());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeAlias;
        }
    }

    public class EpisodeAliasMappingExtensionsTests
    {
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeAliasMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeAliasModel>(), It.IsAny<int>()));
            var mockModel = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
            EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeAliasModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "EpisodeAliases")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeAliasMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeAliasModel>(), ref It.IsAny<IEpisodeAlias>(), It.IsAny<int>()));
        //    var mockModel = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
        //    var mockEntity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
        //    EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeAliasModel>(), ref It.IsAny<IEpisodeAlias>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeAliasMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeAlias>(), It.IsAny<int>()));
            var mockEntity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeAliasMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeAlias>(), It.IsAny<int>()));
            var mockEntity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeAliasMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeAlias>(), It.IsAny<int>()));
            var mockEntity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeAliasMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeAliasModel>()));
            var mockModel = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
            EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeAliasModel>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeAliasMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>()));
            EpisodeAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
            var mockEntity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>()), Times.Once);
        }
    }

    public class EpisodeAliasesMappingTests
    {
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToEntity_AssignsEpisodeAliasProperties()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeAliasProperties()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel();
            // Act
            IEpisodeAlias existingEntity = new EpisodeAlias { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToModel_AssignsEpisodeAliasProperties()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var entity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeAliasProperties()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var entity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeAliasProperties()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var entity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            // Return Entity
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_MapToSearchModel_AssignsEpisodeAliasSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel();
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
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
            var entity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeAliasMapper();
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
            var entity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
