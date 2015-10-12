// <auto-generated>
// <copyright file="Videos.IVideoTypeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VideoTypesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Videos
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class VideoTypesMockingSetup
    {
        public static Mock<IVideoTypeModel> DoMockingSetupForVideoTypeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVideoTypeModel = new Mock<IVideoTypeModel>();
            // Mock Functions
            mockVideoTypeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVideoTypeModel.Setup(m => m.Active).Returns(() => true);
            mockVideoTypeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVideoTypeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoTypeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoTypeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVideoTypeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVideoTypeModel.Setup(m => m.Name).Returns(() => name);
            //mockVideoTypeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVideoTypeModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockVideoTypeModel.Setup(m => m.Videos).Returns(() => new List<IVideoModel>());
            // Return
            return mockVideoTypeModel;
        }

        public static Mock<IVideoType> DoMockingSetupForVideoType(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVideoType = new Mock<IVideoType>();
            // Mock Functions
            mockVideoType.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVideoType.Setup(m => m.Active).Returns(() => true);
            mockVideoType.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVideoType.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoType.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoType.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVideoType.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockVideoType.Setup(m => m.Name).Returns(() => name);
            //mockVideoType.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockVideoType.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockVideoType.Setup(m => m.Videos).Returns(() => new List<IVideo>());
            // Return
            return mockVideoType;
        }
    }

    public class VideoTypeMappingExtensionsTests
    {
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<VideoTypeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVideoTypeModel>()));
            var mockModel = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
            VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVideoTypeModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "VideoTypes")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<VideoTypeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IVideoTypeModel>(), ref It.IsAny<IVideoType>()));
        //    var mockModel = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
        //    var mockEntity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
        //    VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IVideoTypeModel>(), ref It.IsAny<IVideoType>()), Times.Once);
        //}

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VideoTypeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IVideoType>()));
            var mockEntity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IVideoType>()), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VideoTypeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IVideoType>()));
            var mockEntity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IVideoType>()), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VideoTypeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IVideoType>()));
            var mockEntity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IVideoType>()), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<VideoTypeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IVideoTypeModel>()));
            var mockModel = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
            VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IVideoTypeModel>()), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<VideoTypeMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>()));
            VideoTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
            var mockEntity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>()), Times.Once);
        }
    }

    public class VideoTypesMappingTests
    {
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToEntity_AssignsVideoTypeProperties()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.Videos?.Count, entity.Videos?.Count);
            model.VerifyGet(x => x.Videos, Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsVideoTypeProperties()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel();
            // Act
            IVideoType existingEntity = new VideoType { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.Videos, Times.Once);
            //Assert.Equal(model.Object.Videos?.Count, existingEntity.Videos?.Count);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToModel_AssignsVideoTypeProperties()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var entity = VideoTypesMockingSetup.DoMockingSetupForVideoType();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.Videos?.Count, model.Videos?.Count);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToModelLite_AssignsLiteOnlyVideoTypeProperties()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var entity = VideoTypesMockingSetup.DoMockingSetupForVideoType();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToModelListing_AssignsListingOnlyVideoTypeProperties()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var entity = VideoTypesMockingSetup.DoMockingSetupForVideoType();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_MapToSearchModel_AssignsVideoTypeSearchProperties()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
            var entity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new VideoTypeMapper();
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
            var entity = VideoTypesMockingSetup.DoMockingSetupForVideoType(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
