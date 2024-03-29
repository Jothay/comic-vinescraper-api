// <auto-generated>
// <copyright file="Teams.ITeamAliasMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamAliasesMappingTests class.</summary>
// <remarks>This file was auto-generated using MappingTestingFileMaster.tt in
// ComicVineScraper.API.Mappings.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Mappings.Teams
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class TeamAliasesMockingSetup
    {
        public static Mock<ITeamAliasModel> DoMockingSetupForTeamAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamAliasModel = new Mock<ITeamAliasModel>();
            // Mock Functions
            mockTeamAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamAliasModel.Setup(m => m.Active).Returns(() => true);
            mockTeamAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamAliasModel.Setup(m => m.Name).Returns(() => name);
            //mockTeamAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamAliasModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamAliasModel.Setup(m => m.Team).Returns(() => new TeamModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamAliasModel;
        }

        public static Mock<ITeamAlias> DoMockingSetupForTeamAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamAlias = new Mock<ITeamAlias>();
            // Mock Functions
            mockTeamAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamAlias.Setup(m => m.Active).Returns(() => true);
            mockTeamAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamAlias.Setup(m => m.Name).Returns(() => name);
            //mockTeamAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamAlias.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamAlias.Setup(m => m.Team).Returns(() => new Team());
            // Associated Objects
            // <None>
            // Return
            return mockTeamAlias;
        }
    }

    public class TeamAliasMappingExtensionsTests
    {
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<TeamAliasMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamAliasModel>(), It.IsAny<int>()));
            var mockModel = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel(1);
            TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamAliasModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "TeamAliases")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<TeamAliasMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamAliasModel>(), ref It.IsAny<ITeamAlias>(), It.IsAny<int>()));
        //    var mockModel = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel(1);
        //    var mockEntity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(1);
        //    TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamAliasModel>(), ref It.IsAny<ITeamAlias>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamAliasMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ITeamAlias>(), It.IsAny<int>()));
            var mockEntity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(1);
            TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ITeamAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamAliasMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ITeamAlias>(), It.IsAny<int>()));
            var mockEntity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(1);
            TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ITeamAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamAliasMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ITeamAlias>(), It.IsAny<int>()));
            var mockEntity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(1);
            TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ITeamAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamAliasMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ITeamAliasModel>()));
            var mockModel = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel(1);
            TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ITeamAliasModel>()), Times.Once);
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<TeamAliasMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ITeamAliasModel>(), It.IsAny<ITeamAlias>()));
            TeamAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel(1);
            var mockEntity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ITeamAliasModel>(), It.IsAny<ITeamAlias>()), Times.Once);
        }
    }

    public class TeamAliasesMappingTests
    {
        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToEntity_AssignsTeamAliasProperties()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var model = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, entity.TeamId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsTeamAliasProperties()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var model = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel();
            // Act
            ITeamAlias existingEntity = new TeamAlias { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, existingEntity.TeamId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToModel_AssignsTeamAliasProperties()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var entity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToModelLite_AssignsLiteOnlyTeamAliasProperties()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var entity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToModelListing_AssignsListingOnlyTeamAliasProperties()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var entity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            // Return Entity
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_MapToSearchModel_AssignsTeamAliasSearchProperties()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var model = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel();
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
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var model = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel(1);
            var entity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "TeamAliases")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new TeamAliasMapper();
            var model = TeamAliasesMockingSetup.DoMockingSetupForTeamAliasModel(1);
            var entity = TeamAliasesMockingSetup.DoMockingSetupForTeamAlias(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
