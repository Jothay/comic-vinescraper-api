// <auto-generated>
// <copyright file="Teams.ITeamMovieRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamMoviesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Teams
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using API.Repositories;
    using DataModel.Schema;
    using Interfaces.SearchModels;
    using Moq;
    using SearchModels;
    using Xunit;

    public static class TeamMoviesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeTeamMoviesData, out Mock<IDbSet<TeamMovie>> mockSetTeamMovies, bool markATeamMovieInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetTeamMovies = new Mock<IDbSet<TeamMovie>>();
            var personData = (!includeTeamMoviesData ? new List<TeamMovie>() : new List<TeamMovie>
            {
                new TeamMovie { Id = 1, Active = !markATeamMovieInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new TeamMovie { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetTeamMovies.As<IQueryable<TeamMovie>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetTeamMovies.As<IQueryable<TeamMovie>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetTeamMovies.As<IQueryable<TeamMovie>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetTeamMovies.As<IQueryable<TeamMovie>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.TeamMovies).Returns(mockSetTeamMovies.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class TeamMoviesRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(false, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var teamMovies = new TeamMovie { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(teamMovies);
            // Assert
            mockSetTeamMovies.Verify(x => x.Add(teamMovies), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var teamMovies = repository.Get(1);
            // Act
            repository.Remove(teamMovies);
            // Assert
            mockSetTeamMovies.Verify(x => x.Remove((TeamMovie)teamMovies), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var teamMovies = repository.Get(1);
            // Act
            repository.Deactivate(teamMovies);
            // Assert
            Assert.Equal(false, teamMovies.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var teamMovies = repository.Get(1);
            teamMovies.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(teamMovies);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectTeamMovie()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            // Act
            var teamMovies = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", teamMovies.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectTeamMovie()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            // Act
            var teamMovies = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", teamMovies.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfTeamMoviesWithData()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            // Act
            var teamMovies = repository.List.ToArray();
            // Assert
            Assert.Equal(2, teamMovies.Length);
            Assert.Equal(1, teamMovies[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", teamMovies[0].ApiDetailUrl);
            Assert.Equal(2, teamMovies[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamMovies[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfTeamMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies, true);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var searchModel = new Mock<ITeamMovieSearchModel>();
            // Act
            var teamMovies = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, teamMovies.Length);
            Assert.Equal(2, teamMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies, true);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var searchModel = new Mock<ITeamMovieSearchModel>();
            // Act
            var teamMovies = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, teamMovies.Length);
            Assert.Equal(2, teamMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamMovies[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfTeamMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies, true);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ITeamMovieSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new TeamMovieSearchModel { ModifiedSince = createDate };
            // Act
            var teamMovies = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, teamMovies.Length);
            Assert.Equal(2, teamMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfTeamMoviesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<TeamMovie>> mockSetTeamMovies;
            var mockContext = TeamMoviesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamMovies);
            var repository = new TeamMoviesRepository(mockContext.Object);
            var searchModel = new TeamMovieSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var teamMovies = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, teamMovies.Length);
            Assert.Equal(2, teamMovies[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamMovies[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
