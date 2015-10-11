// <auto-generated>
// <copyright file="StoryArcs.IStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcsRepository Class.</summary>
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

    public static class StoryArcsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeStoryArcsData, out Mock<IDbSet<StoryArc>> mockSetStoryArcs, bool markAStoryArcInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetStoryArcs = new Mock<IDbSet<StoryArc>>();
            var personData = (!includeStoryArcsData ? new List<StoryArc>() : new List<StoryArc>
            {
                new StoryArc { Id = 1, Active = !markAStoryArcInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new StoryArc { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetStoryArcs.As<IQueryable<StoryArc>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetStoryArcs.As<IQueryable<StoryArc>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetStoryArcs.As<IQueryable<StoryArc>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetStoryArcs.As<IQueryable<StoryArc>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.StoryArcs).Returns(mockSetStoryArcs.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class StoryArcsRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(false, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            var storyArcs = new StoryArc { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
            // Act
            repository.Add(storyArcs);
            // Assert
            mockSetStoryArcs.Verify(x => x.Add(storyArcs), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            var storyArcs = repository.Get(1);
            // Act
            repository.Remove(storyArcs);
            // Assert
            mockSetStoryArcs.Verify(x => x.Remove((StoryArc)storyArcs), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            var storyArcs = repository.Get(1);
            // Act
            repository.Deactivate(storyArcs);
            // Assert
            Assert.Equal(false, storyArcs.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            var storyArcs = repository.Get(1);
            storyArcs.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(storyArcs);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectStoryArc()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            // Act
            var storyArcs = repository.Get(1);
            // Assert
            Assert.Equal("Stephen King", storyArcs.Name);            Assert.Equal("/TEST/KING-STEPHEN", storyArcs.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectStoryArc()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            // Act
            var storyArcs = repository.Get("KING-STEPHEN");
            // Assert
            Assert.Equal("Stephen King", storyArcs.Name);            Assert.Equal("/TEST/KING-STEPHEN", storyArcs.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfStoryArcsWithData()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            // Act
            var storyArcs = repository.List.ToArray();
            // Assert
            Assert.Equal(2, storyArcs.Length);
            Assert.Equal(1, storyArcs[0].Id);
            Assert.Equal("Stephen King", storyArcs[0].Name);            Assert.Equal("/TEST/KING-STEPHEN", storyArcs[0].ApiDetailUrl);
            Assert.Equal(2, storyArcs[1].Id);
            Assert.Equal("Larry Niven", storyArcs[1].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcs[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs, true);
            var repository = new StoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<IStoryArcSearchModel>();
            // Act
            var storyArcs = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, storyArcs.Length);
            Assert.Equal(2, storyArcs[0].Id);
            Assert.Equal("Larry Niven", storyArcs[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs, true);
            var repository = new StoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<IStoryArcSearchModel>();
            // Act
            var storyArcs = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl, MyName = i.Name }).ToArray();
            // Assert
            Assert.Equal(1, storyArcs.Length);
            Assert.Equal(2, storyArcs[0].Id);
            Assert.Equal("Larry Niven", storyArcs[0].MyName);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcs[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs, true);
            var repository = new StoryArcsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IStoryArcSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new StoryArcSearchModel { ModifiedSince = createDate };
            // Act
            var storyArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, storyArcs.Length);
            Assert.Equal(2, storyArcs[0].Id);
            Assert.Equal("Larry Niven", storyArcs[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArc>> mockSetStoryArcs;
            var mockContext = StoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcs);
            var repository = new StoryArcsRepository(mockContext.Object);
            var searchModel = new StoryArcSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var storyArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, storyArcs.Length);
            Assert.Equal(2, storyArcs[0].Id);
            Assert.Equal("Larry Niven", storyArcs[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", storyArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}