// <auto-generated>
// <copyright file="Movies.MovieStoryArcRepositoryTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieStoryArcsRepositoryTests class.</summary>
// <remarks>This file was auto-generated using RepositoryTestingFileMaster.tt in
// ComicVineScraper.API.Repositories.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.Repositories.Movies
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

    public static class MovieStoryArcsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeMovieStoryArcsData, out Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs, bool markAMovieStoryArcInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetMovieStoryArcs = new Mock<IDbSet<MovieStoryArc>>();
            var personData = (!includeMovieStoryArcsData ? new List<MovieStoryArc>() : new List<MovieStoryArc>
            {
                new MovieStoryArc { Id = 1, Active = !markAMovieStoryArcInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new MovieStoryArc { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetMovieStoryArcs.As<IQueryable<MovieStoryArc>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetMovieStoryArcs.As<IQueryable<MovieStoryArc>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetMovieStoryArcs.As<IQueryable<MovieStoryArc>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetMovieStoryArcs.As<IQueryable<MovieStoryArc>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.MovieStoryArcs).Returns(mockSetMovieStoryArcs.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class MovieStoryArcsRepositoryTests
    {
        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(false, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var movieStoryArcs = new MovieStoryArc { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(movieStoryArcs);
            // Assert
            mockSetMovieStoryArcs.Verify(x => x.Add(movieStoryArcs), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var movieStoryArcs = repository.Get(1);
            // Act
            repository.Remove(movieStoryArcs);
            // Assert
            mockSetMovieStoryArcs.Verify(x => x.Remove((MovieStoryArc)movieStoryArcs), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var movieStoryArcs = repository.Get(1);
            // Act
            repository.Deactivate(movieStoryArcs);
            // Assert
            Assert.Equal(false, movieStoryArcs.Active);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var movieStoryArcs = repository.Get(1);
            movieStoryArcs.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(movieStoryArcs);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectMovieStoryArc()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            // Act
            var movieStoryArcs = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", movieStoryArcs.ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectMovieStoryArc()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            // Act
            var movieStoryArcs = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", movieStoryArcs.ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_List_Should_ReturnAListOfMovieStoryArcsWithData()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            // Act
            var movieStoryArcs = repository.List.ToArray();
            // Assert
            Assert.Equal(2, movieStoryArcs.Length);
            Assert.Equal(1, movieStoryArcs[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", movieStoryArcs[0].ApiDetailUrl);
            Assert.Equal(2, movieStoryArcs[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieStoryArcs[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Search_Should_ReturnAListOfMovieStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs, true);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<IMovieStoryArcSearchModel>();
            // Act
            var movieStoryArcs = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, movieStoryArcs.Length);
            Assert.Equal(2, movieStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs, true);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var searchModel = new Mock<IMovieStoryArcSearchModel>();
            // Act
            var movieStoryArcs = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, movieStoryArcs.Length);
            Assert.Equal(2, movieStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieStoryArcs[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfMovieStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs, true);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IMovieStoryArcSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new MovieStoryArcSearchModel { ModifiedSince = createDate };
            // Act
            var movieStoryArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, movieStoryArcs.Length);
            Assert.Equal(2, movieStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "MovieStoryArcs")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfMovieStoryArcsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieStoryArc>> mockSetMovieStoryArcs;
            var mockContext = MovieStoryArcsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieStoryArcs);
            var repository = new MovieStoryArcsRepository(mockContext.Object);
            var searchModel = new MovieStoryArcSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var movieStoryArcs = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, movieStoryArcs.Length);
            Assert.Equal(2, movieStoryArcs[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieStoryArcs[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}