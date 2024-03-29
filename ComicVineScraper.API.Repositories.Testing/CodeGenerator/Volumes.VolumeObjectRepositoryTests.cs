// <auto-generated>
// <copyright file="Volumes.VolumeObjectRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeObjectsRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Volumes
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

    public static class VolumeObjectsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeVolumeObjectsData, out Mock<IDbSet<VolumeObject>> mockSetVolumeObjects, bool markAVolumeObjectInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetVolumeObjects = new Mock<IDbSet<VolumeObject>>();
            var personData = (!includeVolumeObjectsData ? new List<VolumeObject>() : new List<VolumeObject>
            {
                new VolumeObject { Id = 1, Active = !markAVolumeObjectInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new VolumeObject { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetVolumeObjects.As<IQueryable<VolumeObject>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetVolumeObjects.As<IQueryable<VolumeObject>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetVolumeObjects.As<IQueryable<VolumeObject>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetVolumeObjects.As<IQueryable<VolumeObject>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.VolumeObjects).Returns(mockSetVolumeObjects.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class VolumeObjectsRepositoryTests
    {
        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(false, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var volumeObjects = new VolumeObject { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(volumeObjects);
            // Assert
            mockSetVolumeObjects.Verify(x => x.Add(volumeObjects), Times.Once);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var volumeObjects = repository.Get(1);
            // Act
            repository.Remove(volumeObjects);
            // Assert
            mockSetVolumeObjects.Verify(x => x.Remove((VolumeObject)volumeObjects), Times.Once);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var volumeObjects = repository.Get(1);
            // Act
            repository.Deactivate(volumeObjects);
            // Assert
            Assert.Equal(false, volumeObjects.Active);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var volumeObjects = repository.Get(1);
            volumeObjects.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(volumeObjects);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectVolumeObject()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            // Act
            var volumeObjects = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", volumeObjects.ApiDetailUrl);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectVolumeObject()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            // Act
            var volumeObjects = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", volumeObjects.ApiDetailUrl);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_List_Should_ReturnAListOfVolumeObjectsWithData()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            // Act
            var volumeObjects = repository.List.ToArray();
            // Assert
            Assert.Equal(2, volumeObjects.Length);
            Assert.Equal(1, volumeObjects[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", volumeObjects[0].ApiDetailUrl);
            Assert.Equal(2, volumeObjects[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", volumeObjects[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Search_Should_ReturnAListOfVolumeObjectsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects, true);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var searchModel = new Mock<IVolumeObjectSearchModel>();
            // Act
            var volumeObjects = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, volumeObjects.Length);
            Assert.Equal(2, volumeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", volumeObjects[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects, true);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var searchModel = new Mock<IVolumeObjectSearchModel>();
            // Act
            var volumeObjects = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, volumeObjects.Length);
            Assert.Equal(2, volumeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", volumeObjects[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfVolumeObjectsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects, true);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IVolumeObjectSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new VolumeObjectSearchModel { ModifiedSince = createDate };
            // Act
            var volumeObjects = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, volumeObjects.Length);
            Assert.Equal(2, volumeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", volumeObjects[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "VolumeObjects")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfVolumeObjectsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<VolumeObject>> mockSetVolumeObjects;
            var mockContext = VolumeObjectsMockingSetup.DoMockingSetupForContext(true, out mockSetVolumeObjects);
            var repository = new VolumeObjectsRepository(mockContext.Object);
            var searchModel = new VolumeObjectSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var volumeObjects = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, volumeObjects.Length);
            Assert.Equal(2, volumeObjects[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", volumeObjects[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
