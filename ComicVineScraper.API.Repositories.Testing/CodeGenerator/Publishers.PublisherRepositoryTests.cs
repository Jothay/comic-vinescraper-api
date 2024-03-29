// <auto-generated>
// <copyright file="Publishers.PublisherRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PublishersRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Publishers
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

    public static class PublishersMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includePublishersData, out Mock<IDbSet<Publisher>> mockSetPublishers, bool markAPublisherInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetPublishers = new Mock<IDbSet<Publisher>>();
            var personData = (!includePublishersData ? new List<Publisher>() : new List<Publisher>
            {
                new Publisher { Id = 1, Active = !markAPublisherInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new Publisher { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetPublishers.As<IQueryable<Publisher>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetPublishers.As<IQueryable<Publisher>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetPublishers.As<IQueryable<Publisher>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetPublishers.As<IQueryable<Publisher>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.Publishers).Returns(mockSetPublishers.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class PublishersRepositoryTests
    {
        [Fact][Trait("Category", "Publishers")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(false, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            var publishers = new Publisher { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(publishers);
            // Assert
            mockSetPublishers.Verify(x => x.Add(publishers), Times.Once);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            var publishers = repository.Get(1);
            // Act
            repository.Remove(publishers);
            // Assert
            mockSetPublishers.Verify(x => x.Remove((Publisher)publishers), Times.Once);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            var publishers = repository.Get(1);
            // Act
            repository.Deactivate(publishers);
            // Assert
            Assert.Equal(false, publishers.Active);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            var publishers = repository.Get(1);
            publishers.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(publishers);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectPublisher()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            // Act
            var publishers = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", publishers.ApiDetailUrl);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectPublisher()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            // Act
            var publishers = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", publishers.ApiDetailUrl);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_List_Should_ReturnAListOfPublishersWithData()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            // Act
            var publishers = repository.List.ToArray();
            // Assert
            Assert.Equal(2, publishers.Length);
            Assert.Equal(1, publishers[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", publishers[0].ApiDetailUrl);
            Assert.Equal(2, publishers[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", publishers[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Search_Should_ReturnAListOfPublishersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers, true);
            var repository = new PublishersRepository(mockContext.Object);
            var searchModel = new Mock<IPublisherSearchModel>();
            // Act
            var publishers = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, publishers.Length);
            Assert.Equal(2, publishers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", publishers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers, true);
            var repository = new PublishersRepository(mockContext.Object);
            var searchModel = new Mock<IPublisherSearchModel>();
            // Act
            var publishers = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, publishers.Length);
            Assert.Equal(2, publishers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", publishers[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfPublishersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers, true);
            var repository = new PublishersRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IPublisherSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new PublisherSearchModel { ModifiedSince = createDate };
            // Act
            var publishers = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, publishers.Length);
            Assert.Equal(2, publishers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", publishers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "Publishers")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfPublishersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<Publisher>> mockSetPublishers;
            var mockContext = PublishersMockingSetup.DoMockingSetupForContext(true, out mockSetPublishers);
            var repository = new PublishersRepository(mockContext.Object);
            var searchModel = new PublisherSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var publishers = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, publishers.Length);
            Assert.Equal(2, publishers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", publishers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
