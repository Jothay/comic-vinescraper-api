// <auto-generated>
// <copyright file="Characters.ICharacterStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterStoryArcsRepository Class.</summary>
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

    public static class CharacterStoryArcsMockingSetup
    {
        public static Mock<ICharacterStoryArcModel> DoMockingSetupForCharacterStoryArcModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterStoryArcModel = new Mock<ICharacterStoryArcModel>();
            // Mock Functions
            mockCharacterStoryArcModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterStoryArcModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterStoryArcModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterStoryArcModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterStoryArcModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterStoryArcModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterStoryArcModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterStoryArcModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterStoryArcModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterStoryArcModel.Setup(m => m.StoryArcId).Returns(() => 1);
            mockCharacterStoryArcModel.Setup(m => m.StoryArc).Returns(() => new StoryArcModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterStoryArcModel;
        }

        public static Mock<ICharacterStoryArc> DoMockingSetupForCharacterStoryArc(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterStoryArc = new Mock<ICharacterStoryArc>();
            // Mock Functions
            mockCharacterStoryArc.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterStoryArc.Setup(m => m.Active).Returns(() => true);
            mockCharacterStoryArc.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterStoryArc.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterStoryArc.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterStoryArc.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterStoryArc.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterStoryArc.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterStoryArc.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterStoryArc.Setup(m => m.StoryArcId).Returns(() => 1);
            mockCharacterStoryArc.Setup(m => m.StoryArc).Returns(() => new StoryArc());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterStoryArc;
        }

        public static Mock<ICharacterStoryArcsRepository> DoMockingSetupForRepository()
        {
            var mockCharacterStoryArcsRepository = new Mock<ICharacterStoryArcsRepository>();
            // Mock Functions
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICharacterStoryArc>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICharacterStoryArc>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICharacterStoryArc>>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Search(It.IsAny<ICharacterStoryArcSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterStoryArc>>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Add(It.IsAny<ICharacterStoryArc>()));
            mockCharacterStoryArcsRepository.Setup(m => m.Remove(It.IsAny<ICharacterStoryArc>()));
            mockCharacterStoryArcsRepository.Setup(m => m.Deactivate(It.IsAny<ICharacterStoryArc>()));
            mockCharacterStoryArcsRepository.Setup(m => m.Update(It.IsAny<ICharacterStoryArc>()));
            // Return
            return mockCharacterStoryArcsRepository;
        }
    }

    public class CharacterStoryArcsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CharacterStoryArcModel>(person);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CharacterStoryArcModel>(person);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Search_Should_ReturnAListOfCharacterStoryArcs()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterStoryArcSearchModel>();
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Search(It.IsAny<ICharacterStoryArcSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCharacterStoryArcsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterStoryArcSearchModel>();
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Search(It.IsAny<ICharacterStoryArcSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            mockCharacterStoryArcsRepository.Setup(m => m.Search(It.IsAny<ICharacterStoryArcSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterStoryArc>>().Object);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            var model = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArcModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Add(It.IsAny<ICharacterStoryArc>()), Times.Once);
        }
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterStoryArc = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArc(1);
            mockCharacterStoryArcsRepository.Setup(m => m.Search(It.IsAny<ICharacterStoryArcSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICharacterStoryArc> { mockCharacterStoryArc.Object } );
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterStoryArc.Object);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            var model = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArcModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Add(It.IsAny<ICharacterStoryArc>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCharacterStoryArc = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArc(1);
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterStoryArc.Object);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            var expectedName = "Stephen King (2)";
            var model = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArcModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCharacterStoryArc.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArc(1);
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            var model = CharacterStoryArcsMockingSetup.DoMockingSetupForCharacterStoryArcModel(1);
            ICharacterStoryArcModel result = null;
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
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterStoryArc>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterStoryArc>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterStoryArc>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterStoryArc>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterStoryArc>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Remove(It.IsAny<ICharacterStoryArc>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterStoryArcsMapper = new Mock<ICharacterStoryArcMapper>();
            mockCharacterStoryArcsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterStoryArcModel>(), It.IsAny<ICharacterStoryArc>())).Returns(() => true);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, mockCharacterStoryArcsMapper.Object);
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterStoryArc>().Object);
            mockCharacterStoryArcsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCharacterStoryArcsRepository.Verify(m => m.Remove(It.IsAny<ICharacterStoryArc>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterStoryArcs")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCharacterStoryArcsRepository = CharacterStoryArcsMockingSetup.DoMockingSetupForRepository();
            mockCharacterStoryArcsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CharacterStoryArcsBusinessWorkflow(mockCharacterStoryArcsRepository.Object, new CharacterStoryArcMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
