// <auto-generated>
// <copyright file="Movies.IMovieConceptRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieConceptsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Movies
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

    public static class MovieConceptsMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeMovieConceptsData, out Mock<IDbSet<MovieConcept>> mockSetMovieConcepts, bool markAMovieConceptInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetMovieConcepts = new Mock<IDbSet<MovieConcept>>();
            var personData = (!includeMovieConceptsData ? new List<MovieConcept>() : new List<MovieConcept>
            {
                new MovieConcept { Id = 1, Active = !markAMovieConceptInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new MovieConcept { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetMovieConcepts.As<IQueryable<MovieConcept>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetMovieConcepts.As<IQueryable<MovieConcept>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetMovieConcepts.As<IQueryable<MovieConcept>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetMovieConcepts.As<IQueryable<MovieConcept>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.MovieConcepts).Returns(mockSetMovieConcepts.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class MovieConceptsRepositoryTests
    {
        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(false, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var movieConcepts = new MovieConcept { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(movieConcepts);
            // Assert
            mockSetMovieConcepts.Verify(x => x.Add(movieConcepts), Times.Once);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var movieConcepts = repository.Get(1);
            // Act
            repository.Remove(movieConcepts);
            // Assert
            mockSetMovieConcepts.Verify(x => x.Remove((MovieConcept)movieConcepts), Times.Once);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var movieConcepts = repository.Get(1);
            // Act
            repository.Deactivate(movieConcepts);
            // Assert
            Assert.Equal(false, movieConcepts.Active);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var movieConcepts = repository.Get(1);
            movieConcepts.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(movieConcepts);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectMovieConcept()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            // Act
            var movieConcepts = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", movieConcepts.ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectMovieConcept()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            // Act
            var movieConcepts = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", movieConcepts.ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_List_Should_ReturnAListOfMovieConceptsWithData()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            // Act
            var movieConcepts = repository.List.ToArray();
            // Assert
            Assert.Equal(2, movieConcepts.Length);
            Assert.Equal(1, movieConcepts[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", movieConcepts[0].ApiDetailUrl);
            Assert.Equal(2, movieConcepts[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieConcepts[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Search_Should_ReturnAListOfMovieConceptsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts, true);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var searchModel = new Mock<IMovieConceptSearchModel>();
            // Act
            var movieConcepts = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, movieConcepts.Length);
            Assert.Equal(2, movieConcepts[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieConcepts[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts, true);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var searchModel = new Mock<IMovieConceptSearchModel>();
            // Act
            var movieConcepts = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, movieConcepts.Length);
            Assert.Equal(2, movieConcepts[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieConcepts[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfMovieConceptsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts, true);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IMovieConceptSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new MovieConceptSearchModel { ModifiedSince = createDate };
            // Act
            var movieConcepts = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, movieConcepts.Length);
            Assert.Equal(2, movieConcepts[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieConcepts[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "MovieConcepts")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfMovieConceptsWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieConcept>> mockSetMovieConcepts;
            var mockContext = MovieConceptsMockingSetup.DoMockingSetupForContext(true, out mockSetMovieConcepts);
            var repository = new MovieConceptsRepository(mockContext.Object);
            var searchModel = new MovieConceptSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var movieConcepts = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, movieConcepts.Length);
            Assert.Equal(2, movieConcepts[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieConcepts[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
