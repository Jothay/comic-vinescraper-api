// <auto-generated>
// <copyright file="Media.IImageFileRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ImageFilesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Media
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ImageFilesMockingSetup
    {
        public static Mock<IImageFileModel> DoMockingSetupForImageFileModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockImageFileModel = new Mock<IImageFileModel>();
            // Mock Functions
            mockImageFileModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockImageFileModel.Setup(m => m.Active).Returns(() => true);
            mockImageFileModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockImageFileModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFileModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFileModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockImageFileModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockImageFileModel.Setup(m => m.Name).Returns(() => name);
            //mockImageFileModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockImageFileModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockImageFileModel.Setup(m => m.Characters).Returns(() => new List<ICharacterModel>());
            mockImageFileModel.Setup(m => m.Chats).Returns(() => new List<IChatModel>());
            mockImageFileModel.Setup(m => m.Concepts).Returns(() => new List<IConceptModel>());
            mockImageFileModel.Setup(m => m.Episodes).Returns(() => new List<IEpisodeModel>());
            mockImageFileModel.Setup(m => m.Issues).Returns(() => new List<IIssueModel>());
            mockImageFileModel.Setup(m => m.Locations).Returns(() => new List<ILocationModel>());
            mockImageFileModel.Setup(m => m.Movies).Returns(() => new List<IMovieModel>());
            mockImageFileModel.Setup(m => m.Objects).Returns(() => new List<IObjectModel>());
            mockImageFileModel.Setup(m => m.People).Returns(() => new List<IPersonModel>());
            mockImageFileModel.Setup(m => m.Promos).Returns(() => new List<IPromoModel>());
            mockImageFileModel.Setup(m => m.Publishers).Returns(() => new List<IPublisherModel>());
            mockImageFileModel.Setup(m => m.StoryArcs).Returns(() => new List<IStoryArcModel>());
            mockImageFileModel.Setup(m => m.Teams).Returns(() => new List<ITeamModel>());
            mockImageFileModel.Setup(m => m.Videos).Returns(() => new List<IVideoModel>());
            mockImageFileModel.Setup(m => m.Volumes).Returns(() => new List<IVolumeModel>());
            // Return
            return mockImageFileModel;
        }

        public static Mock<IImageFile> DoMockingSetupForImageFile(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockImageFile = new Mock<IImageFile>();
            // Mock Functions
            mockImageFile.Setup(m => m.Id).Returns(() => idReturnValue);
            mockImageFile.Setup(m => m.Active).Returns(() => true);
            mockImageFile.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockImageFile.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFile.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFile.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockImageFile.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockImageFile.Setup(m => m.Name).Returns(() => name);
            //mockImageFile.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockImageFile.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockImageFile.Setup(m => m.Characters).Returns(() => new List<ICharacter>());
            mockImageFile.Setup(m => m.Chats).Returns(() => new List<IChat>());
            mockImageFile.Setup(m => m.Concepts).Returns(() => new List<IConcept>());
            mockImageFile.Setup(m => m.Episodes).Returns(() => new List<IEpisode>());
            mockImageFile.Setup(m => m.Issues).Returns(() => new List<IIssue>());
            mockImageFile.Setup(m => m.Locations).Returns(() => new List<ILocation>());
            mockImageFile.Setup(m => m.Movies).Returns(() => new List<IMovie>());
            mockImageFile.Setup(m => m.Objects).Returns(() => new List<IObject>());
            mockImageFile.Setup(m => m.People).Returns(() => new List<IPerson>());
            mockImageFile.Setup(m => m.Promos).Returns(() => new List<IPromo>());
            mockImageFile.Setup(m => m.Publishers).Returns(() => new List<IPublisher>());
            mockImageFile.Setup(m => m.StoryArcs).Returns(() => new List<IStoryArc>());
            mockImageFile.Setup(m => m.Teams).Returns(() => new List<ITeam>());
            mockImageFile.Setup(m => m.Videos).Returns(() => new List<IVideo>());
            mockImageFile.Setup(m => m.Volumes).Returns(() => new List<IVolume>());
            // Return
            return mockImageFile;
        }
    }

    public class ImageFileMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ImageFileMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IImageFileModel>()));
            var mockModel = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
            ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IImageFileModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ImageFileMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IImageFileModel>(), ref It.IsAny<IImageFile>()));
        //    var mockModel = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
        //    var mockEntity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
        //    ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IImageFileModel>(), ref It.IsAny<IImageFile>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ImageFileMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IImageFile>()));
            var mockEntity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IImageFile>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ImageFileMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IImageFile>()));
            var mockEntity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IImageFile>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ImageFileMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IImageFile>()));
            var mockEntity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IImageFile>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ImageFileMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IImageFileModel>()));
            var mockModel = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
            ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IImageFileModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<ImageFileMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>()));
            ImageFileMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
            var mockEntity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>()), Times.Once);
        }
    }

    public class ImageFilesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsImageFileProperties()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.Characters?.Count, entity.Characters?.Count);
            model.VerifyGet(x => x.Characters, Times.Once);
            //Assert.Equal(model.Object.Chats?.Count, entity.Chats?.Count);
            model.VerifyGet(x => x.Chats, Times.Once);
            //Assert.Equal(model.Object.Concepts?.Count, entity.Concepts?.Count);
            model.VerifyGet(x => x.Concepts, Times.Once);
            //Assert.Equal(model.Object.Episodes?.Count, entity.Episodes?.Count);
            model.VerifyGet(x => x.Episodes, Times.Once);
            //Assert.Equal(model.Object.Issues?.Count, entity.Issues?.Count);
            model.VerifyGet(x => x.Issues, Times.Once);
            //Assert.Equal(model.Object.Locations?.Count, entity.Locations?.Count);
            model.VerifyGet(x => x.Locations, Times.Once);
            //Assert.Equal(model.Object.Movies?.Count, entity.Movies?.Count);
            model.VerifyGet(x => x.Movies, Times.Once);
            //Assert.Equal(model.Object.Objects?.Count, entity.Objects?.Count);
            model.VerifyGet(x => x.Objects, Times.Once);
            //Assert.Equal(model.Object.People?.Count, entity.People?.Count);
            model.VerifyGet(x => x.People, Times.Once);
            //Assert.Equal(model.Object.Promos?.Count, entity.Promos?.Count);
            model.VerifyGet(x => x.Promos, Times.Once);
            //Assert.Equal(model.Object.Publishers?.Count, entity.Publishers?.Count);
            model.VerifyGet(x => x.Publishers, Times.Once);
            //Assert.Equal(model.Object.StoryArcs?.Count, entity.StoryArcs?.Count);
            model.VerifyGet(x => x.StoryArcs, Times.Once);
            //Assert.Equal(model.Object.Teams?.Count, entity.Teams?.Count);
            model.VerifyGet(x => x.Teams, Times.Once);
            //Assert.Equal(model.Object.Videos?.Count, entity.Videos?.Count);
            model.VerifyGet(x => x.Videos, Times.Once);
            //Assert.Equal(model.Object.Volumes?.Count, entity.Volumes?.Count);
            model.VerifyGet(x => x.Volumes, Times.Once);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsImageFileProperties()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel();
            // Act
            IImageFile existingEntity = new ImageFile { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.Characters, Times.Once);
            //Assert.Equal(model.Object.Characters?.Count, existingEntity.Characters?.Count);
            model.VerifyGet(x => x.Chats, Times.Once);
            //Assert.Equal(model.Object.Chats?.Count, existingEntity.Chats?.Count);
            model.VerifyGet(x => x.Concepts, Times.Once);
            //Assert.Equal(model.Object.Concepts?.Count, existingEntity.Concepts?.Count);
            model.VerifyGet(x => x.Episodes, Times.Once);
            //Assert.Equal(model.Object.Episodes?.Count, existingEntity.Episodes?.Count);
            model.VerifyGet(x => x.Issues, Times.Once);
            //Assert.Equal(model.Object.Issues?.Count, existingEntity.Issues?.Count);
            model.VerifyGet(x => x.Locations, Times.Once);
            //Assert.Equal(model.Object.Locations?.Count, existingEntity.Locations?.Count);
            model.VerifyGet(x => x.Movies, Times.Once);
            //Assert.Equal(model.Object.Movies?.Count, existingEntity.Movies?.Count);
            model.VerifyGet(x => x.Objects, Times.Once);
            //Assert.Equal(model.Object.Objects?.Count, existingEntity.Objects?.Count);
            model.VerifyGet(x => x.People, Times.Once);
            //Assert.Equal(model.Object.People?.Count, existingEntity.People?.Count);
            model.VerifyGet(x => x.Promos, Times.Once);
            //Assert.Equal(model.Object.Promos?.Count, existingEntity.Promos?.Count);
            model.VerifyGet(x => x.Publishers, Times.Once);
            //Assert.Equal(model.Object.Publishers?.Count, existingEntity.Publishers?.Count);
            model.VerifyGet(x => x.StoryArcs, Times.Once);
            //Assert.Equal(model.Object.StoryArcs?.Count, existingEntity.StoryArcs?.Count);
            model.VerifyGet(x => x.Teams, Times.Once);
            //Assert.Equal(model.Object.Teams?.Count, existingEntity.Teams?.Count);
            model.VerifyGet(x => x.Videos, Times.Once);
            //Assert.Equal(model.Object.Videos?.Count, existingEntity.Videos?.Count);
            model.VerifyGet(x => x.Volumes, Times.Once);
            //Assert.Equal(model.Object.Volumes?.Count, existingEntity.Volumes?.Count);
        }

        [Fact]
        public void Verify_MapToModel_AssignsImageFileProperties()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var entity = ImageFilesMockingSetup.DoMockingSetupForImageFile();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.Characters?.Count, model.Characters?.Count);
            Assert.Equal(entity.Object.Chats?.Count, model.Chats?.Count);
            Assert.Equal(entity.Object.Concepts?.Count, model.Concepts?.Count);
            Assert.Equal(entity.Object.Episodes?.Count, model.Episodes?.Count);
            Assert.Equal(entity.Object.Issues?.Count, model.Issues?.Count);
            Assert.Equal(entity.Object.Locations?.Count, model.Locations?.Count);
            Assert.Equal(entity.Object.Movies?.Count, model.Movies?.Count);
            Assert.Equal(entity.Object.Objects?.Count, model.Objects?.Count);
            Assert.Equal(entity.Object.People?.Count, model.People?.Count);
            Assert.Equal(entity.Object.Promos?.Count, model.Promos?.Count);
            Assert.Equal(entity.Object.Publishers?.Count, model.Publishers?.Count);
            Assert.Equal(entity.Object.StoryArcs?.Count, model.StoryArcs?.Count);
            Assert.Equal(entity.Object.Teams?.Count, model.Teams?.Count);
            Assert.Equal(entity.Object.Videos?.Count, model.Videos?.Count);
            Assert.Equal(entity.Object.Volumes?.Count, model.Volumes?.Count);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyImageFileProperties()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var entity = ImageFilesMockingSetup.DoMockingSetupForImageFile();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyImageFileProperties()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var entity = ImageFilesMockingSetup.DoMockingSetupForImageFile();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsImageFileSearchProperties()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
            var entity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ImageFileMapper();
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
            var entity = ImageFilesMockingSetup.DoMockingSetupForImageFile(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
