// <auto-generated>
// <copyright file="Characters.ICharacterPowerRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterPowersRepository Class.</summary>
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

    public static class CharacterPowersMockingSetup
    {
        public static Mock<ICharacterPowerModel> DoMockingSetupForCharacterPowerModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterPowerModel = new Mock<ICharacterPowerModel>();
            // Mock Functions
            mockCharacterPowerModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterPowerModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterPowerModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterPowerModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterPowerModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterPowerModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterPowerModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterPowerModel.Setup(m => m.Name).Returns(() => name);
            //mockCharacterPowerModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterPowerModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterPowerModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterPowerModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterPowerModel.Setup(m => m.PowerId).Returns(() => 1);
            mockCharacterPowerModel.Setup(m => m.Power).Returns(() => new PowerModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterPowerModel;
        }

        public static Mock<ICharacterPower> DoMockingSetupForCharacterPower(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterPower = new Mock<ICharacterPower>();
            // Mock Functions
            mockCharacterPower.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterPower.Setup(m => m.Active).Returns(() => true);
            mockCharacterPower.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterPower.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterPower.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterPower.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterPower.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterPower.Setup(m => m.Name).Returns(() => name);
            //mockCharacterPower.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterPower.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterPower.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterPower.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterPower.Setup(m => m.PowerId).Returns(() => 1);
            mockCharacterPower.Setup(m => m.Power).Returns(() => new Power());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterPower;
        }
    }

    public class CharacterPowerMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<CharacterPowerMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterPowerModel>()));
            var mockModel = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel(1);
            CharacterPowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterPowerModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<CharacterPowerMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterPowerModel>(), ref It.IsAny<ICharacterPower>()));
        //    var mockModel = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel(1);
        //    var mockEntity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower(1);
        //    CharacterPowerMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterPowerModel>(), ref It.IsAny<ICharacterPower>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterPowerMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ICharacterPower>()));
            var mockEntity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower(1);
            CharacterPowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ICharacterPower>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterPowerMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ICharacterPower>()));
            var mockEntity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower(1);
            CharacterPowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ICharacterPower>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterPowerMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ICharacterPower>()));
            var mockEntity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower(1);
            CharacterPowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ICharacterPower>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterPowerMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ICharacterPowerModel>()));
            var mockModel = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel(1);
            CharacterPowerMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ICharacterPowerModel>()), Times.Once);
        }

        public static Mock<ICharacterPower> DoMockingSetupForCharacterPower(int idReturnValue = 0)
        {
            var mockCharacterPower = new Mock<ICharacterPower>();
            // Mock Functions
            mockCharacterPower.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterPower.Setup(m => m.Active).Returns(() => true);
            mockCharacterPower.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterPower.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterPower.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterPower.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterPower.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterPower.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterPower.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterPower.Setup(m => m.PowerId).Returns(() => 1);
            mockCharacterPower.Setup(m => m.Power).Returns(() => new Power());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterPower;
        }
    }

    public class CharacterPowersMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsCharacterPowerProperties()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var model = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            Assert.Equal(model.Object.PowerId, entity.PowerId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsCharacterPowerProperties()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var model = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel();
            // Act
            ICharacterPower existingEntity = new CharacterPower { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            Assert.Equal(model.Object.PowerId, existingEntity.PowerId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsCharacterPowerProperties()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var entity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.PowerId, model.PowerId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyCharacterPowerProperties()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var entity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.PowerId, model.PowerId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyCharacterPowerProperties()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var entity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.PowerId, model.PowerId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsCharacterPowerSearchProperties()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var model = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel();
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
            Assert.Equal(model.Object.PowerId, searchModel.PowerId);
            Assert.Equal(model.Object.Power?.CustomKey, searchModel.PowerCustomKey);
            Assert.Equal(model.Object.Power?.ApiDetailUrl, searchModel.PowerApiDetailUrl);
            Assert.Equal(model.Object.Power?.SiteDetailUrl, searchModel.PowerSiteDetailUrl);
            Assert.Equal(model.Object.Power?.Name, searchModel.PowerName);
            Assert.Equal(model.Object.Power?.ShortDescription, searchModel.PowerShortDescription);
            Assert.Equal(model.Object.Power?.Description, searchModel.PowerDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var model = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel(1);
            var entity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new CharacterPowerMapper();
            var model = CharacterPowersMockingSetup.DoMockingSetupForCharacterPowerModel(1);
            var entity = CharacterPowersMockingSetup.DoMockingSetupForCharacterPower(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
