// <auto-generated>
// <copyright file="Movies.IMovieStoryArcMappingTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieStoryArcsMappingTests class.</summary>
// <remarks>This file was auto-generated using MappingTestingFileMaster.tt in
// ComicVineScraper.API.Mappings.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Mappings.Movies
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class MovieStoryArcsMockingSetup
    {
        public static Mock<IMovieStoryArcModel> DoMockingSetupForMovieStoryArcModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieStoryArcModel = new Mock<IMovieStoryArcModel>();
            // Mock Functions
            mockMovieStoryArcModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieStoryArcModel.Setup(m => m.Active).Returns(() => true);
            mockMovieStoryArcModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieStoryArcModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStoryArcModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStoryArcModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieStoryArcModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieStoryArcModel.Setup(m => m.Name).Returns(() => name);
            //mockMovieStoryArcModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieStoryArcModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieStoryArcModel.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieStoryArcModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            mockMovieStoryArcModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockMovieStoryArcModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            // Associated Objects
            // <None>
            // Return
            return mockMovieStoryArcModel;
        }

        public static Mock<IMovieStoryArc> DoMockingSetupForMovieStoryArc(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieStoryArc = new Mock<IMovieStoryArc>();
            // Mock Functions
            mockMovieStoryArc.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieStoryArc.Setup(m => m.Active).Returns(() => true);
            mockMovieStoryArc.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieStoryArc.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStoryArc.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStoryArc.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieStoryArc.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieStoryArc.Setup(m => m.Name).Returns(() => name);
            //mockMovieStoryArc.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieStoryArc.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieStoryArc.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieStoryArc.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieStoryArc.Setup(m => m.StoryArcId).Returns(() => 1);
            mockMovieStoryArc.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockMovieStoryArc;
        }
    }

    public class MovieStoryArcMappingExtensionsTests
    {
        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<MovieStoryArcMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieStoryArcModel>(), It.IsAny<int>()));
            var mockModel = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel(1);
            MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieStoryArcModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "MovieStoryArcs")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<MovieStoryArcMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieStoryArcModel>(), ref It.IsAny<IMovieStoryArc>(), It.IsAny<int>()));
        //    var mockModel = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel(1);
        //    var mockEntity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(1);
        //    MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieStoryArcModel>(), ref It.IsAny<IMovieStoryArc>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IMovieStoryArc>(), It.IsAny<int>()));
            var mockEntity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(1);
            MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IMovieStoryArc>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IMovieStoryArc>(), It.IsAny<int>()));
            var mockEntity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(1);
            MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IMovieStoryArc>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStoryArcMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IMovieStoryArc>(), It.IsAny<int>()));
            var mockEntity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(1);
            MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IMovieStoryArc>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStoryArcMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IMovieStoryArcModel>()));
            var mockModel = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel(1);
            MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IMovieStoryArcModel>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<MovieStoryArcMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IMovieStoryArcModel>(), It.IsAny<IMovieStoryArc>()));
            MovieStoryArcMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel(1);
            var mockEntity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IMovieStoryArcModel>(), It.IsAny<IMovieStoryArc>()), Times.Once);
        }
    }

    public class MovieStoryArcsMappingTests
    {
        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToEntity_AssignsMovieStoryArcProperties()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var model = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            Assert.Equal(model.Object.StoryArcId, entity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsMovieStoryArcProperties()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var model = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel();
            // Act
            IMovieStoryArc existingEntity = new MovieStoryArc { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            Assert.Equal(model.Object.StoryArcId, existingEntity.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToModel_AssignsMovieStoryArcProperties()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var entity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToModelLite_AssignsLiteOnlyMovieStoryArcProperties()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var entity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToModelListing_AssignsListingOnlyMovieStoryArcProperties()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var entity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.StoryArcId, model.StoryArcId);
            // Return Entity
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_MapToSearchModel_AssignsMovieStoryArcSearchProperties()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var model = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel();
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
            Assert.Equal(model.Object.StoryArcId, searchModel.StoryArcId);
            Assert.Equal(model.Object.StoryArc?.CustomKey, searchModel.StoryArcCustomKey);
            Assert.Equal(model.Object.StoryArc?.ApiDetailUrl, searchModel.StoryArcApiDetailUrl);
            Assert.Equal(model.Object.StoryArc?.SiteDetailUrl, searchModel.StoryArcSiteDetailUrl);
            Assert.Equal(model.Object.StoryArc?.Name, searchModel.StoryArcName);
            Assert.Equal(model.Object.StoryArc?.ShortDescription, searchModel.StoryArcShortDescription);
            Assert.Equal(model.Object.StoryArc?.Description, searchModel.StoryArcDescription);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var model = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel(1);
            var entity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new MovieStoryArcMapper();
            var model = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArcModel(1);
            var entity = MovieStoryArcsMockingSetup.DoMockingSetupForMovieStoryArc(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
