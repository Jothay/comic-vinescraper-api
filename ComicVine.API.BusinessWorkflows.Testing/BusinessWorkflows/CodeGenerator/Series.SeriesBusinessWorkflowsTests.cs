// <auto-generated>
// <copyright file="Series.ISeriesRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Series
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

    public static class SeriesMockingSetup
    {
        public static Mock<ISeriesModel> DoMockingSetupForSeriesModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockSeriesModel = new Mock<ISeriesModel>();
            // Mock Functions
            mockSeriesModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeriesModel.Setup(m => m.Active).Returns(() => true);
            mockSeriesModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeriesModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeriesModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeriesModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockSeriesModel.Setup(m => m.Name).Returns(() => name);
            mockSeriesModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockSeriesModel.Setup(m => m.Description).Returns(() => "long");
            mockSeriesModel.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockSeriesModel.Setup(m => m.PublisherId).Returns(() => 1);
            mockSeriesModel.Setup(m => m.Publisher).Returns(() => new PublisherModel());
            mockSeriesModel.Setup(m => m.FirstEpisodeId).Returns(() => 1);
            mockSeriesModel.Setup(m => m.FirstEpisode).Returns(() => new EpisodeModel());
            mockSeriesModel.Setup(m => m.LastEpisodeId).Returns(() => 1);
            mockSeriesModel.Setup(m => m.LastEpisode).Returns(() => new EpisodeModel());
            // Associated Objects
            mockSeriesModel.Setup(m => m.Episodes).Returns(() => new List<IEpisodeModel>());
            mockSeriesModel.Setup(m => m.SeriesAliases).Returns(() => new List<ISeriesAliasModel>());
            mockSeriesModel.Setup(m => m.SeriesCharacters).Returns(() => new List<ISeriesCharacterModel>());
            mockSeriesModel.Setup(m => m.SeriesLocations).Returns(() => new List<ISeriesLocationModel>());
            // Return
            return mockSeriesModel;
        }

        public static Mock<ISeries> DoMockingSetupForSeries(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockSeries = new Mock<ISeries>();
            // Mock Functions
            mockSeries.Setup(m => m.Id).Returns(() => idReturnValue);
            mockSeries.Setup(m => m.Active).Returns(() => true);
            mockSeries.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockSeries.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeries.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockSeries.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockSeries.Setup(m => m.UpdatedDate).Returns(() => null);
            mockSeries.Setup(m => m.Name).Returns(() => name);
            mockSeries.Setup(m => m.ShortDescription).Returns(() => "short");
            mockSeries.Setup(m => m.Description).Returns(() => "long");
            mockSeries.Setup(m => m.Startyear).Returns(() => 2000);
            // Related Objects
            mockSeries.Setup(m => m.PublisherId).Returns(() => 1);
            mockSeries.Setup(m => m.Publisher).Returns(() => new Publisher());
            mockSeries.Setup(m => m.FirstEpisodeId).Returns(() => 1);
            mockSeries.Setup(m => m.FirstEpisode).Returns(() => new Episode());
            mockSeries.Setup(m => m.LastEpisodeId).Returns(() => 1);
            mockSeries.Setup(m => m.LastEpisode).Returns(() => new Episode());
            // Associated Objects
            mockSeries.Setup(m => m.Episodes).Returns(() => new List<IEpisode>());
            mockSeries.Setup(m => m.SeriesAliases).Returns(() => new List<ISeriesAlias>());
            mockSeries.Setup(m => m.SeriesCharacters).Returns(() => new List<ISeriesCharacter>());
            mockSeries.Setup(m => m.SeriesLocations).Returns(() => new List<ISeriesLocation>());
            // Return
            return mockSeries;
        }

        public static Mock<ISeriesRepository> DoMockingSetupForRepository()
        {
            var mockSeriesRepository = new Mock<ISeriesRepository>();
            // Mock Functions
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ISeries>().Object);
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ISeries>().Object);
            mockSeriesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ISeries>>().Object);
            mockSeriesRepository.Setup(m => m.Search(It.IsAny<ISeriesSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ISeries>>().Object);
            mockSeriesRepository.Setup(m => m.Add(It.IsAny<ISeries>()));
            mockSeriesRepository.Setup(m => m.Remove(It.IsAny<ISeries>()));
            mockSeriesRepository.Setup(m => m.Deactivate(It.IsAny<ISeries>()));
            mockSeriesRepository.Setup(m => m.Update(It.IsAny<ISeries>()));
            // Return
            return mockSeriesRepository;
        }
    }

    public class SeriesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<SeriesModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<SeriesModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfSeries()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ISeriesSearchModel>();
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockSeriesRepository.Verify(m => m.Search(It.IsAny<ISeriesSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfSeriesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ISeriesSearchModel>();
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockSeriesRepository.Verify(m => m.Search(It.IsAny<ISeriesSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            mockSeriesRepository.Setup(m => m.Search(It.IsAny<ISeriesSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ISeries>>().Object);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockSeriesRepository.Verify(m => m.Add(It.IsAny<ISeries>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var mockSeries = SeriesMockingSetup.DoMockingSetupForSeries(1);
            mockSeriesRepository.Setup(m => m.Search(It.IsAny<ISeriesSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ISeries> { mockSeries.Object } );
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockSeries.Object);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockSeriesRepository.Verify(m => m.Add(It.IsAny<ISeries>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockSeries = SeriesMockingSetup.DoMockingSetupForSeries(1);
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockSeries.Object);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            var expectedName = "Stephen King (2)";
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockSeries.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = SeriesMockingSetup.DoMockingSetupForSeries(1);
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            var model = SeriesMockingSetup.DoMockingSetupForSeriesModel(1);
            ISeriesModel result = null;
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
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ISeries>().Object);
            mockSeriesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockSeriesRepository.Verify(m => m.Deactivate(It.IsAny<ISeries>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ISeries>().Object);
            mockSeriesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockSeriesRepository.Verify(m => m.Deactivate(It.IsAny<ISeries>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ISeries>().Object);
            mockSeriesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockSeriesRepository.Verify(m => m.Remove(It.IsAny<ISeries>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            var mockSeriesMapper = new Mock<ISeriesMapper>();
            mockSeriesMapper.Setup(m => m.AreEqual(It.IsAny<ISeriesModel>(), It.IsAny<ISeries>())).Returns(() => true);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, mockSeriesMapper.Object);
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ISeries>().Object);
            mockSeriesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockSeriesRepository.Verify(m => m.Remove(It.IsAny<ISeries>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockSeriesRepository = SeriesMockingSetup.DoMockingSetupForRepository();
            mockSeriesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new SeriesBusinessWorkflow(mockSeriesRepository.Object, new SeriesMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
