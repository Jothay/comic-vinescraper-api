// <auto-generated>
// <copyright file="Profiles.IProfileRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ProfilesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Profiles
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

    public static class ProfilesMockingSetup
    {
        public static Mock<IProfileModel> DoMockingSetupForProfileModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockProfileModel = new Mock<IProfileModel>();
            // Mock Functions
            mockProfileModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockProfileModel.Setup(m => m.Active).Returns(() => true);
            mockProfileModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockProfileModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfileModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfileModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockProfileModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockProfileModel.Setup(m => m.Name).Returns(() => name);
            mockProfileModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockProfileModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockProfileModel.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfileModel>());
            // Return
            return mockProfileModel;
        }

        public static Mock<IProfile> DoMockingSetupForProfile(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockProfile = new Mock<IProfile>();
            // Mock Functions
            mockProfile.Setup(m => m.Id).Returns(() => idReturnValue);
            mockProfile.Setup(m => m.Active).Returns(() => true);
            mockProfile.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockProfile.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfile.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfile.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockProfile.Setup(m => m.UpdatedDate).Returns(() => null);
            mockProfile.Setup(m => m.Name).Returns(() => name);
            mockProfile.Setup(m => m.ShortDescription).Returns(() => "short");
            mockProfile.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockProfile.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfile>());
            // Return
            return mockProfile;
        }

        public static Mock<IProfilesRepository> DoMockingSetupForRepository()
        {
            var mockProfilesRepository = new Mock<IProfilesRepository>();
            // Mock Functions
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IProfile>().Object);
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IProfile>().Object);
            mockProfilesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IProfile>>().Object);
            mockProfilesRepository.Setup(m => m.Search(It.IsAny<IProfileSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IProfile>>().Object);
            mockProfilesRepository.Setup(m => m.Add(It.IsAny<IProfile>()));
            mockProfilesRepository.Setup(m => m.Remove(It.IsAny<IProfile>()));
            mockProfilesRepository.Setup(m => m.Deactivate(It.IsAny<IProfile>()));
            mockProfilesRepository.Setup(m => m.Update(It.IsAny<IProfile>()));
            // Return
            return mockProfilesRepository;
        }
    }

    public class ProfilesBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ProfileModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ProfileModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfProfiles()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IProfileSearchModel>();
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockProfilesRepository.Verify(m => m.Search(It.IsAny<IProfileSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfProfilesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IProfileSearchModel>();
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockProfilesRepository.Verify(m => m.Search(It.IsAny<IProfileSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            mockProfilesRepository.Setup(m => m.Search(It.IsAny<IProfileSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IProfile>>().Object);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockProfilesRepository.Verify(m => m.Add(It.IsAny<IProfile>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var mockProfile = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            mockProfilesRepository.Setup(m => m.Search(It.IsAny<IProfileSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IProfile> { mockProfile.Object } );
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockProfile.Object);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockProfilesRepository.Verify(m => m.Add(It.IsAny<IProfile>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockProfile = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockProfile.Object);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            var expectedName = "Stephen King (2)";
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockProfile.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel(1);
            IProfileModel result = null;
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
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IProfile>().Object);
            mockProfilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockProfilesRepository.Verify(m => m.Deactivate(It.IsAny<IProfile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IProfile>().Object);
            mockProfilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockProfilesRepository.Verify(m => m.Deactivate(It.IsAny<IProfile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IProfile>().Object);
            mockProfilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockProfilesRepository.Verify(m => m.Remove(It.IsAny<IProfile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            var mockProfilesMapper = new Mock<IProfileMapper>();
            mockProfilesMapper.Setup(m => m.AreEqual(It.IsAny<IProfileModel>(), It.IsAny<IProfile>())).Returns(() => true);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, mockProfilesMapper.Object);
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IProfile>().Object);
            mockProfilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockProfilesRepository.Verify(m => m.Remove(It.IsAny<IProfile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockProfilesRepository = ProfilesMockingSetup.DoMockingSetupForRepository();
            mockProfilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ProfilesBusinessWorkflow(mockProfilesRepository.Object, new ProfileMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
