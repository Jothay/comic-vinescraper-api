// <auto-generated>
// <copyright file="Concepts.ConceptIssueRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ConceptIssuesRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Concepts
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

    public static class ConceptIssuesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeConceptIssuesData, out Mock<IDbSet<ConceptIssue>> mockSetConceptIssues, bool markAConceptIssueInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetConceptIssues = new Mock<IDbSet<ConceptIssue>>();
            var personData = (!includeConceptIssuesData ? new List<ConceptIssue>() : new List<ConceptIssue>
            {
                new ConceptIssue { Id = 1, Active = !markAConceptIssueInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new ConceptIssue { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetConceptIssues.As<IQueryable<ConceptIssue>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetConceptIssues.As<IQueryable<ConceptIssue>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetConceptIssues.As<IQueryable<ConceptIssue>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetConceptIssues.As<IQueryable<ConceptIssue>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.ConceptIssues).Returns(mockSetConceptIssues.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class ConceptIssuesRepositoryTests
    {
        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(false, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var conceptIssues = new ConceptIssue { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(conceptIssues);
            // Assert
            mockSetConceptIssues.Verify(x => x.Add(conceptIssues), Times.Once);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var conceptIssues = repository.Get(1);
            // Act
            repository.Remove(conceptIssues);
            // Assert
            mockSetConceptIssues.Verify(x => x.Remove((ConceptIssue)conceptIssues), Times.Once);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var conceptIssues = repository.Get(1);
            // Act
            repository.Deactivate(conceptIssues);
            // Assert
            Assert.Equal(false, conceptIssues.Active);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var conceptIssues = repository.Get(1);
            conceptIssues.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(conceptIssues);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectConceptIssue()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            // Act
            var conceptIssues = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", conceptIssues.ApiDetailUrl);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectConceptIssue()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            // Act
            var conceptIssues = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", conceptIssues.ApiDetailUrl);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_List_Should_ReturnAListOfConceptIssuesWithData()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            // Act
            var conceptIssues = repository.List.ToArray();
            // Assert
            Assert.Equal(2, conceptIssues.Length);
            Assert.Equal(1, conceptIssues[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", conceptIssues[0].ApiDetailUrl);
            Assert.Equal(2, conceptIssues[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", conceptIssues[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Search_Should_ReturnAListOfConceptIssuesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues, true);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var searchModel = new Mock<IConceptIssueSearchModel>();
            // Act
            var conceptIssues = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, conceptIssues.Length);
            Assert.Equal(2, conceptIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", conceptIssues[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues, true);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var searchModel = new Mock<IConceptIssueSearchModel>();
            // Act
            var conceptIssues = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, conceptIssues.Length);
            Assert.Equal(2, conceptIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", conceptIssues[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfConceptIssuesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues, true);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IConceptIssueSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new ConceptIssueSearchModel { ModifiedSince = createDate };
            // Act
            var conceptIssues = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, conceptIssues.Length);
            Assert.Equal(2, conceptIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", conceptIssues[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "ConceptIssues")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfConceptIssuesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<ConceptIssue>> mockSetConceptIssues;
            var mockContext = ConceptIssuesMockingSetup.DoMockingSetupForContext(true, out mockSetConceptIssues);
            var repository = new ConceptIssuesRepository(mockContext.Object);
            var searchModel = new ConceptIssueSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var conceptIssues = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, conceptIssues.Length);
            Assert.Equal(2, conceptIssues[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", conceptIssues[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
