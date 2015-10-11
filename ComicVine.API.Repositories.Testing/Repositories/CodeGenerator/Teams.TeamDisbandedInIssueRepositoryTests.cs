// <auto-generated>
// <copyright file="Teams.ITeamDisbandedInIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamDisbandedInIssuesRepository Class.</summary>
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

    public static class TeamDisbandedInIssuesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeTeamDisbandedInIssuesData, out Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues, bool markATeamDisbandedInIssueInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetTeamDisbandedInIssues = new Mock<IDbSet<TeamDisbandedInIssue>>();
            var personData = (!includeTeamDisbandedInIssuesData ? new List<TeamDisbandedInIssue>() : new List<TeamDisbandedInIssue>
            {
                new TeamDisbandedInIssue { Id = 1, Active = !markATeamDisbandedInIssueInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new TeamDisbandedInIssue { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetTeamDisbandedInIssues.As<IQueryable<TeamDisbandedInIssue>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetTeamDisbandedInIssues.As<IQueryable<TeamDisbandedInIssue>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetTeamDisbandedInIssues.As<IQueryable<TeamDisbandedInIssue>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetTeamDisbandedInIssues.As<IQueryable<TeamDisbandedInIssue>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.TeamDisbandedInIssues).Returns(mockSetTeamDisbandedInIssues.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class TeamDisbandedInIssuesRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(false, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var teamDisbandedInIssues = new TeamDisbandedInIssue { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(teamDisbandedInIssues);
            // Assert
            mockSetTeamDisbandedInIssues.Verify(x => x.Add(teamDisbandedInIssues), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var teamDisbandedInIssues = repository.Get(1);
            // Act
            repository.Remove(teamDisbandedInIssues);
            // Assert
            mockSetTeamDisbandedInIssues.Verify(x => x.Remove((TeamDisbandedInIssue)teamDisbandedInIssues), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var teamDisbandedInIssues = repository.Get(1);
            // Act
            repository.Deactivate(teamDisbandedInIssues);
            // Assert
            Assert.Equal(false, teamDisbandedInIssues.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var teamDisbandedInIssues = repository.Get(1);
            teamDisbandedInIssues.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(teamDisbandedInIssues);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectTeamDisbandedInIssue()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            // Act
            var teamDisbandedInIssues = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", teamDisbandedInIssues.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectTeamDisbandedInIssue()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            // Act
            var teamDisbandedInIssues = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", teamDisbandedInIssues.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfTeamDisbandedInIssuesWithData()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            // Act
            var teamDisbandedInIssues = repository.List.ToArray();
            // Assert
            Assert.Equal(2, teamDisbandedInIssues.Length);
            Assert.Equal(1, teamDisbandedInIssues[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", teamDisbandedInIssues[0].ApiDetailUrl);
            Assert.Equal(2, teamDisbandedInIssues[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamDisbandedInIssues[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfTeamDisbandedInIssuesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues, true);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var searchModel = new Mock<ITeamDisbandedInIssueSearchModel>();
            // Act
            var teamDisbandedInIssues = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, teamDisbandedInIssues.Length);
            Assert.Equal(2, teamDisbandedInIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamDisbandedInIssues[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues, true);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var searchModel = new Mock<ITeamDisbandedInIssueSearchModel>();
            // Act
            var teamDisbandedInIssues = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, teamDisbandedInIssues.Length);
            Assert.Equal(2, teamDisbandedInIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamDisbandedInIssues[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfTeamDisbandedInIssuesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues, true);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ITeamDisbandedInIssueSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new TeamDisbandedInIssueSearchModel { ModifiedSince = createDate };
            // Act
            var teamDisbandedInIssues = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, teamDisbandedInIssues.Length);
            Assert.Equal(2, teamDisbandedInIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamDisbandedInIssues[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfTeamDisbandedInIssuesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<TeamDisbandedInIssue>> mockSetTeamDisbandedInIssues;
            var mockContext = TeamDisbandedInIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetTeamDisbandedInIssues);
            var repository = new TeamDisbandedInIssuesRepository(mockContext.Object);
            var searchModel = new TeamDisbandedInIssueSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var teamDisbandedInIssues = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, teamDisbandedInIssues.Length);
            Assert.Equal(2, teamDisbandedInIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", teamDisbandedInIssues[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
