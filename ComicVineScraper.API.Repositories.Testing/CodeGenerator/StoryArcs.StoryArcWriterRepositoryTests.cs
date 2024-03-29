// <auto-generated>
// <copyright file="StoryArcs.StoryArcWriterRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the StoryArcWritersRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.StoryArcs
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

    public static class StoryArcWritersMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeStoryArcWritersData, out Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters, bool markAStoryArcWriterInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetStoryArcWriters = new Mock<IDbSet<StoryArcWriter>>();
            var personData = (!includeStoryArcWritersData ? new List<StoryArcWriter>() : new List<StoryArcWriter>
            {
                new StoryArcWriter { Id = 1, Active = !markAStoryArcWriterInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new StoryArcWriter { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetStoryArcWriters.As<IQueryable<StoryArcWriter>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetStoryArcWriters.As<IQueryable<StoryArcWriter>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetStoryArcWriters.As<IQueryable<StoryArcWriter>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetStoryArcWriters.As<IQueryable<StoryArcWriter>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.StoryArcWriters).Returns(mockSetStoryArcWriters.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class StoryArcWritersRepositoryTests
    {
        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(false, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var storyArcWriters = new StoryArcWriter { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(storyArcWriters);
            // Assert
            mockSetStoryArcWriters.Verify(x => x.Add(storyArcWriters), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var storyArcWriters = repository.Get(1);
            // Act
            repository.Remove(storyArcWriters);
            // Assert
            mockSetStoryArcWriters.Verify(x => x.Remove((StoryArcWriter)storyArcWriters), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var storyArcWriters = repository.Get(1);
            // Act
            repository.Deactivate(storyArcWriters);
            // Assert
            Assert.Equal(false, storyArcWriters.Active);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var storyArcWriters = repository.Get(1);
            storyArcWriters.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(storyArcWriters);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectStoryArcWriter()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            // Act
            var storyArcWriters = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", storyArcWriters.ApiDetailUrl);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectStoryArcWriter()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            // Act
            var storyArcWriters = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", storyArcWriters.ApiDetailUrl);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_List_Should_ReturnAListOfStoryArcWritersWithData()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            // Act
            var storyArcWriters = repository.List.ToArray();
            // Assert
            Assert.Equal(2, storyArcWriters.Length);
            Assert.Equal(1, storyArcWriters[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", storyArcWriters[0].ApiDetailUrl);
            Assert.Equal(2, storyArcWriters[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", storyArcWriters[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Search_Should_ReturnAListOfStoryArcWritersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters, true);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var searchModel = new Mock<IStoryArcWriterSearchModel>();
            // Act
            var storyArcWriters = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, storyArcWriters.Length);
            Assert.Equal(2, storyArcWriters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", storyArcWriters[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters, true);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var searchModel = new Mock<IStoryArcWriterSearchModel>();
            // Act
            var storyArcWriters = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, storyArcWriters.Length);
            Assert.Equal(2, storyArcWriters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", storyArcWriters[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfStoryArcWritersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters, true);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IStoryArcWriterSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new StoryArcWriterSearchModel { ModifiedSince = createDate };
            // Act
            var storyArcWriters = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, storyArcWriters.Length);
            Assert.Equal(2, storyArcWriters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", storyArcWriters[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "StoryArcWriters")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfStoryArcWritersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<StoryArcWriter>> mockSetStoryArcWriters;
            var mockContext = StoryArcWritersMockingSetup.DoMockingSetupForContext(true, out mockSetStoryArcWriters);
            var repository = new StoryArcWritersRepository(mockContext.Object);
            var searchModel = new StoryArcWriterSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var storyArcWriters = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, storyArcWriters.Length);
            Assert.Equal(2, storyArcWriters[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", storyArcWriters[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
