// <auto-generated>
// <copyright file="Teams.ITeamVolumeBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamVolumesRepository Class.</summary>
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

    public static class TeamVolumesMockingSetup
    {
        public static Mock<ITeamVolumeModel> DoMockingSetupForTeamVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamVolumeModel = new Mock<ITeamVolumeModel>();
            // Mock Functions
            mockTeamVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockTeamVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamVolumeModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamVolumeModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockTeamVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamVolumeModel;
        }

        public static Mock<ITeamVolume> DoMockingSetupForTeamVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamVolume = new Mock<ITeamVolume>();
            // Mock Functions
            mockTeamVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamVolume.Setup(m => m.Active).Returns(() => true);
            mockTeamVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamVolume.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamVolume.Setup(m => m.Team).Returns(() => new Team());
            mockTeamVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockTeamVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockTeamVolume;
        }

        public static Mock<ITeamVolumesRepository> DoMockingSetupForRepository()
        {
            var mockTeamVolumesRepository = new Mock<ITeamVolumesRepository>();
            // Mock Functions
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ITeamVolume>().Object);
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ITeamVolume>().Object);
            mockTeamVolumesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ITeamVolume>>().Object);
            mockTeamVolumesRepository.Setup(m => m.Search(It.IsAny<ITeamVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeamVolume>>().Object);
            mockTeamVolumesRepository.Setup(m => m.Add(It.IsAny<ITeamVolume>()));
            mockTeamVolumesRepository.Setup(m => m.Remove(It.IsAny<ITeamVolume>()));
            mockTeamVolumesRepository.Setup(m => m.Deactivate(It.IsAny<ITeamVolume>()));
            mockTeamVolumesRepository.Setup(m => m.Update(It.IsAny<ITeamVolume>()));
            // Return
            return mockTeamVolumesRepository;
        }
    }

    public class TeamVolumesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<TeamVolumeModel>(person);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<TeamVolumeModel>(person);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Search_Should_ReturnAListOfTeamVolumes()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamVolumeSearchModel>();
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Search(It.IsAny<ITeamVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Search_AsListing_Should_ReturnAListOfTeamVolumesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamVolumeSearchModel>();
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Search(It.IsAny<ITeamVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            mockTeamVolumesRepository.Setup(m => m.Search(It.IsAny<ITeamVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeamVolume>>().Object);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Add(It.IsAny<ITeamVolume>()), Times.Once);
        }
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var mockTeamVolume = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            mockTeamVolumesRepository.Setup(m => m.Search(It.IsAny<ITeamVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ITeamVolume> { mockTeamVolume.Object } );
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeamVolume.Object);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Add(It.IsAny<ITeamVolume>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockTeamVolume = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeamVolume.Object);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            var expectedName = "Stephen King (2)";
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockTeamVolume.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = TeamVolumesMockingSetup.DoMockingSetupForTeamVolume(1);
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            var model = TeamVolumesMockingSetup.DoMockingSetupForTeamVolumeModel(1);
            ITeamVolumeModel result = null;
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
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamVolume>().Object);
            mockTeamVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Deactivate(It.IsAny<ITeamVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamVolume>().Object);
            mockTeamVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Deactivate(It.IsAny<ITeamVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamVolume>().Object);
            mockTeamVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Remove(It.IsAny<ITeamVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            var mockTeamVolumesMapper = new Mock<ITeamVolumeMapper>();
            mockTeamVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ITeamVolumeModel>(), It.IsAny<ITeamVolume>())).Returns(() => true);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, mockTeamVolumesMapper.Object);
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamVolume>().Object);
            mockTeamVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockTeamVolumesRepository.Verify(m => m.Remove(It.IsAny<ITeamVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "TeamVolumes")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockTeamVolumesRepository = TeamVolumesMockingSetup.DoMockingSetupForRepository();
            mockTeamVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new TeamVolumesBusinessWorkflow(mockTeamVolumesRepository.Object, new TeamVolumeMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}