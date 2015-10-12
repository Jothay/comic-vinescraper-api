// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationFirstAppearanceRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocationFirstAppearancesRepository Class.</summary>
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

    public static class EpisodeLocationFirstAppearancesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeEpisodeLocationFirstAppearancesData, out Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances, bool markAEpisodeLocationFirstAppearanceInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetEpisodeLocationFirstAppearances = new Mock<IDbSet<EpisodeLocationFirstAppearance>>();
            var personData = (!includeEpisodeLocationFirstAppearancesData ? new List<EpisodeLocationFirstAppearance>() : new List<EpisodeLocationFirstAppearance>
            {
                new EpisodeLocationFirstAppearance { Id = 1, Active = !markAEpisodeLocationFirstAppearanceInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new EpisodeLocationFirstAppearance { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetEpisodeLocationFirstAppearances.As<IQueryable<EpisodeLocationFirstAppearance>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetEpisodeLocationFirstAppearances.As<IQueryable<EpisodeLocationFirstAppearance>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetEpisodeLocationFirstAppearances.As<IQueryable<EpisodeLocationFirstAppearance>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetEpisodeLocationFirstAppearances.As<IQueryable<EpisodeLocationFirstAppearance>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.EpisodeLocationFirstAppearances).Returns(mockSetEpisodeLocationFirstAppearances.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class EpisodeLocationFirstAppearancesRepositoryTests
    {
        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(false, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var episodeLocationFirstAppearances = new EpisodeLocationFirstAppearance { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(episodeLocationFirstAppearances);
            // Assert
            mockSetEpisodeLocationFirstAppearances.Verify(x => x.Add(episodeLocationFirstAppearances), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var episodeLocationFirstAppearances = repository.Get(1);
            // Act
            repository.Remove(episodeLocationFirstAppearances);
            // Assert
            mockSetEpisodeLocationFirstAppearances.Verify(x => x.Remove((EpisodeLocationFirstAppearance)episodeLocationFirstAppearances), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var episodeLocationFirstAppearances = repository.Get(1);
            // Act
            repository.Deactivate(episodeLocationFirstAppearances);
            // Assert
            Assert.Equal(false, episodeLocationFirstAppearances.Active);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var episodeLocationFirstAppearances = repository.Get(1);
            episodeLocationFirstAppearances.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(episodeLocationFirstAppearances);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectEpisodeLocationFirstAppearance()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            // Act
            var episodeLocationFirstAppearances = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", episodeLocationFirstAppearances.ApiDetailUrl);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectEpisodeLocationFirstAppearance()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            // Act
            var episodeLocationFirstAppearances = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", episodeLocationFirstAppearances.ApiDetailUrl);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_List_Should_ReturnAListOfEpisodeLocationFirstAppearancesWithData()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            // Act
            var episodeLocationFirstAppearances = repository.List.ToArray();
            // Assert
            Assert.Equal(2, episodeLocationFirstAppearances.Length);
            Assert.Equal(1, episodeLocationFirstAppearances[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", episodeLocationFirstAppearances[0].ApiDetailUrl);
            Assert.Equal(2, episodeLocationFirstAppearances[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeLocationFirstAppearances[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Search_Should_ReturnAListOfEpisodeLocationFirstAppearancesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances, true);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var searchModel = new Mock<IEpisodeLocationFirstAppearanceSearchModel>();
            // Act
            var episodeLocationFirstAppearances = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, episodeLocationFirstAppearances.Length);
            Assert.Equal(2, episodeLocationFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeLocationFirstAppearances[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances, true);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var searchModel = new Mock<IEpisodeLocationFirstAppearanceSearchModel>();
            // Act
            var episodeLocationFirstAppearances = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, episodeLocationFirstAppearances.Length);
            Assert.Equal(2, episodeLocationFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeLocationFirstAppearances[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfEpisodeLocationFirstAppearancesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances, true);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IEpisodeLocationFirstAppearanceSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new EpisodeLocationFirstAppearanceSearchModel { ModifiedSince = createDate };
            // Act
            var episodeLocationFirstAppearances = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, episodeLocationFirstAppearances.Length);
            Assert.Equal(2, episodeLocationFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeLocationFirstAppearances[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "EpisodeLocationFirstAppearances")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfEpisodeLocationFirstAppearancesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<EpisodeLocationFirstAppearance>> mockSetEpisodeLocationFirstAppearances;
            var mockContext = EpisodeLocationFirstAppearancesMockingSetup.DoMockingSetupForContext(true, out mockSetEpisodeLocationFirstAppearances);
            var repository = new EpisodeLocationFirstAppearancesRepository(mockContext.Object);
            var searchModel = new EpisodeLocationFirstAppearanceSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var episodeLocationFirstAppearances = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, episodeLocationFirstAppearances.Length);
            Assert.Equal(2, episodeLocationFirstAppearances[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", episodeLocationFirstAppearances[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
