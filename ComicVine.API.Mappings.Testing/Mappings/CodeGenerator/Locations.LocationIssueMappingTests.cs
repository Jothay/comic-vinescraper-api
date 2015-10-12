// <auto-generated>
// <copyright file="Locations.ILocationIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Locations
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class LocationIssuesMockingSetup
    {
        public static Mock<ILocationIssueModel> DoMockingSetupForLocationIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationIssueModel = new Mock<ILocationIssueModel>();
            // Mock Functions
            mockLocationIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationIssueModel.Setup(m => m.Active).Returns(() => true);
            mockLocationIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockLocationIssueModel.Setup(m => m.Name).Returns(() => name);
            //mockLocationIssueModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockLocationIssueModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockLocationIssueModel.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationIssueModel.Setup(m => m.Location).Returns(() => new LocationModel());
            mockLocationIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockLocationIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockLocationIssueModel;
        }

        public static Mock<ILocationIssue> DoMockingSetupForLocationIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationIssue = new Mock<ILocationIssue>();
            // Mock Functions
            mockLocationIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationIssue.Setup(m => m.Active).Returns(() => true);
            mockLocationIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockLocationIssue.Setup(m => m.Name).Returns(() => name);
            //mockLocationIssue.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockLocationIssue.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockLocationIssue.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationIssue.Setup(m => m.Location).Returns(() => new Location());
            mockLocationIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockLocationIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockLocationIssue;
        }
    }

    public class LocationIssueMappingExtensionsTests
    {
        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<LocationIssueMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ILocationIssueModel>()));
            var mockModel = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel(1);
            LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ILocationIssueModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "LocationIssues")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<LocationIssueMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ILocationIssueModel>(), ref It.IsAny<ILocationIssue>()));
        //    var mockModel = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel(1);
        //    var mockEntity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(1);
        //    LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ILocationIssueModel>(), ref It.IsAny<ILocationIssue>()), Times.Once);
        //}

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationIssueMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ILocationIssue>()));
            var mockEntity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(1);
            LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ILocationIssue>()), Times.Once);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationIssueMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ILocationIssue>()));
            var mockEntity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(1);
            LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ILocationIssue>()), Times.Once);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationIssueMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ILocationIssue>()));
            var mockEntity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(1);
            LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ILocationIssue>()), Times.Once);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationIssueMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ILocationIssueModel>()));
            var mockModel = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel(1);
            LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ILocationIssueModel>()), Times.Once);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<LocationIssueMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<ILocationIssueModel>(), It.IsAny<ILocationIssue>()));
            LocationIssueMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel(1);
            var mockEntity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<ILocationIssueModel>(), It.IsAny<ILocationIssue>()), Times.Once);
        }
    }

    public class LocationIssuesMappingTests
    {
        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToEntity_AssignsLocationIssueProperties()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var model = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.LocationId, entity.LocationId);
            Assert.Equal(model.Object.IssueId, entity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsLocationIssueProperties()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var model = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel();
            // Act
            ILocationIssue existingEntity = new LocationIssue { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.LocationId, existingEntity.LocationId);
            Assert.Equal(model.Object.IssueId, existingEntity.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToModel_AssignsLocationIssueProperties()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var entity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToModelLite_AssignsLiteOnlyLocationIssueProperties()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var entity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToModelListing_AssignsListingOnlyLocationIssueProperties()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var entity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.IssueId, model.IssueId);
            // Return Entity
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_MapToSearchModel_AssignsLocationIssueSearchProperties()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var model = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.LocationId, searchModel.LocationId);
            Assert.Equal(model.Object.Location?.CustomKey, searchModel.LocationCustomKey);
            Assert.Equal(model.Object.Location?.ApiDetailUrl, searchModel.LocationApiDetailUrl);
            Assert.Equal(model.Object.Location?.SiteDetailUrl, searchModel.LocationSiteDetailUrl);
            Assert.Equal(model.Object.Location?.Name, searchModel.LocationName);
            Assert.Equal(model.Object.Location?.ShortDescription, searchModel.LocationShortDescription);
            Assert.Equal(model.Object.Location?.Description, searchModel.LocationDescription);
            Assert.Equal(model.Object.IssueId, searchModel.IssueId);
            Assert.Equal(model.Object.Issue?.CustomKey, searchModel.IssueCustomKey);
            Assert.Equal(model.Object.Issue?.ApiDetailUrl, searchModel.IssueApiDetailUrl);
            Assert.Equal(model.Object.Issue?.SiteDetailUrl, searchModel.IssueSiteDetailUrl);
            Assert.Equal(model.Object.Issue?.Name, searchModel.IssueName);
            Assert.Equal(model.Object.Issue?.ShortDescription, searchModel.IssueShortDescription);
            Assert.Equal(model.Object.Issue?.Description, searchModel.IssueDescription);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var model = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel(1);
            var entity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "LocationIssues")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new LocationIssueMapper();
            var model = LocationIssuesMockingSetup.DoMockingSetupForLocationIssueModel(1);
            var entity = LocationIssuesMockingSetup.DoMockingSetupForLocationIssue(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
