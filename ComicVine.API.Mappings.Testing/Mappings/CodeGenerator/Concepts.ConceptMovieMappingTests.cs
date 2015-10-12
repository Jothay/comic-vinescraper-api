// <auto-generated>
// <copyright file="Concepts.IConceptMovieRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptMoviesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Concepts
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ConceptMoviesMockingSetup
    {
        public static Mock<IConceptMovieModel> DoMockingSetupForConceptMovieModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptMovieModel = new Mock<IConceptMovieModel>();
            // Mock Functions
            mockConceptMovieModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptMovieModel.Setup(m => m.Active).Returns(() => true);
            mockConceptMovieModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptMovieModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptMovieModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptMovieModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptMovieModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockConceptMovieModel.Setup(m => m.Name).Returns(() => name);
            //mockConceptMovieModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockConceptMovieModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockConceptMovieModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptMovieModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            mockConceptMovieModel.Setup(m => m.MovieId).Returns(() => 1);
            mockConceptMovieModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            // Associated Objects
            // <None>
            // Return
            return mockConceptMovieModel;
        }

        public static Mock<IConceptMovie> DoMockingSetupForConceptMovie(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptMovie = new Mock<IConceptMovie>();
            // Mock Functions
            mockConceptMovie.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptMovie.Setup(m => m.Active).Returns(() => true);
            mockConceptMovie.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptMovie.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptMovie.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptMovie.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptMovie.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockConceptMovie.Setup(m => m.Name).Returns(() => name);
            //mockConceptMovie.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockConceptMovie.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockConceptMovie.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptMovie.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptMovie.Setup(m => m.MovieId).Returns(() => 1);
            mockConceptMovie.Setup(m => m.Movie).Returns(() => new Movie());
            // Associated Objects
            // <None>
            // Return
            return mockConceptMovie;
        }
    }

    public class ConceptMovieMappingExtensionsTests
    {
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ConceptMovieMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IConceptMovieModel>(), It.IsAny<int>()));
            var mockModel = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel(1);
            ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IConceptMovieModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "ConceptMovies")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ConceptMovieMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IConceptMovieModel>(), ref It.IsAny<IConceptMovie>(), It.IsAny<int>()));
        //    var mockModel = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel(1);
        //    var mockEntity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(1);
        //    ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IConceptMovieModel>(), ref It.IsAny<IConceptMovie>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptMovieMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IConceptMovie>(), It.IsAny<int>()));
            var mockEntity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(1);
            ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IConceptMovie>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptMovieMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IConceptMovie>(), It.IsAny<int>()));
            var mockEntity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(1);
            ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IConceptMovie>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptMovieMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IConceptMovie>(), It.IsAny<int>()));
            var mockEntity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(1);
            ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IConceptMovie>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ConceptMovieMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IConceptMovieModel>()));
            var mockModel = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel(1);
            ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IConceptMovieModel>()), Times.Once);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<ConceptMovieMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IConceptMovieModel>(), It.IsAny<IConceptMovie>()));
            ConceptMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel(1);
            var mockEntity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IConceptMovieModel>(), It.IsAny<IConceptMovie>()), Times.Once);
        }
    }

    public class ConceptMoviesMappingTests
    {
        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToEntity_AssignsConceptMovieProperties()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var model = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ConceptId, entity.ConceptId);
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsConceptMovieProperties()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var model = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel();
            // Act
            IConceptMovie existingEntity = new ConceptMovie { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.ConceptId, existingEntity.ConceptId);
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToModel_AssignsConceptMovieProperties()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var entity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToModelLite_AssignsLiteOnlyConceptMovieProperties()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var entity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToModelListing_AssignsListingOnlyConceptMovieProperties()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var entity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.ConceptId, model.ConceptId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            // Return Entity
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_MapToSearchModel_AssignsConceptMovieSearchProperties()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var model = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.ConceptId, searchModel.ConceptId);
            Assert.Equal(model.Object.Concept?.CustomKey, searchModel.ConceptCustomKey);
            Assert.Equal(model.Object.Concept?.ApiDetailUrl, searchModel.ConceptApiDetailUrl);
            Assert.Equal(model.Object.Concept?.SiteDetailUrl, searchModel.ConceptSiteDetailUrl);
            Assert.Equal(model.Object.Concept?.Name, searchModel.ConceptName);
            Assert.Equal(model.Object.Concept?.ShortDescription, searchModel.ConceptShortDescription);
            Assert.Equal(model.Object.Concept?.Description, searchModel.ConceptDescription);
            Assert.Equal(model.Object.MovieId, searchModel.MovieId);
            Assert.Equal(model.Object.Movie?.CustomKey, searchModel.MovieCustomKey);
            Assert.Equal(model.Object.Movie?.ApiDetailUrl, searchModel.MovieApiDetailUrl);
            Assert.Equal(model.Object.Movie?.SiteDetailUrl, searchModel.MovieSiteDetailUrl);
            Assert.Equal(model.Object.Movie?.Name, searchModel.MovieName);
            Assert.Equal(model.Object.Movie?.ShortDescription, searchModel.MovieShortDescription);
            Assert.Equal(model.Object.Movie?.Description, searchModel.MovieDescription);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var model = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel(1);
            var entity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "ConceptMovies")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ConceptMovieMapper();
            var model = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovieModel(1);
            var entity = ConceptMoviesMockingSetup.DoMockingSetupForConceptMovie(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
