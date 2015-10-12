// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocationsRepository Class.</summary>
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

    public static class EpisodeLocationsMockingSetup
    {
        public static Mock<IEpisodeLocationModel> DoMockingSetupForEpisodeLocationModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeLocationModel = new Mock<IEpisodeLocationModel>();
            // Mock Functions
            mockEpisodeLocationModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeLocationModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeLocationModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeLocationModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocationModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocationModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeLocationModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeLocationModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeLocationModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeLocationModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeLocationModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeLocationModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeLocationModel.Setup(m => m.LocationId).Returns(() => 1);
            mockEpisodeLocationModel.Setup(m => m.Location).Returns(() => new LocationModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeLocationModel;
        }

        public static Mock<IEpisodeLocation> DoMockingSetupForEpisodeLocation(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeLocation = new Mock<IEpisodeLocation>();
            // Mock Functions
            mockEpisodeLocation.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeLocation.Setup(m => m.Active).Returns(() => true);
            mockEpisodeLocation.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeLocation.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocation.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeLocation.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeLocation.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeLocation.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeLocation.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeLocation.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeLocation.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeLocation.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeLocation.Setup(m => m.LocationId).Returns(() => 1);
            mockEpisodeLocation.Setup(m => m.Location).Returns(() => new Location());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeLocation;
        }
    }

    public class EpisodeLocationMappingExtensionsTests
    {
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeLocationModel>()));
            var mockModel = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel(1);
            EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeLocationModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "EpisodeLocations")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeLocationMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeLocationModel>(), ref It.IsAny<IEpisodeLocation>()));
        //    var mockModel = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel(1);
        //    var mockEntity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(1);
        //    EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeLocationModel>(), ref It.IsAny<IEpisodeLocation>()), Times.Once);
        //}

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeLocation>()));
            var mockEntity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(1);
            EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeLocation>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeLocation>()));
            var mockEntity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(1);
            EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeLocation>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeLocation>()));
            var mockEntity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(1);
            EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeLocation>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeLocationModel>()));
            var mockModel = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel(1);
            EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeLocationModel>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeLocationMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodeLocationModel>(), It.IsAny<IEpisodeLocation>()));
            EpisodeLocationMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel(1);
            var mockEntity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodeLocationModel>(), It.IsAny<IEpisodeLocation>()), Times.Once);
        }
    }

    public class EpisodeLocationsMappingTests
    {
        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToEntity_AssignsEpisodeLocationProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var model = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.LocationId, entity.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeLocationProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var model = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel();
            // Act
            IEpisodeLocation existingEntity = new EpisodeLocation { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.LocationId, existingEntity.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToModel_AssignsEpisodeLocationProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var entity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeLocationProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var entity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeLocationProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var entity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.LocationId, model.LocationId);
            // Return Entity
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_MapToSearchModel_AssignsEpisodeLocationSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var model = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel();
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
            Assert.Equal(model.Object.LocationId, searchModel.LocationId);
            Assert.Equal(model.Object.Location?.CustomKey, searchModel.LocationCustomKey);
            Assert.Equal(model.Object.Location?.ApiDetailUrl, searchModel.LocationApiDetailUrl);
            Assert.Equal(model.Object.Location?.SiteDetailUrl, searchModel.LocationSiteDetailUrl);
            Assert.Equal(model.Object.Location?.Name, searchModel.LocationName);
            Assert.Equal(model.Object.Location?.ShortDescription, searchModel.LocationShortDescription);
            Assert.Equal(model.Object.Location?.Description, searchModel.LocationDescription);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var model = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel(1);
            var entity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "EpisodeLocations")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeLocationMapper();
            var model = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocationModel(1);
            var entity = EpisodeLocationsMockingSetup.DoMockingSetupForEpisodeLocation(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
