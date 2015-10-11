// <auto-generated>
// <copyright file="Episodes.IEpisodeCharacterFirstAppearanceRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeCharacterFirstAppearancesRepository Class.</summary>
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

    public static class EpisodeCharacterFirstAppearancesMockingSetup
    {
        public static Mock<IEpisodeCharacterFirstAppearanceModel> DoMockingSetupForEpisodeCharacterFirstAppearanceModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeCharacterFirstAppearanceModel = new Mock<IEpisodeCharacterFirstAppearanceModel>();
            // Mock Functions
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockEpisodeCharacterFirstAppearanceModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeCharacterFirstAppearanceModel;
        }

        public static Mock<IEpisodeCharacterFirstAppearance> DoMockingSetupForEpisodeCharacterFirstAppearance(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodeCharacterFirstAppearance = new Mock<IEpisodeCharacterFirstAppearance>();
            // Mock Functions
            mockEpisodeCharacterFirstAppearance.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodeCharacterFirstAppearance.Setup(m => m.Active).Returns(() => true);
            mockEpisodeCharacterFirstAppearance.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodeCharacterFirstAppearance.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterFirstAppearance.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodeCharacterFirstAppearance.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodeCharacterFirstAppearance.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockEpisodeCharacterFirstAppearance.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodeCharacterFirstAppearance.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodeCharacterFirstAppearance.Setup(m => m.CharacterId).Returns(() => 1);
            mockEpisodeCharacterFirstAppearance.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodeCharacterFirstAppearance;
        }

        public static Mock<IEpisodeCharacterFirstAppearancesRepository> DoMockingSetupForRepository()
        {
            var mockEpisodeCharacterFirstAppearancesRepository = new Mock<IEpisodeCharacterFirstAppearancesRepository>();
            // Mock Functions
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IEpisodeCharacterFirstAppearance>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IEpisodeCharacterFirstAppearance>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IEpisodeCharacterFirstAppearance>>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Search(It.IsAny<IEpisodeCharacterFirstAppearanceSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeCharacterFirstAppearance>>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Add(It.IsAny<IEpisodeCharacterFirstAppearance>()));
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Remove(It.IsAny<IEpisodeCharacterFirstAppearance>()));
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Deactivate(It.IsAny<IEpisodeCharacterFirstAppearance>()));
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Update(It.IsAny<IEpisodeCharacterFirstAppearance>()));
            // Return
            return mockEpisodeCharacterFirstAppearancesRepository;
        }
    }

    public class EpisodeCharacterFirstAppearancesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<EpisodeCharacterFirstAppearanceModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<EpisodeCharacterFirstAppearanceModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfEpisodeCharacterFirstAppearances()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeCharacterFirstAppearanceSearchModel>();
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Search(It.IsAny<IEpisodeCharacterFirstAppearanceSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfEpisodeCharacterFirstAppearancesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IEpisodeCharacterFirstAppearanceSearchModel>();
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Search(It.IsAny<IEpisodeCharacterFirstAppearanceSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Search(It.IsAny<IEpisodeCharacterFirstAppearanceSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IEpisodeCharacterFirstAppearance>>().Object);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            var model = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearanceModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Add(It.IsAny<IEpisodeCharacterFirstAppearance>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeCharacterFirstAppearance = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearance(1);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Search(It.IsAny<IEpisodeCharacterFirstAppearanceSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IEpisodeCharacterFirstAppearance> { mockEpisodeCharacterFirstAppearance.Object } );
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeCharacterFirstAppearance.Object);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            var model = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearanceModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Add(It.IsAny<IEpisodeCharacterFirstAppearance>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearance = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearance(1);
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockEpisodeCharacterFirstAppearance.Object);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            var expectedName = "Stephen King (2)";
            var model = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearanceModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockEpisodeCharacterFirstAppearance.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearance(1);
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            var model = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForEpisodeCharacterFirstAppearanceModel(1);
            IEpisodeCharacterFirstAppearanceModel result = null;
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
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeCharacterFirstAppearance>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeCharacterFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeCharacterFirstAppearance>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Deactivate(It.IsAny<IEpisodeCharacterFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IEpisodeCharacterFirstAppearance>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Remove(It.IsAny<IEpisodeCharacterFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            var mockEpisodeCharacterFirstAppearancesMapper = new Mock<IEpisodeCharacterFirstAppearanceMapper>();
            mockEpisodeCharacterFirstAppearancesMapper.Setup(m => m.AreEqual(It.IsAny<IEpisodeCharacterFirstAppearanceModel>(), It.IsAny<IEpisodeCharacterFirstAppearance>())).Returns(() => true);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, mockEpisodeCharacterFirstAppearancesMapper.Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IEpisodeCharacterFirstAppearance>().Object);
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockEpisodeCharacterFirstAppearancesRepository.Verify(m => m.Remove(It.IsAny<IEpisodeCharacterFirstAppearance>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockEpisodeCharacterFirstAppearancesRepository = EpisodeCharacterFirstAppearancesMockingSetup.DoMockingSetupForRepository();
            mockEpisodeCharacterFirstAppearancesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new EpisodeCharacterFirstAppearancesBusinessWorkflow(mockEpisodeCharacterFirstAppearancesRepository.Object, new EpisodeCharacterFirstAppearanceMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
