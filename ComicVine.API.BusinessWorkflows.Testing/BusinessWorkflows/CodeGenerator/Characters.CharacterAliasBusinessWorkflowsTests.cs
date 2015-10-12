// <auto-generated>
// <copyright file="Characters.ICharacterAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterAliasesRepository Class.</summary>
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

    public static class CharacterAliasesMockingSetup
    {
        public static Mock<ICharacterAliasModel> DoMockingSetupForCharacterAliasModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterAliasModel = new Mock<ICharacterAliasModel>();
            // Mock Functions
            mockCharacterAliasModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterAliasModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterAliasModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterAliasModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAliasModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAliasModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterAliasModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockCharacterAliasModel.Setup(m => m.Name).Returns(() => name);
            mockCharacterAliasModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockCharacterAliasModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterAliasModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterAliasModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterAliasModel;
        }

        public static Mock<ICharacterAlias> DoMockingSetupForCharacterAlias(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterAlias = new Mock<ICharacterAlias>();
            // Mock Functions
            mockCharacterAlias.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterAlias.Setup(m => m.Active).Returns(() => true);
            mockCharacterAlias.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterAlias.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAlias.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterAlias.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterAlias.Setup(m => m.UpdatedDate).Returns(() => null);
            mockCharacterAlias.Setup(m => m.Name).Returns(() => name);
            mockCharacterAlias.Setup(m => m.ShortDescription).Returns(() => "short");
            mockCharacterAlias.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockCharacterAlias.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterAlias.Setup(m => m.Character).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterAlias;
        }

        public static Mock<ICharacterAliasesRepository> DoMockingSetupForRepository()
        {
            var mockCharacterAliasesRepository = new Mock<ICharacterAliasesRepository>();
            // Mock Functions
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICharacterAlias>().Object);
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICharacterAlias>().Object);
            mockCharacterAliasesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICharacterAlias>>().Object);
            mockCharacterAliasesRepository.Setup(m => m.Search(It.IsAny<ICharacterAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterAlias>>().Object);
            mockCharacterAliasesRepository.Setup(m => m.Add(It.IsAny<ICharacterAlias>()));
            mockCharacterAliasesRepository.Setup(m => m.Remove(It.IsAny<ICharacterAlias>()));
            mockCharacterAliasesRepository.Setup(m => m.Deactivate(It.IsAny<ICharacterAlias>()));
            mockCharacterAliasesRepository.Setup(m => m.Update(It.IsAny<ICharacterAlias>()));
            // Return
            return mockCharacterAliasesRepository;
        }
    }

    public class CharacterAliasesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CharacterAliasModel>(person);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CharacterAliasModel>(person);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Search_Should_ReturnAListOfCharacterAliases()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterAliasSearchModel>();
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Search(It.IsAny<ICharacterAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCharacterAliasesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterAliasSearchModel>();
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Search(It.IsAny<ICharacterAliasSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            mockCharacterAliasesRepository.Setup(m => m.Search(It.IsAny<ICharacterAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterAlias>>().Object);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Add(It.IsAny<ICharacterAlias>()), Times.Once);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterAlias = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            mockCharacterAliasesRepository.Setup(m => m.Search(It.IsAny<ICharacterAliasSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICharacterAlias> { mockCharacterAlias.Object } );
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterAlias.Object);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Add(It.IsAny<ICharacterAlias>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCharacterAlias = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterAlias.Object);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            var expectedName = "Stephen King (2)";
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCharacterAlias.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAlias(1);
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            var model = CharacterAliasesMockingSetup.DoMockingSetupForCharacterAliasModel(1);
            ICharacterAliasModel result = null;
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
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterAlias>().Object);
            mockCharacterAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterAlias>().Object);
            mockCharacterAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterAlias>().Object);
            mockCharacterAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Remove(It.IsAny<ICharacterAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterAliasesMapper = new Mock<ICharacterAliasMapper>();
            mockCharacterAliasesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterAliasModel>(), It.IsAny<ICharacterAlias>())).Returns(() => true);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, mockCharacterAliasesMapper.Object);
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterAlias>().Object);
            mockCharacterAliasesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCharacterAliasesRepository.Verify(m => m.Remove(It.IsAny<ICharacterAlias>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterAliases")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCharacterAliasesRepository = CharacterAliasesMockingSetup.DoMockingSetupForRepository();
            mockCharacterAliasesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CharacterAliasesBusinessWorkflow(mockCharacterAliasesRepository.Object, new CharacterAliasMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
