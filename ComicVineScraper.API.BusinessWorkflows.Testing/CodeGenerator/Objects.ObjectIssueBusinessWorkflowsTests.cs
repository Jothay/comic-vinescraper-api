// <auto-generated>
// <copyright file="Objects.IObjectIssueBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectIssuesRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Objects
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

    public static class ObjectIssuesMockingSetup
    {
        public static Mock<IObjectIssueModel> DoMockingSetupForObjectIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectIssueModel = new Mock<IObjectIssueModel>();
            // Mock Functions
            mockObjectIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectIssueModel.Setup(m => m.Active).Returns(() => true);
            mockObjectIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockObjectIssueModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectIssueModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            mockObjectIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockObjectIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockObjectIssueModel;
        }

        public static Mock<IObjectIssue> DoMockingSetupForObjectIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectIssue = new Mock<IObjectIssue>();
            // Mock Functions
            mockObjectIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectIssue.Setup(m => m.Active).Returns(() => true);
            mockObjectIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockObjectIssue.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectIssue.Setup(m => m.Object).Returns(() => new Object());
            mockObjectIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockObjectIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockObjectIssue;
        }

        public static Mock<IObjectIssuesRepository> DoMockingSetupForRepository()
        {
            var mockObjectIssuesRepository = new Mock<IObjectIssuesRepository>();
            // Mock Functions
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IObjectIssue>().Object);
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IObjectIssue>().Object);
            mockObjectIssuesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IObjectIssue>>().Object);
            mockObjectIssuesRepository.Setup(m => m.Search(It.IsAny<IObjectIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IObjectIssue>>().Object);
            mockObjectIssuesRepository.Setup(m => m.Add(It.IsAny<IObjectIssue>()));
            mockObjectIssuesRepository.Setup(m => m.Remove(It.IsAny<IObjectIssue>()));
            mockObjectIssuesRepository.Setup(m => m.Deactivate(It.IsAny<IObjectIssue>()));
            mockObjectIssuesRepository.Setup(m => m.Update(It.IsAny<IObjectIssue>()));
            // Return
            return mockObjectIssuesRepository;
        }
    }

    public class ObjectIssuesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ObjectIssueModel>(person);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ObjectIssueModel>(person);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Search_Should_ReturnAListOfObjectIssues()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IObjectIssueSearchModel>();
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Search(It.IsAny<IObjectIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Search_AsListing_Should_ReturnAListOfObjectIssuesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IObjectIssueSearchModel>();
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Search(It.IsAny<IObjectIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            mockObjectIssuesRepository.Setup(m => m.Search(It.IsAny<IObjectIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IObjectIssue>>().Object);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            var model = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Add(It.IsAny<IObjectIssue>()), Times.Once);
        }
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var mockObjectIssue = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssue(1);
            mockObjectIssuesRepository.Setup(m => m.Search(It.IsAny<IObjectIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IObjectIssue> { mockObjectIssue.Object } );
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockObjectIssue.Object);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            var model = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Add(It.IsAny<IObjectIssue>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockObjectIssue = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssue(1);
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockObjectIssue.Object);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            var expectedName = "Stephen King (2)";
            var model = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssueModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockObjectIssue.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssue(1);
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            var model = ObjectIssuesMockingSetup.DoMockingSetupForObjectIssueModel(1);
            IObjectIssueModel result = null;
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
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectIssue>().Object);
            mockObjectIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IObjectIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectIssue>().Object);
            mockObjectIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IObjectIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectIssue>().Object);
            mockObjectIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Remove(It.IsAny<IObjectIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            var mockObjectIssuesMapper = new Mock<IObjectIssueMapper>();
            mockObjectIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectIssueModel>(), It.IsAny<IObjectIssue>())).Returns(() => true);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, mockObjectIssuesMapper.Object);
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectIssue>().Object);
            mockObjectIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockObjectIssuesRepository.Verify(m => m.Remove(It.IsAny<IObjectIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectIssues")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockObjectIssuesRepository = ObjectIssuesMockingSetup.DoMockingSetupForRepository();
            mockObjectIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ObjectIssuesBusinessWorkflow(mockObjectIssuesRepository.Object, new ObjectIssueMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}