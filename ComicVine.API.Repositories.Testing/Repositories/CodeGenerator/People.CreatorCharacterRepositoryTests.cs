// <auto-generated>
// <copyright file="People.ICreatorCharacterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CreatorCharactersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.People
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

    public static class CreatorCharactersMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeCreatorCharactersData, out Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters, bool markACreatorCharacterInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetCreatorCharacters = new Mock<IDbSet<CreatorCharacter>>();
            var personData = (!includeCreatorCharactersData ? new List<CreatorCharacter>() : new List<CreatorCharacter>
            {
                new CreatorCharacter { Id = 1, Active = !markACreatorCharacterInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new CreatorCharacter { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetCreatorCharacters.As<IQueryable<CreatorCharacter>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetCreatorCharacters.As<IQueryable<CreatorCharacter>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetCreatorCharacters.As<IQueryable<CreatorCharacter>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetCreatorCharacters.As<IQueryable<CreatorCharacter>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.CreatorCharacters).Returns(mockSetCreatorCharacters.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class CreatorCharactersRepositoryTests
    {
        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(false, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var creatorCharacters = new CreatorCharacter { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(creatorCharacters);
            // Assert
            mockSetCreatorCharacters.Verify(x => x.Add(creatorCharacters), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var creatorCharacters = repository.Get(1);
            // Act
            repository.Remove(creatorCharacters);
            // Assert
            mockSetCreatorCharacters.Verify(x => x.Remove((CreatorCharacter)creatorCharacters), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var creatorCharacters = repository.Get(1);
            // Act
            repository.Deactivate(creatorCharacters);
            // Assert
            Assert.Equal(false, creatorCharacters.Active);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var creatorCharacters = repository.Get(1);
            creatorCharacters.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(creatorCharacters);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectCreatorCharacter()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            // Act
            var creatorCharacters = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", creatorCharacters.ApiDetailUrl);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectCreatorCharacter()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            // Act
            var creatorCharacters = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", creatorCharacters.ApiDetailUrl);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_List_Should_ReturnAListOfCreatorCharactersWithData()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            // Act
            var creatorCharacters = repository.List.ToArray();
            // Assert
            Assert.Equal(2, creatorCharacters.Length);
            Assert.Equal(1, creatorCharacters[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", creatorCharacters[0].ApiDetailUrl);
            Assert.Equal(2, creatorCharacters[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", creatorCharacters[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Search_Should_ReturnAListOfCreatorCharactersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters, true);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var searchModel = new Mock<ICreatorCharacterSearchModel>();
            // Act
            var creatorCharacters = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, creatorCharacters.Length);
            Assert.Equal(2, creatorCharacters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", creatorCharacters[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters, true);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var searchModel = new Mock<ICreatorCharacterSearchModel>();
            // Act
            var creatorCharacters = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, creatorCharacters.Length);
            Assert.Equal(2, creatorCharacters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", creatorCharacters[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfCreatorCharactersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters, true);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ICreatorCharacterSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new CreatorCharacterSearchModel { ModifiedSince = createDate };
            // Act
            var creatorCharacters = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, creatorCharacters.Length);
            Assert.Equal(2, creatorCharacters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", creatorCharacters[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "CreatorCharacters")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfCreatorCharactersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CreatorCharacter>> mockSetCreatorCharacters;
            var mockContext = CreatorCharactersMockingSetup.DoMockingSetupForContext(true, out mockSetCreatorCharacters);
            var repository = new CreatorCharactersRepository(mockContext.Object);
            var searchModel = new CreatorCharacterSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var creatorCharacters = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, creatorCharacters.Length);
            Assert.Equal(2, creatorCharacters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", creatorCharacters[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
