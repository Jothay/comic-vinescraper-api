// <auto-generated>
// <copyright file="Teams.ITeamVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamVolumesRepository Class.</summary>
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

    public static class TeamVolumesMockingSetup
    {
        public static Mock<ITeamVolumeModel> DoMockingSetupForTeamVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamVolumeModel = new Mock<ITeamVolumeModel>();
            // Mock Functions
            mockTeamVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockTeamVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamVolumeModel.Setup(m => m.Name).Returns(() => name);
            //mockTeamVolumeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamVolumeModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamVolumeModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamVolumeModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockTeamVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamVolumeModel;
        }

        public static Mock<ITeamVolume> DoMockingSetupForTeamVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamVolume = new Mock<ITeamVolume>();
            // Mock Functions
            mockTeamVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamVolume.Setup(m => m.Active).Returns(() => true);
            mockTeamVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamVolume.Setup(m => m.Name).Returns(() => name);
            //mockTeamVolume.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamVolume.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamVolume.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamVolume.Setup(m => m.Team).Returns(() => new Team());
            mockTeamVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockTeamVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockTeamVolume;
        }
    }

    public class TeamVolumeMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<TeamVolumeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamVolumeModel>()));
            var mockModel = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1);
            TeamVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamVolumeModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<TeamVolumeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamVolumeModel>(), ref It.IsAny<ITeamVolume>()));
        //    var mockModel = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1);
        //    var mockEntity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
        //    TeamVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamVolumeModel>(), ref It.IsAny<ITeamVolume>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamVolumeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ITeamVolume>()));
            var mockEntity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            TeamVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ITeamVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ITeamVolume>()));
            var mockEntity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            TeamVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ITeamVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamVolumeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ITeamVolume>()));
            var mockEntity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            TeamVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ITeamVolume>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamVolumeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ITeamVolumeModel>()));
            var mockModel = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1);
            TeamVolumeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ITeamVolumeModel>()), Times.Once);
        }

        public static Mock<ITeamVolume> DoMockingSetupForTeamVolume(int idReturnValue = 0)
        {
            var mockTeamVolume = new Mock<ITeamVolume>();
            // Mock Functions
            mockTeamVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamVolume.Setup(m => m.Active).Returns(() => true);
            mockTeamVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamVolume.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamVolume.Setup(m => m.Team).Returns(() => new Team());
            mockTeamVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockTeamVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockTeamVolume;
        }
    }

    public class TeamVolumesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsTeamVolumeProperties()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, entity.TeamId);
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsTeamVolumeProperties()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel();
            // Act
            ITeamVolume existingEntity = new TeamVolume { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, existingEntity.TeamId);
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsTeamVolumeProperties()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var entity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyTeamVolumeProperties()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var entity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyTeamVolumeProperties()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var entity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsTeamVolumeSearchProperties()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel();
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
            var mapper = new TeamVolumeMapper();
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1);
            var entity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new TeamVolumeMapper();
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1);
            var entity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
