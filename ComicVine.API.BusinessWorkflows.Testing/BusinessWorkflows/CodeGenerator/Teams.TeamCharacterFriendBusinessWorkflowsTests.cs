// <auto-generated>
// <copyright file="Teams.ITeamCharacterFriendRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamCharacterFriendsRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Teams
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

    public static class TeamCharacterFriendsMockingSetup
    {
        public static Mock<ITeamCharacterFriendModel> DoMockingSetupForTeamCharacterFriendModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamCharacterFriendModel = new Mock<ITeamCharacterFriendModel>();
            // Mock Functions
            mockTeamCharacterFriendModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamCharacterFriendModel.Setup(m => m.Active).Returns(() => true);
            mockTeamCharacterFriendModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamCharacterFriendModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterFriendModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterFriendModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamCharacterFriendModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamCharacterFriendModel.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamCharacterFriendModel.Setup(m => m.Team).Returns(() => new TeamModel());
            mockTeamCharacterFriendModel.Setup(m => m.FriendId).Returns(() => 1);
            mockTeamCharacterFriendModel.Setup(m => m.Friend).Returns(() => new CharacterModel());
            // Associated Objects
            // <None>
            // Return
            return mockTeamCharacterFriendModel;
        }

        public static Mock<ITeamCharacterFriend> DoMockingSetupForTeamCharacterFriend(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockTeamCharacterFriend = new Mock<ITeamCharacterFriend>();
            // Mock Functions
            mockTeamCharacterFriend.Setup(m => m.Id).Returns(() => idReturnValue);
            mockTeamCharacterFriend.Setup(m => m.Active).Returns(() => true);
            mockTeamCharacterFriend.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockTeamCharacterFriend.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterFriend.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockTeamCharacterFriend.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockTeamCharacterFriend.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockTeamCharacterFriend.Setup(m => m.TeamId).Returns(() => 1);
            mockTeamCharacterFriend.Setup(m => m.Team).Returns(() => new Team());
            mockTeamCharacterFriend.Setup(m => m.FriendId).Returns(() => 1);
            mockTeamCharacterFriend.Setup(m => m.Friend).Returns(() => new Character());
            // Associated Objects
            // <None>
            // Return
            return mockTeamCharacterFriend;
        }

        public static Mock<ITeamCharacterFriendsRepository> DoMockingSetupForRepository()
        {
            var mockTeamCharacterFriendsRepository = new Mock<ITeamCharacterFriendsRepository>();
            // Mock Functions
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ITeamCharacterFriend>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ITeamCharacterFriend>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ITeamCharacterFriend>>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Search(It.IsAny<ITeamCharacterFriendSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeamCharacterFriend>>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Add(It.IsAny<ITeamCharacterFriend>()));
            mockTeamCharacterFriendsRepository.Setup(m => m.Remove(It.IsAny<ITeamCharacterFriend>()));
            mockTeamCharacterFriendsRepository.Setup(m => m.Deactivate(It.IsAny<ITeamCharacterFriend>()));
            mockTeamCharacterFriendsRepository.Setup(m => m.Update(It.IsAny<ITeamCharacterFriend>()));
            // Return
            return mockTeamCharacterFriendsRepository;
        }
    }

    public class TeamCharacterFriendsBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<TeamCharacterFriendModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<TeamCharacterFriendModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfTeamCharacterFriends()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamCharacterFriendSearchModel>();
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Search(It.IsAny<ITeamCharacterFriendSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfTeamCharacterFriendsWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ITeamCharacterFriendSearchModel>();
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Search(It.IsAny<ITeamCharacterFriendSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockTeamCharacterFriendsRepository.Setup(m => m.Search(It.IsAny<ITeamCharacterFriendSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ITeamCharacterFriend>>().Object);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            var model = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriendModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Add(It.IsAny<ITeamCharacterFriend>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockTeamCharacterFriend = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriend(1);
            mockTeamCharacterFriendsRepository.Setup(m => m.Search(It.IsAny<ITeamCharacterFriendSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ITeamCharacterFriend> { mockTeamCharacterFriend.Object } );
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeamCharacterFriend.Object);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            var model = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriendModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Add(It.IsAny<ITeamCharacterFriend>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockTeamCharacterFriend = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriend(1);
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockTeamCharacterFriend.Object);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            var expectedName = "Stephen King (2)";
            var model = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriendModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockTeamCharacterFriend.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriend(1);
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            var model = TeamCharacterFriendsMockingSetup.DoMockingSetupForTeamCharacterFriendModel(1);
            ITeamCharacterFriendModel result = null;
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
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamCharacterFriend>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Deactivate(It.IsAny<ITeamCharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamCharacterFriend>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Deactivate(It.IsAny<ITeamCharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ITeamCharacterFriend>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Remove(It.IsAny<ITeamCharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            var mockTeamCharacterFriendsMapper = new Mock<ITeamCharacterFriendMapper>();
            mockTeamCharacterFriendsMapper.Setup(m => m.AreEqual(It.IsAny<ITeamCharacterFriendModel>(), It.IsAny<ITeamCharacterFriend>())).Returns(() => true);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, mockTeamCharacterFriendsMapper.Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ITeamCharacterFriend>().Object);
            mockTeamCharacterFriendsRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockTeamCharacterFriendsRepository.Verify(m => m.Remove(It.IsAny<ITeamCharacterFriend>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockTeamCharacterFriendsRepository = TeamCharacterFriendsMockingSetup.DoMockingSetupForRepository();
            mockTeamCharacterFriendsRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new TeamCharacterFriendsBusinessWorkflow(mockTeamCharacterFriendsRepository.Object, new TeamCharacterFriendMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
