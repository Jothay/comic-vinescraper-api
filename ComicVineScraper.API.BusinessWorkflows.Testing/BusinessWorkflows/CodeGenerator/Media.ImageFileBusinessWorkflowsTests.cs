// <auto-generated>
// <copyright file="Media.IImageFileRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ImageFilesRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Media
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

    public static class ImageFilesMockingSetup
    {
        public static Mock<IImageFileModel> DoMockingSetupForImageFileModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockImageFileModel = new Mock<IImageFileModel>();
            // Mock Functions
            mockImageFileModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockImageFileModel.Setup(m => m.Active).Returns(() => true);
            mockImageFileModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockImageFileModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFileModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFileModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockImageFileModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockImageFileModel.Setup(m => m.Name).Returns(() => name);
            mockImageFileModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockImageFileModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockImageFileModel.Setup(m => m.Characters).Returns(() => new List<ICharacterModel>());
            mockImageFileModel.Setup(m => m.Chats).Returns(() => new List<IChatModel>());
            mockImageFileModel.Setup(m => m.Concepts).Returns(() => new List<IConceptModel>());
            mockImageFileModel.Setup(m => m.Episodes).Returns(() => new List<IEpisodeModel>());
            mockImageFileModel.Setup(m => m.Issues).Returns(() => new List<IIssueModel>());
            mockImageFileModel.Setup(m => m.Locations).Returns(() => new List<ILocationModel>());
            mockImageFileModel.Setup(m => m.Movies).Returns(() => new List<IMovieModel>());
            mockImageFileModel.Setup(m => m.Objects).Returns(() => new List<IObjectModel>());
            mockImageFileModel.Setup(m => m.People).Returns(() => new List<IPersonModel>());
            mockImageFileModel.Setup(m => m.Promos).Returns(() => new List<IPromoModel>());
            mockImageFileModel.Setup(m => m.Publishers).Returns(() => new List<IPublisherModel>());
            mockImageFileModel.Setup(m => m.StoryArcs).Returns(() => new List<IStoryArcModel>());
            mockImageFileModel.Setup(m => m.Teams).Returns(() => new List<ITeamModel>());
            mockImageFileModel.Setup(m => m.Videos).Returns(() => new List<IVideoModel>());
            mockImageFileModel.Setup(m => m.Volumes).Returns(() => new List<IVolumeModel>());
            // Return
            return mockImageFileModel;
        }

        public static Mock<IImageFile> DoMockingSetupForImageFile(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockImageFile = new Mock<IImageFile>();
            // Mock Functions
            mockImageFile.Setup(m => m.Id).Returns(() => idReturnValue);
            mockImageFile.Setup(m => m.Active).Returns(() => true);
            mockImageFile.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockImageFile.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFile.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockImageFile.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockImageFile.Setup(m => m.UpdatedDate).Returns(() => null);
            mockImageFile.Setup(m => m.Name).Returns(() => name);
            mockImageFile.Setup(m => m.ShortDescription).Returns(() => "short");
            mockImageFile.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockImageFile.Setup(m => m.Characters).Returns(() => new List<ICharacter>());
            mockImageFile.Setup(m => m.Chats).Returns(() => new List<IChat>());
            mockImageFile.Setup(m => m.Concepts).Returns(() => new List<IConcept>());
            mockImageFile.Setup(m => m.Episodes).Returns(() => new List<IEpisode>());
            mockImageFile.Setup(m => m.Issues).Returns(() => new List<IIssue>());
            mockImageFile.Setup(m => m.Locations).Returns(() => new List<ILocation>());
            mockImageFile.Setup(m => m.Movies).Returns(() => new List<IMovie>());
            mockImageFile.Setup(m => m.Objects).Returns(() => new List<IObject>());
            mockImageFile.Setup(m => m.People).Returns(() => new List<IPerson>());
            mockImageFile.Setup(m => m.Promos).Returns(() => new List<IPromo>());
            mockImageFile.Setup(m => m.Publishers).Returns(() => new List<IPublisher>());
            mockImageFile.Setup(m => m.StoryArcs).Returns(() => new List<IStoryArc>());
            mockImageFile.Setup(m => m.Teams).Returns(() => new List<ITeam>());
            mockImageFile.Setup(m => m.Videos).Returns(() => new List<IVideo>());
            mockImageFile.Setup(m => m.Volumes).Returns(() => new List<IVolume>());
            // Return
            return mockImageFile;
        }

        public static Mock<IImageFilesRepository> DoMockingSetupForRepository()
        {
            var mockImageFilesRepository = new Mock<IImageFilesRepository>();
            // Mock Functions
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IImageFile>().Object);
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IImageFile>().Object);
            mockImageFilesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IImageFile>>().Object);
            mockImageFilesRepository.Setup(m => m.Search(It.IsAny<IImageFileSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IImageFile>>().Object);
            mockImageFilesRepository.Setup(m => m.Add(It.IsAny<IImageFile>()));
            mockImageFilesRepository.Setup(m => m.Remove(It.IsAny<IImageFile>()));
            mockImageFilesRepository.Setup(m => m.Deactivate(It.IsAny<IImageFile>()));
            mockImageFilesRepository.Setup(m => m.Update(It.IsAny<IImageFile>()));
            // Return
            return mockImageFilesRepository;
        }
    }

    public class ImageFilesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<ImageFileModel>(person);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<ImageFileModel>(person);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Search_Should_ReturnAListOfImageFiles()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IImageFileSearchModel>();
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockImageFilesRepository.Verify(m => m.Search(It.IsAny<IImageFileSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Search_AsListing_Should_ReturnAListOfImageFilesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IImageFileSearchModel>();
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockImageFilesRepository.Verify(m => m.Search(It.IsAny<IImageFileSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            mockImageFilesRepository.Setup(m => m.Search(It.IsAny<IImageFileSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IImageFile>>().Object);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockImageFilesRepository.Verify(m => m.Add(It.IsAny<IImageFile>()), Times.Once);
        }
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var mockImageFile = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            mockImageFilesRepository.Setup(m => m.Search(It.IsAny<IImageFileSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IImageFile> { mockImageFile.Object } );
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockImageFile.Object);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockImageFilesRepository.Verify(m => m.Add(It.IsAny<IImageFile>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockImageFile = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockImageFile.Object);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            var expectedName = "Stephen King (2)";
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockImageFile.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = ImageFilesMockingSetup.DoMockingSetupForImageFile(1);
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            var model = ImageFilesMockingSetup.DoMockingSetupForImageFileModel(1);
            IImageFileModel result = null;
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
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IImageFile>().Object);
            mockImageFilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockImageFilesRepository.Verify(m => m.Deactivate(It.IsAny<IImageFile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IImageFile>().Object);
            mockImageFilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockImageFilesRepository.Verify(m => m.Deactivate(It.IsAny<IImageFile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IImageFile>().Object);
            mockImageFilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockImageFilesRepository.Verify(m => m.Remove(It.IsAny<IImageFile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            var mockImageFilesMapper = new Mock<IImageFileMapper>();
            mockImageFilesMapper.Setup(m => m.AreEqual(It.IsAny<IImageFileModel>(), It.IsAny<IImageFile>())).Returns(() => true);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, mockImageFilesMapper.Object);
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IImageFile>().Object);
            mockImageFilesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockImageFilesRepository.Verify(m => m.Remove(It.IsAny<IImageFile>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "ImageFiles")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockImageFilesRepository = ImageFilesMockingSetup.DoMockingSetupForRepository();
            mockImageFilesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new ImageFilesBusinessWorkflow(mockImageFilesRepository.Object, new ImageFileMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}