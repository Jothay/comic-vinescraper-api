// <auto-generated>
// <copyright file="Episodes.IEpisodeObjectRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeObjectsRepository Class.</summary>
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

    public static class EpisodeObjectsMockingSetup
    {
        public static Mock<IEpisodeObjectModel> DoMockingSetupForEpisodeObjectModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeObjectModel = new Mock<IEpisodeObjectModel>();
            // Mock Functions
            mockEpisodeObjectModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeObjectModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeObjectModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeObjectModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeObjectModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeObjectModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeObjectModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeObjectModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeObjectModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeObjectModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeObjectModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeObjectModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeObjectModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockEpisodeObjectModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeObjectModel;
        }

        public static Mock<IEpisodeObject> DoMockingSetupForEpisodeObject(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeObject = new Mock<IEpisodeObject>();
            // Mock Functions
            mockEpisodeObject.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeObject.Setup(m => m.Active).Returns(() => true);
            mockEpisodeObject.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeObject.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeObject.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeObject.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeObject.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodeObject.Setup(m => m.Name).Returns(() => name);
            //mockEpisodeObject.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodeObject.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodeObject.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeObject.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeObject.Setup(m => m.ObjectId).Returns(() => 1);
            mockEpisodeObject.Setup(m => m.Object).Returns(() => new Object());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeObject;
        }
    }

    public class EpisodeObjectMappingExtensionsTests
    {
        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeObjectMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeObjectModel>(), It.IsAny<int>()));
            var mockModel = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel(1);
            EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeObjectModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "EpisodeObjects")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodeObjectMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodeObjectModel>(), ref It.IsAny<IEpisodeObject>(), It.IsAny<int>()));
        //    var mockModel = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel(1);
        //    var mockEntity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(1);
        //    EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodeObjectModel>(), ref It.IsAny<IEpisodeObject>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeObjectMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodeObject>(), It.IsAny<int>()));
            var mockEntity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(1);
            EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodeObject>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeObjectMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodeObject>(), It.IsAny<int>()));
            var mockEntity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(1);
            EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodeObject>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeObjectMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodeObject>(), It.IsAny<int>()));
            var mockEntity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(1);
            EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodeObject>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeObjectMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodeObjectModel>()));
            var mockModel = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel(1);
            EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodeObjectModel>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodeObjectMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodeObjectModel>(), It.IsAny<IEpisodeObject>()));
            EpisodeObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel(1);
            var mockEntity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodeObjectModel>(), It.IsAny<IEpisodeObject>()), Times.Once);
        }
    }

    public class EpisodeObjectsMappingTests
    {
        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToEntity_AssignsEpisodeObjectProperties()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var model = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.ObjectId, entity.ObjectId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodeObjectProperties()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var model = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel();
            // Act
            IEpisodeObject existingEntity = new EpisodeObject { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.ObjectId, existingEntity.ObjectId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToModel_AssignsEpisodeObjectProperties()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var entity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodeObjectProperties()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var entity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodeObjectProperties()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var entity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            // Return Entity
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_MapToSearchModel_AssignsEpisodeObjectSearchProperties()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var model = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel();
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
            Assert.Equal(model.Object.ObjectId, searchModel.ObjectId);
            Assert.Equal(model.Object.Object?.CustomKey, searchModel.ObjectCustomKey);
            Assert.Equal(model.Object.Object?.ApiDetailUrl, searchModel.ObjectApiDetailUrl);
            Assert.Equal(model.Object.Object?.SiteDetailUrl, searchModel.ObjectSiteDetailUrl);
            Assert.Equal(model.Object.Object?.Name, searchModel.ObjectName);
            Assert.Equal(model.Object.Object?.ShortDescription, searchModel.ObjectShortDescription);
            Assert.Equal(model.Object.Object?.Description, searchModel.ObjectDescription);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var model = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel(1);
            var entity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "EpisodeObjects")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodeObjectMapper();
            var model = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObjectModel(1);
            var entity = EpisodeObjectsMockingSetup.DoMockingSetupForEpisodeObject(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
