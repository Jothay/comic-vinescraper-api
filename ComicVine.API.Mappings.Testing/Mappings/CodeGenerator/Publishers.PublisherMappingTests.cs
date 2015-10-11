// <auto-generated>
// <copyright file="Publishers.IPublisherRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PublishersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Publishers
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class PublishersMockingSetup
    {
        public static Mock<IPublisherModel> DoMockingSetupForPublisherModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPublisherModel = new Mock<IPublisherModel>();
            // Mock Functions
            mockPublisherModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPublisherModel.Setup(m => m.Active).Returns(() => true);
            mockPublisherModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPublisherModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPublisherModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPublisherModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPublisherModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockPublisherModel.Setup(m => m.Name).Returns(() => name);
            //mockPublisherModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockPublisherModel.Setup(m => m.Description).Returns(() => "long");
            mockPublisherModel.Setup(m => m.LocationAddress).Returns(() => "LocationAddress");
            mockPublisherModel.Setup(m => m.LocationCity).Returns(() => "LocationCity");
            mockPublisherModel.Setup(m => m.LocationState).Returns(() => "LocationState");
            // Related Objects
            mockPublisherModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockPublisherModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            // Associated Objects
            mockPublisherModel.Setup(m => m.CharactersPublished).Returns(() => new List<ICharacterModel>());
            mockPublisherModel.Setup(m => m.PublisherAliases).Returns(() => new List<IPublisherAliasModel>());
            mockPublisherModel.Setup(m => m.SeriesPublished).Returns(() => new List<ISeriesModel>());
            mockPublisherModel.Setup(m => m.StoryArcsPublished).Returns(() => new List<IStoryArcModel>());
            mockPublisherModel.Setup(m => m.TeamsPublished).Returns(() => new List<ITeamModel>());
            mockPublisherModel.Setup(m => m.VolumesPublished).Returns(() => new List<IVolumeModel>());
            // Return
            return mockPublisherModel;
        }

        public static Mock<IPublisher> DoMockingSetupForPublisher(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockPublisher = new Mock<IPublisher>();
            // Mock Functions
            mockPublisher.Setup(m => m.Id).Returns(() => idReturnValue);
            mockPublisher.Setup(m => m.Active).Returns(() => true);
            mockPublisher.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockPublisher.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPublisher.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockPublisher.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockPublisher.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockPublisher.Setup(m => m.Name).Returns(() => name);
            //mockPublisher.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockPublisher.Setup(m => m.Description).Returns(() => "long");
            mockPublisher.Setup(m => m.LocationAddress).Returns(() => "LocationAddress");
            mockPublisher.Setup(m => m.LocationCity).Returns(() => "LocationCity");
            mockPublisher.Setup(m => m.LocationState).Returns(() => "LocationState");
            // Related Objects
            mockPublisher.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockPublisher.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            // Associated Objects
            mockPublisher.Setup(m => m.CharactersPublished).Returns(() => new List<ICharacter>());
            mockPublisher.Setup(m => m.PublisherAliases).Returns(() => new List<IPublisherAlias>());
            mockPublisher.Setup(m => m.SeriesPublished).Returns(() => new List<ISeries>());
            mockPublisher.Setup(m => m.StoryArcsPublished).Returns(() => new List<IStoryArc>());
            mockPublisher.Setup(m => m.TeamsPublished).Returns(() => new List<ITeam>());
            mockPublisher.Setup(m => m.VolumesPublished).Returns(() => new List<IVolume>());
            // Return
            return mockPublisher;
        }
    }

    public class PublisherMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<PublisherMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IPublisherModel>()));
            var mockModel = PublishersMockingSetup.DoMockingSetupForPublisherModel(1);
            PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IPublisherModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<PublisherMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IPublisherModel>(), ref It.IsAny<IPublisher>()));
        //    var mockModel = PublishersMockingSetup.DoMockingSetupForPublisherModel(1);
        //    var mockEntity = PublishersMockingSetup.DoMockingSetupForPublisher(1);
        //    PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IPublisherModel>(), ref It.IsAny<IPublisher>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PublisherMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IPublisher>()));
            var mockEntity = PublishersMockingSetup.DoMockingSetupForPublisher(1);
            PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IPublisher>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PublisherMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IPublisher>()));
            var mockEntity = PublishersMockingSetup.DoMockingSetupForPublisher(1);
            PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IPublisher>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PublisherMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IPublisher>()));
            var mockEntity = PublishersMockingSetup.DoMockingSetupForPublisher(1);
            PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IPublisher>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<PublisherMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IPublisherModel>()));
            var mockModel = PublishersMockingSetup.DoMockingSetupForPublisherModel(1);
            PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IPublisherModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<PublisherMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IPublisherModel>(), It.IsAny<IPublisher>()));
            PublisherMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = PublishersMockingSetup.DoMockingSetupForPublisherModel(1);
            var mockEntity = PublishersMockingSetup.DoMockingSetupForPublisher(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IPublisherModel>(), It.IsAny<IPublisher>()), Times.Once);
        }
    }

    public class PublishersMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsPublisherProperties()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var model = PublishersMockingSetup.DoMockingSetupForPublisherModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.LocationAddress, entity.LocationAddress);
            Assert.Equal(model.Object.LocationCity, entity.LocationCity);
            Assert.Equal(model.Object.LocationState, entity.LocationState);
            // Related Objects
            Assert.Equal(model.Object.PrimaryImageFileId, entity.PrimaryImageFileId);
            // Associated Objects
            //Assert.Equal(model.Object.CharactersPublished?.Count, entity.CharactersPublished?.Count);
            model.VerifyGet(x => x.CharactersPublished, Times.Once);
            //Assert.Equal(model.Object.PublisherAliases?.Count, entity.PublisherAliases?.Count);
            model.VerifyGet(x => x.PublisherAliases, Times.Once);
            //Assert.Equal(model.Object.SeriesPublished?.Count, entity.SeriesPublished?.Count);
            model.VerifyGet(x => x.SeriesPublished, Times.Once);
            //Assert.Equal(model.Object.StoryArcsPublished?.Count, entity.StoryArcsPublished?.Count);
            model.VerifyGet(x => x.StoryArcsPublished, Times.Once);
            //Assert.Equal(model.Object.TeamsPublished?.Count, entity.TeamsPublished?.Count);
            model.VerifyGet(x => x.TeamsPublished, Times.Once);
            //Assert.Equal(model.Object.VolumesPublished?.Count, entity.VolumesPublished?.Count);
            model.VerifyGet(x => x.VolumesPublished, Times.Once);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsPublisherProperties()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var model = PublishersMockingSetup.DoMockingSetupForPublisherModel();
            // Act
            IPublisher existingEntity = new Publisher { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.LocationAddress, existingEntity.LocationAddress);
            Assert.Equal(model.Object.LocationCity, existingEntity.LocationCity);
            Assert.Equal(model.Object.LocationState, existingEntity.LocationState);
            // Related Objects
            Assert.Equal(model.Object.PrimaryImageFileId, existingEntity.PrimaryImageFileId);
            // Associated Objects
            model.VerifyGet(x => x.CharactersPublished, Times.Once);
            //Assert.Equal(model.Object.CharactersPublished?.Count, existingEntity.CharactersPublished?.Count);
            model.VerifyGet(x => x.PublisherAliases, Times.Once);
            //Assert.Equal(model.Object.PublisherAliases?.Count, existingEntity.PublisherAliases?.Count);
            model.VerifyGet(x => x.SeriesPublished, Times.Once);
            //Assert.Equal(model.Object.SeriesPublished?.Count, existingEntity.SeriesPublished?.Count);
            model.VerifyGet(x => x.StoryArcsPublished, Times.Once);
            //Assert.Equal(model.Object.StoryArcsPublished?.Count, existingEntity.StoryArcsPublished?.Count);
            model.VerifyGet(x => x.TeamsPublished, Times.Once);
            //Assert.Equal(model.Object.TeamsPublished?.Count, existingEntity.TeamsPublished?.Count);
            model.VerifyGet(x => x.VolumesPublished, Times.Once);
            //Assert.Equal(model.Object.VolumesPublished?.Count, existingEntity.VolumesPublished?.Count);
        }

        [Fact]
        public void Verify_MapToModel_AssignsPublisherProperties()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var entity = PublishersMockingSetup.DoMockingSetupForPublisher();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.LocationAddress, model.LocationAddress);
            Assert.Equal(entity.Object.LocationCity, model.LocationCity);
            Assert.Equal(entity.Object.LocationState, model.LocationState);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            // Associated Objects
            Assert.Equal(entity.Object.CharactersPublished?.Count, model.CharactersPublished?.Count);
            Assert.Equal(entity.Object.PublisherAliases?.Count, model.PublisherAliases?.Count);
            Assert.Equal(entity.Object.SeriesPublished?.Count, model.SeriesPublished?.Count);
            Assert.Equal(entity.Object.StoryArcsPublished?.Count, model.StoryArcsPublished?.Count);
            Assert.Equal(entity.Object.TeamsPublished?.Count, model.TeamsPublished?.Count);
            Assert.Equal(entity.Object.VolumesPublished?.Count, model.VolumesPublished?.Count);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyPublisherProperties()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var entity = PublishersMockingSetup.DoMockingSetupForPublisher();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.LocationAddress, model.LocationAddress);
            Assert.Equal(entity.Object.LocationCity, model.LocationCity);
            Assert.Equal(entity.Object.LocationState, model.LocationState);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyPublisherProperties()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var entity = PublishersMockingSetup.DoMockingSetupForPublisher();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.LocationAddress, model.LocationAddress);
            Assert.Equal(entity.Object.LocationCity, model.LocationCity);
            Assert.Equal(entity.Object.LocationState, model.LocationState);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsPublisherSearchProperties()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var model = PublishersMockingSetup.DoMockingSetupForPublisherModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.PrimaryImageFileId, searchModel.PrimaryImageFileId);
            Assert.Equal(model.Object.PrimaryImageFile?.CustomKey, searchModel.PrimaryImageFileCustomKey);
            Assert.Equal(model.Object.PrimaryImageFile?.ApiDetailUrl, searchModel.PrimaryImageFileApiDetailUrl);
            Assert.Equal(model.Object.PrimaryImageFile?.SiteDetailUrl, searchModel.PrimaryImageFileSiteDetailUrl);
            Assert.Equal(model.Object.PrimaryImageFile?.Name, searchModel.PrimaryImageFileName);
            Assert.Equal(model.Object.PrimaryImageFile?.ShortDescription, searchModel.PrimaryImageFileShortDescription);
            Assert.Equal(model.Object.PrimaryImageFile?.Description, searchModel.PrimaryImageFileDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var model = PublishersMockingSetup.DoMockingSetupForPublisherModel(1);
            var entity = PublishersMockingSetup.DoMockingSetupForPublisher(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new PublisherMapper();
            var model = PublishersMockingSetup.DoMockingSetupForPublisherModel(1);
            var entity = PublishersMockingSetup.DoMockingSetupForPublisher(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
