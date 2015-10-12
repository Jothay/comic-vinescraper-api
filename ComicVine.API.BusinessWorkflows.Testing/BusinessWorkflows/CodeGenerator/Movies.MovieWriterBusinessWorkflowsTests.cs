// <auto-generated>
// <copyright file="Movies.IMovieWriterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieWritersRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Movies
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

    public static class MovieWritersMockingSetup
    {
        public static Mock<IMovieWriterModel> DoMockingSetupForMovieWriterModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieWriterModel = new Mock<IMovieWriterModel>();
            // Mock Functions
            mockMovieWriterModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieWriterModel.Setup(m => m.Active).Returns(() => true);
            mockMovieWriterModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieWriterModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriterModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriterModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieWriterModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockMovieWriterModel.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieWriterModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            mockMovieWriterModel.Setup(m => m.WriterId).Returns(() => 1);
            mockMovieWriterModel.Setup(m => m.Writer).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockMovieWriterModel;
        }

        public static Mock<IMovieWriter> DoMockingSetupForMovieWriter(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieWriter = new Mock<IMovieWriter>();
            // Mock Functions
            mockMovieWriter.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieWriter.Setup(m => m.Active).Returns(() => true);
            mockMovieWriter.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieWriter.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriter.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieWriter.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieWriter.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockMovieWriter.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieWriter.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieWriter.Setup(m => m.WriterId).Returns(() => 1);
            mockMovieWriter.Setup(m => m.Writer).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockMovieWriter;
        }

        public static Mock<IMovieWritersRepository> DoMockingSetupForRepository()
        {
            var mockMovieWritersRepository = new Mock<IMovieWritersRepository>();
            // Mock Functions
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IMovieWriter>().Object);
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IMovieWriter>().Object);
            mockMovieWritersRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IMovieWriter>>().Object);
            mockMovieWritersRepository.Setup(m => m.Search(It.IsAny<IMovieWriterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IMovieWriter>>().Object);
            mockMovieWritersRepository.Setup(m => m.Add(It.IsAny<IMovieWriter>()));
            mockMovieWritersRepository.Setup(m => m.Remove(It.IsAny<IMovieWriter>()));
            mockMovieWritersRepository.Setup(m => m.Deactivate(It.IsAny<IMovieWriter>()));
            mockMovieWritersRepository.Setup(m => m.Update(It.IsAny<IMovieWriter>()));
            // Return
            return mockMovieWritersRepository;
        }
    }

    public class MovieWritersBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<MovieWriterModel>(person);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<MovieWriterModel>(person);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Search_Should_ReturnAListOfMovieWriters()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IMovieWriterSearchModel>();
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockMovieWritersRepository.Verify(m => m.Search(It.IsAny<IMovieWriterSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Search_AsListing_Should_ReturnAListOfMovieWritersWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IMovieWriterSearchModel>();
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockMovieWritersRepository.Verify(m => m.Search(It.IsAny<IMovieWriterSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            mockMovieWritersRepository.Setup(m => m.Search(It.IsAny<IMovieWriterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IMovieWriter>>().Object);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockMovieWritersRepository.Verify(m => m.Add(It.IsAny<IMovieWriter>()), Times.Once);
        }
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var mockMovieWriter = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            mockMovieWritersRepository.Setup(m => m.Search(It.IsAny<IMovieWriterSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IMovieWriter> { mockMovieWriter.Object } );
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockMovieWriter.Object);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockMovieWritersRepository.Verify(m => m.Add(It.IsAny<IMovieWriter>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockMovieWriter = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockMovieWriter.Object);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            var expectedName = "Stephen King (2)";
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockMovieWriter.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = MovieWritersMockingSetup.DoMockingSetupForMovieWriter(1);
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            var model = MovieWritersMockingSetup.DoMockingSetupForMovieWriterModel(1);
            IMovieWriterModel result = null;
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
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieWriter>().Object);
            mockMovieWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockMovieWritersRepository.Verify(m => m.Deactivate(It.IsAny<IMovieWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieWriter>().Object);
            mockMovieWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockMovieWritersRepository.Verify(m => m.Deactivate(It.IsAny<IMovieWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieWriter>().Object);
            mockMovieWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockMovieWritersRepository.Verify(m => m.Remove(It.IsAny<IMovieWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            var mockMovieWritersMapper = new Mock<IMovieWriterMapper>();
            mockMovieWritersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieWriterModel>(), It.IsAny<IMovieWriter>())).Returns(() => true);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, mockMovieWritersMapper.Object);
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieWriter>().Object);
            mockMovieWritersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockMovieWritersRepository.Verify(m => m.Remove(It.IsAny<IMovieWriter>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "MovieWriters")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockMovieWritersRepository = MovieWritersMockingSetup.DoMockingSetupForRepository();
            mockMovieWritersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new MovieWritersBusinessWorkflow(mockMovieWritersRepository.Object, new MovieWriterMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
