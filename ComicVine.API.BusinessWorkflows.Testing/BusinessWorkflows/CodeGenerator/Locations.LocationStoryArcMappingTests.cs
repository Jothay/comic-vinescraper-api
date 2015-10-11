// <auto-generated>
// <copyright file="Locations.ILocationStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationStoryArcsRepository Class.</summary>
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

    public static class LocationStoryArcsMockingSetup
    {
        public static Mock<ILocationStoryArcModel> DoMockingSetupForLocationStoryArcModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationStoryArcModel = new Mock<ILocationStoryArcModel>();
            // Mock Functions
            mockLocationStoryArcModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationStoryArcModel.Setup(m => m.Active).Returns(() => true);
            mockLocationStoryArcModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationStoryArcModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationStoryArcModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationStoryArcModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationStoryArcModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockLocationStoryArcModel.Setup(m => m.Name).Returns(() => name);
            //mockLocationStoryArcModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockLocationStoryArcModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockLocationStoryArcModel.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationStoryArcModel.Setup(m => m.Location).Returns(() => new LocationModel());
            mockLocationStoryArcModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockLocationStoryArcModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            // Associated Objects
            // <None>
            // Return
            return mockLocationStoryArcModel;
        }

        public static Mock<ILocationStoryArc> DoMockingSetupForLocationStoryArc(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationStoryArc = new Mock<ILocationStoryArc>();
            // Mock Functions
            mockLocationStoryArc.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationStoryArc.Setup(m => m.Active).Returns(() => true);
            mockLocationStoryArc.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationStoryArc.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationStoryArc.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationStoryArc.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationStoryArc.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockLocationStoryArc.Setup(m => m.Name).Returns(() => name);
            //mockLocationStoryArc.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockLocationStoryArc.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockLocationStoryArc.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationStoryArc.Setup(m => m.Location).Returns(() => new Location());
            mockLocationStoryArc.Setup(m => m.StoryArcId).Returns(() => 1);
            mockLocationStoryArc.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockLocationStoryArc;
        }
    }

    public class LocationStoryArcMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<LocationStoryArcMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ILocationStoryArcModel>()));
            var mockModel = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel(1);
            LocationStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ILocationStoryArcModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<LocationStoryArcMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ILocationStoryArcModel>(), ref It.IsAny<ILocationStoryArc>()));
        //    var mockModel = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel(1);
        //    var mockEntity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc(1);
        //    LocationStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ILocationStoryArcModel>(), ref It.IsAny<ILocationStoryArc>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ILocationStoryArc>()));
            var mockEntity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc(1);
            LocationStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ILocationStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ILocationStoryArc>()));
            var mockEntity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc(1);
            LocationStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ILocationStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ILocationStoryArc>()));
            var mockEntity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc(1);
            LocationStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ILocationStoryArc>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<LocationStoryArcMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ILocationStoryArcModel>()));
            var mockModel = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel(1);
            LocationStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ILocationStoryArcModel>()), Times.Once);
        }

        public static Mock<ILocationStoryArc> DoMockingSetupForLocationStoryArc(int idReturnValue = 0)
        {
            var mockLocationStoryArc = new Mock<ILocationStoryArc>();
            // Mock Functions
            mockLocationStoryArc.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationStoryArc.Setup(m => m.Active).Returns(() => true);
            mockLocationStoryArc.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationStoryArc.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationStoryArc.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationStoryArc.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationStoryArc.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockLocationStoryArc.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationStoryArc.Setup(m => m.Location).Returns(() => new Location());
            mockLocationStoryArc.Setup(m => m.StoryArcId).Returns(() => 1);
            mockLocationStoryArc.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockLocationStoryArc;
        }
    }

    public class LocationStoryArcsMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsLocationStoryArcProperties()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var model = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.LocationId, entity.LocationId);
            Assert.Equal(model.Object.StoryArcId, entity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsLocationStoryArcProperties()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var model = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel();
            // Act
            ILocationStoryArc existingEntity = new LocationStoryArc { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.LocationId, existingEntity.LocationId);
            Assert.Equal(model.Object.StoryArcId, existingEntity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsLocationStoryArcProperties()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var entity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyLocationStoryArcProperties()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var entity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyLocationStoryArcProperties()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var entity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsLocationStoryArcSearchProperties()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var model = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel();
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
            Assert.Equal(model.Object.StoryArcId, searchModel.StoryArcId);
            Assert.Equal(model.Object.StoryArc?.CustomKey, searchModel.StoryArcCustomKey);
            Assert.Equal(model.Object.StoryArc?.ApiDetailUrl, searchModel.StoryArcApiDetailUrl);
            Assert.Equal(model.Object.StoryArc?.SiteDetailUrl, searchModel.StoryArcSiteDetailUrl);
            Assert.Equal(model.Object.StoryArc?.Name, searchModel.StoryArcName);
            Assert.Equal(model.Object.StoryArc?.ShortDescription, searchModel.StoryArcShortDescription);
            Assert.Equal(model.Object.StoryArc?.Description, searchModel.StoryArcDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var model = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel(1);
            var entity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new LocationStoryArcMapper();
            var model = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArcModel(1);
            var entity = LocationStoryArcsMockingSetup.DoMockingSetupForLocationStoryArc(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
