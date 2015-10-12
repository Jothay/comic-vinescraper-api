// <auto-generated>
// <copyright file="Characters.ICharacterMovieRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterMoviesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Characters
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

    public static class CharacterMoviesMockingSetup
    {
        public static Mock<ICharacterMovieModel> DoMockingSetupForCharacterMovieModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterMovieModel = new Mock<ICharacterMovieModel>();
            // Mock Functions
            mockCharacterMovieModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterMovieModel.Setup(m => m.Active).Returns(() => true);
            mockCharacterMovieModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterMovieModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterMovieModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterMovieModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterMovieModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterMovieModel.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterMovieModel.Setup(m => m.Character).Returns(() => new CharacterModel());
            mockCharacterMovieModel.Setup(m => m.MovieId).Returns(() => 1);
            mockCharacterMovieModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterMovieModel;
        }

        public static Mock<ICharacterMovie> DoMockingSetupForCharacterMovie(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockCharacterMovie = new Mock<ICharacterMovie>();
            // Mock Functions
            mockCharacterMovie.Setup(m => m.Id).Returns(() => idReturnValue);
            mockCharacterMovie.Setup(m => m.Active).Returns(() => true);
            mockCharacterMovie.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockCharacterMovie.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterMovie.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockCharacterMovie.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockCharacterMovie.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockCharacterMovie.Setup(m => m.CharacterId).Returns(() => 1);
            mockCharacterMovie.Setup(m => m.Character).Returns(() => new Character());
            mockCharacterMovie.Setup(m => m.MovieId).Returns(() => 1);
            mockCharacterMovie.Setup(m => m.Movie).Returns(() => new Movie());
            // Associated Objects
            // <None>
            // Return
            return mockCharacterMovie;
        }

        public static Mock<ICharacterMoviesRepository> DoMockingSetupForRepository()
        {
            var mockCharacterMoviesRepository = new Mock<ICharacterMoviesRepository>();
            // Mock Functions
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<ICharacterMovie>().Object);
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<ICharacterMovie>().Object);
            mockCharacterMoviesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<ICharacterMovie>>().Object);
            mockCharacterMoviesRepository.Setup(m => m.Search(It.IsAny<ICharacterMovieSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterMovie>>().Object);
            mockCharacterMoviesRepository.Setup(m => m.Add(It.IsAny<ICharacterMovie>()));
            mockCharacterMoviesRepository.Setup(m => m.Remove(It.IsAny<ICharacterMovie>()));
            mockCharacterMoviesRepository.Setup(m => m.Deactivate(It.IsAny<ICharacterMovie>()));
            mockCharacterMoviesRepository.Setup(m => m.Update(It.IsAny<ICharacterMovie>()));
            // Return
            return mockCharacterMoviesRepository;
        }
    }

    public class CharacterMoviesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<CharacterMovieModel>(person);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<CharacterMovieModel>(person);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Search_Should_ReturnAListOfCharacterMovies()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterMovieSearchModel>();
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Search(It.IsAny<ICharacterMovieSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Search_AsListing_Should_ReturnAListOfCharacterMoviesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<ICharacterMovieSearchModel>();
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Search(It.IsAny<ICharacterMovieSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            mockCharacterMoviesRepository.Setup(m => m.Search(It.IsAny<ICharacterMovieSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<ICharacterMovie>>().Object);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            var model = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovieModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Add(It.IsAny<ICharacterMovie>()), Times.Once);
        }
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterMovie = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovie(1);
            mockCharacterMoviesRepository.Setup(m => m.Search(It.IsAny<ICharacterMovieSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<ICharacterMovie> { mockCharacterMovie.Object } );
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterMovie.Object);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            var model = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovieModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Add(It.IsAny<ICharacterMovie>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockCharacterMovie = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovie(1);
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockCharacterMovie.Object);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            var expectedName = "Stephen King (2)";
            var model = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovieModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockCharacterMovie.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovie(1);
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            var model = CharacterMoviesMockingSetup.DoMockingSetupForCharacterMovieModel(1);
            ICharacterMovieModel result = null;
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
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterMovie>().Object);
            mockCharacterMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterMovie>().Object);
            mockCharacterMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Deactivate(It.IsAny<ICharacterMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<ICharacterMovie>().Object);
            mockCharacterMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Remove(It.IsAny<ICharacterMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            var mockCharacterMoviesMapper = new Mock<ICharacterMovieMapper>();
            mockCharacterMoviesMapper.Setup(m => m.AreEqual(It.IsAny<ICharacterMovieModel>(), It.IsAny<ICharacterMovie>())).Returns(() => true);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, mockCharacterMoviesMapper.Object);
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<ICharacterMovie>().Object);
            mockCharacterMoviesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockCharacterMoviesRepository.Verify(m => m.Remove(It.IsAny<ICharacterMovie>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "CharacterMovies")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockCharacterMoviesRepository = CharacterMoviesMockingSetup.DoMockingSetupForRepository();
            mockCharacterMoviesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new CharacterMoviesBusinessWorkflow(mockCharacterMoviesRepository.Object, new CharacterMovieMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
