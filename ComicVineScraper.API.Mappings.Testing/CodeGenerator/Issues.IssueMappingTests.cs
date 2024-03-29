// <auto-generated>
// <copyright file="Issues.IIssueMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssuesMappingTests class.</summary>
// <remarks>This file was auto-generated using MappingTestingFileMaster.tt in
// ComicVineScraper.API.Mappings.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Mappings.Issues
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class IssuesMockingSetup
    {
        public static Mock<IIssueModel> DoMockingSetupForIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockIssueModel = new Mock<IIssueModel>();
            // Mock Functions
            mockIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockIssueModel.Setup(m => m.Active).Returns(() => true);
            mockIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockIssueModel.Setup(m => m.Name).Returns(() => name);
            //mockIssueModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockIssueModel.Setup(m => m.Description).Returns(() => "long");
            mockIssueModel.Setup(m => m.HasStaffReview).Returns(() => true);
            mockIssueModel.Setup(m => m.CoverDate).Returns(() => new System.DateTime());
            mockIssueModel.Setup(m => m.StoreDate).Returns(() => new System.DateTime());
            mockIssueModel.Setup(m => m.IssueNumber).Returns(() => "IssueNumber");
            // Related Objects
            mockIssueModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockIssueModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            mockIssueModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockIssueModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            mockIssueModel.Setup(m => m.IssueAliases).Returns(() => new List<IIssueAliasModel>());
            mockIssueModel.Setup(m => m.IssueStoryArcs).Returns(() => new List<IStoryArcIssueModel>());
            mockIssueModel.Setup(m => m.IssueWriters).Returns(() => new List<IIssueWriterModel>());
            // Return
            return mockIssueModel;
        }

        public static Mock<IIssue> DoMockingSetupForIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockIssue = new Mock<IIssue>();
            // Mock Functions
            mockIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockIssue.Setup(m => m.Active).Returns(() => true);
            mockIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockIssue.Setup(m => m.Name).Returns(() => name);
            //mockIssue.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockIssue.Setup(m => m.Description).Returns(() => "long");
            mockIssue.Setup(m => m.HasStaffReview).Returns(() => true);
            mockIssue.Setup(m => m.CoverDate).Returns(() => new System.DateTime());
            mockIssue.Setup(m => m.StoreDate).Returns(() => new System.DateTime());
            mockIssue.Setup(m => m.IssueNumber).Returns(() => "IssueNumber");
            // Related Objects
            mockIssue.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockIssue.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockIssue.Setup(m => m.VolumeId).Returns(() => 1);
            mockIssue.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            mockIssue.Setup(m => m.IssueAliases).Returns(() => new List<IIssueAlias>());
            mockIssue.Setup(m => m.IssueStoryArcs).Returns(() => new List<IStoryArcIssue>());
            mockIssue.Setup(m => m.IssueWriters).Returns(() => new List<IIssueWriter>());
            // Return
            return mockIssue;
        }
    }

    public class IssueMappingExtensionsTests
    {
        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<IssueMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IIssueModel>(), It.IsAny<int>()));
            var mockModel = IssuesMockingSetup.DoMockingSetupForIssueModel(1);
            IssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IIssueModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "Issues")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<IssueMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IIssueModel>(), ref It.IsAny<IIssue>(), It.IsAny<int>()));
        //    var mockModel = IssuesMockingSetup.DoMockingSetupForIssueModel(1);
        //    var mockEntity = IssuesMockingSetup.DoMockingSetupForIssue(1);
        //    IssueMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IIssueModel>(), ref It.IsAny<IIssue>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<IssueMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IIssue>(), It.IsAny<int>()));
            var mockEntity = IssuesMockingSetup.DoMockingSetupForIssue(1);
            IssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IIssue>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<IssueMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IIssue>(), It.IsAny<int>()));
            var mockEntity = IssuesMockingSetup.DoMockingSetupForIssue(1);
            IssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IIssue>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<IssueMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IIssue>(), It.IsAny<int>()));
            var mockEntity = IssuesMockingSetup.DoMockingSetupForIssue(1);
            IssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IIssue>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<IssueMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IIssueModel>()));
            var mockModel = IssuesMockingSetup.DoMockingSetupForIssueModel(1);
            IssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IIssueModel>()), Times.Once);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<IssueMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IIssueModel>(), It.IsAny<IIssue>()));
            IssueMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = IssuesMockingSetup.DoMockingSetupForIssueModel(1);
            var mockEntity = IssuesMockingSetup.DoMockingSetupForIssue(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IIssueModel>(), It.IsAny<IIssue>()), Times.Once);
        }
    }

    public class IssuesMappingTests
    {
        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToEntity_AssignsIssueProperties()
        {
            // Arrange
            var mapper = new IssueMapper();
            var model = IssuesMockingSetup.DoMockingSetupForIssueModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.HasStaffReview, entity.HasStaffReview);
            Assert.Equal(model.Object.CoverDate, entity.CoverDate);
            Assert.Equal(model.Object.StoreDate, entity.StoreDate);
            Assert.Equal(model.Object.IssueNumber, entity.IssueNumber);
            // Related Objects
            Assert.Equal(model.Object.PrimaryImageFileId, entity.PrimaryImageFileId);
            Assert.Equal(model.Object.VolumeId, entity.VolumeId);
            // Associated Objects
            //Assert.Equal(model.Object.IssueAliases?.Count, entity.IssueAliases?.Count);
            model.VerifyGet(x => x.IssueAliases, Times.Once);
            //Assert.Equal(model.Object.IssueStoryArcs?.Count, entity.IssueStoryArcs?.Count);
            model.VerifyGet(x => x.IssueStoryArcs, Times.Once);
            //Assert.Equal(model.Object.IssueWriters?.Count, entity.IssueWriters?.Count);
            model.VerifyGet(x => x.IssueWriters, Times.Once);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsIssueProperties()
        {
            // Arrange
            var mapper = new IssueMapper();
            var model = IssuesMockingSetup.DoMockingSetupForIssueModel();
            // Act
            IIssue existingEntity = new Issue { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.HasStaffReview, existingEntity.HasStaffReview);
            Assert.Equal(model.Object.CoverDate, existingEntity.CoverDate);
            Assert.Equal(model.Object.StoreDate, existingEntity.StoreDate);
            Assert.Equal(model.Object.IssueNumber, existingEntity.IssueNumber);
            // Related Objects
            Assert.Equal(model.Object.PrimaryImageFileId, existingEntity.PrimaryImageFileId);
            Assert.Equal(model.Object.VolumeId, existingEntity.VolumeId);
            // Associated Objects
            model.VerifyGet(x => x.IssueAliases, Times.Once);
            //Assert.Equal(model.Object.IssueAliases?.Count, existingEntity.IssueAliases?.Count);
            model.VerifyGet(x => x.IssueStoryArcs, Times.Once);
            //Assert.Equal(model.Object.IssueStoryArcs?.Count, existingEntity.IssueStoryArcs?.Count);
            model.VerifyGet(x => x.IssueWriters, Times.Once);
            //Assert.Equal(model.Object.IssueWriters?.Count, existingEntity.IssueWriters?.Count);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToModel_AssignsIssueProperties()
        {
            // Arrange
            var mapper = new IssueMapper();
            var entity = IssuesMockingSetup.DoMockingSetupForIssue();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.HasStaffReview, model.HasStaffReview);
            Assert.Equal(entity.Object.CoverDate, model.CoverDate);
            Assert.Equal(entity.Object.StoreDate, model.StoreDate);
            Assert.Equal(entity.Object.IssueNumber, model.IssueNumber);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Associated Objects
            Assert.Equal(entity.Object.IssueAliases?.Count, model.IssueAliases?.Count);
            Assert.Equal(entity.Object.IssueStoryArcs?.Count, model.IssueStoryArcs?.Count);
            Assert.Equal(entity.Object.IssueWriters?.Count, model.IssueWriters?.Count);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToModelLite_AssignsLiteOnlyIssueProperties()
        {
            // Arrange
            var mapper = new IssueMapper();
            var entity = IssuesMockingSetup.DoMockingSetupForIssue();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.HasStaffReview, model.HasStaffReview);
            Assert.Equal(entity.Object.CoverDate, model.CoverDate);
            Assert.Equal(entity.Object.StoreDate, model.StoreDate);
            Assert.Equal(entity.Object.IssueNumber, model.IssueNumber);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToModelListing_AssignsListingOnlyIssueProperties()
        {
            // Arrange
            var mapper = new IssueMapper();
            var entity = IssuesMockingSetup.DoMockingSetupForIssue();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.HasStaffReview, model.HasStaffReview);
            Assert.Equal(entity.Object.CoverDate, model.CoverDate);
            Assert.Equal(entity.Object.StoreDate, model.StoreDate);
            Assert.Equal(entity.Object.IssueNumber, model.IssueNumber);
            // Related Objects
            Assert.Equal(entity.Object.PrimaryImageFileId, model.PrimaryImageFileId);
            Assert.Equal(entity.Object.VolumeId, model.VolumeId);
            // Return Entity
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_MapToSearchModel_AssignsIssueSearchProperties()
        {
            // Arrange
            var mapper = new IssueMapper();
            var model = IssuesMockingSetup.DoMockingSetupForIssueModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.PrimaryImageFileId, searchModel.PrimaryImageFileId);
            Assert.Equal(model.Object.PrimaryImageFile?.CustomKey, searchModel.PrimaryImageFileCustomKey);
            Assert.Equal(model.Object.PrimaryImageFile?.ApiDetailUrl, searchModel.PrimaryImageFileApiDetailUrl);
            Assert.Equal(model.Object.PrimaryImageFile?.SiteDetailUrl, searchModel.PrimaryImageFileSiteDetailUrl);
            Assert.Equal(model.Object.PrimaryImageFile?.Name, searchModel.PrimaryImageFileName);
            Assert.Equal(model.Object.PrimaryImageFile?.ShortDescription, searchModel.PrimaryImageFileShortDescription);
            Assert.Equal(model.Object.PrimaryImageFile?.Description, searchModel.PrimaryImageFileDescription);
            Assert.Equal(model.Object.VolumeId, searchModel.VolumeId);
            Assert.Equal(model.Object.Volume?.CustomKey, searchModel.VolumeCustomKey);
            Assert.Equal(model.Object.Volume?.ApiDetailUrl, searchModel.VolumeApiDetailUrl);
            Assert.Equal(model.Object.Volume?.SiteDetailUrl, searchModel.VolumeSiteDetailUrl);
            Assert.Equal(model.Object.Volume?.Name, searchModel.VolumeName);
            Assert.Equal(model.Object.Volume?.ShortDescription, searchModel.VolumeShortDescription);
            Assert.Equal(model.Object.Volume?.Description, searchModel.VolumeDescription);
            Assert.Equal(model.Object.HasStaffReview, searchModel.HasStaffReview);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new IssueMapper();
            var model = IssuesMockingSetup.DoMockingSetupForIssueModel(1);
            var entity = IssuesMockingSetup.DoMockingSetupForIssue(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "Issues")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new IssueMapper();
            var model = IssuesMockingSetup.DoMockingSetupForIssueModel(1);
            var entity = IssuesMockingSetup.DoMockingSetupForIssue(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
