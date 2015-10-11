// <auto-generated>
// <copyright file="Series.ISeriesRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Series
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class SeriesMockingSetup
    {
        public static Mock<ISeriesModel> DoMockingSetupForSeriesModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockSeriesModel = new Mock<ISeriesModel>();
            // Mock Functions
            mockSeriesModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeriesModel.Setup(m => m.Active).Returns(() => true);
            mockSeriesModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeriesModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeriesModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockSeriesModel.Setup(m => m.Name).Returns(() => name);
            //mockSeriesModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockSeriesModel.Setup(m => m.Description).Returns(() => "long");
            mockSeriesModel.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockSeriesModel.Setup(m => m.PublisherId).Returns(() => 1);
            mockSeriesModel.Setup(m => m.Publisher).Returns(() => new PublisherModel());
            mockSeriesModel.Setup(m => m.FirstEpisodeId).Returns(() => 1);
            mockSeriesModel.Setup(m => m.FirstEpisode).Returns(() => new EpisodeModel());
            mockSeriesModel.Setup(m => m.LastEpisodeId).Returns(() => 1);
            mockSeriesModel.Setup(m => m.LastEpisode).Returns(() => new EpisodeModel());
            // Associated Objects
            mockSeriesModel.Setup(m => m.Episodes).Returns(() => new List<IEpisodeModel>());
            mockSeriesModel.Setup(m => m.SeriesAliases).Returns(() => new List<ISeriesAliasModel>());
            mockSeriesModel.Setup(m => m.SeriesCharacters).Returns(() => new List<ISeriesCharacterModel>());
            mockSeriesModel.Setup(m => m.SeriesLocations).Returns(() => new List<ISeriesLocationModel>());
            // Return
            return mockSeriesModel;
        }

        public static Mock<ISeries> DoMockingSetupForSeries(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockSeries = new Mock<ISeries>();
            // Mock Functions
            mockSeries.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeries.Setup(m => m.Active).Returns(() => true);
            mockSeries.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeries.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeries.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeries.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeries.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockSeries.Setup(m => m.Name).Returns(() => name);
            //mockSeries.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockSeries.Setup(m => m.Description).Returns(() => "long");
            mockSeries.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockSeries.Setup(m => m.PublisherId).Returns(() => 1);
            mockSeries.Setup(m => m.Publisher).Returns(() => new Publisher());
            mockSeries.Setup(m => m.FirstEpisodeId).Returns(() => 1);
            mockSeries.Setup(m => m.FirstEpisode).Returns(() => new Episode());
            mockSeries.Setup(m => m.LastEpisodeId).Returns(() => 1);
            mockSeries.Setup(m => m.LastEpisode).Returns(() => new Episode());
            // Associated Objects
            mockSeries.Setup(m => m.Episodes).Returns(() => new List<IEpisode>());
            mockSeries.Setup(m => m.SeriesAliases).Returns(() => new List<ISeriesAlias>());
            mockSeries.Setup(m => m.SeriesCharacters).Returns(() => new List<ISeriesCharacter>());
            mockSeries.Setup(m => m.SeriesLocations).Returns(() => new List<ISeriesLocation>());
            // Return
            return mockSeries;
        }
    }

    public class SeriesMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<SeriesMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ISeriesModel>()));
            var mockModel = SeriesMockingSetup.DoMockingSetupForSeriesModel(1);
            SeriesMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ISeriesModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<SeriesMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ISeriesModel>(), ref It.IsAny<ISeries>()));
        //    var mockModel = SeriesMockingSetup.DoMockingSetupForSeriesModel(1);
        //    var mockEntity = SeriesMockingSetup.DoMockingSetupForSeries(1);
        //    SeriesMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ISeriesModel>(), ref It.IsAny<ISeries>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<SeriesMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ISeries>()));
            var mockEntity = SeriesMockingSetup.DoMockingSetupForSeries(1);
            SeriesMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ISeries>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<SeriesMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ISeries>()));
            var mockEntity = SeriesMockingSetup.DoMockingSetupForSeries(1);
            SeriesMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ISeries>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<SeriesMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ISeries>()));
            var mockEntity = SeriesMockingSetup.DoMockingSetupForSeries(1);
            SeriesMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ISeries>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<SeriesMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ISeriesModel>()));
            var mockModel = SeriesMockingSetup.DoMockingSetupForSeriesModel(1);
            SeriesMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ISeriesModel>()), Times.Once);
        }

        public static Mock<ISeries> DoMockingSetupForSeries(int idReturnValue = 0)
        {
            var mockSeries = new Mock<ISeries>();
            // Mock Functions
            mockSeries.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeries.Setup(m => m.Active).Returns(() => true);
            mockSeries.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeries.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeries.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeries.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeries.Setup(m => m.UpdatedDate).Returns(() => null);
            mockSeries.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockSeries.Setup(m => m.PublisherId).Returns(() => 1);
            mockSeries.Setup(m => m.Publisher).Returns(() => new Publisher());
            mockSeries.Setup(m => m.FirstEpisodeId).Returns(() => 1);
            mockSeries.Setup(m => m.FirstEpisode).Returns(() => new Episode());
            mockSeries.Setup(m => m.LastEpisodeId).Returns(() => 1);
            mockSeries.Setup(m => m.LastEpisode).Returns(() => new Episode());
            // Associated Objects
            mockSeries.Setup(m => m.Episodes).Returns(() => new List<IEpisode>());
            mockSeries.Setup(m => m.SeriesAliases).Returns(() => new List<ISeriesAlias>());
            mockSeries.Setup(m => m.SeriesCharacters).Returns(() => new List<ISeriesCharacter>());
            mockSeries.Setup(m => m.SeriesLocations).Returns(() => new List<ISeriesLocation>());
            // Return
            return mockSeries;
        }
    }

    public class SeriesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsSeriesProperties()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.Startyear, entity.Startyear);
            // Related Objects
            Assert.Equal(model.Object.PublisherId, entity.PublisherId);
            Assert.Equal(model.Object.FirstEpisodeId, entity.FirstEpisodeId);
            Assert.Equal(model.Object.LastEpisodeId, entity.LastEpisodeId);
            // Associated Objects
            //Assert.Equal(model.Object.Episodes?.Count, entity.Episodes?.Count);
            model.VerifyGet(x => x.Episodes, Times.Once);
            //Assert.Equal(model.Object.SeriesAliases?.Count, entity.SeriesAliases?.Count);
            model.VerifyGet(x => x.SeriesAliases, Times.Once);
            //Assert.Equal(model.Object.SeriesCharacters?.Count, entity.SeriesCharacters?.Count);
            model.VerifyGet(x => x.SeriesCharacters, Times.Once);
            //Assert.Equal(model.Object.SeriesLocations?.Count, entity.SeriesLocations?.Count);
            model.VerifyGet(x => x.SeriesLocations, Times.Once);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsSeriesProperties()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel();
            // Act
            ISeries existingEntity = new Series { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.Startyear, existingEntity.Startyear);
            // Related Objects
            Assert.Equal(model.Object.PublisherId, existingEntity.PublisherId);
            Assert.Equal(model.Object.FirstEpisodeId, existingEntity.FirstEpisodeId);
            Assert.Equal(model.Object.LastEpisodeId, existingEntity.LastEpisodeId);
            // Associated Objects
            model.VerifyGet(x => x.Episodes, Times.Once);
            //Assert.Equal(model.Object.Episodes?.Count, existingEntity.Episodes?.Count);
            model.VerifyGet(x => x.SeriesAliases, Times.Once);
            //Assert.Equal(model.Object.SeriesAliases?.Count, existingEntity.SeriesAliases?.Count);
            model.VerifyGet(x => x.SeriesCharacters, Times.Once);
            //Assert.Equal(model.Object.SeriesCharacters?.Count, existingEntity.SeriesCharacters?.Count);
            model.VerifyGet(x => x.SeriesLocations, Times.Once);
            //Assert.Equal(model.Object.SeriesLocations?.Count, existingEntity.SeriesLocations?.Count);
        }

        [Fact]
        public void Verify_MapToModel_AssignsSeriesProperties()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var entity = SeriesMockingSetup.DoMockingSetupForSeries();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Startyear, model.Startyear);
            // Related Objects
            Assert.Equal(entity.Object.PublisherId, model.PublisherId);
            Assert.Equal(entity.Object.FirstEpisodeId, model.FirstEpisodeId);
            Assert.Equal(entity.Object.LastEpisodeId, model.LastEpisodeId);
            // Associated Objects
            Assert.Equal(entity.Object.Episodes?.Count, model.Episodes?.Count);
            Assert.Equal(entity.Object.SeriesAliases?.Count, model.SeriesAliases?.Count);
            Assert.Equal(entity.Object.SeriesCharacters?.Count, model.SeriesCharacters?.Count);
            Assert.Equal(entity.Object.SeriesLocations?.Count, model.SeriesLocations?.Count);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlySeriesProperties()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var entity = SeriesMockingSetup.DoMockingSetupForSeries();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Startyear, model.Startyear);
            // Related Objects
            Assert.Equal(entity.Object.PublisherId, model.PublisherId);
            Assert.Equal(entity.Object.FirstEpisodeId, model.FirstEpisodeId);
            Assert.Equal(entity.Object.LastEpisodeId, model.LastEpisodeId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlySeriesProperties()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var entity = SeriesMockingSetup.DoMockingSetupForSeries();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Startyear, model.Startyear);
            // Related Objects
            Assert.Equal(entity.Object.PublisherId, model.PublisherId);
            Assert.Equal(entity.Object.FirstEpisodeId, model.FirstEpisodeId);
            Assert.Equal(entity.Object.LastEpisodeId, model.LastEpisodeId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsSeriesSearchProperties()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.PublisherId, searchModel.PublisherId);
            Assert.Equal(model.Object.Publisher?.CustomKey, searchModel.PublisherCustomKey);
            Assert.Equal(model.Object.Publisher?.ApiDetailUrl, searchModel.PublisherApiDetailUrl);
            Assert.Equal(model.Object.Publisher?.SiteDetailUrl, searchModel.PublisherSiteDetailUrl);
            Assert.Equal(model.Object.Publisher?.Name, searchModel.PublisherName);
            Assert.Equal(model.Object.Publisher?.ShortDescription, searchModel.PublisherShortDescription);
            Assert.Equal(model.Object.Publisher?.Description, searchModel.PublisherDescription);
            Assert.Equal(model.Object.FirstEpisodeId, searchModel.FirstEpisodeId);
            Assert.Equal(model.Object.FirstEpisode?.CustomKey, searchModel.FirstEpisodeCustomKey);
            Assert.Equal(model.Object.FirstEpisode?.ApiDetailUrl, searchModel.FirstEpisodeApiDetailUrl);
            Assert.Equal(model.Object.FirstEpisode?.SiteDetailUrl, searchModel.FirstEpisodeSiteDetailUrl);
            Assert.Equal(model.Object.FirstEpisode?.Name, searchModel.FirstEpisodeName);
            Assert.Equal(model.Object.FirstEpisode?.ShortDescription, searchModel.FirstEpisodeShortDescription);
            Assert.Equal(model.Object.FirstEpisode?.Description, searchModel.FirstEpisodeDescription);
            Assert.Equal(model.Object.LastEpisodeId, searchModel.LastEpisodeId);
            Assert.Equal(model.Object.LastEpisode?.CustomKey, searchModel.LastEpisodeCustomKey);
            Assert.Equal(model.Object.LastEpisode?.ApiDetailUrl, searchModel.LastEpisodeApiDetailUrl);
            Assert.Equal(model.Object.LastEpisode?.SiteDetailUrl, searchModel.LastEpisodeSiteDetailUrl);
            Assert.Equal(model.Object.LastEpisode?.Name, searchModel.LastEpisodeName);
            Assert.Equal(model.Object.LastEpisode?.ShortDescription, searchModel.LastEpisodeShortDescription);
            Assert.Equal(model.Object.LastEpisode?.Description, searchModel.LastEpisodeDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel(1);
            var entity = SeriesMockingSetup.DoMockingSetupForSeries(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new SeriesMapper();
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel(1);
            var entity = SeriesMockingSetup.DoMockingSetupForSeries(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
