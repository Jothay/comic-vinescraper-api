// <auto-generated>
// <copyright file="Concepts.IConceptAppearedInIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptAppearedInIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Concepts
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

    public static class ConceptAppearedInIssuesMockingSetup
    {
        public static Mock<IConceptAppearedInIssueModel> DoMockingSetupForConceptAppearedInIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptAppearedInIssueModel = new Mock<IConceptAppearedInIssueModel>();
            // Mock Functions
            mockConceptAppearedInIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptAppearedInIssueModel.Setup(m => m.Active).Returns(() => true);
            mockConceptAppearedInIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptAppearedInIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptAppearedInIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptAppearedInIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptAppearedInIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptAppearedInIssueModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptAppearedInIssueModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            mockConceptAppearedInIssueModel.Setup(m => m.AppearedInIssueId).Returns(() => 1);
            mockConceptAppearedInIssueModel.Setup(m => m.AppearedInIssue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockConceptAppearedInIssueModel;
        }

        public static Mock<IConceptAppearedInIssue> DoMockingSetupForConceptAppearedInIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptAppearedInIssue = new Mock<IConceptAppearedInIssue>();
            // Mock Functions
            mockConceptAppearedInIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptAppearedInIssue.Setup(m => m.Active).Returns(() => true);
            mockConceptAppearedInIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptAppearedInIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptAppearedInIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptAppearedInIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptAppearedInIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptAppearedInIssue.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptAppearedInIssue.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptAppearedInIssue.Setup(m => m.AppearedInIssueId).Returns(() => 1);
            mockConceptAppearedInIssue.Setup(m => m.AppearedInIssue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockConceptAppearedInIssue;
        }

        public static Mock<IConceptAppearedInIssuesRepository> DoMockingSetupForRepository()
        {
            var mockConceptAppearedInIssuesRepository = new Mock<IConceptAppearedInIssuesRepository>();
            // Mock Functions
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IConceptAppearedInIssue>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IConceptAppearedInIssue>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IConceptAppearedInIssue>>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Search(It.IsAny<IConceptAppearedInIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IConceptAppearedInIssue>>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Add(It.IsAny<IConceptAppearedInIssue>()));
            mockConceptAppearedInIssuesRepository.Setup(m => m.Remove(It.IsAny<IConceptAppearedInIssue>()));
            mockConceptAppearedInIssuesRepository.Setup(m => m.Deactivate(It.IsAny<IConceptAppearedInIssue>()));
            mockConceptAppearedInIssuesRepository.Setup(m => m.Update(It.IsAny<IConceptAppearedInIssue>()));
            // Return
            return mockConceptAppearedInIssuesRepository;
        }
    }

    public class ConceptAppearedInIssuesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ConceptAppearedInIssueModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ConceptAppearedInIssueModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfConceptAppearedInIssues()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IConceptAppearedInIssueSearchModel>();
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Search(It.IsAny<IConceptAppearedInIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfConceptAppearedInIssuesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IConceptAppearedInIssueSearchModel>();
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Search(It.IsAny<IConceptAppearedInIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptAppearedInIssuesRepository.Setup(m => m.Search(It.IsAny<IConceptAppearedInIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IConceptAppearedInIssue>>().Object);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            var model = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Add(It.IsAny<IConceptAppearedInIssue>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptAppearedInIssue = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssue(1);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Search(It.IsAny<IConceptAppearedInIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IConceptAppearedInIssue> { mockConceptAppearedInIssue.Object } );
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockConceptAppearedInIssue.Object);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            var model = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Add(It.IsAny<IConceptAppearedInIssue>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockConceptAppearedInIssue = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssue(1);
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockConceptAppearedInIssue.Object);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            var expectedName = "Stephen King (2)";
            var model = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssueModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockConceptAppearedInIssue.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssue(1);
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            var model = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForConceptAppearedInIssueModel(1);
            IConceptAppearedInIssueModel result = null;
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
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptAppearedInIssue>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IConceptAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptAppearedInIssue>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IConceptAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptAppearedInIssue>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Remove(It.IsAny<IConceptAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptAppearedInIssuesMapper = new Mock<IConceptAppearedInIssueMapper>();
            mockConceptAppearedInIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptAppearedInIssueModel>(), It.IsAny<IConceptAppearedInIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, mockConceptAppearedInIssuesMapper.Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptAppearedInIssue>().Object);
            mockConceptAppearedInIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockConceptAppearedInIssuesRepository.Verify(m => m.Remove(It.IsAny<IConceptAppearedInIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockConceptAppearedInIssuesRepository = ConceptAppearedInIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptAppearedInIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ConceptAppearedInIssuesBusinessWorkflow(mockConceptAppearedInIssuesRepository.Object, new ConceptAppearedInIssueMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}