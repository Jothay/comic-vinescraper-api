// <auto-generated>
// <copyright file="Movies.IMovieProducerRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieProducersRepository Class.</summary>
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

    public static class MovieProducersMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeMovieProducersData, out Mock<IDbSet<MovieProducer>> mockSetMovieProducers, bool markAMovieProducerInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetMovieProducers = new Mock<IDbSet<MovieProducer>>();
            var personData = (!includeMovieProducersData ? new List<MovieProducer>() : new List<MovieProducer>
            {
                new MovieProducer { Id = 1, Active = !markAMovieProducerInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", },
                new MovieProducer { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", }
            }).AsQueryable();
            mockSetMovieProducers.As<IQueryable<MovieProducer>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetMovieProducers.As<IQueryable<MovieProducer>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetMovieProducers.As<IQueryable<MovieProducer>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetMovieProducers.As<IQueryable<MovieProducer>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.MovieProducers).Returns(mockSetMovieProducers.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class MovieProducersRepositoryTests
    {
        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(false, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            var movieProducers = new MovieProducer { Active = true, CustomKey = "SALVATORE-RAA", };
            // Act
            repository.Add(movieProducers);
            // Assert
            mockSetMovieProducers.Verify(x => x.Add(movieProducers), Times.Once);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            var movieProducers = repository.Get(1);
            // Act
            repository.Remove(movieProducers);
            // Assert
            mockSetMovieProducers.Verify(x => x.Remove((MovieProducer)movieProducers), Times.Once);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            var movieProducers = repository.Get(1);
            // Act
            repository.Deactivate(movieProducers);
            // Assert
            Assert.Equal(false, movieProducers.Active);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            var movieProducers = repository.Get(1);
            movieProducers.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(movieProducers);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectMovieProducer()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            // Act
            var movieProducers = repository.Get(1);
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", movieProducers.ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectMovieProducer()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            // Act
            var movieProducers = repository.Get("KING-STEPHEN");
            // Assert
                        Assert.Equal("/TEST/KING-STEPHEN", movieProducers.ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_List_Should_ReturnAListOfMovieProducersWithData()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            // Act
            var movieProducers = repository.List.ToArray();
            // Assert
            Assert.Equal(2, movieProducers.Length);
            Assert.Equal(1, movieProducers[0].Id);
            Assert.Equal("/TEST/KING-STEPHEN", movieProducers[0].ApiDetailUrl);
            Assert.Equal(2, movieProducers[1].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieProducers[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Search_Should_ReturnAListOfMovieProducersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers, true);
            var repository = new MovieProducersRepository(mockContext.Object);
            var searchModel = new Mock<IMovieProducerSearchModel>();
            // Act
            var movieProducers = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, movieProducers.Length);
            Assert.Equal(2, movieProducers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieProducers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers, true);
            var repository = new MovieProducersRepository(mockContext.Object);
            var searchModel = new Mock<IMovieProducerSearchModel>();
            // Act
            var movieProducers = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl }).ToArray();
            // Assert
            Assert.Equal(1, movieProducers.Length);
            Assert.Equal(2, movieProducers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieProducers[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfMovieProducersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers, true);
            var repository = new MovieProducersRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IMovieProducerSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new MovieProducerSearchModel { ModifiedSince = createDate };
            // Act
            var movieProducers = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, movieProducers.Length);
            Assert.Equal(2, movieProducers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieProducers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "MovieProducers")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfMovieProducersWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<MovieProducer>> mockSetMovieProducers;
            var mockContext = MovieProducersMockingSetup.DoMockingSetupForContext(true, out mockSetMovieProducers);
            var repository = new MovieProducersRepository(mockContext.Object);
            var searchModel = new MovieProducerSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var movieProducers = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, movieProducers.Length);
            Assert.Equal(2, movieProducers[0].Id);
            Assert.Equal("/TEST/NIVEN-LARRY", movieProducers[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
