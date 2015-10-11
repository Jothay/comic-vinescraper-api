// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeStoryArcsRepository Class.</summary>
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

    public static class EpisodeStoryArcsMockingSetup
    {
        public static Mock<IEpisodeStoryArcModel> DoMockingSetupForEpisodeStoryArcModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeStoryArcModel = new Mock<IEpisodeStoryArcModel>();
            // Mock Functions
            mockEpisodeStoryArcModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeStoryArcModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeStoryArcModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeStoryArcModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArcModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArcModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeStoryArcModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeStoryArcModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeStoryArcModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeStoryArcModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeStoryArcModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeStoryArcModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeStoryArcModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockEpisodeStoryArcModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeStoryArcModel;
        }

        public static Mock<IEpisodeStoryArc> DoMockingSetupForEpisodeStoryArc(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeStoryArc = new Mock<IEpisodeStoryArc>();
            // Mock Functions
            mockEpisodeStoryArc.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeStoryArc.Setup(m => m.Active).Returns(() => true);
            mockEpisodeStoryArc.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeStoryArc.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArc.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArc.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeStoryArc.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeStoryArc.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeStoryArc.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeStoryArc.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeStoryArc.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeStoryArc.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeStoryArc.Setup(m => m.StoryArcId).Returns(() => 1);
            mockEpisodeStoryArc.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeStoryArc;
        }
    }

    public class EpisodeStoryArcMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeStoryArcMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeStoryArcModel>()));
            var mockModel = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel(1);
            EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeStoryArcModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeStoryArcMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeStoryArcModel>(), ref It.IsAny<IEpisodeStoryArc>()));
        //    var mockModel = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel(1);
        //    var mockEntity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(1);
        //    EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeStoryArcModel>(), ref It.IsAny<IEpisodeStoryArc>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeStoryArc>()));
            var mockEntity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(1);
            EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeStoryArc>()));
            var mockEntity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(1);
            EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeStoryArc>()));
            var mockEntity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(1);
            EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeStoryArcMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeStoryArcModel>()));
            var mockModel = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel(1);
            EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeStoryArcModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeStoryArcMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodeStoryArcModel>(), It.IsAny<IEpisodeStoryArc>()));
            EpisodeStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel(1);
            var mockEntity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodeStoryArcModel>(), It.IsAny<IEpisodeStoryArc>()), Times.Once);
        }
    }

    public class EpisodeStoryArcsMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsEpisodeStoryArcProperties()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var model = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.StoryArcId, entity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeStoryArcProperties()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var model = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel();
            // Act
            IEpisodeStoryArc existingEntity = new EpisodeStoryArc { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.StoryArcId, existingEntity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsEpisodeStoryArcProperties()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var entity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeStoryArcProperties()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var entity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeStoryArcProperties()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var entity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsEpisodeStoryArcSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var model = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel();
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
            Assert.Equal(model.Object.StoryArcId, searchModel.StoryArcId);
            Assert.Equal(model.Object.StoryArc?.CustomKey, searchModel.StoryArcCustomKey);
            Assert.Equal(model.Object.StoryArc?.ApiDetailUrl, searchModel.StoryArcApiDetailUrl);
            Assert.Equal(model.Object.StoryArc?.SiteDetailUrl, searchModel.StoryArcSiteDetailUrl);
            Assert.Equal(model.Object.StoryArc?.Name, searchModel.StoryArcName);
            Assert.Equal(model.Object.StoryArc?.ShortDescription, searchModel.StoryArcShortDescription);
            Assert.Equal(model.Object.StoryArc?.Description, searchModel.StoryArcDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var model = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel(1);
            var entity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeStoryArcMapper();
            var model = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArcModel(1);
            var entity = EpisodeStoryArcsMockingSetup.DoMockingSetupForEpisodeStoryArc(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
