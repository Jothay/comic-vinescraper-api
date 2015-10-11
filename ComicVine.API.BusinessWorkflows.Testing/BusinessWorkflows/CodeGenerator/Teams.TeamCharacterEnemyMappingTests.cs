// <auto-generated>
// <copyright file="Teams.ITeamCharacterEnemyRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamCharacterEnemiesRepository Class.</summary>
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

    public static class TeamCharacterEnemiesMockingSetup
    {
        public static Mock<ITeamCharacterEnemyModel> DoMockingSetupForTeamCharacterEnemyModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamCharacterEnemyModel = new Mock<ITeamCharacterEnemyModel>();
            // Mock Functions
            mockTeamCharacterEnemyModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamCharacterEnemyModel.Setup(m => m.Active).Returns(() => true);
            mockTeamCharacterEnemyModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamCharacterEnemyModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterEnemyModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterEnemyModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamCharacterEnemyModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamCharacterEnemyModel.Setup(m => m.Name).Returns(() => name);
            //mockTeamCharacterEnemyModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamCharacterEnemyModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamCharacterEnemyModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamCharacterEnemyModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamCharacterEnemyModel.Setup(m => m.EnemyId).Returns(() => 1);
            mockTeamCharacterEnemyModel.Setup(m => m.Enemy).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamCharacterEnemyModel;
        }

        public static Mock<ITeamCharacterEnemy> DoMockingSetupForTeamCharacterEnemy(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamCharacterEnemy = new Mock<ITeamCharacterEnemy>();
            // Mock Functions
            mockTeamCharacterEnemy.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamCharacterEnemy.Setup(m => m.Active).Returns(() => true);
            mockTeamCharacterEnemy.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamCharacterEnemy.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterEnemy.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterEnemy.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamCharacterEnemy.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamCharacterEnemy.Setup(m => m.Name).Returns(() => name);
            //mockTeamCharacterEnemy.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamCharacterEnemy.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamCharacterEnemy.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamCharacterEnemy.Setup(m => m.Team).Returns(() => new Team());
            mockTeamCharacterEnemy.Setup(m => m.EnemyId).Returns(() => 1);
            mockTeamCharacterEnemy.Setup(m => m.Enemy).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockTeamCharacterEnemy;
        }
    }

    public class TeamCharacterEnemyMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<TeamCharacterEnemyMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamCharacterEnemyModel>()));
            var mockModel = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel(1);
            TeamCharacterEnemyMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamCharacterEnemyModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<TeamCharacterEnemyMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamCharacterEnemyModel>(), ref It.IsAny<ITeamCharacterEnemy>()));
        //    var mockModel = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel(1);
        //    var mockEntity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy(1);
        //    TeamCharacterEnemyMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamCharacterEnemyModel>(), ref It.IsAny<ITeamCharacterEnemy>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamCharacterEnemyMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ITeamCharacterEnemy>()));
            var mockEntity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy(1);
            TeamCharacterEnemyMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ITeamCharacterEnemy>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamCharacterEnemyMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ITeamCharacterEnemy>()));
            var mockEntity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy(1);
            TeamCharacterEnemyMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ITeamCharacterEnemy>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamCharacterEnemyMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ITeamCharacterEnemy>()));
            var mockEntity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy(1);
            TeamCharacterEnemyMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ITeamCharacterEnemy>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamCharacterEnemyMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ITeamCharacterEnemyModel>()));
            var mockModel = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel(1);
            TeamCharacterEnemyMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ITeamCharacterEnemyModel>()), Times.Once);
        }

        public static Mock<ITeamCharacterEnemy> DoMockingSetupForTeamCharacterEnemy(int idReturnValue = 0)
        {
            var mockTeamCharacterEnemy = new Mock<ITeamCharacterEnemy>();
            // Mock Functions
            mockTeamCharacterEnemy.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamCharacterEnemy.Setup(m => m.Active).Returns(() => true);
            mockTeamCharacterEnemy.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamCharacterEnemy.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterEnemy.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterEnemy.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamCharacterEnemy.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamCharacterEnemy.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamCharacterEnemy.Setup(m => m.Team).Returns(() => new Team());
            mockTeamCharacterEnemy.Setup(m => m.EnemyId).Returns(() => 1);
            mockTeamCharacterEnemy.Setup(m => m.Enemy).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockTeamCharacterEnemy;
        }
    }

    public class TeamCharacterEnemiesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsTeamCharacterEnemyProperties()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var model = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, entity.TeamId);
            Assert.Equal(model.Object.EnemyId, entity.EnemyId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsTeamCharacterEnemyProperties()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var model = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel();
            // Act
            ITeamCharacterEnemy existingEntity = new TeamCharacterEnemy { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, existingEntity.TeamId);
            Assert.Equal(model.Object.EnemyId, existingEntity.EnemyId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsTeamCharacterEnemyProperties()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var entity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.EnemyId, model.EnemyId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyTeamCharacterEnemyProperties()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var entity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.EnemyId, model.EnemyId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyTeamCharacterEnemyProperties()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var entity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.EnemyId, model.EnemyId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsTeamCharacterEnemySearchProperties()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var model = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel();
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
            Assert.Equal(model.Object.EnemyId, searchModel.EnemyId);
            Assert.Equal(model.Object.Enemy?.CustomKey, searchModel.EnemyCustomKey);
            Assert.Equal(model.Object.Enemy?.ApiDetailUrl, searchModel.EnemyApiDetailUrl);
            Assert.Equal(model.Object.Enemy?.SiteDetailUrl, searchModel.EnemySiteDetailUrl);
            Assert.Equal(model.Object.Enemy?.Name, searchModel.EnemyName);
            Assert.Equal(model.Object.Enemy?.ShortDescription, searchModel.EnemyShortDescription);
            Assert.Equal(model.Object.Enemy?.Description, searchModel.EnemyDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var model = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel(1);
            var entity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new TeamCharacterEnemyMapper();
            var model = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemyModel(1);
            var entity = TeamCharacterEnemiesMockingSetup.DoMockingSetupForTeamCharacterEnemy(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
