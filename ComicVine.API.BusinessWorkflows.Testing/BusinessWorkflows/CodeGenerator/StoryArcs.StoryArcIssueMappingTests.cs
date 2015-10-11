// <auto-generated>
// <copyright file="StoryArcs.IStoryArcIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.StoryArcs
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class StoryArcIssuesMockingSetup
    {
        public static Mock<IStoryArcIssueModel> DoMockingSetupForStoryArcIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStoryArcIssueModel = new Mock<IStoryArcIssueModel>();
            // Mock Functions
            mockStoryArcIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcIssueModel.Setup(m => m.Active).Returns(() => true);
            mockStoryArcIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockStoryArcIssueModel.Setup(m => m.Name).Returns(() => name);
            //mockStoryArcIssueModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockStoryArcIssueModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockStoryArcIssueModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcIssueModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            mockStoryArcIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockStoryArcIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcIssueModel;
        }

        public static Mock<IStoryArcIssue> DoMockingSetupForStoryArcIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStoryArcIssue = new Mock<IStoryArcIssue>();
            // Mock Functions
            mockStoryArcIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcIssue.Setup(m => m.Active).Returns(() => true);
            mockStoryArcIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockStoryArcIssue.Setup(m => m.Name).Returns(() => name);
            //mockStoryArcIssue.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockStoryArcIssue.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockStoryArcIssue.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcIssue.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            mockStoryArcIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockStoryArcIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcIssue;
        }
    }

    public class StoryArcIssueMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcIssueMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IStoryArcIssueModel>()));
            var mockModel = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1);
            StoryArcIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IStoryArcIssueModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<StoryArcIssueMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IStoryArcIssueModel>(), ref It.IsAny<IStoryArcIssue>()));
        //    var mockModel = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1);
        //    var mockEntity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
        //    StoryArcIssueMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IStoryArcIssueModel>(), ref It.IsAny<IStoryArcIssue>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcIssueMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IStoryArcIssue>()));
            var mockEntity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            StoryArcIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IStoryArcIssue>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcIssueMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IStoryArcIssue>()));
            var mockEntity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            StoryArcIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IStoryArcIssue>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcIssueMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IStoryArcIssue>()));
            var mockEntity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            StoryArcIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IStoryArcIssue>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcIssueMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IStoryArcIssueModel>()));
            var mockModel = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1);
            StoryArcIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IStoryArcIssueModel>()), Times.Once);
        }

        public static Mock<IStoryArcIssue> DoMockingSetupForStoryArcIssue(int idReturnValue = 0)
        {
            var mockStoryArcIssue = new Mock<IStoryArcIssue>();
            // Mock Functions
            mockStoryArcIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcIssue.Setup(m => m.Active).Returns(() => true);
            mockStoryArcIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockStoryArcIssue.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcIssue.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            mockStoryArcIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockStoryArcIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcIssue;
        }
    }

    public class StoryArcIssuesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsStoryArcIssueProperties()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.StoryArcId, entity.StoryArcId);
            Assert.Equal(model.Object.IssueId, entity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsStoryArcIssueProperties()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel();
            // Act
            IStoryArcIssue existingEntity = new StoryArcIssue { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.StoryArcId, existingEntity.StoryArcId);
            Assert.Equal(model.Object.IssueId, existingEntity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsStoryArcIssueProperties()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var entity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyStoryArcIssueProperties()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var entity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyStoryArcIssueProperties()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var entity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsStoryArcIssueSearchProperties()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.StoryArcId, searchModel.StoryArcId);
            Assert.Equal(model.Object.StoryArc?.CustomKey, searchModel.StoryArcCustomKey);
            Assert.Equal(model.Object.StoryArc?.ApiDetailUrl, searchModel.StoryArcApiDetailUrl);
            Assert.Equal(model.Object.StoryArc?.SiteDetailUrl, searchModel.StoryArcSiteDetailUrl);
            Assert.Equal(model.Object.StoryArc?.Name, searchModel.StoryArcName);
            Assert.Equal(model.Object.StoryArc?.ShortDescription, searchModel.StoryArcShortDescription);
            Assert.Equal(model.Object.StoryArc?.Description, searchModel.StoryArcDescription);
            Assert.Equal(model.Object.IssueId, searchModel.IssueId);
            Assert.Equal(model.Object.Issue?.CustomKey, searchModel.IssueCustomKey);
            Assert.Equal(model.Object.Issue?.ApiDetailUrl, searchModel.IssueApiDetailUrl);
            Assert.Equal(model.Object.Issue?.SiteDetailUrl, searchModel.IssueSiteDetailUrl);
            Assert.Equal(model.Object.Issue?.Name, searchModel.IssueName);
            Assert.Equal(model.Object.Issue?.ShortDescription, searchModel.IssueShortDescription);
            Assert.Equal(model.Object.Issue?.Description, searchModel.IssueDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1);
            var entity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new StoryArcIssueMapper();
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1);
            var entity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
