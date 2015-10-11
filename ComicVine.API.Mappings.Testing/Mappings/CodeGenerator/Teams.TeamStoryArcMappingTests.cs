// <auto-generated>
// <copyright file="Teams.ITeamStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamStoryArcsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Teams
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class TeamStoryArcsMockingSetup
    {
        public static Mock<ITeamStoryArcModel> DoMockingSetupForTeamStoryArcModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamStoryArcModel = new Mock<ITeamStoryArcModel>();
            // Mock Functions
            mockTeamStoryArcModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamStoryArcModel.Setup(m => m.Active).Returns(() => true);
            mockTeamStoryArcModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamStoryArcModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamStoryArcModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamStoryArcModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamStoryArcModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamStoryArcModel.Setup(m => m.Name).Returns(() => name);
            //mockTeamStoryArcModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamStoryArcModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamStoryArcModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamStoryArcModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamStoryArcModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockTeamStoryArcModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamStoryArcModel;
        }

        public static Mock<ITeamStoryArc> DoMockingSetupForTeamStoryArc(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamStoryArc = new Mock<ITeamStoryArc>();
            // Mock Functions
            mockTeamStoryArc.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamStoryArc.Setup(m => m.Active).Returns(() => true);
            mockTeamStoryArc.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamStoryArc.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamStoryArc.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamStoryArc.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamStoryArc.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamStoryArc.Setup(m => m.Name).Returns(() => name);
            //mockTeamStoryArc.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamStoryArc.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamStoryArc.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamStoryArc.Setup(m => m.Team).Returns(() => new Team());
            mockTeamStoryArc.Setup(m => m.StoryArcId).Returns(() => 1);
            mockTeamStoryArc.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockTeamStoryArc;
        }
    }

    public class TeamStoryArcMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<TeamStoryArcMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamStoryArcModel>()));
            var mockModel = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel(1);
            TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamStoryArcModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<TeamStoryArcMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamStoryArcModel>(), ref It.IsAny<ITeamStoryArc>()));
        //    var mockModel = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel(1);
        //    var mockEntity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(1);
        //    TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamStoryArcModel>(), ref It.IsAny<ITeamStoryArc>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ITeamStoryArc>()));
            var mockEntity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(1);
            TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ITeamStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ITeamStoryArc>()));
            var mockEntity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(1);
            TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ITeamStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ITeamStoryArc>()));
            var mockEntity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(1);
            TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ITeamStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamStoryArcMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ITeamStoryArcModel>()));
            var mockModel = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel(1);
            TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ITeamStoryArcModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<TeamStoryArcMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ITeamStoryArcModel>(), It.IsAny<ITeamStoryArc>()));
            TeamStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel(1);
            var mockEntity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ITeamStoryArcModel>(), It.IsAny<ITeamStoryArc>()), Times.Once);
        }
    }

    public class TeamStoryArcsMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsTeamStoryArcProperties()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var model = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, entity.TeamId);
            Assert.Equal(model.Object.StoryArcId, entity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsTeamStoryArcProperties()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var model = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel();
            // Act
            ITeamStoryArc existingEntity = new TeamStoryArc { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, existingEntity.TeamId);
            Assert.Equal(model.Object.StoryArcId, existingEntity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsTeamStoryArcProperties()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var entity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyTeamStoryArcProperties()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var entity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyTeamStoryArcProperties()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var entity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsTeamStoryArcSearchProperties()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var model = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.TeamId, searchModel.TeamId);
            Assert.Equal(model.Object.Team?.CustomKey, searchModel.TeamCustomKey);
            Assert.Equal(model.Object.Team?.ApiDetailUrl, searchModel.TeamApiDetailUrl);
            Assert.Equal(model.Object.Team?.SiteDetailUrl, searchModel.TeamSiteDetailUrl);
            Assert.Equal(model.Object.Team?.Name, searchModel.TeamName);
            Assert.Equal(model.Object.Team?.ShortDescription, searchModel.TeamShortDescription);
            Assert.Equal(model.Object.Team?.Description, searchModel.TeamDescription);
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
            var mapper = new TeamStoryArcMapper();
            var model = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel(1);
            var entity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new TeamStoryArcMapper();
            var model = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArcModel(1);
            var entity = TeamStoryArcsMockingSetup.DoMockingSetupForTeamStoryArc(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
