// <auto-generated>
// <copyright file="Volumes.IVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Volumes
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

    public static class VolumesMockingSetup
    {
        public static Mock<IVolumeModel> DoMockingSetupForVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolumeModel = new Mock<IVolumeModel>();
            // Mock Functions
            mockVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockVolumeModel.Setup(m => m.Name).Returns(() => name);
            mockVolumeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockVolumeModel.Setup(m => m.Description).Returns(() => "long");
            mockVolumeModel.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockVolumeModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockVolumeModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            mockVolumeModel.Setup(m => m.FirstIssueId).Returns(() => 1);
            mockVolumeModel.Setup(m => m.FirstIssue).Returns(() => new IssueModel());
            mockVolumeModel.Setup(m => m.LastIssueId).Returns(() => 1);
            mockVolumeModel.Setup(m => m.LastIssue).Returns(() => new IssueModel());
            mockVolumeModel.Setup(m => m.PublisherId).Returns(() => 1);
            mockVolumeModel.Setup(m => m.Publisher).Returns(() => new PublisherModel());
            // Associated Objects
            mockVolumeModel.Setup(m => m.Issues).Returns(() => new List<IIssueModel>());
            mockVolumeModel.Setup(m => m.VolumeAliases).Returns(() => new List<IVolumeAliasModel>());
            mockVolumeModel.Setup(m => m.VolumeCharacters).Returns(() => new List<IVolumeCharacterModel>());
            mockVolumeModel.Setup(m => m.VolumeConcepts).Returns(() => new List<IVolumeConceptModel>());
            mockVolumeModel.Setup(m => m.VolumeLocations).Returns(() => new List<IVolumeLocationModel>());
            mockVolumeModel.Setup(m => m.VolumeObjects).Returns(() => new List<IVolumeObjectModel>());
            mockVolumeModel.Setup(m => m.VolumeTeams).Returns(() => new List<IVolumeTeamModel>());
            mockVolumeModel.Setup(m => m.VolumeWriters).Returns(() => new List<IVolumeWriterModel>());
            // Return
            return mockVolumeModel;
        }

        public static Mock<IVolume> DoMockingSetupForVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVolume = new Mock<IVolume>();
            // Mock Functions
            mockVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVolume.Setup(m => m.Active).Returns(() => true);
            mockVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            mockVolume.Setup(m => m.Name).Returns(() => name);
            mockVolume.Setup(m => m.ShortDescription).Returns(() => "short");
            mockVolume.Setup(m => m.Description).Returns(() => "long");
            mockVolume.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockVolume.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockVolume.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockVolume.Setup(m => m.FirstIssueId).Returns(() => 1);
            mockVolume.Setup(m => m.FirstIssue).Returns(() => new Issue());
            mockVolume.Setup(m => m.LastIssueId).Returns(() => 1);
            mockVolume.Setup(m => m.LastIssue).Returns(() => new Issue());
            mockVolume.Setup(m => m.PublisherId).Returns(() => 1);
            mockVolume.Setup(m => m.Publisher).Returns(() => new Publisher());
            // Associated Objects
            mockVolume.Setup(m => m.Issues).Returns(() => new List<IIssue>());
            mockVolume.Setup(m => m.VolumeAliases).Returns(() => new List<IVolumeAlias>());
            mockVolume.Setup(m => m.VolumeCharacters).Returns(() => new List<IVolumeCharacter>());
            mockVolume.Setup(m => m.VolumeConcepts).Returns(() => new List<IVolumeConcept>());
            mockVolume.Setup(m => m.VolumeLocations).Returns(() => new List<IVolumeLocation>());
            mockVolume.Setup(m => m.VolumeObjects).Returns(() => new List<IVolumeObject>());
            mockVolume.Setup(m => m.VolumeTeams).Returns(() => new List<IVolumeTeam>());
            mockVolume.Setup(m => m.VolumeWriters).Returns(() => new List<IVolumeWriter>());
            // Return
            return mockVolume;
        }

        public static Mock<IVolumesRepository> DoMockingSetupForRepository()
        {
            var mockVolumesRepository = new Mock<IVolumesRepository>();
            // Mock Functions
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IVolume>().Object);
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IVolume>().Object);
            mockVolumesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IVolume>>().Object);
            mockVolumesRepository.Setup(m => m.Search(It.IsAny<IVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVolume>>().Object);
            mockVolumesRepository.Setup(m => m.Add(It.IsAny<IVolume>()));
            mockVolumesRepository.Setup(m => m.Remove(It.IsAny<IVolume>()));
            mockVolumesRepository.Setup(m => m.Deactivate(It.IsAny<IVolume>()));
            mockVolumesRepository.Setup(m => m.Update(It.IsAny<IVolume>()));
            // Return
            return mockVolumesRepository;
        }
    }

    public class VolumesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<VolumeModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<VolumeModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfVolumes()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVolumeSearchModel>();
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockVolumesRepository.Verify(m => m.Search(It.IsAny<IVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfVolumesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVolumeSearchModel>();
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockVolumesRepository.Verify(m => m.Search(It.IsAny<IVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            mockVolumesRepository.Setup(m => m.Search(It.IsAny<IVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVolume>>().Object);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            var model = VolumesMockingSetup.DoMockingSetupForVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockVolumesRepository.Verify(m => m.Add(It.IsAny<IVolume>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var mockVolume = VolumesMockingSetup.DoMockingSetupForVolume(1);
            mockVolumesRepository.Setup(m => m.Search(It.IsAny<IVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IVolume> { mockVolume.Object } );
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVolume.Object);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            var model = VolumesMockingSetup.DoMockingSetupForVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockVolumesRepository.Verify(m => m.Add(It.IsAny<IVolume>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockVolume = VolumesMockingSetup.DoMockingSetupForVolume(1);
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVolume.Object);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            var expectedName = "Stephen King (2)";
            var model = VolumesMockingSetup.DoMockingSetupForVolumeModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockVolume.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = VolumesMockingSetup.DoMockingSetupForVolume(1);
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            var model = VolumesMockingSetup.DoMockingSetupForVolumeModel(1);
            IVolumeModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("Stephen King", result.Name);
            Assert.Equal("/TEST/KING-STEPHEN", result.ApiDetailUrl);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolume>().Object);
            mockVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockVolumesRepository.Verify(m => m.Deactivate(It.IsAny<IVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolume>().Object);
            mockVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockVolumesRepository.Verify(m => m.Deactivate(It.IsAny<IVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVolume>().Object);
            mockVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockVolumesRepository.Verify(m => m.Remove(It.IsAny<IVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            var mockVolumesMapper = new Mock<IVolumeMapper>();
            mockVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IVolumeModel>(), It.IsAny<IVolume>())).Returns(() => true);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, mockVolumesMapper.Object);
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVolume>().Object);
            mockVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockVolumesRepository.Verify(m => m.Remove(It.IsAny<IVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockVolumesRepository = VolumesMockingSetup.DoMockingSetupForRepository();
            mockVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new VolumesBusinessWorkflow(mockVolumesRepository.Object, new VolumeMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}