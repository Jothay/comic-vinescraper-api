// <auto-generated>
// <copyright file="Movies.IMovieStudioRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieStudiosRepository Class.</summary>
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

    public static class MovieStudiosMockingSetup
    {
        public static Mock<IMovieStudioModel> DoMockingSetupForMovieStudioModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieStudioModel = new Mock<IMovieStudioModel>();
            // Mock Functions
            mockMovieStudioModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieStudioModel.Setup(m => m.Active).Returns(() => true);
            mockMovieStudioModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieStudioModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStudioModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStudioModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieStudioModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieStudioModel.Setup(m => m.Name).Returns(() => name);
            //mockMovieStudioModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieStudioModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieStudioModel.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieStudioModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            mockMovieStudioModel.Setup(m => m.StudioId).Returns(() => 1);
            mockMovieStudioModel.Setup(m => m.Studio).Returns(() => new StudioModel());
            // Associated Objects
            // <None>
            // Return
            return mockMovieStudioModel;
        }

        public static Mock<IMovieStudio> DoMockingSetupForMovieStudio(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieStudio = new Mock<IMovieStudio>();
            // Mock Functions
            mockMovieStudio.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieStudio.Setup(m => m.Active).Returns(() => true);
            mockMovieStudio.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieStudio.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStudio.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStudio.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieStudio.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieStudio.Setup(m => m.Name).Returns(() => name);
            //mockMovieStudio.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieStudio.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieStudio.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieStudio.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieStudio.Setup(m => m.StudioId).Returns(() => 1);
            mockMovieStudio.Setup(m => m.Studio).Returns(() => new Studio());
            // Associated Objects
            // <None>
            // Return
            return mockMovieStudio;
        }
    }

    public class MovieStudioMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<MovieStudioMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieStudioModel>()));
            var mockModel = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel(1);
            MovieStudioMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieStudioModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<MovieStudioMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieStudioModel>(), ref It.IsAny<IMovieStudio>()));
        //    var mockModel = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel(1);
        //    var mockEntity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio(1);
        //    MovieStudioMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieStudioModel>(), ref It.IsAny<IMovieStudio>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStudioMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IMovieStudio>()));
            var mockEntity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio(1);
            MovieStudioMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IMovieStudio>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStudioMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IMovieStudio>()));
            var mockEntity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio(1);
            MovieStudioMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IMovieStudio>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStudioMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IMovieStudio>()));
            var mockEntity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio(1);
            MovieStudioMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IMovieStudio>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieStudioMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IMovieStudioModel>()));
            var mockModel = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel(1);
            MovieStudioMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IMovieStudioModel>()), Times.Once);
        }

        public static Mock<IMovieStudio> DoMockingSetupForMovieStudio(int idReturnValue = 0)
        {
            var mockMovieStudio = new Mock<IMovieStudio>();
            // Mock Functions
            mockMovieStudio.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieStudio.Setup(m => m.Active).Returns(() => true);
            mockMovieStudio.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieStudio.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStudio.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieStudio.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieStudio.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockMovieStudio.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieStudio.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieStudio.Setup(m => m.StudioId).Returns(() => 1);
            mockMovieStudio.Setup(m => m.Studio).Returns(() => new Studio());
            // Associated Objects
            // <None>
            // Return
            return mockMovieStudio;
        }
    }

    public class MovieStudiosMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsMovieStudioProperties()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var model = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            Assert.Equal(model.Object.StudioId, entity.StudioId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsMovieStudioProperties()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var model = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel();
            // Act
            IMovieStudio existingEntity = new MovieStudio { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            Assert.Equal(model.Object.StudioId, existingEntity.StudioId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsMovieStudioProperties()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var entity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.StudioId, model.StudioId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyMovieStudioProperties()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var entity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.StudioId, model.StudioId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyMovieStudioProperties()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var entity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.StudioId, model.StudioId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsMovieStudioSearchProperties()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var model = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel();
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
            Assert.Equal(model.Object.StudioId, searchModel.StudioId);
            Assert.Equal(model.Object.Studio?.CustomKey, searchModel.StudioCustomKey);
            Assert.Equal(model.Object.Studio?.ApiDetailUrl, searchModel.StudioApiDetailUrl);
            Assert.Equal(model.Object.Studio?.SiteDetailUrl, searchModel.StudioSiteDetailUrl);
            Assert.Equal(model.Object.Studio?.Name, searchModel.StudioName);
            Assert.Equal(model.Object.Studio?.ShortDescription, searchModel.StudioShortDescription);
            Assert.Equal(model.Object.Studio?.Description, searchModel.StudioDescription);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var model = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel(1);
            var entity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new MovieStudioMapper();
            var model = MovieStudiosMockingSetup.DoMockingSetupForMovieStudioModel(1);
            var entity = MovieStudiosMockingSetup.DoMockingSetupForMovieStudio(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
