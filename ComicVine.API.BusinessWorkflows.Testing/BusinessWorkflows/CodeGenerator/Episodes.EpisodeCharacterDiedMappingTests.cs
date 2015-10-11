// <auto-generated>
// <copyright file="Episodes.IEpisodeCharacterDiedRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeCharactersDiedRepository Class.</summary>
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

    public static class EpisodeCharactersDiedMockingSetup
    {
        public static Mock<IEpisodeCharacterDiedModel> DoMockingSetupForEpisodeCharacterDiedModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeCharacterDiedModel = new Mock<IEpisodeCharacterDiedModel>();
            // Mock Functions
            mockEpisodeCharacterDiedModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeCharacterDiedModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeCharacterDiedModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeCharacterDiedModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterDiedModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterDiedModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeCharacterDiedModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeCharacterDiedModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeCharacterDiedModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeCharacterDiedModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeCharacterDiedModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeCharacterDiedModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeCharacterDiedModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockEpisodeCharacterDiedModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeCharacterDiedModel;
        }

        public static Mock<IEpisodeCharacterDied> DoMockingSetupForEpisodeCharacterDied(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeCharacterDied = new Mock<IEpisodeCharacterDied>();
            // Mock Functions
            mockEpisodeCharacterDied.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeCharacterDied.Setup(m => m.Active).Returns(() => true);
            mockEpisodeCharacterDied.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeCharacterDied.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterDied.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterDied.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeCharacterDied.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeCharacterDied.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeCharacterDied.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeCharacterDied.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeCharacterDied.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeCharacterDied.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeCharacterDied.Setup(m => m.CharacterId).Returns(() => 1);
            mockEpisodeCharacterDied.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeCharacterDied;
        }
    }

    public class EpisodeCharacterDiedMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeCharacterDiedMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeCharacterDiedModel>()));
            var mockModel = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel(1);
            EpisodeCharacterDiedMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeCharacterDiedModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeCharacterDiedMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeCharacterDiedModel>(), ref It.IsAny<IEpisodeCharacterDied>()));
        //    var mockModel = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel(1);
        //    var mockEntity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied(1);
        //    EpisodeCharacterDiedMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeCharacterDiedModel>(), ref It.IsAny<IEpisodeCharacterDied>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeCharacterDiedMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeCharacterDied>()));
            var mockEntity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied(1);
            EpisodeCharacterDiedMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeCharacterDied>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeCharacterDiedMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeCharacterDied>()));
            var mockEntity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied(1);
            EpisodeCharacterDiedMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeCharacterDied>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeCharacterDiedMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeCharacterDied>()));
            var mockEntity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied(1);
            EpisodeCharacterDiedMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeCharacterDied>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeCharacterDiedMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeCharacterDiedModel>()));
            var mockModel = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel(1);
            EpisodeCharacterDiedMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeCharacterDiedModel>()), Times.Once);
        }

        public static Mock<IEpisodeCharacterDied> DoMockingSetupForEpisodeCharacterDied(int idReturnValue = 0)
        {
            var mockEpisodeCharacterDied = new Mock<IEpisodeCharacterDied>();
            // Mock Functions
            mockEpisodeCharacterDied.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeCharacterDied.Setup(m => m.Active).Returns(() => true);
            mockEpisodeCharacterDied.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeCharacterDied.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterDied.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterDied.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeCharacterDied.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeCharacterDied.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeCharacterDied.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeCharacterDied.Setup(m => m.CharacterId).Returns(() => 1);
            mockEpisodeCharacterDied.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeCharacterDied;
        }
    }

    public class EpisodeCharactersDiedMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsEpisodeCharacterDiedProperties()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var model = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeCharacterDiedProperties()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var model = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel();
            // Act
            IEpisodeCharacterDied existingEntity = new EpisodeCharacterDied { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsEpisodeCharacterDiedProperties()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var entity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeCharacterDiedProperties()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var entity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeCharacterDiedProperties()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var entity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsEpisodeCharacterDiedSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var model = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel();
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
            Assert.Equal(model.Object.CharacterId, searchModel.CharacterId);
            Assert.Equal(model.Object.Character?.CustomKey, searchModel.CharacterCustomKey);
            Assert.Equal(model.Object.Character?.ApiDetailUrl, searchModel.CharacterApiDetailUrl);
            Assert.Equal(model.Object.Character?.SiteDetailUrl, searchModel.CharacterSiteDetailUrl);
            Assert.Equal(model.Object.Character?.Name, searchModel.CharacterName);
            Assert.Equal(model.Object.Character?.ShortDescription, searchModel.CharacterShortDescription);
            Assert.Equal(model.Object.Character?.Description, searchModel.CharacterDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var model = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel(1);
            var entity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeCharacterDiedMapper();
            var model = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDiedModel(1);
            var entity = EpisodeCharactersDiedMockingSetup.DoMockingSetupForEpisodeCharacterDied(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
