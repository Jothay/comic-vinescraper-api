// <auto-generated>
// <copyright file="StoryArcs.IStoryArcWriterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcWritersRepository Class.</summary>
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

    public static class StoryArcWritersMockingSetup
    {
        public static Mock<IStoryArcWriterModel> DoMockingSetupForStoryArcWriterModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStoryArcWriterModel = new Mock<IStoryArcWriterModel>();
            // Mock Functions
            mockStoryArcWriterModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcWriterModel.Setup(m => m.Active).Returns(() => true);
            mockStoryArcWriterModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcWriterModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcWriterModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcWriterModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcWriterModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockStoryArcWriterModel.Setup(m => m.Name).Returns(() => name);
            //mockStoryArcWriterModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockStoryArcWriterModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockStoryArcWriterModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcWriterModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            mockStoryArcWriterModel.Setup(m => m.WriterId).Returns(() => 1);
            mockStoryArcWriterModel.Setup(m => m.Writer).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcWriterModel;
        }

        public static Mock<IStoryArcWriter> DoMockingSetupForStoryArcWriter(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStoryArcWriter = new Mock<IStoryArcWriter>();
            // Mock Functions
            mockStoryArcWriter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcWriter.Setup(m => m.Active).Returns(() => true);
            mockStoryArcWriter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcWriter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcWriter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcWriter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcWriter.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockStoryArcWriter.Setup(m => m.Name).Returns(() => name);
            //mockStoryArcWriter.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockStoryArcWriter.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockStoryArcWriter.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcWriter.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            mockStoryArcWriter.Setup(m => m.WriterId).Returns(() => 1);
            mockStoryArcWriter.Setup(m => m.Writer).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcWriter;
        }
    }

    public class StoryArcWriterMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcWriterMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IStoryArcWriterModel>()));
            var mockModel = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel(1);
            StoryArcWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IStoryArcWriterModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<StoryArcWriterMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IStoryArcWriterModel>(), ref It.IsAny<IStoryArcWriter>()));
        //    var mockModel = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel(1);
        //    var mockEntity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter(1);
        //    StoryArcWriterMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IStoryArcWriterModel>(), ref It.IsAny<IStoryArcWriter>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcWriterMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IStoryArcWriter>()));
            var mockEntity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter(1);
            StoryArcWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IStoryArcWriter>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcWriterMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IStoryArcWriter>()));
            var mockEntity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter(1);
            StoryArcWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IStoryArcWriter>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcWriterMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IStoryArcWriter>()));
            var mockEntity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter(1);
            StoryArcWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IStoryArcWriter>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<StoryArcWriterMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IStoryArcWriterModel>()));
            var mockModel = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel(1);
            StoryArcWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IStoryArcWriterModel>()), Times.Once);
        }

        public static Mock<IStoryArcWriter> DoMockingSetupForStoryArcWriter(int idReturnValue = 0)
        {
            var mockStoryArcWriter = new Mock<IStoryArcWriter>();
            // Mock Functions
            mockStoryArcWriter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcWriter.Setup(m => m.Active).Returns(() => true);
            mockStoryArcWriter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcWriter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcWriter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcWriter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcWriter.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockStoryArcWriter.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcWriter.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            mockStoryArcWriter.Setup(m => m.WriterId).Returns(() => 1);
            mockStoryArcWriter.Setup(m => m.Writer).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcWriter;
        }
    }

    public class StoryArcWritersMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsStoryArcWriterProperties()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var model = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.StoryArcId, entity.StoryArcId);
            Assert.Equal(model.Object.WriterId, entity.WriterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsStoryArcWriterProperties()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var model = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel();
            // Act
            IStoryArcWriter existingEntity = new StoryArcWriter { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.StoryArcId, existingEntity.StoryArcId);
            Assert.Equal(model.Object.WriterId, existingEntity.WriterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsStoryArcWriterProperties()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var entity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            Assert.Equal(entity.Object.WriterId, model.WriterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyStoryArcWriterProperties()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var entity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            Assert.Equal(entity.Object.WriterId, model.WriterId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyStoryArcWriterProperties()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var entity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            Assert.Equal(entity.Object.WriterId, model.WriterId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsStoryArcWriterSearchProperties()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var model = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel();
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
            Assert.Equal(model.Object.WriterId, searchModel.WriterId);
            Assert.Equal(model.Object.Writer?.CustomKey, searchModel.WriterCustomKey);
            Assert.Equal(model.Object.Writer?.ApiDetailUrl, searchModel.WriterApiDetailUrl);
            Assert.Equal(model.Object.Writer?.SiteDetailUrl, searchModel.WriterSiteDetailUrl);
            Assert.Equal(model.Object.Writer?.Name, searchModel.WriterName);
            Assert.Equal(model.Object.Writer?.ShortDescription, searchModel.WriterShortDescription);
            Assert.Equal(model.Object.Writer?.Description, searchModel.WriterDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var model = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel(1);
            var entity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new StoryArcWriterMapper();
            var model = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriterModel(1);
            var entity = StoryArcWritersMockingSetup.DoMockingSetupForStoryArcWriter(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
