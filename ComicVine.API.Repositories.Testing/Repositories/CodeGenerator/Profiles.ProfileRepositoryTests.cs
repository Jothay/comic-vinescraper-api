// <auto-generated>
// <copyright file="Profiles.IProfileRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ProfilesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Profiles
{
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using API.Repositories;
    using DataModel.Schema;
    using Interfaces.SearchModels;
    using Moq;
    using SearchModels;
    using Xunit;

    public static class ProfilesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeProfilesData, out Mock<IDbSet<Profile>> mockSetProfiles, bool markAProfileInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetProfiles = new Mock<IDbSet<Profile>>();
            var personData = (!includeProfilesData ? new List<Profile>() : new List<Profile>
            {
                new Profile { Id = 1, Active = !markAProfileInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new Profile { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetProfiles.As<IQueryable<Profile>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetProfiles.As<IQueryable<Profile>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetProfiles.As<IQueryable<Profile>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetProfiles.As<IQueryable<Profile>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.Profiles).Returns(mockSetProfiles.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class ProfilesRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(false, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            var profiles = new Profile { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
            // Act
            repository.Add(profiles);
            // Assert
            mockSetProfiles.Verify(x => x.Add(profiles), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            var profiles = repository.Get(1);
            // Act
            repository.Remove(profiles);
            // Assert
            mockSetProfiles.Verify(x => x.Remove((Profile)profiles), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            var profiles = repository.Get(1);
            // Act
            repository.Deactivate(profiles);
            // Assert
            Assert.Equal(false, profiles.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            var profiles = repository.Get(1);
            profiles.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(profiles);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectProfile()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            // Act
            var profiles = repository.Get(1);
            // Assert
            Assert.Equal("Stephen King", profiles.Name);            Assert.Equal("/TEST/KING-STEPHEN", profiles.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectProfile()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            // Act
            var profiles = repository.Get("KING-STEPHEN");
            // Assert
            Assert.Equal("Stephen King", profiles.Name);            Assert.Equal("/TEST/KING-STEPHEN", profiles.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfProfilesWithData()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            // Act
            var profiles = repository.List.ToArray();
            // Assert
            Assert.Equal(2, profiles.Length);
            Assert.Equal(1, profiles[0].Id);
            Assert.Equal("Stephen King", profiles[0].Name);            Assert.Equal("/TEST/KING-STEPHEN", profiles[0].ApiDetailUrl);
            Assert.Equal(2, profiles[1].Id);
            Assert.Equal("Larry Niven", profiles[1].Name);            Assert.Equal("/TEST/NIVEN-LARRY", profiles[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfProfilesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles, true);
            var repository = new ProfilesRepository(mockContext.Object);
            var searchModel = new Mock<IProfileSearchModel>();
            // Act
            var profiles = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, profiles.Length);
            Assert.Equal(2, profiles[0].Id);
            Assert.Equal("Larry Niven", profiles[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", profiles[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles, true);
            var repository = new ProfilesRepository(mockContext.Object);
            var searchModel = new Mock<IProfileSearchModel>();
            // Act
            var profiles = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl, MyName = i.Name }).ToArray();
            // Assert
            Assert.Equal(1, profiles.Length);
            Assert.Equal(2, profiles[0].Id);
            Assert.Equal("Larry Niven", profiles[0].MyName);            Assert.Equal("/TEST/NIVEN-LARRY", profiles[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfProfilesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles, true);
            var repository = new ProfilesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IProfileSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new ProfileSearchModel { ModifiedSince = createDate };
            // Act
            var profiles = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, profiles.Length);
            Assert.Equal(2, profiles[0].Id);
            Assert.Equal("Larry Niven", profiles[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", profiles[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfProfilesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Profile>> mockSetProfiles;
            var mockContext = ProfilesMockingSetup.DoMockingSetupForContext(true, out mockSetProfiles);
            var repository = new ProfilesRepository(mockContext.Object);
            var searchModel = new ProfileSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var profiles = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, profiles.Length);
            Assert.Equal(2, profiles[0].Id);
            Assert.Equal("Larry Niven", profiles[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", profiles[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}