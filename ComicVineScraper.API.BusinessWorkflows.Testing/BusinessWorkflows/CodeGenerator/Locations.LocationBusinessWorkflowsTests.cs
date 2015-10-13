// <auto-generated>
// <copyright file="Locations.ILocationRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationsRepository Class.</summary>
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

    public static class LocationsMockingSetup
    {
        public static Mock<ILocationModel> DoMockingSetupForLocationModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocationModel = new Mock<ILocationModel>();
            // Mock Functions
            mockLocationModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocationModel.Setup(m => m.Active).Returns(() => true);
            mockLocationModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocationModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocationModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocationModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockLocationModel.Setup(m => m.Name).Returns(() => name);
            mockLocationModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockLocationModel.Setup(m => m.Description).Returns(() => "long");
            mockLocationModel.Setup(m => m.StartYear).Returns(() => 2000);
            // Related Objects
            mockLocationModel.Setup(m => m.FirstIssueAppearanceId).Returns(() => 1);
            mockLocationModel.Setup(m => m.FirstIssueAppearance).Returns(() => new IssueModel());
            mockLocationModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockLocationModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            // Associated Objects
            mockLocationModel.Setup(m => m.LocationAliases).Returns(() => new List<ILocationAliasModel>());
            mockLocationModel.Setup(m => m.LocationAppearedInIssues).Returns(() => new List<ILocationAppearedInIssueModel>());
            mockLocationModel.Setup(m => m.LocationIssues).Returns(() => new List<ILocationIssueModel>());
            mockLocationModel.Setup(m => m.LocationMovies).Returns(() => new List<ILocationMovieModel>());
            mockLocationModel.Setup(m => m.LocationStoryArcs).Returns(() => new List<ILocationStoryArcModel>());
            mockLocationModel.Setup(m => m.LocationVolumes).Returns(() => new List<ILocationVolumeModel>());
            // Return
            return mockLocationModel;
        }

        public static Mock<ILocation> DoMockingSetupForLocation(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockLocation = new Mock<ILocation>();
            // Mock Functions
            mockLocation.Setup(m => m.Id).Returns(() => idReturnValue);
            mockLocation.Setup(m => m.Active).Returns(() => true);
            mockLocation.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockLocation.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocation.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockLocation.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockLocation.Setup(m => m.UpdatedDate).Returns(() => null);
            mockLocation.Setup(m => m.Name).Returns(() => name);
            mockLocation.Setup(m => m.ShortDescription).Returns(() => "short");
            mockLocation.Setup(m => m.Description).Returns(() => "long");
            mockLocation.Setup(m => m.StartYear).Returns(() => 2000);
            // Related Objects
            mockLocation.Setup(m => m.FirstIssueAppearanceId).Returns(() => 1);
            mockLocation.Setup(m => m.FirstIssueAppearance).Returns(() => new Issue());
            mockLocation.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockLocation.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            // Associated Objects
            mockLocation.Setup(m => m.LocationAliases).Returns(() => new List<ILocationAlias>());
            mockLocation.Setup(m => m.LocationAppearedInIssues).Returns(() => new List<ILocationAppearedInIssue>());
            mockLocation.Setup(m => m.LocationIssues).Returns(() => new List<ILocationIssue>());
            mockLocation.Setup(m => m.LocationMovies).Returns(() => new List<ILocationMovie>());
            mockLocation.Setup(m => m.LocationStoryArcs).Returns(() => new List<ILocationStoryArc>());
            mockLocation.Setup(m => m.LocationVolumes).Returns(() => new List<ILocationVolume>());
            // Return
            return mockLocation;
        }

        public static Mock<ILocationsRepository> DoMockingSetupForRepository()
        {
            var mockLocationsRepository = new Mock<ILocationsRepository>();
            // Mock Functions
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ILocation>().Object);
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ILocation>().Object);
            mockLocationsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ILocation>>().Object);
            mockLocationsRepository.Setup(m => m.Search(It.IsAny<ILocationSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ILocation>>().Object);
            mockLocationsRepository.Setup(m => m.Add(It.IsAny<ILocation>()));
            mockLocationsRepository.Setup(m => m.Remove(It.IsAny<ILocation>()));
            mockLocationsRepository.Setup(m => m.Deactivate(It.IsAny<ILocation>()));
            mockLocationsRepository.Setup(m => m.Update(It.IsAny<ILocation>()));
            // Return
            return mockLocationsRepository;
        }
    }

    public class LocationsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "Locations")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<LocationModel>(person);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<LocationModel>(person);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Search_Should_ReturnAListOfLocations()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ILocationSearchModel>();
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockLocationsRepository.Verify(m => m.Search(It.IsAny<ILocationSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Search_AsListing_Should_ReturnAListOfLocationsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ILocationSearchModel>();
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockLocationsRepository.Verify(m => m.Search(It.IsAny<ILocationSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "Locations")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            mockLocationsRepository.Setup(m => m.Search(It.IsAny<ILocationSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ILocation>>().Object);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            var model = LocationsMockingSetup.DoMockingSetupForLocationModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockLocationsRepository.Verify(m => m.Add(It.IsAny<ILocation>()), Times.Once);
        }
        [Fact][Trait("Category", "Locations")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var mockLocation = LocationsMockingSetup.DoMockingSetupForLocation(1);
            mockLocationsRepository.Setup(m => m.Search(It.IsAny<ILocationSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ILocation> { mockLocation.Object } );
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockLocation.Object);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            var model = LocationsMockingSetup.DoMockingSetupForLocationModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockLocationsRepository.Verify(m => m.Add(It.IsAny<ILocation>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "Locations")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockLocation = LocationsMockingSetup.DoMockingSetupForLocation(1);
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockLocation.Object);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            var expectedName = "Stephen King (2)";
            var model = LocationsMockingSetup.DoMockingSetupForLocationModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockLocation.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "Locations")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = LocationsMockingSetup.DoMockingSetupForLocation(1);
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            var model = LocationsMockingSetup.DoMockingSetupForLocationModel(1);
            ILocationModel result = null;
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
        [Fact][Trait("Category", "Locations")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ILocation>().Object);
            mockLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockLocationsRepository.Verify(m => m.Deactivate(It.IsAny<ILocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ILocation>().Object);
            mockLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockLocationsRepository.Verify(m => m.Deactivate(It.IsAny<ILocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "Locations")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ILocation>().Object);
            mockLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockLocationsRepository.Verify(m => m.Remove(It.IsAny<ILocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            var mockLocationsMapper = new Mock<ILocationMapper>();
            mockLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ILocationModel>(), It.IsAny<ILocation>())).Returns(() => true);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, mockLocationsMapper.Object);
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ILocation>().Object);
            mockLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockLocationsRepository.Verify(m => m.Remove(It.IsAny<ILocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Locations")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockLocationsRepository = LocationsMockingSetup.DoMockingSetupForRepository();
            mockLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new LocationsBusinessWorkflow(mockLocationsRepository.Object, new LocationMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}