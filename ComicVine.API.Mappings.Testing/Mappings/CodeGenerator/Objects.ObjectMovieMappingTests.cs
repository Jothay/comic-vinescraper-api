// <auto-generated>
// <copyright file="Objects.IObjectMovieRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectMoviesRepository Class.</summary>
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

    public static class ObjectMoviesMockingSetup
    {
        public static Mock<IObjectMovieModel> DoMockingSetupForObjectMovieModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectMovieModel = new Mock<IObjectMovieModel>();
            // Mock Functions
            mockObjectMovieModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectMovieModel.Setup(m => m.Active).Returns(() => true);
            mockObjectMovieModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectMovieModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovieModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovieModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectMovieModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockObjectMovieModel.Setup(m => m.Name).Returns(() => name);
            //mockObjectMovieModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockObjectMovieModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectMovieModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectMovieModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            mockObjectMovieModel.Setup(m => m.MovieId).Returns(() => 1);
            mockObjectMovieModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            // Associated Objects
            // <None>
            // Return
            return mockObjectMovieModel;
        }

        public static Mock<IObjectMovie> DoMockingSetupForObjectMovie(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectMovie = new Mock<IObjectMovie>();
            // Mock Functions
            mockObjectMovie.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectMovie.Setup(m => m.Active).Returns(() => true);
            mockObjectMovie.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectMovie.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovie.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovie.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectMovie.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockObjectMovie.Setup(m => m.Name).Returns(() => name);
            //mockObjectMovie.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockObjectMovie.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockObjectMovie.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectMovie.Setup(m => m.Object).Returns(() => new Object());
            mockObjectMovie.Setup(m => m.MovieId).Returns(() => 1);
            mockObjectMovie.Setup(m => m.Movie).Returns(() => new Movie());
            // Associated Objects
            // <None>
            // Return
            return mockObjectMovie;
        }
    }

    public class ObjectMovieMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ObjectMovieMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IObjectMovieModel>()));
            var mockModel = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
            ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IObjectMovieModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ObjectMovieMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IObjectMovieModel>(), ref It.IsAny<IObjectMovie>()));
        //    var mockModel = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
        //    var mockEntity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
        //    ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IObjectMovieModel>(), ref It.IsAny<IObjectMovie>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectMovieMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IObjectMovie>()));
            var mockEntity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IObjectMovie>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectMovieMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IObjectMovie>()));
            var mockEntity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IObjectMovie>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectMovieMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IObjectMovie>()));
            var mockEntity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IObjectMovie>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ObjectMovieMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IObjectMovieModel>()));
            var mockModel = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
            ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IObjectMovieModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<ObjectMovieMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>()));
            ObjectMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
            var mockEntity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>()), Times.Once);
        }
    }

    public class ObjectMoviesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsObjectMovieProperties()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ObjectId, entity.ObjectId);
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsObjectMovieProperties()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel();
            // Act
            IObjectMovie existingEntity = new ObjectMovie { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ObjectId, existingEntity.ObjectId);
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsObjectMovieProperties()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var entity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyObjectMovieProperties()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var entity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyObjectMovieProperties()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var entity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ObjectId, model.ObjectId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsObjectMovieSearchProperties()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel();
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
            Assert.Equal(model.Object.MovieId, searchModel.MovieId);
            Assert.Equal(model.Object.Movie?.CustomKey, searchModel.MovieCustomKey);
            Assert.Equal(model.Object.Movie?.ApiDetailUrl, searchModel.MovieApiDetailUrl);
            Assert.Equal(model.Object.Movie?.SiteDetailUrl, searchModel.MovieSiteDetailUrl);
            Assert.Equal(model.Object.Movie?.Name, searchModel.MovieName);
            Assert.Equal(model.Object.Movie?.ShortDescription, searchModel.MovieShortDescription);
            Assert.Equal(model.Object.Movie?.Description, searchModel.MovieDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
            var entity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ObjectMovieMapper();
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
            var entity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
