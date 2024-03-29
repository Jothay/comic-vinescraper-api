// <auto-generated>
// <copyright file="Teams.ITeamAppearedInIssueBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamAppearedInIssuesRepository Class.</summary>
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

    public static class TeamAppearedInIssuesMockingSetup
    {
        public static Mock<ITeamAppearedInIssueModel> DoMockingSetupForTeamAppearedInIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamAppearedInIssueModel = new Mock<ITeamAppearedInIssueModel>();
            // Mock Functions
            mockTeamAppearedInIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamAppearedInIssueModel.Setup(m => m.Active).Returns(() => true);
            mockTeamAppearedInIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamAppearedInIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAppearedInIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAppearedInIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamAppearedInIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamAppearedInIssueModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamAppearedInIssueModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamAppearedInIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockTeamAppearedInIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamAppearedInIssueModel;
        }

        public static Mock<ITeamAppearedInIssue> DoMockingSetupForTeamAppearedInIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamAppearedInIssue = new Mock<ITeamAppearedInIssue>();
            // Mock Functions
            mockTeamAppearedInIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamAppearedInIssue.Setup(m => m.Active).Returns(() => true);
            mockTeamAppearedInIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamAppearedInIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAppearedInIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamAppearedInIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamAppearedInIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamAppearedInIssue.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamAppearedInIssue.Setup(m => m.Team).Returns(() => new Team());
            mockTeamAppearedInIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockTeamAppearedInIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockTeamAppearedInIssue;
        }

        public static Mock<ITeamAppearedInIssuesRepository> DoMockingSetupForRepository()
        {
            var mockTeamAppearedInIssuesRepository = new Mock<ITeamAppearedInIssuesRepository>();
            // Mock Functions
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ITeamAppearedInIssue>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ITeamAppearedInIssue>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ITeamAppearedInIssue>>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Search(It.IsAny<ITeamAppearedInIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeamAppearedInIssue>>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Add(It.IsAny<ITeamAppearedInIssue>()));
            mockTeamAppearedInIssuesRepository.Setup(m => m.Remove(It.IsAny<ITeamAppearedInIssue>()));
            mockTeamAppearedInIssuesRepository.Setup(m => m.Deactivate(It.IsAny<ITeamAppearedInIssue>()));
            mockTeamAppearedInIssuesRepository.Setup(m => m.Update(It.IsAny<ITeamAppearedInIssue>()));
            // Return
            return mockTeamAppearedInIssuesRepository;
        }
    }

    public class TeamAppearedInIssuesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<TeamAppearedInIssueModel>(person);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<TeamAppearedInIssueModel>(person);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Search_Should_ReturnAListOfTeamAppearedInIssues()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamAppearedInIssueSearchModel>();
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Search(It.IsAny<ITeamAppearedInIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Search_AsListing_Should_ReturnAListOfTeamAppearedInIssuesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamAppearedInIssueSearchModel>();
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Search(It.IsAny<ITeamAppearedInIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockTeamAppearedInIssuesRepository.Setup(m => m.Search(It.IsAny<ITeamAppearedInIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeamAppearedInIssue>>().Object);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            var model = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Add(It.IsAny<ITeamAppearedInIssue>()), Times.Once);
        }
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockTeamAppearedInIssue = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssue(1);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Search(It.IsAny<ITeamAppearedInIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ITeamAppearedInIssue> { mockTeamAppearedInIssue.Object } );
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeamAppearedInIssue.Object);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            var model = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Add(It.IsAny<ITeamAppearedInIssue>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockTeamAppearedInIssue = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssue(1);
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeamAppearedInIssue.Object);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            var expectedName = "Stephen King (2)";
            var model = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssueModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockTeamAppearedInIssue.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssue(1);
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            var model = TeamAppearedInIssuesMockingSetup.DoMockingSetupForTeamAppearedInIssueModel(1);
            ITeamAppearedInIssueModel result = null;
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
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamAppearedInIssue>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Deactivate(It.IsAny<ITeamAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamAppearedInIssue>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Deactivate(It.IsAny<ITeamAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamAppearedInIssue>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Remove(It.IsAny<ITeamAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockTeamAppearedInIssuesMapper = new Mock<ITeamAppearedInIssueMapper>();
            mockTeamAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamAppearedInIssueModel>(), It.IsAny<ITeamAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, mockTeamAppearedInIssuesMapper.Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamAppearedInIssue>().Object);
            mockTeamAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockTeamAppearedInIssuesRepository.Verify(m => m.Remove(It.IsAny<ITeamAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamAppearedInIssues")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockTeamAppearedInIssuesRepository = TeamAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockTeamAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new TeamAppearedInIssuesBusinessWorkflow(mockTeamAppearedInIssuesRepository.Object, new TeamAppearedInIssueMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
