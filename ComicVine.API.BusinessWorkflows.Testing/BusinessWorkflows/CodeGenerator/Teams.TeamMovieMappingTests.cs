// <auto-generated>
// <copyright file="Teams.ITeamMovieRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamMoviesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Teams
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class TeamMoviesMockingSetup
    {
        public static Mock<ITeamMovieModel> DoMockingSetupForTeamMovieModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamMovieModel = new Mock<ITeamMovieModel>();
            // Mock Functions
            mockTeamMovieModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamMovieModel.Setup(m => m.Active).Returns(() => true);
            mockTeamMovieModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamMovieModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamMovieModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamMovieModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamMovieModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamMovieModel.Setup(m => m.Name).Returns(() => name);
            //mockTeamMovieModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamMovieModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamMovieModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamMovieModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamMovieModel.Setup(m => m.MovieId).Returns(() => 1);
            mockTeamMovieModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamMovieModel;
        }

        public static Mock<ITeamMovie> DoMockingSetupForTeamMovie(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamMovie = new Mock<ITeamMovie>();
            // Mock Functions
            mockTeamMovie.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamMovie.Setup(m => m.Active).Returns(() => true);
            mockTeamMovie.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamMovie.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamMovie.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamMovie.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamMovie.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockTeamMovie.Setup(m => m.Name).Returns(() => name);
            //mockTeamMovie.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockTeamMovie.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockTeamMovie.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamMovie.Setup(m => m.Team).Returns(() => new Team());
            mockTeamMovie.Setup(m => m.MovieId).Returns(() => 1);
            mockTeamMovie.Setup(m => m.Movie).Returns(() => new Movie());
            // Associated Objects
            // <None>
            // Return
            return mockTeamMovie;
        }
    }

    public class TeamMovieMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<TeamMovieMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamMovieModel>()));
            var mockModel = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel(1);
            TeamMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamMovieModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<TeamMovieMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<ITeamMovieModel>(), ref It.IsAny<ITeamMovie>()));
        //    var mockModel = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel(1);
        //    var mockEntity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie(1);
        //    TeamMovieMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<ITeamMovieModel>(), ref It.IsAny<ITeamMovie>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamMovieMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<ITeamMovie>()));
            var mockEntity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie(1);
            TeamMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<ITeamMovie>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamMovieMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<ITeamMovie>()));
            var mockEntity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie(1);
            TeamMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<ITeamMovie>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamMovieMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<ITeamMovie>()));
            var mockEntity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie(1);
            TeamMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<ITeamMovie>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<TeamMovieMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<ITeamMovieModel>()));
            var mockModel = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel(1);
            TeamMovieMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<ITeamMovieModel>()), Times.Once);
        }

        public static Mock<ITeamMovie> DoMockingSetupForTeamMovie(int idReturnValue = 0)
        {
            var mockTeamMovie = new Mock<ITeamMovie>();
            // Mock Functions
            mockTeamMovie.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamMovie.Setup(m => m.Active).Returns(() => true);
            mockTeamMovie.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamMovie.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamMovie.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamMovie.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamMovie.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamMovie.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamMovie.Setup(m => m.Team).Returns(() => new Team());
            mockTeamMovie.Setup(m => m.MovieId).Returns(() => 1);
            mockTeamMovie.Setup(m => m.Movie).Returns(() => new Movie());
            // Associated Objects
            // <None>
            // Return
            return mockTeamMovie;
        }
    }

    public class TeamMoviesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsTeamMovieProperties()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var model = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, entity.TeamId);
            Assert.Equal(model.Object.MovieId, entity.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsTeamMovieProperties()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var model = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel();
            // Act
            ITeamMovie existingEntity = new TeamMovie { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.TeamId, existingEntity.TeamId);
            Assert.Equal(model.Object.MovieId, existingEntity.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModel_AssignsTeamMovieProperties()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var entity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            // Associated Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyTeamMovieProperties()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var entity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyTeamMovieProperties()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var entity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.TeamId, model.TeamId);
            Assert.Equal(entity.Object.MovieId, model.MovieId);
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsTeamMovieSearchProperties()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var model = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.TeamId, searchModel.TeamId);
            Assert.Equal(model.Object.Team?.CustomKey, searchModel.TeamCustomKey);
            Assert.Equal(model.Object.Team?.ApiDetailUrl, searchModel.TeamApiDetailUrl);
            Assert.Equal(model.Object.Team?.SiteDetailUrl, searchModel.TeamSiteDetailUrl);
            Assert.Equal(model.Object.Team?.Name, searchModel.TeamName);
            Assert.Equal(model.Object.Team?.ShortDescription, searchModel.TeamShortDescription);
            Assert.Equal(model.Object.Team?.Description, searchModel.TeamDescription);
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
            var mapper = new TeamMovieMapper();
            var model = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel(1);
            var entity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new TeamMovieMapper();
            var model = TeamMoviesMockingSetup.DoMockingSetupForTeamMovieModel(1);
            var entity = TeamMoviesMockingSetup.DoMockingSetupForTeamMovie(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
