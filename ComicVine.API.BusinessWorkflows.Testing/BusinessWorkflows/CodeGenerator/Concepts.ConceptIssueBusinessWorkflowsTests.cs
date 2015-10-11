// <auto-generated>
// <copyright file="Concepts.IConceptIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptIssuesRepository Class.</summary>
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

    public static class ConceptIssuesMockingSetup
    {
        public static Mock<IConceptIssueModel> DoMockingSetupForConceptIssueModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptIssueModel = new Mock<IConceptIssueModel>();
            // Mock Functions
            mockConceptIssueModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptIssueModel.Setup(m => m.Active).Returns(() => true);
            mockConceptIssueModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptIssueModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssueModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssueModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptIssueModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptIssueModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptIssueModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            mockConceptIssueModel.Setup(m => m.IssueId).Returns(() => 1);
            mockConceptIssueModel.Setup(m => m.Issue).Returns(() => new IssueModel());
            // Associated Objects
            // <None>
            // Return
            return mockConceptIssueModel;
        }

        public static Mock<IConceptIssue> DoMockingSetupForConceptIssue(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptIssue = new Mock<IConceptIssue>();
            // Mock Functions
            mockConceptIssue.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptIssue.Setup(m => m.Active).Returns(() => true);
            mockConceptIssue.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptIssue.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssue.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptIssue.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptIssue.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptIssue.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptIssue.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptIssue.Setup(m => m.IssueId).Returns(() => 1);
            mockConceptIssue.Setup(m => m.Issue).Returns(() => new Issue());
            // Associated Objects
            // <None>
            // Return
            return mockConceptIssue;
        }

        public static Mock<IConceptIssuesRepository> DoMockingSetupForRepository()
        {
            var mockConceptIssuesRepository = new Mock<IConceptIssuesRepository>();
            // Mock Functions
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IConceptIssue>().Object);
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IConceptIssue>().Object);
            mockConceptIssuesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IConceptIssue>>().Object);
            mockConceptIssuesRepository.Setup(m => m.Search(It.IsAny<IConceptIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IConceptIssue>>().Object);
            mockConceptIssuesRepository.Setup(m => m.Add(It.IsAny<IConceptIssue>()));
            mockConceptIssuesRepository.Setup(m => m.Remove(It.IsAny<IConceptIssue>()));
            mockConceptIssuesRepository.Setup(m => m.Deactivate(It.IsAny<IConceptIssue>()));
            mockConceptIssuesRepository.Setup(m => m.Update(It.IsAny<IConceptIssue>()));
            // Return
            return mockConceptIssuesRepository;
        }
    }

    public class ConceptIssuesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ConceptIssueModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ConceptIssueModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfConceptIssues()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IConceptIssueSearchModel>();
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Search(It.IsAny<IConceptIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfConceptIssuesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IConceptIssueSearchModel>();
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Search(It.IsAny<IConceptIssueSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptIssuesRepository.Setup(m => m.Search(It.IsAny<IConceptIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IConceptIssue>>().Object);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Add(It.IsAny<IConceptIssue>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptIssue = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            mockConceptIssuesRepository.Setup(m => m.Search(It.IsAny<IConceptIssueSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IConceptIssue> { mockConceptIssue.Object } );
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockConceptIssue.Object);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Add(It.IsAny<IConceptIssue>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockConceptIssue = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockConceptIssue.Object);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            var expectedName = "Stephen King (2)";
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockConceptIssue.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssue(1);
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            var model = ConceptIssuesMockingSetup.DoMockingSetupForConceptIssueModel(1);
            IConceptIssueModel result = null;
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
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptIssue>().Object);
            mockConceptIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IConceptIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptIssue>().Object);
            mockConceptIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Deactivate(It.IsAny<IConceptIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptIssue>().Object);
            mockConceptIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Remove(It.IsAny<IConceptIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            var mockConceptIssuesMapper = new Mock<IConceptIssueMapper>();
            mockConceptIssuesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptIssueModel>(), It.IsAny<IConceptIssue>())).Returns(() => true);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, mockConceptIssuesMapper.Object);
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptIssue>().Object);
            mockConceptIssuesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockConceptIssuesRepository.Verify(m => m.Remove(It.IsAny<IConceptIssue>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockConceptIssuesRepository = ConceptIssuesMockingSetup.DoMockingSetupForRepository();
            mockConceptIssuesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ConceptIssuesBusinessWorkflow(mockConceptIssuesRepository.Object, new ConceptIssueMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
