// <auto-generated>
// <copyright file="Movies.IMovieProducerRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieProducersRepository Class.</summary>
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

    public static class MovieProducersMockingSetup
    {
        public static Mock<IMovieProducerModel> DoMockingSetupForMovieProducerModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieProducerModel = new Mock<IMovieProducerModel>();
            // Mock Functions
            mockMovieProducerModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieProducerModel.Setup(m => m.Active).Returns(() => true);
            mockMovieProducerModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieProducerModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieProducerModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieProducerModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieProducerModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockMovieProducerModel.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieProducerModel.Setup(m => m.Movie).Returns(() => new MovieModel());
            mockMovieProducerModel.Setup(m => m.ProducerId).Returns(() => 1);
            mockMovieProducerModel.Setup(m => m.Producer).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockMovieProducerModel;
        }

        public static Mock<IMovieProducer> DoMockingSetupForMovieProducer(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockMovieProducer = new Mock<IMovieProducer>();
            // Mock Functions
            mockMovieProducer.Setup(m => m.Id).Returns(() => idReturnValue);
            mockMovieProducer.Setup(m => m.Active).Returns(() => true);
            mockMovieProducer.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockMovieProducer.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieProducer.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockMovieProducer.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockMovieProducer.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            mockMovieProducer.Setup(m => m.MovieId).Returns(() => 1);
            mockMovieProducer.Setup(m => m.Movie).Returns(() => new Movie());
            mockMovieProducer.Setup(m => m.ProducerId).Returns(() => 1);
            mockMovieProducer.Setup(m => m.Producer).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockMovieProducer;
        }

        public static Mock<IMovieProducersRepository> DoMockingSetupForRepository()
        {
            var mockMovieProducersRepository = new Mock<IMovieProducersRepository>();
            // Mock Functions
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IMovieProducer>().Object);
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IMovieProducer>().Object);
            mockMovieProducersRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IMovieProducer>>().Object);
            mockMovieProducersRepository.Setup(m => m.Search(It.IsAny<IMovieProducerSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IMovieProducer>>().Object);
            mockMovieProducersRepository.Setup(m => m.Add(It.IsAny<IMovieProducer>()));
            mockMovieProducersRepository.Setup(m => m.Remove(It.IsAny<IMovieProducer>()));
            mockMovieProducersRepository.Setup(m => m.Deactivate(It.IsAny<IMovieProducer>()));
            mockMovieProducersRepository.Setup(m => m.Update(It.IsAny<IMovieProducer>()));
            // Return
            return mockMovieProducersRepository;
        }
    }

    public class MovieProducersBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<MovieProducerModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<MovieProducerModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfMovieProducers()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IMovieProducerSearchModel>();
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockMovieProducersRepository.Verify(m => m.Search(It.IsAny<IMovieProducerSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfMovieProducersWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IMovieProducerSearchModel>();
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockMovieProducersRepository.Verify(m => m.Search(It.IsAny<IMovieProducerSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            mockMovieProducersRepository.Setup(m => m.Search(It.IsAny<IMovieProducerSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IMovieProducer>>().Object);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            var model = MovieProducersMockingSetup.DoMockingSetupForMovieProducerModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockMovieProducersRepository.Verify(m => m.Add(It.IsAny<IMovieProducer>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var mockMovieProducer = MovieProducersMockingSetup.DoMockingSetupForMovieProducer(1);
            mockMovieProducersRepository.Setup(m => m.Search(It.IsAny<IMovieProducerSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IMovieProducer> { mockMovieProducer.Object } );
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockMovieProducer.Object);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            var model = MovieProducersMockingSetup.DoMockingSetupForMovieProducerModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockMovieProducersRepository.Verify(m => m.Add(It.IsAny<IMovieProducer>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockMovieProducer = MovieProducersMockingSetup.DoMockingSetupForMovieProducer(1);
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockMovieProducer.Object);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            var expectedName = "Stephen King (2)";
            var model = MovieProducersMockingSetup.DoMockingSetupForMovieProducerModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockMovieProducer.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = MovieProducersMockingSetup.DoMockingSetupForMovieProducer(1);
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            var model = MovieProducersMockingSetup.DoMockingSetupForMovieProducerModel(1);
            IMovieProducerModel result = null;
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
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieProducer>().Object);
            mockMovieProducersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockMovieProducersRepository.Verify(m => m.Deactivate(It.IsAny<IMovieProducer>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieProducer>().Object);
            mockMovieProducersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockMovieProducersRepository.Verify(m => m.Deactivate(It.IsAny<IMovieProducer>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IMovieProducer>().Object);
            mockMovieProducersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockMovieProducersRepository.Verify(m => m.Remove(It.IsAny<IMovieProducer>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            var mockMovieProducersMapper = new Mock<IMovieProducerMapper>();
            mockMovieProducersMapper.Setup(m => m.AreEqual(It.IsAny<IMovieProducerModel>(), It.IsAny<IMovieProducer>())).Returns(() => true);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, mockMovieProducersMapper.Object);
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IMovieProducer>().Object);
            mockMovieProducersRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockMovieProducersRepository.Verify(m => m.Remove(It.IsAny<IMovieProducer>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockMovieProducersRepository = MovieProducersMockingSetup.DoMockingSetupForRepository();
            mockMovieProducersRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new MovieProducersBusinessWorkflow(mockMovieProducersRepository.Object, new MovieProducerMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}