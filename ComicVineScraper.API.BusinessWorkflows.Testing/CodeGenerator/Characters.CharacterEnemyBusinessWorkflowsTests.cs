


// <auto-generated>
// <copyright file="Characters.ICharacterEnemyBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemiesRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Characters
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

    public static class CharacterEnemiesMockingSetup
    {
        public static Mock<ICharacterEnemyModel> DoMockingSetupForCharacterEnemyModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterEnemyModel = new Mock<ICharacterEnemyModel>();
            // Mock Functions
            mockCharacterEnemyModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterEnemyModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterEnemyModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterEnemyModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemyModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemyModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterEnemyModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterEnemyModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterEnemyModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterEnemyModel.Setup(m => m.EnemyId).Returns(() => 1);
            mockCharacterEnemyModel.Setup(m => m.Enemy).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterEnemyModel;
        }

        public static Mock<ICharacterEnemy> DoMockingSetupForCharacterEnemy(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterEnemy = new Mock<ICharacterEnemy>();
            // Mock Functions
            mockCharacterEnemy.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterEnemy.Setup(m => m.Active).Returns(() => true);
            mockCharacterEnemy.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterEnemy.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemy.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterEnemy.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterEnemy.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterEnemy.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterEnemy.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterEnemy.Setup(m => m.EnemyId).Returns(() => 1);
            mockCharacterEnemy.Setup(m => m.Enemy).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterEnemy;
        }

        public static Mock<ICharacterEnemiesRepository> DoMockingSetupForRepository()
        {
            var mockCharacterEnemiesRepository = new Mock<ICharacterEnemiesRepository>();
            // Mock Functions
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICharacterEnemy>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICharacterEnemy>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICharacterEnemy>>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.Search(It.IsAny<ICharacterEnemySearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterEnemy>>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.Add(It.IsAny<ICharacterEnemy>()));
            mockCharacterEnemiesRepository.Setup(m => m.Remove(It.IsAny<ICharacterEnemy>()));
            mockCharacterEnemiesRepository.Setup(m => m.Deactivate(It.IsAny<ICharacterEnemy>()));
            mockCharacterEnemiesRepository.Setup(m => m.Update(It.IsAny<ICharacterEnemy>()));
            // Return
            return mockCharacterEnemiesRepository;
        }
    }

    public class CharacterEnemiesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CharacterEnemyModel>(person);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CharacterEnemyModel>(person);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Search_Should_ReturnAListOfCharacterEnemies()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterEnemySearchModel>();
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Search(It.IsAny<ICharacterEnemySearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCharacterEnemiesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterEnemySearchModel>();
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Search(It.IsAny<ICharacterEnemySearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            mockCharacterEnemiesRepository.Setup(m => m.Search(It.IsAny<ICharacterEnemySearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterEnemy>>().Object);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            var model = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemyModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Add(It.IsAny<ICharacterEnemy>()), Times.Once);
        }
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterEnemy = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemy(1);
            mockCharacterEnemiesRepository.Setup(m => m.Search(It.IsAny<ICharacterEnemySearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICharacterEnemy> { mockCharacterEnemy.Object } );
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterEnemy.Object);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            var model = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemyModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Add(It.IsAny<ICharacterEnemy>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCharacterEnemy = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemy(1);
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterEnemy.Object);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            var expectedName = "Stephen King (2)";
            var model = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemyModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCharacterEnemy.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemy(1);
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            var model = CharacterEnemiesMockingSetup.DoMockingSetupForCharacterEnemyModel(1);
            ICharacterEnemyModel result = null;
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
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterEnemy>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterEnemy>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterEnemy>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterEnemy>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterEnemy>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Remove(It.IsAny<ICharacterEnemy>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterEnemiesMapper = new Mock<ICharacterEnemyMapper>();
            mockCharacterEnemiesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterEnemyModel>(), It.IsAny<ICharacterEnemy>())).Returns(() => true);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, mockCharacterEnemiesMapper.Object);
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterEnemy>().Object);
            mockCharacterEnemiesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCharacterEnemiesRepository.Verify(m => m.Remove(It.IsAny<ICharacterEnemy>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterEnemies")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCharacterEnemiesRepository = CharacterEnemiesMockingSetup.DoMockingSetupForRepository();
            mockCharacterEnemiesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CharacterEnemiesBusinessWorkflow(mockCharacterEnemiesRepository.Object, new CharacterEnemyMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
