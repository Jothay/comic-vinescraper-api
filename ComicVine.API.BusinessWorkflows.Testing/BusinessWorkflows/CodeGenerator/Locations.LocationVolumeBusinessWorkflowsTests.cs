// <auto-generated>
// <copyright file="Locations.ILocationVolumeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationVolumesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Locations
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

    public static class LocationVolumesMockingSetup
    {
        public static Mock<ILocationVolumeModel> DoMockingSetupForLocationVolumeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationVolumeModel = new Mock<ILocationVolumeModel>();
            // Mock Functions
            mockLocationVolumeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationVolumeModel.Setup(m => m.Active).Returns(() => true);
            mockLocationVolumeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationVolumeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolumeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolumeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationVolumeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockLocationVolumeModel.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationVolumeModel.Setup(m => m.Location).Returns(() => new LocationModel());
            mockLocationVolumeModel.Setup(m => m.VolumeId).Returns(() => 1);
            mockLocationVolumeModel.Setup(m => m.Volume).Returns(() => new VolumeModel());
            // Associated Objects
            // <None>
            // Return
            return mockLocationVolumeModel;
        }

        public static Mock<ILocationVolume> DoMockingSetupForLocationVolume(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationVolume = new Mock<ILocationVolume>();
            // Mock Functions
            mockLocationVolume.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationVolume.Setup(m => m.Active).Returns(() => true);
            mockLocationVolume.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationVolume.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolume.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationVolume.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationVolume.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockLocationVolume.Setup(m => m.LocationId).Returns(() => 1);
            mockLocationVolume.Setup(m => m.Location).Returns(() => new Location());
            mockLocationVolume.Setup(m => m.VolumeId).Returns(() => 1);
            mockLocationVolume.Setup(m => m.Volume).Returns(() => new Volume());
            // Associated Objects
            // <None>
            // Return
            return mockLocationVolume;
        }

        public static Mock<ILocationVolumesRepository> DoMockingSetupForRepository()
        {
            var mockLocationVolumesRepository = new Mock<ILocationVolumesRepository>();
            // Mock Functions
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ILocationVolume>().Object);
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ILocationVolume>().Object);
            mockLocationVolumesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ILocationVolume>>().Object);
            mockLocationVolumesRepository.Setup(m => m.Search(It.IsAny<ILocationVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ILocationVolume>>().Object);
            mockLocationVolumesRepository.Setup(m => m.Add(It.IsAny<ILocationVolume>()));
            mockLocationVolumesRepository.Setup(m => m.Remove(It.IsAny<ILocationVolume>()));
            mockLocationVolumesRepository.Setup(m => m.Deactivate(It.IsAny<ILocationVolume>()));
            mockLocationVolumesRepository.Setup(m => m.Update(It.IsAny<ILocationVolume>()));
            // Return
            return mockLocationVolumesRepository;
        }
    }

    public class LocationVolumesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<LocationVolumeModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<LocationVolumeModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfLocationVolumes()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ILocationVolumeSearchModel>();
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Search(It.IsAny<ILocationVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfLocationVolumesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ILocationVolumeSearchModel>();
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Search(It.IsAny<ILocationVolumeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            mockLocationVolumesRepository.Setup(m => m.Search(It.IsAny<ILocationVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ILocationVolume>>().Object);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Add(It.IsAny<ILocationVolume>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var mockLocationVolume = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            mockLocationVolumesRepository.Setup(m => m.Search(It.IsAny<ILocationVolumeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ILocationVolume> { mockLocationVolume.Object } );
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockLocationVolume.Object);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Add(It.IsAny<ILocationVolume>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockLocationVolume = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockLocationVolume.Object);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            var expectedName = "Stephen King (2)";
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockLocationVolume.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = LocationVolumesMockingSetup.DoMockingSetupForLocationVolume(1);
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            var model = LocationVolumesMockingSetup.DoMockingSetupForLocationVolumeModel(1);
            ILocationVolumeModel result = null;
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
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ILocationVolume>().Object);
            mockLocationVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Deactivate(It.IsAny<ILocationVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ILocationVolume>().Object);
            mockLocationVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Deactivate(It.IsAny<ILocationVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ILocationVolume>().Object);
            mockLocationVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Remove(It.IsAny<ILocationVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            var mockLocationVolumesMapper = new Mock<ILocationVolumeMapper>();
            mockLocationVolumesMapper.Setup(m => m.AreEqual(It.IsAny<ILocationVolumeModel>(), It.IsAny<ILocationVolume>())).Returns(() => true);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, mockLocationVolumesMapper.Object);
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ILocationVolume>().Object);
            mockLocationVolumesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockLocationVolumesRepository.Verify(m => m.Remove(It.IsAny<ILocationVolume>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockLocationVolumesRepository = LocationVolumesMockingSetup.DoMockingSetupForRepository();
            mockLocationVolumesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new LocationVolumesBusinessWorkflow(mockLocationVolumesRepository.Object, new LocationVolumeMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
