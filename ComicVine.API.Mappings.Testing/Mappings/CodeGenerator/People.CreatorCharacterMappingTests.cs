// <auto-generated>
// <copyright file="People.ICreatorCharacterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CreatorCharactersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.People
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class CreatorCharactersMockingSetup
    {
        public static Mock<ICreatorCharacterModel> DoMockingSetupForCreatorCharacterModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCreatorCharacterModel = new Mock<ICreatorCharacterModel>();
            // Mock Functions
            mockCreatorCharacterModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCreatorCharacterModel.Setup(m => m.Active).Returns(() => true);
            mockCreatorCharacterModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCreatorCharacterModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacterModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacterModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCreatorCharacterModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCreatorCharacterModel.Setup(m => m.Name).Returns(() => name);
            //mockCreatorCharacterModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCreatorCharacterModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCreatorCharacterModel.Setup(m => m.PersonId).Returns(() => 1);
            mockCreatorCharacterModel.Setup(m => m.Creator).Returns(() => new PersonModel());
            mockCreatorCharacterModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCreatorCharacterModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockCreatorCharacterModel;
        }

        public static Mock<ICreatorCharacter> DoMockingSetupForCreatorCharacter(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCreatorCharacter = new Mock<ICreatorCharacter>();
            // Mock Functions
            mockCreatorCharacter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCreatorCharacter.Setup(m => m.Active).Returns(() => true);
            mockCreatorCharacter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCreatorCharacter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCreatorCharacter.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCreatorCharacter.Setup(m => m.Name).Returns(() => name);
            //mockCreatorCharacter.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCreatorCharacter.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCreatorCharacter.Setup(m => m.PersonId).Returns(() => 1);
            mockCreatorCharacter.Setup(m => m.Creator).Returns(() => new Person());
            mockCreatorCharacter.Setup(m => m.CharacterId).Returns(() => 1);
            mockCreatorCharacter.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockCreatorCharacter;
        }
    }

    public class CreatorCharacterMappingExtensionsTests
    {
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<CreatorCharacterMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICreatorCharacterModel>(), It.IsAny<int>()));
            var mockModel = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
            CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICreatorCharacterModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "CreatorCharacters")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<CreatorCharacterMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICreatorCharacterModel>(), ref It.IsAny<ICreatorCharacter>(), It.IsAny<int>()));
        //    var mockModel = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
        //    var mockEntity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
        //    CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICreatorCharacterModel>(), ref It.IsAny<ICreatorCharacter>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CreatorCharacterMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ICreatorCharacter>(), It.IsAny<int>()));
            var mockEntity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ICreatorCharacter>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CreatorCharacterMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ICreatorCharacter>(), It.IsAny<int>()));
            var mockEntity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ICreatorCharacter>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CreatorCharacterMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ICreatorCharacter>(), It.IsAny<int>()));
            var mockEntity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ICreatorCharacter>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CreatorCharacterMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ICreatorCharacterModel>()));
            var mockModel = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
            CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ICreatorCharacterModel>()), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<CreatorCharacterMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>()));
            CreatorCharacterMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
            var mockEntity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>()), Times.Once);
        }
    }

    public class CreatorCharactersMappingTests
    {
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToEntity_AssignsCreatorCharacterProperties()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.PersonId, entity.PersonId);
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsCreatorCharacterProperties()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel();
            // Act
            ICreatorCharacter existingEntity = new CreatorCharacter { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.PersonId, existingEntity.PersonId);
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToModel_AssignsCreatorCharacterProperties()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var entity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.PersonId, model.PersonId);
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToModelLite_AssignsLiteOnlyCreatorCharacterProperties()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var entity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.PersonId, model.PersonId);
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToModelListing_AssignsListingOnlyCreatorCharacterProperties()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var entity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.PersonId, model.PersonId);
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            // Return Entity
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_MapToSearchModel_AssignsCreatorCharacterSearchProperties()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.PersonId, searchModel.PersonId);
            Assert.Equal(model.Object.Creator?.ApiDetailUrl, searchModel.CreatorApiDetailUrl);
            Assert.Equal(model.Object.Creator?.SiteDetailUrl, searchModel.CreatorSiteDetailUrl);
            Assert.Equal(model.Object.Creator?.Name, searchModel.CreatorName);
            Assert.Equal(model.Object.Creator?.ShortDescription, searchModel.CreatorShortDescription);
            Assert.Equal(model.Object.Creator?.Description, searchModel.CreatorDescription);
            Assert.Equal(model.Object.CharacterId, searchModel.CharacterId);
            Assert.Equal(model.Object.Character?.CustomKey, searchModel.CharacterCustomKey);
            Assert.Equal(model.Object.Character?.ApiDetailUrl, searchModel.CharacterApiDetailUrl);
            Assert.Equal(model.Object.Character?.SiteDetailUrl, searchModel.CharacterSiteDetailUrl);
            Assert.Equal(model.Object.Character?.Name, searchModel.CharacterName);
            Assert.Equal(model.Object.Character?.ShortDescription, searchModel.CharacterShortDescription);
            Assert.Equal(model.Object.Character?.Description, searchModel.CharacterDescription);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
            var entity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new CreatorCharacterMapper();
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
            var entity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
