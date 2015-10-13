// <auto-generated>
// <copyright file="Characters.ICharacterCreatorRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterCreatorsRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Characters
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

    public static class CharacterCreatorsMockingSetup
    {
        public static Mock<ICharacterCreatorModel> DoMockingSetupForCharacterCreatorModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterCreatorModel = new Mock<ICharacterCreatorModel>();
            // Mock Functions
            mockCharacterCreatorModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterCreatorModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterCreatorModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterCreatorModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterCreatorModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterCreatorModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterCreatorModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterCreatorModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterCreatorModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterCreatorModel.Setup(m => m.CreatorId).Returns(() => 1);
            mockCharacterCreatorModel.Setup(m => m.Creator).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterCreatorModel;
        }

        public static Mock<ICharacterCreator> DoMockingSetupForCharacterCreator(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterCreator = new Mock<ICharacterCreator>();
            // Mock Functions
            mockCharacterCreator.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterCreator.Setup(m => m.Active).Returns(() => true);
            mockCharacterCreator.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterCreator.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterCreator.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterCreator.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterCreator.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterCreator.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterCreator.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterCreator.Setup(m => m.CreatorId).Returns(() => 1);
            mockCharacterCreator.Setup(m => m.Creator).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterCreator;
        }

        public static Mock<ICharacterCreatorsRepository> DoMockingSetupForRepository()
        {
            var mockCharacterCreatorsRepository = new Mock<ICharacterCreatorsRepository>();
            // Mock Functions
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICharacterCreator>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICharacterCreator>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICharacterCreator>>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.Search(It.IsAny<ICharacterCreatorSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterCreator>>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.Add(It.IsAny<ICharacterCreator>()));
            mockCharacterCreatorsRepository.Setup(m => m.Remove(It.IsAny<ICharacterCreator>()));
            mockCharacterCreatorsRepository.Setup(m => m.Deactivate(It.IsAny<ICharacterCreator>()));
            mockCharacterCreatorsRepository.Setup(m => m.Update(It.IsAny<ICharacterCreator>()));
            // Return
            return mockCharacterCreatorsRepository;
        }
    }

    public class CharacterCreatorsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CharacterCreatorModel>(person);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CharacterCreatorModel>(person);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Search_Should_ReturnAListOfCharacterCreators()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterCreatorSearchModel>();
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Search(It.IsAny<ICharacterCreatorSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCharacterCreatorsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterCreatorSearchModel>();
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Search(It.IsAny<ICharacterCreatorSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            mockCharacterCreatorsRepository.Setup(m => m.Search(It.IsAny<ICharacterCreatorSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterCreator>>().Object);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            var model = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreatorModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Add(It.IsAny<ICharacterCreator>()), Times.Once);
        }
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterCreator = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreator(1);
            mockCharacterCreatorsRepository.Setup(m => m.Search(It.IsAny<ICharacterCreatorSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICharacterCreator> { mockCharacterCreator.Object } );
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterCreator.Object);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            var model = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreatorModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Add(It.IsAny<ICharacterCreator>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCharacterCreator = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreator(1);
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterCreator.Object);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            var expectedName = "Stephen King (2)";
            var model = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreatorModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCharacterCreator.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreator(1);
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            var model = CharacterCreatorsMockingSetup.DoMockingSetupForCharacterCreatorModel(1);
            ICharacterCreatorModel result = null;
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
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterCreator>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterCreator>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterCreator>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterCreator>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterCreator>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Remove(It.IsAny<ICharacterCreator>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterCreatorsMapper = new Mock<ICharacterCreatorMapper>();
            mockCharacterCreatorsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterCreatorModel>(), It.IsAny<ICharacterCreator>())).Returns(() => true);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, mockCharacterCreatorsMapper.Object);
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterCreator>().Object);
            mockCharacterCreatorsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCharacterCreatorsRepository.Verify(m => m.Remove(It.IsAny<ICharacterCreator>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCharacterCreatorsRepository = CharacterCreatorsMockingSetup.DoMockingSetupForRepository();
            mockCharacterCreatorsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CharacterCreatorsBusinessWorkflow(mockCharacterCreatorsRepository.Object, new CharacterCreatorMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}