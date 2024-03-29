// <auto-generated>
// <copyright file="Issues.IssueAliasRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the IssueAliasesRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Issues
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

    public static class IssueAliasesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeIssueAliasesData, out Mock<IDbSet<IssueAlias>> mockSetIssueAliases, bool markAIssueAliasInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetIssueAliases = new Mock<IDbSet<IssueAlias>>();
            var personData = (!includeIssueAliasesData ? new List<IssueAlias>() : new List<IssueAlias>
            {
                new IssueAlias { Id = 1, Active = !markAIssueAliasInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new IssueAlias { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetIssueAliases.As<IQueryable<IssueAlias>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetIssueAliases.As<IQueryable<IssueAlias>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetIssueAliases.As<IQueryable<IssueAlias>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetIssueAliases.As<IQueryable<IssueAlias>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.IssueAliases).Returns(mockSetIssueAliases.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class IssueAliasesRepositoryTests
    {
        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(false, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var issueAliases = new IssueAlias { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(issueAliases);
            // Assert
            mockSetIssueAliases.Verify(x => x.Add(issueAliases), Times.Once);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var issueAliases = repository.Get(1);
            // Act
            repository.Remove(issueAliases);
            // Assert
            mockSetIssueAliases.Verify(x => x.Remove((IssueAlias)issueAliases), Times.Once);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var issueAliases = repository.Get(1);
            // Act
            repository.Deactivate(issueAliases);
            // Assert
            Assert.Equal(false, issueAliases.Active);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var issueAliases = repository.Get(1);
            issueAliases.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(issueAliases);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectIssueAlias()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            // Act
            var issueAliases = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", issueAliases.ApiDetailUrl);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectIssueAlias()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            // Act
            var issueAliases = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", issueAliases.ApiDetailUrl);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_List_Should_ReturnAListOfIssueAliasesWithData()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            // Act
            var issueAliases = repository.List.ToArray();
            // Assert
            Assert.Equal(2, issueAliases.Length);
            Assert.Equal(1, issueAliases[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", issueAliases[0].ApiDetailUrl);
            Assert.Equal(2, issueAliases[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", issueAliases[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Search_Should_ReturnAListOfIssueAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases, true);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var searchModel = new Mock<IIssueAliasSearchModel>();
            // Act
            var issueAliases = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, issueAliases.Length);
            Assert.Equal(2, issueAliases[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", issueAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases, true);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var searchModel = new Mock<IIssueAliasSearchModel>();
            // Act
            var issueAliases = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, issueAliases.Length);
            Assert.Equal(2, issueAliases[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", issueAliases[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfIssueAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases, true);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IIssueAliasSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new IssueAliasSearchModel { ModifiedSince = createDate };
            // Act
            var issueAliases = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, issueAliases.Length);
            Assert.Equal(2, issueAliases[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", issueAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "IssueAliases")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfIssueAliasesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<IssueAlias>> mockSetIssueAliases;
            var mockContext = IssueAliasesMockingSetup.DoMockingSetupForContext(true, out mockSetIssueAliases);
            var repository = new IssueAliasesRepository(mockContext.Object);
            var searchModel = new IssueAliasSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var issueAliases = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, issueAliases.Length);
            Assert.Equal(2, issueAliases[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", issueAliases[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
