// <auto-generated>
// <copyright file="Characters.CharacterVolumeRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterVolumesRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Characters
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

    public static class CharacterVolumesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeCharacterVolumesData, out Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes, bool markACharacterVolumeInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetCharacterVolumes = new Mock<IDbSet<CharacterVolume>>();
            var personData = (!includeCharacterVolumesData ? new List<CharacterVolume>() : new List<CharacterVolume>
            {
                new CharacterVolume { Id = 1, Active = !markACharacterVolumeInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new CharacterVolume { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetCharacterVolumes.As<IQueryable<CharacterVolume>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetCharacterVolumes.As<IQueryable<CharacterVolume>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetCharacterVolumes.As<IQueryable<CharacterVolume>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetCharacterVolumes.As<IQueryable<CharacterVolume>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.CharacterVolumes).Returns(mockSetCharacterVolumes.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class CharacterVolumesRepositoryTests
    {
        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(false, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var characterVolumes = new CharacterVolume { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(characterVolumes);
            // Assert
            mockSetCharacterVolumes.Verify(x => x.Add(characterVolumes), Times.Once);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var characterVolumes = repository.Get(1);
            // Act
            repository.Remove(characterVolumes);
            // Assert
            mockSetCharacterVolumes.Verify(x => x.Remove((CharacterVolume)characterVolumes), Times.Once);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var characterVolumes = repository.Get(1);
            // Act
            repository.Deactivate(characterVolumes);
            // Assert
            Assert.Equal(false, characterVolumes.Active);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var characterVolumes = repository.Get(1);
            characterVolumes.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(characterVolumes);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectCharacterVolume()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            // Act
            var characterVolumes = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", characterVolumes.ApiDetailUrl);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectCharacterVolume()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            // Act
            var characterVolumes = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", characterVolumes.ApiDetailUrl);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_List_Should_ReturnAListOfCharacterVolumesWithData()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            // Act
            var characterVolumes = repository.List.ToArray();
            // Assert
            Assert.Equal(2, characterVolumes.Length);
            Assert.Equal(1, characterVolumes[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", characterVolumes[0].ApiDetailUrl);
            Assert.Equal(2, characterVolumes[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterVolumes[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Search_Should_ReturnAListOfCharacterVolumesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes, true);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var searchModel = new Mock<ICharacterVolumeSearchModel>();
            // Act
            var characterVolumes = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, characterVolumes.Length);
            Assert.Equal(2, characterVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterVolumes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes, true);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var searchModel = new Mock<ICharacterVolumeSearchModel>();
            // Act
            var characterVolumes = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, characterVolumes.Length);
            Assert.Equal(2, characterVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterVolumes[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfCharacterVolumesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes, true);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ICharacterVolumeSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new CharacterVolumeSearchModel { ModifiedSince = createDate };
            // Act
            var characterVolumes = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, characterVolumes.Length);
            Assert.Equal(2, characterVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterVolumes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "CharacterVolumes")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfCharacterVolumesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterVolume>> mockSetCharacterVolumes;
            var mockContext = CharacterVolumesMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterVolumes);
            var repository = new CharacterVolumesRepository(mockContext.Object);
            var searchModel = new CharacterVolumeSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var characterVolumes = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, characterVolumes.Length);
            Assert.Equal(2, characterVolumes[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterVolumes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}