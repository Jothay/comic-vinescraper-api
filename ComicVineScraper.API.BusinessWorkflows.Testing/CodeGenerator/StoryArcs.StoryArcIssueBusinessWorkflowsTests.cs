// <auto-generated>
// <copyright file="StoryArcs.IStoryArcIssueBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcIssuesRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.StoryArcs
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

    public static class StoryArcIssuesMockingSetup
    {
        public static Mock<IStoryArcIssueModel> DoMockingSetupForStoryArcIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStoryArcIssueModel = new Mock<IStoryArcIssueModel>();
            // Mock Functions
            mockStoryArcIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcIssueModel.Setup(m => m.Active).Returns(() => true);
            mockStoryArcIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockStoryArcIssueModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcIssueModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            mockStoryArcIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockStoryArcIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcIssueModel;
        }

        public static Mock<IStoryArcIssue> DoMockingSetupForStoryArcIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStoryArcIssue = new Mock<IStoryArcIssue>();
            // Mock Functions
            mockStoryArcIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStoryArcIssue.Setup(m => m.Active).Returns(() => true);
            mockStoryArcIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStoryArcIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStoryArcIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockStoryArcIssue.Setup(m => m.StoryArcId).Returns(() => 1);
            mockStoryArcIssue.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            mockStoryArcIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockStoryArcIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockStoryArcIssue;
        }

        public static Mock<IStoryArcIssuesRepository> DoMockingSetupForRepository()
        {
            var mockStoryArcIssuesRepository = new Mock<IStoryArcIssuesRepository>();
            // Mock Functions
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IStoryArcIssue>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IStoryArcIssue>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IStoryArcIssue>>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.Search(It.IsAny<IStoryArcIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IStoryArcIssue>>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.Add(It.IsAny<IStoryArcIssue>()));
            mockStoryArcIssuesRepository.Setup(m => m.Remove(It.IsAny<IStoryArcIssue>()));
            mockStoryArcIssuesRepository.Setup(m => m.Deactivate(It.IsAny<IStoryArcIssue>()));
            mockStoryArcIssuesRepository.Setup(m => m.Update(It.IsAny<IStoryArcIssue>()));
            // Return
            return mockStoryArcIssuesRepository;
        }
    }

    public class StoryArcIssuesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<StoryArcIssueModel>(person);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<StoryArcIssueModel>(person);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Search_Should_ReturnAListOfStoryArcIssues()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IStoryArcIssueSearchModel>();
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Search(It.IsAny<IStoryArcIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Search_AsListing_Should_ReturnAListOfStoryArcIssuesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IStoryArcIssueSearchModel>();
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Search(It.IsAny<IStoryArcIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            mockStoryArcIssuesRepository.Setup(m => m.Search(It.IsAny<IStoryArcIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IStoryArcIssue>>().Object);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Add(It.IsAny<IStoryArcIssue>()), Times.Once);
        }
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var mockStoryArcIssue = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            mockStoryArcIssuesRepository.Setup(m => m.Search(It.IsAny<IStoryArcIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IStoryArcIssue> { mockStoryArcIssue.Object } );
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockStoryArcIssue.Object);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Add(It.IsAny<IStoryArcIssue>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockStoryArcIssue = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockStoryArcIssue.Object);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            var expectedName = "Stephen King (2)";
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockStoryArcIssue.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssue(1);
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            var model = StoryArcIssuesMockingSetup.DoMockingSetupForStoryArcIssueModel(1);
            IStoryArcIssueModel result = null;
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
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IStoryArcIssue>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IStoryArcIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IStoryArcIssue>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IStoryArcIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IStoryArcIssue>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Remove(It.IsAny<IStoryArcIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            var mockStoryArcIssuesMapper = new Mock<IStoryArcIssueMapper>();
            mockStoryArcIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IStoryArcIssueModel>(), It.IsAny<IStoryArcIssue>())).Returns(() => true);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, mockStoryArcIssuesMapper.Object);
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IStoryArcIssue>().Object);
            mockStoryArcIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockStoryArcIssuesRepository.Verify(m => m.Remove(It.IsAny<IStoryArcIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "StoryArcIssues")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockStoryArcIssuesRepository = StoryArcIssuesMockingSetup.DoMockingSetupForRepository();
            mockStoryArcIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new StoryArcIssuesBusinessWorkflow(mockStoryArcIssuesRepository.Object, new StoryArcIssueMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
