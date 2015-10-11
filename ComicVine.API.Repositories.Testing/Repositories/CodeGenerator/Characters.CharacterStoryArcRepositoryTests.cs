// <auto-generated>
// <copyright file="Characters.ICharacterStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterStoryArcsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Characters
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

    public static class CharacterStoryArcsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeCharacterStoryArcsData, out Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs, bool markACharacterStoryArcInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetCharacterStoryArcs = new Mock<IDbSet<CharacterStoryArc>>();
            var personData = (!includeCharacterStoryArcsData ? new List<CharacterStoryArc>() : new List<CharacterStoryArc>
            {
                new CharacterStoryArc { Id = 1, Active = !markACharacterStoryArcInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new CharacterStoryArc { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetCharacterStoryArcs.As<IQueryable<CharacterStoryArc>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetCharacterStoryArcs.As<IQueryable<CharacterStoryArc>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetCharacterStoryArcs.As<IQueryable<CharacterStoryArc>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetCharacterStoryArcs.As<IQueryable<CharacterStoryArc>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.CharacterStoryArcs).Returns(mockSetCharacterStoryArcs.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class CharacterStoryArcsRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(false, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var characterStoryArcs = new CharacterStoryArc { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(characterStoryArcs);
            // Assert
            mockSetCharacterStoryArcs.Verify(x => x.Add(characterStoryArcs), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var characterStoryArcs = repository.Get(1);
            // Act
            repository.Remove(characterStoryArcs);
            // Assert
            mockSetCharacterStoryArcs.Verify(x => x.Remove((CharacterStoryArc)characterStoryArcs), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var characterStoryArcs = repository.Get(1);
            // Act
            repository.Deactivate(characterStoryArcs);
            // Assert
            Assert.Equal(false, characterStoryArcs.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var characterStoryArcs = repository.Get(1);
            characterStoryArcs.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(characterStoryArcs);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectCharacterStoryArc()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            // Act
            var characterStoryArcs = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", characterStoryArcs.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectCharacterStoryArc()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            // Act
            var characterStoryArcs = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", characterStoryArcs.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfCharacterStoryArcsWithData()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            // Act
            var characterStoryArcs = repository.List.ToArray();
            // Assert
            Assert.Equal(2, characterStoryArcs.Length);
            Assert.Equal(1, characterStoryArcs[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", characterStoryArcs[0].ApiDetailUrl);
            Assert.Equal(2, characterStoryArcs[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterStoryArcs[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfCharacterStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs, true);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<ICharacterStoryArcSearchModel>();
            // Act
            var characterStoryArcs = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, characterStoryArcs.Length);
            Assert.Equal(2, characterStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs, true);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<ICharacterStoryArcSearchModel>();
            // Act
            var characterStoryArcs = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, characterStoryArcs.Length);
            Assert.Equal(2, characterStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterStoryArcs[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfCharacterStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs, true);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<ICharacterStoryArcSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new CharacterStoryArcSearchModel { ModifiedSince = createDate };
            // Act
            var characterStoryArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, characterStoryArcs.Length);
            Assert.Equal(2, characterStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfCharacterStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<CharacterStoryArc>> mockSetCharacterStoryArcs;
            var mockContext = CharacterStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetCharacterStoryArcs);
            var repository = new CharacterStoryArcsRepository(mockContext.Object);
            var searchModel = new CharacterStoryArcSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var characterStoryArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, characterStoryArcs.Length);
            Assert.Equal(2, characterStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", characterStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
