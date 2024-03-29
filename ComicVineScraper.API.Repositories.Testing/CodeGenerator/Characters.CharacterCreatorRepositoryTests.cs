// <auto-generated>
// <copyright file="Characters.CharacterCreatorRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterCreatorsRepositoryTests class.</summary>
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

    public static class CharacterCreatorsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeCharacterCreatorsData, out Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators, bool markACharacterCreatorInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetCharacterCreators = new Mock<IDbSet<CharacterCreator>>();
            var personData = (!includeCharacterCreatorsData ? new List<CharacterCreator>() : new List<CharacterCreator>
            {
                new CharacterCreator { Id = 1, Active = !markACharacterCreatorInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new CharacterCreator { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetCharacterCreators.As<IQueryable<CharacterCreator>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetCharacterCreators.As<IQueryable<CharacterCreator>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetCharacterCreators.As<IQueryable<CharacterCreator>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetCharacterCreators.As<IQueryable<CharacterCreator>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.CharacterCreators).Returns(mockSetCharacterCreators.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class CharacterCreatorsRepositoryTests
    {
        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(false, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var characterCreators = new CharacterCreator { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(characterCreators);
            // Assert
            mockSetCharacterCreators.Verify(x => x.Add(characterCreators), Times.Once);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var characterCreators = repository.Get(1);
            // Act
            repository.Remove(characterCreators);
            // Assert
            mockSetCharacterCreators.Verify(x => x.Remove((CharacterCreator)characterCreators), Times.Once);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var characterCreators = repository.Get(1);
            // Act
            repository.Deactivate(characterCreators);
            // Assert
            Assert.Equal(false, characterCreators.Active);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var characterCreators = repository.Get(1);
            characterCreators.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(characterCreators);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectCharacterCreator()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            // Act
            var characterCreators = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", characterCreators.ApiDetailUrl);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectCharacterCreator()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            // Act
            var characterCreators = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", characterCreators.ApiDetailUrl);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_List_Should_ReturnAListOfCharacterCreatorsWithData()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            // Act
            var characterCreators = repository.List.ToArray();
            // Assert
            Assert.Equal(2, characterCreators.Length);
            Assert.Equal(1, characterCreators[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", characterCreators[0].ApiDetailUrl);
            Assert.Equal(2, characterCreators[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterCreators[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Search_Should_ReturnAListOfCharacterCreatorsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators, true);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var searchModel = new Mock<ICharacterCreatorSearchModel>();
            // Act
            var characterCreators = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, characterCreators.Length);
            Assert.Equal(2, characterCreators[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterCreators[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators, true);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var searchModel = new Mock<ICharacterCreatorSearchModel>();
            // Act
            var characterCreators = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, characterCreators.Length);
            Assert.Equal(2, characterCreators[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterCreators[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfCharacterCreatorsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators, true);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ICharacterCreatorSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new CharacterCreatorSearchModel { ModifiedSince = createDate };
            // Act
            var characterCreators = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, characterCreators.Length);
            Assert.Equal(2, characterCreators[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterCreators[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "CharacterCreators")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfCharacterCreatorsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterCreator>> mockSetCharacterCreators;
            var mockContext = CharacterCreatorsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterCreators);
            var repository = new CharacterCreatorsRepository(mockContext.Object);
            var searchModel = new CharacterCreatorSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var characterCreators = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, characterCreators.Length);
            Assert.Equal(2, characterCreators[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterCreators[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
