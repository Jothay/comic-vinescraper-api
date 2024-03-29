// <auto-generated>
// <copyright file="Characters.ICharacterFriendBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriendsRepository Class.</summary>
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

    public static class CharacterFriendsMockingSetup
    {
        public static Mock<ICharacterFriendModel> DoMockingSetupForCharacterFriendModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterFriendModel = new Mock<ICharacterFriendModel>();
            // Mock Functions
            mockCharacterFriendModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterFriendModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterFriendModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterFriendModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriendModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriendModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterFriendModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterFriendModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterFriendModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterFriendModel.Setup(m => m.FriendId).Returns(() => 1);
            mockCharacterFriendModel.Setup(m => m.Friend).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterFriendModel;
        }

        public static Mock<ICharacterFriend> DoMockingSetupForCharacterFriend(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterFriend = new Mock<ICharacterFriend>();
            // Mock Functions
            mockCharacterFriend.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterFriend.Setup(m => m.Active).Returns(() => true);
            mockCharacterFriend.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterFriend.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriend.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterFriend.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterFriend.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterFriend.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterFriend.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterFriend.Setup(m => m.FriendId).Returns(() => 1);
            mockCharacterFriend.Setup(m => m.Friend).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterFriend;
        }

        public static Mock<ICharacterFriendsRepository> DoMockingSetupForRepository()
        {
            var mockCharacterFriendsRepository = new Mock<ICharacterFriendsRepository>();
            // Mock Functions
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICharacterFriend>().Object);
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICharacterFriend>().Object);
            mockCharacterFriendsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICharacterFriend>>().Object);
            mockCharacterFriendsRepository.Setup(m => m.Search(It.IsAny<ICharacterFriendSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterFriend>>().Object);
            mockCharacterFriendsRepository.Setup(m => m.Add(It.IsAny<ICharacterFriend>()));
            mockCharacterFriendsRepository.Setup(m => m.Remove(It.IsAny<ICharacterFriend>()));
            mockCharacterFriendsRepository.Setup(m => m.Deactivate(It.IsAny<ICharacterFriend>()));
            mockCharacterFriendsRepository.Setup(m => m.Update(It.IsAny<ICharacterFriend>()));
            // Return
            return mockCharacterFriendsRepository;
        }
    }

    public class CharacterFriendsBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CharacterFriendModel>(person);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CharacterFriendModel>(person);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Search_Should_ReturnAListOfCharacterFriends()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterFriendSearchModel>();
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Search(It.IsAny<ICharacterFriendSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCharacterFriendsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterFriendSearchModel>();
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Search(It.IsAny<ICharacterFriendSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockCharacterFriendsRepository.Setup(m => m.Search(It.IsAny<ICharacterFriendSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterFriend>>().Object);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            var model = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriendModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Add(It.IsAny<ICharacterFriend>()), Times.Once);
        }
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterFriend = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriend(1);
            mockCharacterFriendsRepository.Setup(m => m.Search(It.IsAny<ICharacterFriendSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICharacterFriend> { mockCharacterFriend.Object } );
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterFriend.Object);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            var model = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriendModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Add(It.IsAny<ICharacterFriend>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCharacterFriend = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriend(1);
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterFriend.Object);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            var expectedName = "Stephen King (2)";
            var model = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriendModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCharacterFriend.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriend(1);
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            var model = CharacterFriendsMockingSetup.DoMockingSetupForCharacterFriendModel(1);
            ICharacterFriendModel result = null;
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
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterFriend>().Object);
            mockCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterFriend>().Object);
            mockCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterFriend>().Object);
            mockCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Remove(It.IsAny<ICharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockCharacterFriendsMapper = new Mock<ICharacterFriendMapper>();
            mockCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterFriendModel>(), It.IsAny<ICharacterFriend>())).Returns(() => true);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, mockCharacterFriendsMapper.Object);
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterFriend>().Object);
            mockCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCharacterFriendsRepository.Verify(m => m.Remove(It.IsAny<ICharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterFriends")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCharacterFriendsRepository = CharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CharacterFriendsBusinessWorkflow(mockCharacterFriendsRepository.Object, new CharacterFriendMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
