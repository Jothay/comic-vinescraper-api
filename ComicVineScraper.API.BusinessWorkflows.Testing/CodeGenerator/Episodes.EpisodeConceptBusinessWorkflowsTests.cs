// <auto-generated>
// <copyright file="Episodes.IEpisodeConceptBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeConceptsRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Episodes
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

    public static class EpisodeConceptsMockingSetup
    {
        public static Mock<IEpisodeConceptModel> DoMockingSetupForEpisodeConceptModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeConceptModel = new Mock<IEpisodeConceptModel>();
            // Mock Functions
            mockEpisodeConceptModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeConceptModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeConceptModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeConceptModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConceptModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConceptModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeConceptModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeConceptModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeConceptModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeConceptModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockEpisodeConceptModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeConceptModel;
        }

        public static Mock<IEpisodeConcept> DoMockingSetupForEpisodeConcept(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeConcept = new Mock<IEpisodeConcept>();
            // Mock Functions
            mockEpisodeConcept.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeConcept.Setup(m => m.Active).Returns(() => true);
            mockEpisodeConcept.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeConcept.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConcept.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeConcept.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeConcept.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeConcept.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeConcept.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeConcept.Setup(m => m.ConceptId).Returns(() => 1);
            mockEpisodeConcept.Setup(m => m.Concept).Returns(() => new Concept());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeConcept;
        }

        public static Mock<IEpisodeConceptsRepository> DoMockingSetupForRepository()
        {
            var mockEpisodeConceptsRepository = new Mock<IEpisodeConceptsRepository>();
            // Mock Functions
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IEpisodeConcept>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IEpisodeConcept>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IEpisodeConcept>>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.Search(It.IsAny<IEpisodeConceptSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeConcept>>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.Add(It.IsAny<IEpisodeConcept>()));
            mockEpisodeConceptsRepository.Setup(m => m.Remove(It.IsAny<IEpisodeConcept>()));
            mockEpisodeConceptsRepository.Setup(m => m.Deactivate(It.IsAny<IEpisodeConcept>()));
            mockEpisodeConceptsRepository.Setup(m => m.Update(It.IsAny<IEpisodeConcept>()));
            // Return
            return mockEpisodeConceptsRepository;
        }
    }

    public class EpisodeConceptsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<EpisodeConceptModel>(person);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<EpisodeConceptModel>(person);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Search_Should_ReturnAListOfEpisodeConcepts()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeConceptSearchModel>();
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Search(It.IsAny<IEpisodeConceptSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Search_AsListing_Should_ReturnAListOfEpisodeConceptsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeConceptSearchModel>();
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Search(It.IsAny<IEpisodeConceptSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            mockEpisodeConceptsRepository.Setup(m => m.Search(It.IsAny<IEpisodeConceptSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeConcept>>().Object);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Add(It.IsAny<IEpisodeConcept>()), Times.Once);
        }
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeConcept = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            mockEpisodeConceptsRepository.Setup(m => m.Search(It.IsAny<IEpisodeConceptSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IEpisodeConcept> { mockEpisodeConcept.Object } );
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeConcept.Object);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Add(It.IsAny<IEpisodeConcept>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockEpisodeConcept = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeConcept.Object);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            var expectedName = "Stephen King (2)";
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockEpisodeConcept.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConcept(1);
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            var model = EpisodeConceptsMockingSetup.DoMockingSetupForEpisodeConceptModel(1);
            IEpisodeConceptModel result = null;
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
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeConcept>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeConcept>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeConcept>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeConcept>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeConcept>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Remove(It.IsAny<IEpisodeConcept>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeConceptsMapper = new Mock<IEpisodeConceptMapper>();
            mockEpisodeConceptsMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeConceptModel>(), It.IsAny<IEpisodeConcept>())).Returns(() => true);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, mockEpisodeConceptsMapper.Object);
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeConcept>().Object);
            mockEpisodeConceptsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockEpisodeConceptsRepository.Verify(m => m.Remove(It.IsAny<IEpisodeConcept>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeConcepts")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockEpisodeConceptsRepository = EpisodeConceptsMockingSetup.DoMockingSetupForRepository();
            mockEpisodeConceptsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new EpisodeConceptsBusinessWorkflow(mockEpisodeConceptsRepository.Object, new EpisodeConceptMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
