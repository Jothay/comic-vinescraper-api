// <auto-generated>
// <copyright file="Characters.ICharacterIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterIssuesRepository Class.</summary>
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

    public static class CharacterIssuesMockingSetup
    {
        public static Mock<ICharacterIssueModel> DoMockingSetupForCharacterIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterIssueModel = new Mock<ICharacterIssueModel>();
            // Mock Functions
            mockCharacterIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterIssueModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterIssueModel.Setup(m => m.Name).Returns(() => name);
            //mockCharacterIssueModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterIssueModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterIssueModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterIssueModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockCharacterIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterIssueModel;
        }

        public static Mock<ICharacterIssue> DoMockingSetupForCharacterIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterIssue = new Mock<ICharacterIssue>();
            // Mock Functions
            mockCharacterIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterIssue.Setup(m => m.Active).Returns(() => true);
            mockCharacterIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockCharacterIssue.Setup(m => m.Name).Returns(() => name);
            //mockCharacterIssue.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockCharacterIssue.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterIssue.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterIssue.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockCharacterIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterIssue;
        }
    }

    public class CharacterIssueMappingExtensionsTests
    {
        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<CharacterIssueMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterIssueModel>(), It.IsAny<int>()));
            var mockModel = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel(1);
            CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterIssueModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "CharacterIssues")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<CharacterIssueMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ICharacterIssueModel>(), ref It.IsAny<ICharacterIssue>(), It.IsAny<int>()));
        //    var mockModel = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel(1);
        //    var mockEntity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(1);
        //    CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ICharacterIssueModel>(), ref It.IsAny<ICharacterIssue>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterIssueMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ICharacterIssue>(), It.IsAny<int>()));
            var mockEntity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(1);
            CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ICharacterIssue>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterIssueMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ICharacterIssue>(), It.IsAny<int>()));
            var mockEntity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(1);
            CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ICharacterIssue>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterIssueMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ICharacterIssue>(), It.IsAny<int>()));
            var mockEntity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(1);
            CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ICharacterIssue>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<CharacterIssueMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ICharacterIssueModel>()));
            var mockModel = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel(1);
            CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ICharacterIssueModel>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<CharacterIssueMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ICharacterIssueModel>(), It.IsAny<ICharacterIssue>()));
            CharacterIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel(1);
            var mockEntity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ICharacterIssueModel>(), It.IsAny<ICharacterIssue>()), Times.Once);
        }
    }

    public class CharacterIssuesMappingTests
    {
        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToEntity_AssignsCharacterIssueProperties()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var model = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, entity.CharacterId);
            Assert.Equal(model.Object.IssueId, entity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsCharacterIssueProperties()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var model = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel();
            // Act
            ICharacterIssue existingEntity = new CharacterIssue { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.CharacterId, existingEntity.CharacterId);
            Assert.Equal(model.Object.IssueId, existingEntity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToModel_AssignsCharacterIssueProperties()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var entity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToModelLite_AssignsLiteOnlyCharacterIssueProperties()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var entity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToModelListing_AssignsListingOnlyCharacterIssueProperties()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var entity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.CharacterId, model.CharacterId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Return Entity
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_MapToSearchModel_AssignsCharacterIssueSearchProperties()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var model = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel();
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
            Assert.Equal(model.Object.IssueId, searchModel.IssueId);
            Assert.Equal(model.Object.Issue?.CustomKey, searchModel.IssueCustomKey);
            Assert.Equal(model.Object.Issue?.ApiDetailUrl, searchModel.IssueApiDetailUrl);
            Assert.Equal(model.Object.Issue?.SiteDetailUrl, searchModel.IssueSiteDetailUrl);
            Assert.Equal(model.Object.Issue?.Name, searchModel.IssueName);
            Assert.Equal(model.Object.Issue?.ShortDescription, searchModel.IssueShortDescription);
            Assert.Equal(model.Object.Issue?.Description, searchModel.IssueDescription);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var model = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel(1);
            var entity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "CharacterIssues")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new CharacterIssueMapper();
            var model = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssueModel(1);
            var entity = CharacterIssuesMockingSetup.DoMockingSetupForCharacterIssue(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
