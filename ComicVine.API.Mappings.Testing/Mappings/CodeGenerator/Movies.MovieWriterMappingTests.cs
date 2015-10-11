// <auto-generated>
// <copyright file="Movies.IMovieWriterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieWritersRepository Class.</summary>
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

    public static class MovieWritersMockingSetup
    {
        public static Mock<IMovieWriterModel> DoMockingSetupForMovieWriterModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieWriterModel = new Mock<IMovieWriterModel>();
            // Mock Functions
            mockMovieWriterModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieWriterModel.Setup(m => m.Active).Returns(() => true);
            mockMovieWriterModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieWriterModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriterModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriterModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieWriterModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieWriterModel.Setup(m => m.Name).Returns(() => name);
            //mockMovieWriterModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieWriterModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieWriterModel.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieWriterModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            mockMovieWriterModel.Setup(m => m.WriterId).Returns(() => 1);
            mockMovieWriterModel.Setup(m => m.Writer).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockMovieWriterModel;
        }

        public static Mock<IMovieWriter> DoMockingSetupForMovieWriter(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieWriter = new Mock<IMovieWriter>();
            // Mock Functions
            mockMovieWriter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieWriter.Setup(m => m.Active).Returns(() => true);
            mockMovieWriter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieWriter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieWriter.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockMovieWriter.Setup(m => m.Name).Returns(() => name);
            //mockMovieWriter.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockMovieWriter.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockMovieWriter.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieWriter.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieWriter.Setup(m => m.WriterId).Returns(() => 1);
            mockMovieWriter.Setup(m => m.Writer).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockMovieWriter;
        }
    }

    public class MovieWriterMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<MovieWriterMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieWriterModel>()));
            var mockModel = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
            MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieWriterModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<MovieWriterMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IMovieWriterModel>(), ref It.IsAny<IMovieWriter>()));
        //    var mockModel = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
        //    var mockEntity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
        //    MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IMovieWriterModel>(), ref It.IsAny<IMovieWriter>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieWriterMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IMovieWriter>()));
            var mockEntity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IMovieWriter>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieWriterMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IMovieWriter>()));
            var mockEntity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IMovieWriter>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieWriterMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IMovieWriter>()));
            var mockEntity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IMovieWriter>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<MovieWriterMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IMovieWriterModel>()));
            var mockModel = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
            MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IMovieWriterModel>()), Times.Once);
        }

        [Fact]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<MovieWriterMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>()));
            MovieWriterMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
            var mockEntity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>()), Times.Once);
        }
    }

    public class MovieWritersMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsMovieWriterProperties()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            Assert.Equal(model.Object.WriterId, entity.WriterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsMovieWriterProperties()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel();
            // Act
            IMovieWriter existingEntity = new MovieWriter { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            Assert.Equal(model.Object.WriterId, existingEntity.WriterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsMovieWriterProperties()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var entity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.WriterId, model.WriterId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyMovieWriterProperties()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var entity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.WriterId, model.WriterId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyMovieWriterProperties()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var entity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            Assert.Equal(entity.Object.WriterId, model.WriterId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsMovieWriterSearchProperties()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel();
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
            var mapper = new MovieWriterMapper();
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
            var entity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new MovieWriterMapper();
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
            var entity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
