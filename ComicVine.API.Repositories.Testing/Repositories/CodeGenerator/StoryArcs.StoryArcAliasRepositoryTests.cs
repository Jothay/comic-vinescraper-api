// <auto-generated>
// <copyright file="StoryArcs.IStoryArcAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcAliasesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.StoryArcs
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

    public static class StoryArcAliasesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeStoryArcAliasesData, out Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases, bool markAStoryArcAliasInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetStoryArcAliases = new Mock<IDbSet<StoryArcAlias>>();
            var personData = (!includeStoryArcAliasesData ? new List<StoryArcAlias>() : new List<StoryArcAlias>
            {
                new StoryArcAlias { Id = 1, Active = !markAStoryArcAliasInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new StoryArcAlias { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetStoryArcAliases.As<IQueryable<StoryArcAlias>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetStoryArcAliases.As<IQueryable<StoryArcAlias>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetStoryArcAliases.As<IQueryable<StoryArcAlias>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetStoryArcAliases.As<IQueryable<StoryArcAlias>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.StoryArcAliases).Returns(mockSetStoryArcAliases.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class StoryArcAliasesRepositoryTests
    {
        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(false, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var storyArcAliases = new StoryArcAlias { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
            // Act
            repository.Add(storyArcAliases);
            // Assert
            mockSetStoryArcAliases.Verify(x => x.Add(storyArcAliases), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var storyArcAliases = repository.Get(1);
            // Act
            repository.Remove(storyArcAliases);
            // Assert
            mockSetStoryArcAliases.Verify(x => x.Remove((StoryArcAlias)storyArcAliases), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var storyArcAliases = repository.Get(1);
            // Act
            repository.Deactivate(storyArcAliases);
            // Assert
            Assert.Equal(false, storyArcAliases.Active);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var storyArcAliases = repository.Get(1);
            storyArcAliases.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(storyArcAliases);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectStoryArcAlias()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            // Act
            var storyArcAliases = repository.Get(1);
            // Assert
            Assert.Equal("Stephen King", storyArcAliases.Name);            Assert.Equal("/TEST/KING-STEPHEN", storyArcAliases.ApiDetailUrl);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectStoryArcAlias()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            // Act
            var storyArcAliases = repository.Get("KING-STEPHEN");
            // Assert
            Assert.Equal("Stephen King", storyArcAliases.Name);            Assert.Equal("/TEST/KING-STEPHEN", storyArcAliases.ApiDetailUrl);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_List_Should_ReturnAListOfStoryArcAliasesWithData()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            // Act
            var storyArcAliases = repository.List.ToArray();
            // Assert
            Assert.Equal(2, storyArcAliases.Length);
            Assert.Equal(1, storyArcAliases[0].Id);
            Assert.Equal("Stephen King", storyArcAliases[0].Name);            Assert.Equal("/TEST/KING-STEPHEN", storyArcAliases[0].ApiDetailUrl);
            Assert.Equal(2, storyArcAliases[1].Id);
            Assert.Equal("Larry Niven", storyArcAliases[1].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcAliases[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Search_Should_ReturnAListOfStoryArcAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases, true);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var searchModel = new Mock<IStoryArcAliasSearchModel>();
            // Act
            var storyArcAliases = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, storyArcAliases.Length);
            Assert.Equal(2, storyArcAliases[0].Id);
            Assert.Equal("Larry Niven", storyArcAliases[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases, true);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var searchModel = new Mock<IStoryArcAliasSearchModel>();
            // Act
            var storyArcAliases = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl, MyName = i.Name }).ToArray();
            // Assert
            Assert.Equal(1, storyArcAliases.Length);
            Assert.Equal(2, storyArcAliases[0].Id);
            Assert.Equal("Larry Niven", storyArcAliases[0].MyName);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcAliases[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfStoryArcAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases, true);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IStoryArcAliasSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new StoryArcAliasSearchModel { ModifiedSince = createDate };
            // Act
            var storyArcAliases = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, storyArcAliases.Length);
            Assert.Equal(2, storyArcAliases[0].Id);
            Assert.Equal("Larry Niven", storyArcAliases[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "StoryArcAliases")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfStoryArcAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArcAlias>> mockSetStoryArcAliases;
            var mockContext = StoryArcAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcAliases);
            var repository = new StoryArcAliasesRepository(mockContext.Object);
            var searchModel = new StoryArcAliasSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var storyArcAliases = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, storyArcAliases.Length);
            Assert.Equal(2, storyArcAliases[0].Id);
            Assert.Equal("Larry Niven", storyArcAliases[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
