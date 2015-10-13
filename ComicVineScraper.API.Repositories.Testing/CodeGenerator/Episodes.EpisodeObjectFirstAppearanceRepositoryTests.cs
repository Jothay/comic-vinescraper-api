// <auto-generated>
// <copyright file="Episodes.EpisodeObjectFirstAppearanceRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeObjectFirstAppearancesRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Episodes
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

    public static class EpisodeObjectFirstAppearancesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeEpisodeObjectFirstAppearancesData, out Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances, bool markAEpisodeObjectFirstAppearanceInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetEpisodeObjectFirstAppearances = new Mock<IDbSet<EpisodeObjectFirstAppearance>>();
            var personData = (!includeEpisodeObjectFirstAppearancesData ? new List<EpisodeObjectFirstAppearance>() : new List<EpisodeObjectFirstAppearance>
            {
                new EpisodeObjectFirstAppearance { Id = 1, Active = !markAEpisodeObjectFirstAppearanceInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new EpisodeObjectFirstAppearance { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetEpisodeObjectFirstAppearances.As<IQueryable<EpisodeObjectFirstAppearance>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetEpisodeObjectFirstAppearances.As<IQueryable<EpisodeObjectFirstAppearance>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetEpisodeObjectFirstAppearances.As<IQueryable<EpisodeObjectFirstAppearance>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetEpisodeObjectFirstAppearances.As<IQueryable<EpisodeObjectFirstAppearance>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.EpisodeObjectFirstAppearances).Returns(mockSetEpisodeObjectFirstAppearances.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class EpisodeObjectFirstAppearancesRepositoryTests
    {
        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(false, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var episodeObjectFirstAppearances = new EpisodeObjectFirstAppearance { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(episodeObjectFirstAppearances);
            // Assert
            mockSetEpisodeObjectFirstAppearances.Verify(x => x.Add(episodeObjectFirstAppearances), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var episodeObjectFirstAppearances = repository.Get(1);
            // Act
            repository.Remove(episodeObjectFirstAppearances);
            // Assert
            mockSetEpisodeObjectFirstAppearances.Verify(x => x.Remove((EpisodeObjectFirstAppearance)episodeObjectFirstAppearances), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var episodeObjectFirstAppearances = repository.Get(1);
            // Act
            repository.Deactivate(episodeObjectFirstAppearances);
            // Assert
            Assert.Equal(false, episodeObjectFirstAppearances.Active);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var episodeObjectFirstAppearances = repository.Get(1);
            episodeObjectFirstAppearances.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(episodeObjectFirstAppearances);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectEpisodeObjectFirstAppearance()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            // Act
            var episodeObjectFirstAppearances = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", episodeObjectFirstAppearances.ApiDetailUrl);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectEpisodeObjectFirstAppearance()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            // Act
            var episodeObjectFirstAppearances = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", episodeObjectFirstAppearances.ApiDetailUrl);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_List_Should_ReturnAListOfEpisodeObjectFirstAppearancesWithData()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            // Act
            var episodeObjectFirstAppearances = repository.List.ToArray();
            // Assert
            Assert.Equal(2, episodeObjectFirstAppearances.Length);
            Assert.Equal(1, episodeObjectFirstAppearances[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", episodeObjectFirstAppearances[0].ApiDetailUrl);
            Assert.Equal(2, episodeObjectFirstAppearances[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjectFirstAppearances[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Search_Should_ReturnAListOfEpisodeObjectFirstAppearancesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances, true);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var searchModel = new Mock<IEpisodeObjectFirstAppearanceSearchModel>();
            // Act
            var episodeObjectFirstAppearances = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, episodeObjectFirstAppearances.Length);
            Assert.Equal(2, episodeObjectFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjectFirstAppearances[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances, true);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var searchModel = new Mock<IEpisodeObjectFirstAppearanceSearchModel>();
            // Act
            var episodeObjectFirstAppearances = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, episodeObjectFirstAppearances.Length);
            Assert.Equal(2, episodeObjectFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjectFirstAppearances[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfEpisodeObjectFirstAppearancesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances, true);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IEpisodeObjectFirstAppearanceSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new EpisodeObjectFirstAppearanceSearchModel { ModifiedSince = createDate };
            // Act
            var episodeObjectFirstAppearances = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, episodeObjectFirstAppearances.Length);
            Assert.Equal(2, episodeObjectFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjectFirstAppearances[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "EpisodeObjectFirstAppearances")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfEpisodeObjectFirstAppearancesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeObjectFirstAppearance>> mockSetEpisodeObjectFirstAppearances;
            var mockContext = EpisodeObjectFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeObjectFirstAppearances);
            var repository = new EpisodeObjectFirstAppearancesRepository(mockContext.Object);
            var searchModel = new EpisodeObjectFirstAppearanceSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var episodeObjectFirstAppearances = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, episodeObjectFirstAppearances.Length);
            Assert.Equal(2, episodeObjectFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeObjectFirstAppearances[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}