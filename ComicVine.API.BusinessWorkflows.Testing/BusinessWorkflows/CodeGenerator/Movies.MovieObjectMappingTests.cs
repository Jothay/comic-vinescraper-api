// <auto-generated>
// <copyright file="Movies.IMovieObjectRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieObjectsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Movies
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class MovieObjectsMockingSetup
    {
        public static Mock<IMovieObjectModel> DoMockingSetupForMovieObjectModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieObjectModel = new Mock<IMovieObjectModel>();
            // Mock Functions
            mockMovieObjectModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieObjectModel.Setup(m => m.Active).Returns(() => true);
            mockMovieObjectModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieObjectModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieObjectModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieObjectModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieObjectModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieObjectModel.Setup(m => m.Name).Returns(() => name);
            //mockMovieObjectModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieObjectModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieObjectModel.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieObjectModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            mockMovieObjectModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockMovieObjectModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            // Associated Objects
            // <None>
            // Return
            return mockMovieObjectModel;
        }

        public static Mock<IMovieObject> DoMockingSetupForMovieObject(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieObject = new Mock<IMovieObject>();
            // Mock Functions
            mockMovieObject.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieObject.Setup(m => m.Active).Returns(() => true);
            mockMovieObject.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieObject.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieObject.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieObject.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieObject.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieObject.Setup(m => m.Name).Returns(() => name);
            //mockMovieObject.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieObject.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieObject.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieObject.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieObject.Setup(m => m.ObjectId).Returns(() => 1);
            mockMovieObject.Setup(m => m.Object).Returns(() => new Object());
            // Associated Objects
            // <None>
            // Return
            return mockMovieObject;
        }
    }

    public class MovieObjectMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<MovieObjectMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieObjectModel>()));
            var mockModel = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel(1);
            MovieObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieObjectModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<MovieObjectMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieObjectModel>(), ref It.IsAny<IMovieObject>()));
        //    var mockModel = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel(1);
        //    var mockEntity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject(1);
        //    MovieObjectMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieObjectModel>(), ref It.IsAny<IMovieObject>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieObjectMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IMovieObject>()));
            var mockEntity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject(1);
            MovieObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IMovieObject>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieObjectMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IMovieObject>()));
            var mockEntity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject(1);
            MovieObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IMovieObject>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieObjectMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IMovieObject>()));
            var mockEntity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject(1);
            MovieObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IMovieObject>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieObjectMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IMovieObjectModel>()));
            var mockModel = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel(1);
            MovieObjectMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IMovieObjectModel>()), Times.Once);
        }

        public static Mock<IMovieObject> DoMockingSetupForMovieObject(int idReturnValue = 0)
        {
            var mockMovieObject = new Mock<IMovieObject>();
            // Mock Functions
            mockMovieObject.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieObject.Setup(m => m.Active).Returns(() => true);
            mockMovieObject.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieObject.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieObject.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieObject.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieObject.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockMovieObject.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieObject.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieObject.Setup(m => m.ObjectId).Returns(() => 1);
            mockMovieObject.Setup(m => m.Object).Returns(() => new Object());
            // Associated Objects
            // <None>
            // Return
            return mockMovieObject;
        }
    }

    public class MovieObjectsMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsMovieObjectProperties()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var model = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            Assert.Equal(model.Object.ObjectId, entity.ObjectId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsMovieObjectProperties()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var model = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel();
            // Act
            IMovieObject existingEntity = new MovieObject { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            Assert.Equal(model.Object.ObjectId, existingEntity.ObjectId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsMovieObjectProperties()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var entity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyMovieObjectProperties()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var entity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyMovieObjectProperties()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var entity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsMovieObjectSearchProperties()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var model = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.MovieId, searchModel.MovieId);
            Assert.Equal(model.Object.Movie?.CustomKey, searchModel.MovieCustomKey);
            Assert.Equal(model.Object.Movie?.ApiDetailUrl, searchModel.MovieApiDetailUrl);
            Assert.Equal(model.Object.Movie?.SiteDetailUrl, searchModel.MovieSiteDetailUrl);
            Assert.Equal(model.Object.Movie?.Name, searchModel.MovieName);
            Assert.Equal(model.Object.Movie?.ShortDescription, searchModel.MovieShortDescription);
            Assert.Equal(model.Object.Movie?.Description, searchModel.MovieDescription);
            Assert.Equal(model.Object.ObjectId, searchModel.ObjectId);
            Assert.Equal(model.Object.Object?.CustomKey, searchModel.ObjectCustomKey);
            Assert.Equal(model.Object.Object?.ApiDetailUrl, searchModel.ObjectApiDetailUrl);
            Assert.Equal(model.Object.Object?.SiteDetailUrl, searchModel.ObjectSiteDetailUrl);
            Assert.Equal(model.Object.Object?.Name, searchModel.ObjectName);
            Assert.Equal(model.Object.Object?.ShortDescription, searchModel.ObjectShortDescription);
            Assert.Equal(model.Object.Object?.Description, searchModel.ObjectDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var model = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel(1);
            var entity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new MovieObjectMapper();
            var model = MovieObjectsMockingSetup.DoMockingSetupForMovieObjectModel(1);
            var entity = MovieObjectsMockingSetup.DoMockingSetupForMovieObject(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
