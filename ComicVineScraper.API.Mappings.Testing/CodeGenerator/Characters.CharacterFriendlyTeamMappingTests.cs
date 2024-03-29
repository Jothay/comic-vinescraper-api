// <auto-generated>
// <copyright file="Characters.ICharacterFriendlyTeamMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriendlyTeamsMappingTests class.</summary>
// <remarks>This file was auto-generated using MappingTestingFileMaster.tt in
// ComicVineScraper.API.Mappings.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Mappings.Characters
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class CharacterFriendlyTeamsMockingSetup
    {
        public static Mock<ICharacterFriendlyTeamModel> DoMockingSetupForCharacterFriendlyTeamModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterFriendlyTeamModel = new Mock<ICharacterFriendlyTeamModel>();
            // Mock Functions
            mockCharacterFriendlyTeamModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterFriendlyTeamModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterFriendlyTeamModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterFriendlyTeamModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriendlyTeamModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriendlyTeamModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterFriendlyTeamModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterFriendlyTeamModel.Setup(m => m.Name).Returns(() => name);
            //mockCharacterFriendlyTeamModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterFriendlyTeamModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterFriendlyTeamModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterFriendlyTeamModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterFriendlyTeamModel.Setup(m => m.FriendlyTeamId).Returns(() => 1);
            mockCharacterFriendlyTeamModel.Setup(m => m.FriendlyTeam).Returns(() => new TeamModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterFriendlyTeamModel;
        }

        public static Mock<ICharacterFriendlyTeam> DoMockingSetupForCharacterFriendlyTeam(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterFriendlyTeam = new Mock<ICharacterFriendlyTeam>();
            // Mock Functions
            mockCharacterFriendlyTeam.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterFriendlyTeam.Setup(m => m.Active).Returns(() => true);
            mockCharacterFriendlyTeam.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterFriendlyTeam.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriendlyTeam.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriendlyTeam.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterFriendlyTeam.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterFriendlyTeam.Setup(m => m.Name).Returns(() => name);
            //mockCharacterFriendlyTeam.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterFriendlyTeam.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterFriendlyTeam.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterFriendlyTeam.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterFriendlyTeam.Setup(m => m.FriendlyTeamId).Returns(() => 1);
            mockCharacterFriendlyTeam.Setup(m => m.FriendlyTeam).Returns(() => new Team());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterFriendlyTeam;
        }
    }

    public class CharacterFriendlyTeamMappingExtensionsTests
    {
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterFriendlyTeamModel>(), It.IsAny<int>()));
            var mockModel = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel(1);
            CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterFriendlyTeamModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "CharacterFriendlyTeams")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterFriendlyTeamModel>(), ref It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()));
        //    var mockModel = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel(1);
        //    var mockEntity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(1);
        //    CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterFriendlyTeamModel>(), ref It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()));
            var mockEntity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(1);
            CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()));
            var mockEntity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(1);
            CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()));
            var mockEntity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(1);
            CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ICharacterFriendlyTeam>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ICharacterFriendlyTeamModel>()));
            var mockModel = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel(1);
            CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ICharacterFriendlyTeamModel>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<CharacterFriendlyTeamMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ICharacterFriendlyTeamModel>(), It.IsAny<ICharacterFriendlyTeam>()));
            CharacterFriendlyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel(1);
            var mockEntity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ICharacterFriendlyTeamModel>(), It.IsAny<ICharacterFriendlyTeam>()), Times.Once);
        }
    }

    public class CharacterFriendlyTeamsMappingTests
    {
        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToEntity_AssignsCharacterFriendlyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var model = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            Assert.Equal(model.Object.FriendlyTeamId, entity.FriendlyTeamId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsCharacterFriendlyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var model = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel();
            // Act
            ICharacterFriendlyTeam existingEntity = new CharacterFriendlyTeam { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            Assert.Equal(model.Object.FriendlyTeamId, existingEntity.FriendlyTeamId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToModel_AssignsCharacterFriendlyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var entity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.FriendlyTeamId, model.FriendlyTeamId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToModelLite_AssignsLiteOnlyCharacterFriendlyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var entity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.FriendlyTeamId, model.FriendlyTeamId);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToModelListing_AssignsListingOnlyCharacterFriendlyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var entity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.FriendlyTeamId, model.FriendlyTeamId);
            // Return Entity
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_MapToSearchModel_AssignsCharacterFriendlyTeamSearchProperties()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var model = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.CharacterId, searchModel.CharacterId);
            Assert.Equal(model.Object.Character?.CustomKey, searchModel.CharacterCustomKey);
            Assert.Equal(model.Object.Character?.ApiDetailUrl, searchModel.CharacterApiDetailUrl);
            Assert.Equal(model.Object.Character?.SiteDetailUrl, searchModel.CharacterSiteDetailUrl);
            Assert.Equal(model.Object.Character?.Name, searchModel.CharacterName);
            Assert.Equal(model.Object.Character?.ShortDescription, searchModel.CharacterShortDescription);
            Assert.Equal(model.Object.Character?.Description, searchModel.CharacterDescription);
            Assert.Equal(model.Object.FriendlyTeamId, searchModel.FriendlyTeamId);
            Assert.Equal(model.Object.FriendlyTeam?.CustomKey, searchModel.FriendlyTeamCustomKey);
            Assert.Equal(model.Object.FriendlyTeam?.ApiDetailUrl, searchModel.FriendlyTeamApiDetailUrl);
            Assert.Equal(model.Object.FriendlyTeam?.SiteDetailUrl, searchModel.FriendlyTeamSiteDetailUrl);
            Assert.Equal(model.Object.FriendlyTeam?.Name, searchModel.FriendlyTeamName);
            Assert.Equal(model.Object.FriendlyTeam?.ShortDescription, searchModel.FriendlyTeamShortDescription);
            Assert.Equal(model.Object.FriendlyTeam?.Description, searchModel.FriendlyTeamDescription);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var model = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel(1);
            var entity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "CharacterFriendlyTeams")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new CharacterFriendlyTeamMapper();
            var model = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeamModel(1);
            var entity = CharacterFriendlyTeamsMockingSetup.DoMockingSetupForCharacterFriendlyTeam(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
