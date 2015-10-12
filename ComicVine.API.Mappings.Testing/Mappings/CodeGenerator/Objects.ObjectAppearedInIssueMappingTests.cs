// <auto-generated>
// <copyright file="Objects.IObjectAppearedInIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectAppearedInIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Objects
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ObjectAppearedInIssuesMockingSetup
    {
        public static Mock<IObjectAppearedInIssueModel> DoMockingSetupForObjectAppearedInIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectAppearedInIssueModel = new Mock<IObjectAppearedInIssueModel>();
            // Mock Functions
            mockObjectAppearedInIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectAppearedInIssueModel.Setup(m => m.Active).Returns(() => true);
            mockObjectAppearedInIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectAppearedInIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAppearedInIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAppearedInIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectAppearedInIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockObjectAppearedInIssueModel.Setup(m => m.Name).Returns(() => name);
            //mockObjectAppearedInIssueModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockObjectAppearedInIssueModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectAppearedInIssueModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectAppearedInIssueModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            mockObjectAppearedInIssueModel.Setup(m => m.AppearedInIssueId).Returns(() => 1);
            mockObjectAppearedInIssueModel.Setup(m => m.AppearedInIssue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockObjectAppearedInIssueModel;
        }

        public static Mock<IObjectAppearedInIssue> DoMockingSetupForObjectAppearedInIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectAppearedInIssue = new Mock<IObjectAppearedInIssue>();
            // Mock Functions
            mockObjectAppearedInIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectAppearedInIssue.Setup(m => m.Active).Returns(() => true);
            mockObjectAppearedInIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectAppearedInIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAppearedInIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectAppearedInIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectAppearedInIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockObjectAppearedInIssue.Setup(m => m.Name).Returns(() => name);
            //mockObjectAppearedInIssue.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockObjectAppearedInIssue.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectAppearedInIssue.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectAppearedInIssue.Setup(m => m.Object).Returns(() => new Object());
            mockObjectAppearedInIssue.Setup(m => m.AppearedInIssueId).Returns(() => 1);
            mockObjectAppearedInIssue.Setup(m => m.AppearedInIssue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockObjectAppearedInIssue;
        }
    }

    public class ObjectAppearedInIssueMappingExtensionsTests
    {
        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IObjectAppearedInIssueModel>()));
            var mockModel = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel(1);
            ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IObjectAppearedInIssueModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "ObjectAppearedInIssues")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IObjectAppearedInIssueModel>(), ref It.IsAny<IObjectAppearedInIssue>()));
        //    var mockModel = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel(1);
        //    var mockEntity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(1);
        //    ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IObjectAppearedInIssueModel>(), ref It.IsAny<IObjectAppearedInIssue>()), Times.Once);
        //}

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IObjectAppearedInIssue>()));
            var mockEntity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(1);
            ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IObjectAppearedInIssue>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IObjectAppearedInIssue>()));
            var mockEntity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(1);
            ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IObjectAppearedInIssue>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IObjectAppearedInIssue>()));
            var mockEntity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(1);
            ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IObjectAppearedInIssue>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IObjectAppearedInIssueModel>()));
            var mockModel = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel(1);
            ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IObjectAppearedInIssueModel>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<ObjectAppearedInIssueMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IObjectAppearedInIssueModel>(), It.IsAny<IObjectAppearedInIssue>()));
            ObjectAppearedInIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel(1);
            var mockEntity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IObjectAppearedInIssueModel>(), It.IsAny<IObjectAppearedInIssue>()), Times.Once);
        }
    }

    public class ObjectAppearedInIssuesMappingTests
    {
        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToEntity_AssignsObjectAppearedInIssueProperties()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var model = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ObjectId, entity.ObjectId);
            Assert.Equal(model.Object.AppearedInIssueId, entity.AppearedInIssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsObjectAppearedInIssueProperties()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var model = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel();
            // Act
            IObjectAppearedInIssue existingEntity = new ObjectAppearedInIssue { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ObjectId, existingEntity.ObjectId);
            Assert.Equal(model.Object.AppearedInIssueId, existingEntity.AppearedInIssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToModel_AssignsObjectAppearedInIssueProperties()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var entity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.AppearedInIssueId, model.AppearedInIssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToModelLite_AssignsLiteOnlyObjectAppearedInIssueProperties()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var entity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.AppearedInIssueId, model.AppearedInIssueId);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToModelListing_AssignsListingOnlyObjectAppearedInIssueProperties()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var entity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.AppearedInIssueId, model.AppearedInIssueId);
            // Return Entity
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_MapToSearchModel_AssignsObjectAppearedInIssueSearchProperties()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var model = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.ObjectId, searchModel.ObjectId);
            Assert.Equal(model.Object.Object?.CustomKey, searchModel.ObjectCustomKey);
            Assert.Equal(model.Object.Object?.ApiDetailUrl, searchModel.ObjectApiDetailUrl);
            Assert.Equal(model.Object.Object?.SiteDetailUrl, searchModel.ObjectSiteDetailUrl);
            Assert.Equal(model.Object.Object?.Name, searchModel.ObjectName);
            Assert.Equal(model.Object.Object?.ShortDescription, searchModel.ObjectShortDescription);
            Assert.Equal(model.Object.Object?.Description, searchModel.ObjectDescription);
            Assert.Equal(model.Object.AppearedInIssueId, searchModel.AppearedInIssueId);
            Assert.Equal(model.Object.AppearedInIssue?.CustomKey, searchModel.AppearedInIssueCustomKey);
            Assert.Equal(model.Object.AppearedInIssue?.ApiDetailUrl, searchModel.AppearedInIssueApiDetailUrl);
            Assert.Equal(model.Object.AppearedInIssue?.SiteDetailUrl, searchModel.AppearedInIssueSiteDetailUrl);
            Assert.Equal(model.Object.AppearedInIssue?.Name, searchModel.AppearedInIssueName);
            Assert.Equal(model.Object.AppearedInIssue?.ShortDescription, searchModel.AppearedInIssueShortDescription);
            Assert.Equal(model.Object.AppearedInIssue?.Description, searchModel.AppearedInIssueDescription);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var model = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel(1);
            var entity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "ObjectAppearedInIssues")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ObjectAppearedInIssueMapper();
            var model = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssueModel(1);
            var entity = ObjectAppearedInIssuesMockingSetup.DoMockingSetupForObjectAppearedInIssue(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
