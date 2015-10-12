// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcFirstAppearanceRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeStoryArcFirstAppearancesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Episodes
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

    public static class EpisodeStoryArcFirstAppearancesMockingSetup
    {
        public static Mock<IEpisodeStoryArcFirstAppearanceModel> DoMockingSetupForEpisodeStoryArcFirstAppearanceModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeStoryArcFirstAppearanceModel = new Mock<IEpisodeStoryArcFirstAppearanceModel>();
            // Mock Functions
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockEpisodeStoryArcFirstAppearanceModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeStoryArcFirstAppearanceModel;
        }

        public static Mock<IEpisodeStoryArcFirstAppearance> DoMockingSetupForEpisodeStoryArcFirstAppearance(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeStoryArcFirstAppearance = new Mock<IEpisodeStoryArcFirstAppearance>();
            // Mock Functions
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.Active).Returns(() => true);
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.StoryArcId).Returns(() => 1);
            mockEpisodeStoryArcFirstAppearance.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeStoryArcFirstAppearance;
        }

        public static Mock<IEpisodeStoryArcFirstAppearancesRepository> DoMockingSetupForRepository()
        {
            var mockEpisodeStoryArcFirstAppearancesRepository = new Mock<IEpisodeStoryArcFirstAppearancesRepository>();
            // Mock Functions
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IEpisodeStoryArcFirstAppearance>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IEpisodeStoryArcFirstAppearance>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IEpisodeStoryArcFirstAppearance>>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Search(It.IsAny<IEpisodeStoryArcFirstAppearanceSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeStoryArcFirstAppearance>>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Add(It.IsAny<IEpisodeStoryArcFirstAppearance>()));
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Remove(It.IsAny<IEpisodeStoryArcFirstAppearance>()));
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Deactivate(It.IsAny<IEpisodeStoryArcFirstAppearance>()));
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Update(It.IsAny<IEpisodeStoryArcFirstAppearance>()));
            // Return
            return mockEpisodeStoryArcFirstAppearancesRepository;
        }
    }

    public class EpisodeStoryArcFirstAppearancesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<EpisodeStoryArcFirstAppearanceModel>(person);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<EpisodeStoryArcFirstAppearanceModel>(person);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Search_Should_ReturnAListOfEpisodeStoryArcFirstAppearances()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeStoryArcFirstAppearanceSearchModel>();
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Search(It.IsAny<IEpisodeStoryArcFirstAppearanceSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Search_AsListing_Should_ReturnAListOfEpisodeStoryArcFirstAppearancesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeStoryArcFirstAppearanceSearchModel>();
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Search(It.IsAny<IEpisodeStoryArcFirstAppearanceSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Search(It.IsAny<IEpisodeStoryArcFirstAppearanceSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeStoryArcFirstAppearance>>().Object);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            var model = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearanceModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Add(It.IsAny<IEpisodeStoryArcFirstAppearance>()), Times.Once);
        }
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeStoryArcFirstAppearance = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearance(1);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Search(It.IsAny<IEpisodeStoryArcFirstAppearanceSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IEpisodeStoryArcFirstAppearance> { mockEpisodeStoryArcFirstAppearance.Object } );
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeStoryArcFirstAppearance.Object);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            var model = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearanceModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Add(It.IsAny<IEpisodeStoryArcFirstAppearance>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearance = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearance(1);
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeStoryArcFirstAppearance.Object);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            var expectedName = "Stephen King (2)";
            var model = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearanceModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockEpisodeStoryArcFirstAppearance.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearance(1);
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            var model = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForEpisodeStoryArcFirstAppearanceModel(1);
            IEpisodeStoryArcFirstAppearanceModel result = null;
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
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeStoryArcFirstAppearance>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeStoryArcFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeStoryArcFirstAppearance>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeStoryArcFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeStoryArcFirstAppearance>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Remove(It.IsAny<IEpisodeStoryArcFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeStoryArcFirstAppearancesMapper = new Mock<IEpisodeStoryArcFirstAppearanceMapper>();
            mockEpisodeStoryArcFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeStoryArcFirstAppearanceModel>(), It.IsAny<IEpisodeStoryArcFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, mockEpisodeStoryArcFirstAppearancesMapper.Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeStoryArcFirstAppearance>().Object);
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockEpisodeStoryArcFirstAppearancesRepository.Verify(m => m.Remove(It.IsAny<IEpisodeStoryArcFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "EpisodeStoryArcFirstAppearances")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockEpisodeStoryArcFirstAppearancesRepository = EpisodeStoryArcFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeStoryArcFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new EpisodeStoryArcFirstAppearancesBusinessWorkflow(mockEpisodeStoryArcFirstAppearancesRepository.Object, new EpisodeStoryArcFirstAppearanceMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
