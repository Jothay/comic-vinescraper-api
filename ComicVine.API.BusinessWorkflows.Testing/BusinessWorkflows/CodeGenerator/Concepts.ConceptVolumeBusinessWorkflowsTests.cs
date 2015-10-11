// <auto-generated>
// <copyright file="Concepts.IConceptVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptVolumesRepository Class.</summary>
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

    public static class ConceptVolumesMockingSetup
    {
        public static Mock<IConceptVolumeModel> DoMockingSetupForConceptVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptVolumeModel = new Mock<IConceptVolumeModel>();
            // Mock Functions
            mockConceptVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockConceptVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptVolumeModel.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptVolumeModel.Setup(m => m.Concept).Returns(() => new ConceptModel());
            mockConceptVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockConceptVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockConceptVolumeModel;
        }

        public static Mock<IConceptVolume> DoMockingSetupForConceptVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockConceptVolume = new Mock<IConceptVolume>();
            // Mock Functions
            mockConceptVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockConceptVolume.Setup(m => m.Active).Returns(() => true);
            mockConceptVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockConceptVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockConceptVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockConceptVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockConceptVolume.Setup(m => m.ConceptId).Returns(() => 1);
            mockConceptVolume.Setup(m => m.Concept).Returns(() => new Concept());
            mockConceptVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockConceptVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockConceptVolume;
        }

        public static Mock<IConceptVolumesRepository> DoMockingSetupForRepository()
        {
            var mockConceptVolumesRepository = new Mock<IConceptVolumesRepository>();
            // Mock Functions
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IConceptVolume>().Object);
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IConceptVolume>().Object);
            mockConceptVolumesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IConceptVolume>>().Object);
            mockConceptVolumesRepository.Setup(m => m.Search(It.IsAny<IConceptVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IConceptVolume>>().Object);
            mockConceptVolumesRepository.Setup(m => m.Add(It.IsAny<IConceptVolume>()));
            mockConceptVolumesRepository.Setup(m => m.Remove(It.IsAny<IConceptVolume>()));
            mockConceptVolumesRepository.Setup(m => m.Deactivate(It.IsAny<IConceptVolume>()));
            mockConceptVolumesRepository.Setup(m => m.Update(It.IsAny<IConceptVolume>()));
            // Return
            return mockConceptVolumesRepository;
        }
    }

    public class ConceptVolumesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ConceptVolumeModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ConceptVolumeModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfConceptVolumes()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IConceptVolumeSearchModel>();
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Search(It.IsAny<IConceptVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfConceptVolumesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IConceptVolumeSearchModel>();
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Search(It.IsAny<IConceptVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            mockConceptVolumesRepository.Setup(m => m.Search(It.IsAny<IConceptVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IConceptVolume>>().Object);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Add(It.IsAny<IConceptVolume>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var mockConceptVolume = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            mockConceptVolumesRepository.Setup(m => m.Search(It.IsAny<IConceptVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IConceptVolume> { mockConceptVolume.Object } );
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockConceptVolume.Object);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Add(It.IsAny<IConceptVolume>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockConceptVolume = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockConceptVolume.Object);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            var expectedName = "Stephen King (2)";
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockConceptVolume.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolume(1);
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            var model = ConceptVolumesMockingSetup.DoMockingSetupForConceptVolumeModel(1);
            IConceptVolumeModel result = null;
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
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptVolume>().Object);
            mockConceptVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Deactivate(It.IsAny<IConceptVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptVolume>().Object);
            mockConceptVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Deactivate(It.IsAny<IConceptVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IConceptVolume>().Object);
            mockConceptVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Remove(It.IsAny<IConceptVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            var mockConceptVolumesMapper = new Mock<IConceptVolumeMapper>();
            mockConceptVolumesMapper.Setup(m => m.AreEqual(It.IsAny<IConceptVolumeModel>(), It.IsAny<IConceptVolume>())).Returns(() => true);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, mockConceptVolumesMapper.Object);
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IConceptVolume>().Object);
            mockConceptVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockConceptVolumesRepository.Verify(m => m.Remove(It.IsAny<IConceptVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockConceptVolumesRepository = ConceptVolumesMockingSetup.DoMockingSetupForRepository();
            mockConceptVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ConceptVolumesBusinessWorkflow(mockConceptVolumesRepository.Object, new ConceptVolumeMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}