// <auto-generated>
// <copyright file="Episodes.IEpisodeAliasBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeAliasesRepository Class.</summary>
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

    public static class EpisodeAliasesMockingSetup
    {
        public static Mock<IEpisodeAliasModel> DoMockingSetupForEpisodeAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeAliasModel = new Mock<IEpisodeAliasModel>();
            // Mock Functions
            mockEpisodeAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeAliasModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeAliasModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeAliasModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeAliasModel;
        }

        public static Mock<IEpisodeAlias> DoMockingSetupForEpisodeAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeAlias = new Mock<IEpisodeAlias>();
            // Mock Functions
            mockEpisodeAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeAlias.Setup(m => m.Active).Returns(() => true);
            mockEpisodeAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeAlias.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeAlias.Setup(m => m.Episode).Returns(() => new Episode());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeAlias;
        }

        public static Mock<IEpisodeAliasesRepository> DoMockingSetupForRepository()
        {
            var mockEpisodeAliasesRepository = new Mock<IEpisodeAliasesRepository>();
            // Mock Functions
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IEpisodeAlias>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IEpisodeAlias>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IEpisodeAlias>>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.Search(It.IsAny<IEpisodeAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeAlias>>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.Add(It.IsAny<IEpisodeAlias>()));
            mockEpisodeAliasesRepository.Setup(m => m.Remove(It.IsAny<IEpisodeAlias>()));
            mockEpisodeAliasesRepository.Setup(m => m.Deactivate(It.IsAny<IEpisodeAlias>()));
            mockEpisodeAliasesRepository.Setup(m => m.Update(It.IsAny<IEpisodeAlias>()));
            // Return
            return mockEpisodeAliasesRepository;
        }
    }

    public class EpisodeAliasesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<EpisodeAliasModel>(person);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<EpisodeAliasModel>(person);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Search_Should_ReturnAListOfEpisodeAliases()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeAliasSearchModel>();
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Search(It.IsAny<IEpisodeAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Search_AsListing_Should_ReturnAListOfEpisodeAliasesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeAliasSearchModel>();
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Search(It.IsAny<IEpisodeAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeAliasesRepository.Setup(m => m.Search(It.IsAny<IEpisodeAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeAlias>>().Object);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Add(It.IsAny<IEpisodeAlias>()), Times.Once);
        }
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeAlias = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            mockEpisodeAliasesRepository.Setup(m => m.Search(It.IsAny<IEpisodeAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IEpisodeAlias> { mockEpisodeAlias.Object } );
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeAlias.Object);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Add(It.IsAny<IEpisodeAlias>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockEpisodeAlias = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeAlias.Object);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            var expectedName = "Stephen King (2)";
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockEpisodeAlias.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAlias(1);
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            var model = EpisodeAliasesMockingSetup.DoMockingSetupForEpisodeAliasModel(1);
            IEpisodeAliasModel result = null;
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
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeAlias>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeAlias>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeAlias>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Remove(It.IsAny<IEpisodeAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeAliasesMapper = new Mock<IEpisodeAliasMapper>();
            mockEpisodeAliasesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeAliasModel>(), It.IsAny<IEpisodeAlias>())).Returns(() => true);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, mockEpisodeAliasesMapper.Object);
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeAlias>().Object);
            mockEpisodeAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockEpisodeAliasesRepository.Verify(m => m.Remove(It.IsAny<IEpisodeAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeAliases")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockEpisodeAliasesRepository = EpisodeAliasesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new EpisodeAliasesBusinessWorkflow(mockEpisodeAliasesRepository.Object, new EpisodeAliasMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
