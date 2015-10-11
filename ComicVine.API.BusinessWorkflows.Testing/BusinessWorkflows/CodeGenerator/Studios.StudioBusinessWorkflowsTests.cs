// <auto-generated>
// <copyright file="Studios.IStudioRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StudiosRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Studios
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

    public static class StudiosMockingSetup
    {
        public static Mock<IStudioModel> DoMockingSetupForStudioModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStudioModel = new Mock<IStudioModel>();
            // Mock Functions
            mockStudioModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStudioModel.Setup(m => m.Active).Returns(() => true);
            mockStudioModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStudioModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStudioModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStudioModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStudioModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockStudioModel.Setup(m => m.Name).Returns(() => name);
            mockStudioModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockStudioModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockStudioModel.Setup(m => m.MovieStudios).Returns(() => new List<IMovieStudioModel>());
            // Return
            return mockStudioModel;
        }

        public static Mock<IStudio> DoMockingSetupForStudio(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockStudio = new Mock<IStudio>();
            // Mock Functions
            mockStudio.Setup(m => m.Id).Returns(() => idReturnValue);
            mockStudio.Setup(m => m.Active).Returns(() => true);
            mockStudio.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockStudio.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStudio.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockStudio.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockStudio.Setup(m => m.UpdatedDate).Returns(() => null);
            mockStudio.Setup(m => m.Name).Returns(() => name);
            mockStudio.Setup(m => m.ShortDescription).Returns(() => "short");
            mockStudio.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockStudio.Setup(m => m.MovieStudios).Returns(() => new List<IMovieStudio>());
            // Return
            return mockStudio;
        }

        public static Mock<IStudiosRepository> DoMockingSetupForRepository()
        {
            var mockStudiosRepository = new Mock<IStudiosRepository>();
            // Mock Functions
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IStudio>().Object);
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IStudio>().Object);
            mockStudiosRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IStudio>>().Object);
            mockStudiosRepository.Setup(m => m.Search(It.IsAny<IStudioSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IStudio>>().Object);
            mockStudiosRepository.Setup(m => m.Add(It.IsAny<IStudio>()));
            mockStudiosRepository.Setup(m => m.Remove(It.IsAny<IStudio>()));
            mockStudiosRepository.Setup(m => m.Deactivate(It.IsAny<IStudio>()));
            mockStudiosRepository.Setup(m => m.Update(It.IsAny<IStudio>()));
            // Return
            return mockStudiosRepository;
        }
    }

    public class StudiosBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<StudioModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<StudioModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfStudios()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IStudioSearchModel>();
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockStudiosRepository.Verify(m => m.Search(It.IsAny<IStudioSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfStudiosWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IStudioSearchModel>();
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockStudiosRepository.Verify(m => m.Search(It.IsAny<IStudioSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            mockStudiosRepository.Setup(m => m.Search(It.IsAny<IStudioSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IStudio>>().Object);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            var model = StudiosMockingSetup.DoMockingSetupForStudioModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockStudiosRepository.Verify(m => m.Add(It.IsAny<IStudio>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var mockStudio = StudiosMockingSetup.DoMockingSetupForStudio(1);
            mockStudiosRepository.Setup(m => m.Search(It.IsAny<IStudioSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IStudio> { mockStudio.Object } );
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockStudio.Object);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            var model = StudiosMockingSetup.DoMockingSetupForStudioModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockStudiosRepository.Verify(m => m.Add(It.IsAny<IStudio>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockStudio = StudiosMockingSetup.DoMockingSetupForStudio(1);
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockStudio.Object);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            var expectedName = "Stephen King (2)";
            var model = StudiosMockingSetup.DoMockingSetupForStudioModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockStudio.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = StudiosMockingSetup.DoMockingSetupForStudio(1);
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            var model = StudiosMockingSetup.DoMockingSetupForStudioModel(1);
            IStudioModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("Stephen King", result.Name);
            Assert.Equal("/TEST/KING-STEPHEN", result.ApiDetailUrl);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IStudio>().Object);
            mockStudiosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockStudiosRepository.Verify(m => m.Deactivate(It.IsAny<IStudio>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IStudio>().Object);
            mockStudiosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockStudiosRepository.Verify(m => m.Deactivate(It.IsAny<IStudio>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IStudio>().Object);
            mockStudiosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockStudiosRepository.Verify(m => m.Remove(It.IsAny<IStudio>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            var mockStudiosMapper = new Mock<IStudioMapper>();
            mockStudiosMapper.Setup(m => m.AreEqual(It.IsAny<IStudioModel>(), It.IsAny<IStudio>())).Returns(() => true);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, mockStudiosMapper.Object);
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IStudio>().Object);
            mockStudiosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockStudiosRepository.Verify(m => m.Remove(It.IsAny<IStudio>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockStudiosRepository = StudiosMockingSetup.DoMockingSetupForRepository();
            mockStudiosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new StudiosBusinessWorkflow(mockStudiosRepository.Object, new StudioMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}