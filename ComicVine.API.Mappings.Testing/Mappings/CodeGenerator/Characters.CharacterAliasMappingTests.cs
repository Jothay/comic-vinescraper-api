// <auto-generated>
// <copyright file="Characters.ICharacterAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterAliasesRepository Class.</summary>
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

    public static class CharacterAliasesMockingSetup
    {
        public static Mock<ICharacterAliasModel> DoMockingSetupForCharacterAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterAliasModel = new Mock<ICharacterAliasModel>();
            // Mock Functions
            mockCharacterAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterAliasModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterAliasModel.Setup(m => m.Name).Returns(() => name);
            //mockCharacterAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterAliasModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterAliasModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterAliasModel;
        }

        public static Mock<ICharacterAlias> DoMockingSetupForCharacterAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterAlias = new Mock<ICharacterAlias>();
            // Mock Functions
            mockCharacterAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterAlias.Setup(m => m.Active).Returns(() => true);
            mockCharacterAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterAlias.Setup(m => m.Name).Returns(() => name);
            //mockCharacterAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterAlias.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterAlias.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterAlias;
        }
    }

    public class CharacterAliasMappingExtensionsTests
    {
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<CharacterAliasMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterAliasModel>(), It.IsAny<int>()));
            var mockModel = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
            CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterAliasModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "CharacterAliases")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<CharacterAliasMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterAliasModel>(), ref It.IsAny<ICharacterAlias>(), It.IsAny<int>()));
        //    var mockModel = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
        //    var mockEntity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
        //    CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterAliasModel>(), ref It.IsAny<ICharacterAlias>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterAliasMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ICharacterAlias>(), It.IsAny<int>()));
            var mockEntity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ICharacterAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterAliasMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ICharacterAlias>(), It.IsAny<int>()));
            var mockEntity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ICharacterAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterAliasMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ICharacterAlias>(), It.IsAny<int>()));
            var mockEntity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ICharacterAlias>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterAliasMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ICharacterAliasModel>()));
            var mockModel = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
            CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ICharacterAliasModel>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<CharacterAliasMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>()));
            CharacterAliasMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
            var mockEntity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>()), Times.Once);
        }
    }

    public class CharacterAliasesMappingTests
    {
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToEntity_AssignsCharacterAliasProperties()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsCharacterAliasProperties()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel();
            // Act
            ICharacterAlias existingEntity = new CharacterAlias { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToModel_AssignsCharacterAliasProperties()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var entity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToModelLite_AssignsLiteOnlyCharacterAliasProperties()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var entity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToModelListing_AssignsListingOnlyCharacterAliasProperties()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var entity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            // Return Entity
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_MapToSearchModel_AssignsCharacterAliasSearchProperties()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel();
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
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
            var entity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new CharacterAliasMapper();
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
            var entity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
