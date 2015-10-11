// <auto-generated>
// <copyright file="Episodes.IEpisodeObjectRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeObjectsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Episodes
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

    public static class EpisodeObjectsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeEpisodeObjectsData, out Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects, bool markAEpisodeObjectInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetEpisodeObjects = new Mock<IDbSet<EpisodeObject>>();
            var personData = (!includeEpisodeObjectsData ? new List<EpisodeObject>() : new List<EpisodeObject>
            {
                new EpisodeObject { Id = 1, Active = !markAEpisodeObjectInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new EpisodeObject { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetEpisodeObjects.As<IQueryable<EpisodeObject>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetEpisodeObjects.As<IQueryable<EpisodeObject>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetEpisodeObjects.As<IQueryable<EpisodeObject>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetEpisodeObjects.As<IQueryable<EpisodeObject>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.EpisodeObjects).Returns(mockSetEpisodeObjects.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class EpisodeObjectsRepositoryTests
    {
        [Fact]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(false, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var episodeObjects = new EpisodeObject { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(episodeObjects);
            // Assert
            mockSetEpisodeObjects.Verify(x => x.Add(episodeObjects), Times.Once);
        }

        [Fact]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var episodeObjects = repository.Get(1);
            // Act
            repository.Remove(episodeObjects);
            // Assert
            mockSetEpisodeObjects.Verify(x => x.Remove((EpisodeObject)episodeObjects), Times.Once);
        }

        [Fact]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var episodeObjects = repository.Get(1);
            // Act
            repository.Deactivate(episodeObjects);
            // Assert
            Assert.Equal(false, episodeObjects.Active);
        }

        [Fact]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var episodeObjects = repository.Get(1);
            episodeObjects.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(episodeObjects);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectEpisodeObject()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            // Act
            var episodeObjects = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", episodeObjects.ApiDetailUrl);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectEpisodeObject()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            // Act
            var episodeObjects = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", episodeObjects.ApiDetailUrl);
        }

        [Fact]
        public void Verify_List_Should_ReturnAListOfEpisodeObjectsWithData()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            // Act
            var episodeObjects = repository.List.ToArray();
            // Assert
            Assert.Equal(2, episodeObjects.Length);
            Assert.Equal(1, episodeObjects[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", episodeObjects[0].ApiDetailUrl);
            Assert.Equal(2, episodeObjects[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjects[1].ApiDetailUrl);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfEpisodeObjectsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects, true);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var searchModel = new Mock<IEpisodeObjectSearchModel>();
            // Act
            var episodeObjects = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, episodeObjects.Length);
            Assert.Equal(2, episodeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjects[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects, true);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var searchModel = new Mock<IEpisodeObjectSearchModel>();
            // Act
            var episodeObjects = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, episodeObjects.Length);
            Assert.Equal(2, episodeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjects[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfEpisodeObjectsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects, true);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IEpisodeObjectSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new EpisodeObjectSearchModel { ModifiedSince = createDate };
            // Act
            var episodeObjects = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, episodeObjects.Length);
            Assert.Equal(2, episodeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjects[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact]
        public void Verify_Search_WithPaging_Should_ReturnAListOfEpisodeObjectsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeObject>> mockSetEpisodeObjects;
            var mockContext = EpisodeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjects);
            var repository = new EpisodeObjectsRepository(mockContext.Object);
            var searchModel = new EpisodeObjectSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var episodeObjects = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, episodeObjects.Length);
            Assert.Equal(2, episodeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjects[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
