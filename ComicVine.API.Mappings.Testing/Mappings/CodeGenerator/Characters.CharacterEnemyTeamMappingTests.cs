// <auto-generated>
// <copyright file="Characters.ICharacterEnemyTeamRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemyTeamsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Characters
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class CharacterEnemyTeamsMockingSetup
    {
        public static Mock<ICharacterEnemyTeamModel> DoMockingSetupForCharacterEnemyTeamModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterEnemyTeamModel = new Mock<ICharacterEnemyTeamModel>();
            // Mock Functions
            mockCharacterEnemyTeamModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterEnemyTeamModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterEnemyTeamModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterEnemyTeamModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemyTeamModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemyTeamModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterEnemyTeamModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterEnemyTeamModel.Setup(m => m.Name).Returns(() => name);
            //mockCharacterEnemyTeamModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterEnemyTeamModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterEnemyTeamModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterEnemyTeamModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterEnemyTeamModel.Setup(m => m.EnemyTeamId).Returns(() => 1);
            mockCharacterEnemyTeamModel.Setup(m => m.EnemyTeam).Returns(() => new TeamModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterEnemyTeamModel;
        }

        public static Mock<ICharacterEnemyTeam> DoMockingSetupForCharacterEnemyTeam(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterEnemyTeam = new Mock<ICharacterEnemyTeam>();
            // Mock Functions
            mockCharacterEnemyTeam.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterEnemyTeam.Setup(m => m.Active).Returns(() => true);
            mockCharacterEnemyTeam.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterEnemyTeam.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemyTeam.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemyTeam.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterEnemyTeam.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterEnemyTeam.Setup(m => m.Name).Returns(() => name);
            //mockCharacterEnemyTeam.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterEnemyTeam.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterEnemyTeam.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterEnemyTeam.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterEnemyTeam.Setup(m => m.EnemyTeamId).Returns(() => 1);
            mockCharacterEnemyTeam.Setup(m => m.EnemyTeam).Returns(() => new Team());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterEnemyTeam;
        }
    }

    public class CharacterEnemyTeamMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<CharacterEnemyTeamMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterEnemyTeamModel>()));
            var mockModel = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel(1);
            CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterEnemyTeamModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<CharacterEnemyTeamMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterEnemyTeamModel>(), ref It.IsAny<ICharacterEnemyTeam>()));
        //    var mockModel = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel(1);
        //    var mockEntity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(1);
        //    CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterEnemyTeamModel>(), ref It.IsAny<ICharacterEnemyTeam>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterEnemyTeamMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ICharacterEnemyTeam>()));
            var mockEntity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(1);
            CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ICharacterEnemyTeam>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterEnemyTeamMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ICharacterEnemyTeam>()));
            var mockEntity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(1);
            CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ICharacterEnemyTeam>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterEnemyTeamMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ICharacterEnemyTeam>()));
            var mockEntity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(1);
            CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ICharacterEnemyTeam>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterEnemyTeamMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ICharacterEnemyTeamModel>()));
            var mockModel = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel(1);
            CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ICharacterEnemyTeamModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<CharacterEnemyTeamMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ICharacterEnemyTeamModel>(), It.IsAny<ICharacterEnemyTeam>()));
            CharacterEnemyTeamMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel(1);
            var mockEntity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ICharacterEnemyTeamModel>(), It.IsAny<ICharacterEnemyTeam>()), Times.Once);
        }
    }

    public class CharacterEnemyTeamsMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsCharacterEnemyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var model = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            Assert.Equal(model.Object.EnemyTeamId, entity.EnemyTeamId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsCharacterEnemyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var model = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel();
            // Act
            ICharacterEnemyTeam existingEntity = new CharacterEnemyTeam { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            Assert.Equal(model.Object.EnemyTeamId, existingEntity.EnemyTeamId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsCharacterEnemyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var entity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.EnemyTeamId, model.EnemyTeamId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyCharacterEnemyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var entity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.EnemyTeamId, model.EnemyTeamId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyCharacterEnemyTeamProperties()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var entity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.EnemyTeamId, model.EnemyTeamId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsCharacterEnemyTeamSearchProperties()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var model = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel();
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
            Assert.Equal(model.Object.EnemyTeamId, searchModel.EnemyTeamId);
            Assert.Equal(model.Object.EnemyTeam?.CustomKey, searchModel.EnemyTeamCustomKey);
            Assert.Equal(model.Object.EnemyTeam?.ApiDetailUrl, searchModel.EnemyTeamApiDetailUrl);
            Assert.Equal(model.Object.EnemyTeam?.SiteDetailUrl, searchModel.EnemyTeamSiteDetailUrl);
            Assert.Equal(model.Object.EnemyTeam?.Name, searchModel.EnemyTeamName);
            Assert.Equal(model.Object.EnemyTeam?.ShortDescription, searchModel.EnemyTeamShortDescription);
            Assert.Equal(model.Object.EnemyTeam?.Description, searchModel.EnemyTeamDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var model = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel(1);
            var entity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new CharacterEnemyTeamMapper();
            var model = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeamModel(1);
            var entity = CharacterEnemyTeamsMockingSetup.DoMockingSetupForCharacterEnemyTeam(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
