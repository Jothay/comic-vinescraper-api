// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationFirstAppearanceRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocationFirstAppearancesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Episodes
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class EpisodeLocationFirstAppearancesMockingSetup
    {
        public static Mock<IEpisodeLocationFirstAppearanceModel> DoMockingSetupForEpisodeLocationFirstAppearanceModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeLocationFirstAppearanceModel = new Mock<IEpisodeLocationFirstAppearanceModel>();
            // Mock Functions
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeLocationFirstAppearanceModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeLocationFirstAppearanceModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeLocationFirstAppearanceModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.LocationId).Returns(() => 1);
            mockEpisodeLocationFirstAppearanceModel.Setup(m => m.Location).Returns(() => new LocationModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeLocationFirstAppearanceModel;
        }

        public static Mock<IEpisodeLocationFirstAppearance> DoMockingSetupForEpisodeLocationFirstAppearance(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeLocationFirstAppearance = new Mock<IEpisodeLocationFirstAppearance>();
            // Mock Functions
            mockEpisodeLocationFirstAppearance.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeLocationFirstAppearance.Setup(m => m.Active).Returns(() => true);
            mockEpisodeLocationFirstAppearance.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeLocationFirstAppearance.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocationFirstAppearance.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocationFirstAppearance.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeLocationFirstAppearance.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeLocationFirstAppearance.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeLocationFirstAppearance.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeLocationFirstAppearance.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeLocationFirstAppearance.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeLocationFirstAppearance.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeLocationFirstAppearance.Setup(m => m.LocationId).Returns(() => 1);
            mockEpisodeLocationFirstAppearance.Setup(m => m.Location).Returns(() => new Location());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeLocationFirstAppearance;
        }
    }

    public class EpisodeLocationFirstAppearanceMappingExtensionsTests
    {
        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeLocationFirstAppearanceModel>()));
            var mockModel = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel(1);
            EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeLocationFirstAppearanceModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeLocationFirstAppearanceModel>(), ref It.IsAny<IEpisodeLocationFirstAppearance>()));
        //    var mockModel = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel(1);
        //    var mockEntity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(1);
        //    EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeLocationFirstAppearanceModel>(), ref It.IsAny<IEpisodeLocationFirstAppearance>()), Times.Once);
        //}

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeLocationFirstAppearance>()));
            var mockEntity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(1);
            EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeLocationFirstAppearance>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeLocationFirstAppearance>()));
            var mockEntity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(1);
            EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeLocationFirstAppearance>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeLocationFirstAppearance>()));
            var mockEntity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(1);
            EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeLocationFirstAppearance>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeLocationFirstAppearanceModel>()));
            var mockModel = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel(1);
            EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeLocationFirstAppearanceModel>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationFirstAppearanceMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodeLocationFirstAppearanceModel>(), It.IsAny<IEpisodeLocationFirstAppearance>()));
            EpisodeLocationFirstAppearanceMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel(1);
            var mockEntity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodeLocationFirstAppearanceModel>(), It.IsAny<IEpisodeLocationFirstAppearance>()), Times.Once);
        }
    }

    public class EpisodeLocationFirstAppearancesMappingTests
    {
        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToEntity_AssignsEpisodeLocationFirstAppearanceProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var model = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.LocationId, entity.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeLocationFirstAppearanceProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var model = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel();
            // Act
            IEpisodeLocationFirstAppearance existingEntity = new EpisodeLocationFirstAppearance { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.LocationId, existingEntity.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToModel_AssignsEpisodeLocationFirstAppearanceProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var entity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeLocationFirstAppearanceProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var entity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeLocationFirstAppearanceProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var entity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            // Return Entity
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_MapToSearchModel_AssignsEpisodeLocationFirstAppearanceSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var model = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel();
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
            Assert.Equal(model.Object.LocationId, searchModel.LocationId);
            Assert.Equal(model.Object.Location?.CustomKey, searchModel.LocationCustomKey);
            Assert.Equal(model.Object.Location?.ApiDetailUrl, searchModel.LocationApiDetailUrl);
            Assert.Equal(model.Object.Location?.SiteDetailUrl, searchModel.LocationSiteDetailUrl);
            Assert.Equal(model.Object.Location?.Name, searchModel.LocationName);
            Assert.Equal(model.Object.Location?.ShortDescription, searchModel.LocationShortDescription);
            Assert.Equal(model.Object.Location?.Description, searchModel.LocationDescription);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var model = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel(1);
            var entity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeLocationFirstAppearanceMapper();
            var model = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearanceModel(1);
            var entity = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForEpisodeLocationFirstAppearance(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
