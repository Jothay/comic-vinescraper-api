// <auto-generated>
// <copyright file="Objects.IObjectMovieBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectMoviesRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Objects
{
    using System.Collections.Generic;
    using API.BusinessWorkflows;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;
    using Models;
    using Moq;
    using Xunit;

    public static class ObjectMoviesMockingSetup
    {
        public static Mock<IObjectMovieModel> DoMockingSetupForObjectMovieModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectMovieModel = new Mock<IObjectMovieModel>();
            // Mock Functions
            mockObjectMovieModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectMovieModel.Setup(m => m.Active).Returns(() => true);
            mockObjectMovieModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectMovieModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovieModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovieModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectMovieModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockObjectMovieModel.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectMovieModel.Setup(m => m.Object).Returns(() => new ObjectModel());
            mockObjectMovieModel.Setup(m => m.MovieId).Returns(() => 1);
            mockObjectMovieModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            // Associated Objects
            // <None>
            // Return
            return mockObjectMovieModel;
        }

        public static Mock<IObjectMovie> DoMockingSetupForObjectMovie(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockObjectMovie = new Mock<IObjectMovie>();
            // Mock Functions
            mockObjectMovie.Setup(m => m.Id).Returns(() => idReturnValue);
            mockObjectMovie.Setup(m => m.Active).Returns(() => true);
            mockObjectMovie.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockObjectMovie.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovie.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockObjectMovie.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockObjectMovie.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockObjectMovie.Setup(m => m.ObjectId).Returns(() => 1);
            mockObjectMovie.Setup(m => m.Object).Returns(() => new Object());
            mockObjectMovie.Setup(m => m.MovieId).Returns(() => 1);
            mockObjectMovie.Setup(m => m.Movie).Returns(() => new Movie());
            // Associated Objects
            // <None>
            // Return
            return mockObjectMovie;
        }

        public static Mock<IObjectMoviesRepository> DoMockingSetupForRepository()
        {
            var mockObjectMoviesRepository = new Mock<IObjectMoviesRepository>();
            // Mock Functions
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IObjectMovie>().Object);
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IObjectMovie>().Object);
            mockObjectMoviesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IObjectMovie>>().Object);
            mockObjectMoviesRepository.Setup(m => m.Search(It.IsAny<IObjectMovieSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IObjectMovie>>().Object);
            mockObjectMoviesRepository.Setup(m => m.Add(It.IsAny<IObjectMovie>()));
            mockObjectMoviesRepository.Setup(m => m.Remove(It.IsAny<IObjectMovie>()));
            mockObjectMoviesRepository.Setup(m => m.Deactivate(It.IsAny<IObjectMovie>()));
            mockObjectMoviesRepository.Setup(m => m.Update(It.IsAny<IObjectMovie>()));
            // Return
            return mockObjectMoviesRepository;
        }
    }

    public class ObjectMoviesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ObjectMovieModel>(person);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ObjectMovieModel>(person);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Search_Should_ReturnAListOfObjectMovies()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IObjectMovieSearchModel>();
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Search(It.IsAny<IObjectMovieSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Search_AsListing_Should_ReturnAListOfObjectMoviesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IObjectMovieSearchModel>();
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Search(It.IsAny<IObjectMovieSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            mockObjectMoviesRepository.Setup(m => m.Search(It.IsAny<IObjectMovieSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IObjectMovie>>().Object);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Add(It.IsAny<IObjectMovie>()), Times.Once);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var mockObjectMovie = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            mockObjectMoviesRepository.Setup(m => m.Search(It.IsAny<IObjectMovieSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IObjectMovie> { mockObjectMovie.Object } );
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockObjectMovie.Object);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Add(It.IsAny<IObjectMovie>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockObjectMovie = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockObjectMovie.Object);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            var expectedName = "Stephen King (2)";
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockObjectMovie.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovie(1);
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            var model = ObjectMoviesMockingSetup.DoMockingSetupForObjectMovieModel(1);
            IObjectMovieModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("/TEST/KING-STEPHEN", result.ApiDetailUrl);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectMovie>().Object);
            mockObjectMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Deactivate(It.IsAny<IObjectMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectMovie>().Object);
            mockObjectMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Deactivate(It.IsAny<IObjectMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IObjectMovie>().Object);
            mockObjectMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Remove(It.IsAny<IObjectMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            var mockObjectMoviesMapper = new Mock<IObjectMovieMapper>();
            mockObjectMoviesMapper.Setup(m => m.AreEqual(It.IsAny<IObjectMovieModel>(), It.IsAny<IObjectMovie>())).Returns(() => true);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, mockObjectMoviesMapper.Object);
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IObjectMovie>().Object);
            mockObjectMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockObjectMoviesRepository.Verify(m => m.Remove(It.IsAny<IObjectMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ObjectMovies")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockObjectMoviesRepository = ObjectMoviesMockingSetup.DoMockingSetupForRepository();
            mockObjectMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ObjectMoviesBusinessWorkflow(mockObjectMoviesRepository.Object, new ObjectMovieMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
