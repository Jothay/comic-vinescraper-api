// <auto-generated>
// <copyright file="People.ICreatorCharacterBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CreatorCharactersRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.People
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

    public static class CreatorCharactersMockingSetup
    {
        public static Mock<ICreatorCharacterModel> DoMockingSetupForCreatorCharacterModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCreatorCharacterModel = new Mock<ICreatorCharacterModel>();
            // Mock Functions
            mockCreatorCharacterModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCreatorCharacterModel.Setup(m => m.Active).Returns(() => true);
            mockCreatorCharacterModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCreatorCharacterModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacterModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacterModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCreatorCharacterModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCreatorCharacterModel.Setup(m => m.PersonId).Returns(() => 1);
            mockCreatorCharacterModel.Setup(m => m.Creator).Returns(() => new PersonModel());
            mockCreatorCharacterModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCreatorCharacterModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockCreatorCharacterModel;
        }

        public static Mock<ICreatorCharacter> DoMockingSetupForCreatorCharacter(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCreatorCharacter = new Mock<ICreatorCharacter>();
            // Mock Functions
            mockCreatorCharacter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCreatorCharacter.Setup(m => m.Active).Returns(() => true);
            mockCreatorCharacter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCreatorCharacter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCreatorCharacter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCreatorCharacter.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCreatorCharacter.Setup(m => m.PersonId).Returns(() => 1);
            mockCreatorCharacter.Setup(m => m.Creator).Returns(() => new Person());
            mockCreatorCharacter.Setup(m => m.CharacterId).Returns(() => 1);
            mockCreatorCharacter.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockCreatorCharacter;
        }

        public static Mock<ICreatorCharactersRepository> DoMockingSetupForRepository()
        {
            var mockCreatorCharactersRepository = new Mock<ICreatorCharactersRepository>();
            // Mock Functions
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICreatorCharacter>().Object);
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICreatorCharacter>().Object);
            mockCreatorCharactersRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICreatorCharacter>>().Object);
            mockCreatorCharactersRepository.Setup(m => m.Search(It.IsAny<ICreatorCharacterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICreatorCharacter>>().Object);
            mockCreatorCharactersRepository.Setup(m => m.Add(It.IsAny<ICreatorCharacter>()));
            mockCreatorCharactersRepository.Setup(m => m.Remove(It.IsAny<ICreatorCharacter>()));
            mockCreatorCharactersRepository.Setup(m => m.Deactivate(It.IsAny<ICreatorCharacter>()));
            mockCreatorCharactersRepository.Setup(m => m.Update(It.IsAny<ICreatorCharacter>()));
            // Return
            return mockCreatorCharactersRepository;
        }
    }

    public class CreatorCharactersBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CreatorCharacterModel>(person);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CreatorCharacterModel>(person);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Search_Should_ReturnAListOfCreatorCharacters()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICreatorCharacterSearchModel>();
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Search(It.IsAny<ICreatorCharacterSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCreatorCharactersWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICreatorCharacterSearchModel>();
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Search(It.IsAny<ICreatorCharacterSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            mockCreatorCharactersRepository.Setup(m => m.Search(It.IsAny<ICreatorCharacterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICreatorCharacter>>().Object);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Add(It.IsAny<ICreatorCharacter>()), Times.Once);
        }
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var mockCreatorCharacter = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            mockCreatorCharactersRepository.Setup(m => m.Search(It.IsAny<ICreatorCharacterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICreatorCharacter> { mockCreatorCharacter.Object } );
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCreatorCharacter.Object);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Add(It.IsAny<ICreatorCharacter>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCreatorCharacter = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCreatorCharacter.Object);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            var expectedName = "Stephen King (2)";
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCreatorCharacter.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacter(1);
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            var model = CreatorCharactersMockingSetup.DoMockingSetupForCreatorCharacterModel(1);
            ICreatorCharacterModel result = null;
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
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICreatorCharacter>().Object);
            mockCreatorCharactersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Deactivate(It.IsAny<ICreatorCharacter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICreatorCharacter>().Object);
            mockCreatorCharactersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Deactivate(It.IsAny<ICreatorCharacter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICreatorCharacter>().Object);
            mockCreatorCharactersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Remove(It.IsAny<ICreatorCharacter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            var mockCreatorCharactersMapper = new Mock<ICreatorCharacterMapper>();
            mockCreatorCharactersMapper.Setup(m => m.AreEqual(It.IsAny<ICreatorCharacterModel>(), It.IsAny<ICreatorCharacter>())).Returns(() => true);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, mockCreatorCharactersMapper.Object);
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICreatorCharacter>().Object);
            mockCreatorCharactersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCreatorCharactersRepository.Verify(m => m.Remove(It.IsAny<ICreatorCharacter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCreatorCharactersRepository = CreatorCharactersMockingSetup.DoMockingSetupForRepository();
            mockCreatorCharactersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CreatorCharactersBusinessWorkflow(mockCreatorCharactersRepository.Object, new CreatorCharacterMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}