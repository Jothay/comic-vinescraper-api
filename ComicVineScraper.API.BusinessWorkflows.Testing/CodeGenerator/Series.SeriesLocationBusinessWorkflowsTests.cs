// <auto-generated>
// <copyright file="Series.ISeriesLocationBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesLocationsRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Series
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

    public static class SeriesLocationsMockingSetup
    {
        public static Mock<ISeriesLocationModel> DoMockingSetupForSeriesLocationModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockSeriesLocationModel = new Mock<ISeriesLocationModel>();
            // Mock Functions
            mockSeriesLocationModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeriesLocationModel.Setup(m => m.Active).Returns(() => true);
            mockSeriesLocationModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeriesLocationModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesLocationModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesLocationModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeriesLocationModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockSeriesLocationModel.Setup(m => m.SeriesId).Returns(() => 1);
            mockSeriesLocationModel.Setup(m => m.Series).Returns(() => new SeriesModel());
            mockSeriesLocationModel.Setup(m => m.LocationId).Returns(() => 1);
            mockSeriesLocationModel.Setup(m => m.Location).Returns(() => new LocationModel());
            // Associated Objects
            // <None>
            // Return
            return mockSeriesLocationModel;
        }

        public static Mock<ISeriesLocation> DoMockingSetupForSeriesLocation(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockSeriesLocation = new Mock<ISeriesLocation>();
            // Mock Functions
            mockSeriesLocation.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeriesLocation.Setup(m => m.Active).Returns(() => true);
            mockSeriesLocation.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeriesLocation.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesLocation.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesLocation.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeriesLocation.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockSeriesLocation.Setup(m => m.SeriesId).Returns(() => 1);
            mockSeriesLocation.Setup(m => m.Series).Returns(() => new Series());
            mockSeriesLocation.Setup(m => m.LocationId).Returns(() => 1);
            mockSeriesLocation.Setup(m => m.Location).Returns(() => new Location());
            // Associated Objects
            // <None>
            // Return
            return mockSeriesLocation;
        }

        public static Mock<ISeriesLocationsRepository> DoMockingSetupForRepository()
        {
            var mockSeriesLocationsRepository = new Mock<ISeriesLocationsRepository>();
            // Mock Functions
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ISeriesLocation>().Object);
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ISeriesLocation>().Object);
            mockSeriesLocationsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ISeriesLocation>>().Object);
            mockSeriesLocationsRepository.Setup(m => m.Search(It.IsAny<ISeriesLocationSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ISeriesLocation>>().Object);
            mockSeriesLocationsRepository.Setup(m => m.Add(It.IsAny<ISeriesLocation>()));
            mockSeriesLocationsRepository.Setup(m => m.Remove(It.IsAny<ISeriesLocation>()));
            mockSeriesLocationsRepository.Setup(m => m.Deactivate(It.IsAny<ISeriesLocation>()));
            mockSeriesLocationsRepository.Setup(m => m.Update(It.IsAny<ISeriesLocation>()));
            // Return
            return mockSeriesLocationsRepository;
        }
    }

    public class SeriesLocationsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<SeriesLocationModel>(person);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<SeriesLocationModel>(person);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Search_Should_ReturnAListOfSeriesLocations()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ISeriesLocationSearchModel>();
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Search(It.IsAny<ISeriesLocationSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Search_AsListing_Should_ReturnAListOfSeriesLocationsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ISeriesLocationSearchModel>();
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Search(It.IsAny<ISeriesLocationSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            mockSeriesLocationsRepository.Setup(m => m.Search(It.IsAny<ISeriesLocationSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ISeriesLocation>>().Object);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            var model = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocationModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Add(It.IsAny<ISeriesLocation>()), Times.Once);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var mockSeriesLocation = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocation(1);
            mockSeriesLocationsRepository.Setup(m => m.Search(It.IsAny<ISeriesLocationSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ISeriesLocation> { mockSeriesLocation.Object } );
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockSeriesLocation.Object);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            var model = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocationModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Add(It.IsAny<ISeriesLocation>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockSeriesLocation = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocation(1);
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockSeriesLocation.Object);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            var expectedName = "Stephen King (2)";
            var model = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocationModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockSeriesLocation.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocation(1);
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            var model = SeriesLocationsMockingSetup.DoMockingSetupForSeriesLocationModel(1);
            ISeriesLocationModel result = null;
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
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ISeriesLocation>().Object);
            mockSeriesLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Deactivate(It.IsAny<ISeriesLocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ISeriesLocation>().Object);
            mockSeriesLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Deactivate(It.IsAny<ISeriesLocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ISeriesLocation>().Object);
            mockSeriesLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Remove(It.IsAny<ISeriesLocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            var mockSeriesLocationsMapper = new Mock<ISeriesLocationMapper>();
            mockSeriesLocationsMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesLocationModel>(), It.IsAny<ISeriesLocation>())).Returns(() => true);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, mockSeriesLocationsMapper.Object);
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ISeriesLocation>().Object);
            mockSeriesLocationsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockSeriesLocationsRepository.Verify(m => m.Remove(It.IsAny<ISeriesLocation>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "SeriesLocations")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockSeriesLocationsRepository = SeriesLocationsMockingSetup.DoMockingSetupForRepository();
            mockSeriesLocationsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new SeriesLocationsBusinessWorkflow(mockSeriesLocationsRepository.Object, new SeriesLocationMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
