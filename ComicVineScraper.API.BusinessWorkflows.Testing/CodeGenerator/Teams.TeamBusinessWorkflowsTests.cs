// <auto-generated>
// <copyright file="Teams.ITeamBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamsRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Teams
{
    using System.Collections.Generic;
    using API.BusinessWorkflows;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;
    using Models;
    using Moq;
    using Xunit;

    public static class TeamsMockingSetup
    {
        public static Mock<ITeamModel> DoMockingSetupForTeamModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamModel = new Mock<ITeamModel>();
            // Mock Functions
            mockTeamModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamModel.Setup(m => m.Active).Returns(() => true);
            mockTeamModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockTeamModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            mockTeamModel.Setup(m => m.FirstIssueAppearanceId).Returns(() => 1);
            mockTeamModel.Setup(m => m.FirstIssueAppearance).Returns(() => new IssueModel());
            mockTeamModel.Setup(m => m.PublisherId).Returns(() => 1);
            mockTeamModel.Setup(m => m.Publisher).Returns(() => new PublisherModel());
            // Associated Objects
            mockTeamModel.Setup(m => m.TeamAliases).Returns(() => new List<ITeamAliasModel>());
            mockTeamModel.Setup(m => m.TeamCharacterEnemies).Returns(() => new List<ITeamCharacterEnemyModel>());
            mockTeamModel.Setup(m => m.TeamCharacterFriends).Returns(() => new List<ITeamCharacterFriendModel>());
            mockTeamModel.Setup(m => m.TeamIssuesAppearedIn).Returns(() => new List<ITeamAppearedInIssueModel>());
            mockTeamModel.Setup(m => m.TeamIssuesDisbandedIn).Returns(() => new List<ITeamDisbandedInIssueModel>());
            mockTeamModel.Setup(m => m.TeamIssues).Returns(() => new List<ITeamIssueModel>());
            mockTeamModel.Setup(m => m.TeamMembers).Returns(() => new List<ITeamMemberModel>());
            mockTeamModel.Setup(m => m.TeamMovies).Returns(() => new List<ITeamMovieModel>());
            mockTeamModel.Setup(m => m.TeamStoryArcs).Returns(() => new List<ITeamStoryArcModel>());
            mockTeamModel.Setup(m => m.TeamVolumes).Returns(() => new List<ITeamVolumeModel>());
            // Return
            return mockTeamModel;
        }

        public static Mock<ITeam> DoMockingSetupForTeam(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeam = new Mock<ITeam>();
            // Mock Functions
            mockTeam.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeam.Setup(m => m.Active).Returns(() => true);
            mockTeam.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeam.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeam.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeam.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeam.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeam.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockTeam.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockTeam.Setup(m => m.FirstIssueAppearanceId).Returns(() => 1);
            mockTeam.Setup(m => m.FirstIssueAppearance).Returns(() => new Issue());
            mockTeam.Setup(m => m.PublisherId).Returns(() => 1);
            mockTeam.Setup(m => m.Publisher).Returns(() => new Publisher());
            // Associated Objects
            mockTeam.Setup(m => m.TeamAliases).Returns(() => new List<ITeamAlias>());
            mockTeam.Setup(m => m.TeamCharacterEnemies).Returns(() => new List<ITeamCharacterEnemy>());
            mockTeam.Setup(m => m.TeamCharacterFriends).Returns(() => new List<ITeamCharacterFriend>());
            mockTeam.Setup(m => m.TeamIssuesAppearedIn).Returns(() => new List<ITeamAppearedInIssue>());
            mockTeam.Setup(m => m.TeamIssuesDisbandedIn).Returns(() => new List<ITeamDisbandedInIssue>());
            mockTeam.Setup(m => m.TeamIssues).Returns(() => new List<ITeamIssue>());
            mockTeam.Setup(m => m.TeamMembers).Returns(() => new List<ITeamMember>());
            mockTeam.Setup(m => m.TeamMovies).Returns(() => new List<ITeamMovie>());
            mockTeam.Setup(m => m.TeamStoryArcs).Returns(() => new List<ITeamStoryArc>());
            mockTeam.Setup(m => m.TeamVolumes).Returns(() => new List<ITeamVolume>());
            // Return
            return mockTeam;
        }

        public static Mock<ITeamsRepository> DoMockingSetupForRepository()
        {
            var mockTeamsRepository = new Mock<ITeamsRepository>();
            // Mock Functions
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ITeam>().Object);
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ITeam>().Object);
            mockTeamsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ITeam>>().Object);
            mockTeamsRepository.Setup(m => m.Search(It.IsAny<ITeamSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeam>>().Object);
            mockTeamsRepository.Setup(m => m.Add(It.IsAny<ITeam>()));
            mockTeamsRepository.Setup(m => m.Remove(It.IsAny<ITeam>()));
            mockTeamsRepository.Setup(m => m.Deactivate(It.IsAny<ITeam>()));
            mockTeamsRepository.Setup(m => m.Update(It.IsAny<ITeam>()));
            // Return
            return mockTeamsRepository;
        }
    }

    public class TeamsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "Teams")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<TeamModel>(person);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<TeamModel>(person);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Search_Should_ReturnAListOfTeams()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamSearchModel>();
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockTeamsRepository.Verify(m => m.Search(It.IsAny<ITeamSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Search_AsListing_Should_ReturnAListOfTeamsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamSearchModel>();
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockTeamsRepository.Verify(m => m.Search(It.IsAny<ITeamSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "Teams")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            mockTeamsRepository.Setup(m => m.Search(It.IsAny<ITeamSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeam>>().Object);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            var model = TeamsMockingSetup.DoMockingSetupForTeamModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockTeamsRepository.Verify(m => m.Add(It.IsAny<ITeam>()), Times.Once);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var mockTeam = TeamsMockingSetup.DoMockingSetupForTeam(1);
            mockTeamsRepository.Setup(m => m.Search(It.IsAny<ITeamSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ITeam> { mockTeam.Object } );
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeam.Object);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            var model = TeamsMockingSetup.DoMockingSetupForTeamModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockTeamsRepository.Verify(m => m.Add(It.IsAny<ITeam>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "Teams")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockTeam = TeamsMockingSetup.DoMockingSetupForTeam(1);
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeam.Object);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            var expectedName = "Stephen King (2)";
            var model = TeamsMockingSetup.DoMockingSetupForTeamModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockTeam.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "Teams")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = TeamsMockingSetup.DoMockingSetupForTeam(1);
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            var model = TeamsMockingSetup.DoMockingSetupForTeamModel(1);
            ITeamModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("/TEST/KING-STEPHEN", result.ApiDetailUrl);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact][Trait("Category", "Teams")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeam>().Object);
            mockTeamsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockTeamsRepository.Verify(m => m.Deactivate(It.IsAny<ITeam>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeam>().Object);
            mockTeamsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockTeamsRepository.Verify(m => m.Deactivate(It.IsAny<ITeam>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "Teams")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeam>().Object);
            mockTeamsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockTeamsRepository.Verify(m => m.Remove(It.IsAny<ITeam>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            var mockTeamsMapper = new Mock<ITeamMapper>();
            mockTeamsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamModel>(), It.IsAny<ITeam>())).Returns(() => true);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, mockTeamsMapper.Object);
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeam>().Object);
            mockTeamsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockTeamsRepository.Verify(m => m.Remove(It.IsAny<ITeam>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Teams")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockTeamsRepository = TeamsMockingSetup.DoMockingSetupForRepository();
            mockTeamsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new TeamsBusinessWorkflow(mockTeamsRepository.Object, new TeamMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
