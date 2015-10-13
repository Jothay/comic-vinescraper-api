// <auto-generated>
// <copyright file="Videos.IVideoRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VideosRepository Class.</summary>
// <remarks>This file was autogenerated using BusinessWorkflowsTestingFileMaster.tt in ComicVine.API.BusinessWorkflows.Testing\BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.BusinessWorkflows.Videos
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

    public static class VideosMockingSetup
    {
        public static Mock<IVideoModel> DoMockingSetupForVideoModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVideoModel = new Mock<IVideoModel>();
            // Mock Functions
            mockVideoModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVideoModel.Setup(m => m.Active).Returns(() => true);
            mockVideoModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVideoModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVideoModel.Setup(m => m.UpdatedDate).Returns(() => null);
            mockVideoModel.Setup(m => m.Name).Returns(() => name);
            mockVideoModel.Setup(m => m.ShortDescription).Returns(() => "short");
            mockVideoModel.Setup(m => m.Description).Returns(() => "long");
            mockVideoModel.Setup(m => m.LowUrl).Returns(() => "LowUrl");
            mockVideoModel.Setup(m => m.HighUrl).Returns(() => "HighUrl");
            mockVideoModel.Setup(m => m.HdUrl).Returns(() => "HdUrl");
            mockVideoModel.Setup(m => m.Url).Returns(() => "Url");
            mockVideoModel.Setup(m => m.LengthSeconds).Returns(() => 2000);
            mockVideoModel.Setup(m => m.PublishDate).Returns(() => new System.DateTime());
            // Related Objects
            mockVideoModel.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockVideoModel.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFileModel());
            mockVideoModel.Setup(m => m.AuthorId).Returns(() => 1);
            mockVideoModel.Setup(m => m.Author).Returns(() => new PersonModel());
            mockVideoModel.Setup(m => m.VideoTypeId).Returns(() => 1);
            mockVideoModel.Setup(m => m.VideoType).Returns(() => new VideoTypeModel());
            // Associated Objects
            // <None>
            // Return
            return mockVideoModel;
        }

        public static Mock<IVideo> DoMockingSetupForVideo(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVideo = new Mock<IVideo>();
            // Mock Functions
            mockVideo.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVideo.Setup(m => m.Active).Returns(() => true);
            mockVideo.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVideo.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideo.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideo.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVideo.Setup(m => m.UpdatedDate).Returns(() => null);
            mockVideo.Setup(m => m.Name).Returns(() => name);
            mockVideo.Setup(m => m.ShortDescription).Returns(() => "short");
            mockVideo.Setup(m => m.Description).Returns(() => "long");
            mockVideo.Setup(m => m.LowUrl).Returns(() => "LowUrl");
            mockVideo.Setup(m => m.HighUrl).Returns(() => "HighUrl");
            mockVideo.Setup(m => m.HdUrl).Returns(() => "HdUrl");
            mockVideo.Setup(m => m.Url).Returns(() => "Url");
            mockVideo.Setup(m => m.LengthSeconds).Returns(() => 2000);
            mockVideo.Setup(m => m.PublishDate).Returns(() => new System.DateTime());
            // Related Objects
            mockVideo.Setup(m => m.PrimaryImageFileId).Returns(() => 1);
            mockVideo.Setup(m => m.PrimaryImageFile).Returns(() => new ImageFile());
            mockVideo.Setup(m => m.AuthorId).Returns(() => 1);
            mockVideo.Setup(m => m.Author).Returns(() => new Person());
            mockVideo.Setup(m => m.VideoTypeId).Returns(() => 1);
            mockVideo.Setup(m => m.VideoType).Returns(() => new VideoType());
            // Associated Objects
            // <None>
            // Return
            return mockVideo;
        }

        public static Mock<IVideosRepository> DoMockingSetupForRepository()
        {
            var mockVideosRepository = new Mock<IVideosRepository>();
            // Mock Functions
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IVideo>().Object);
            mockVideosRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IVideo>().Object);
            mockVideosRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IVideo>>().Object);
            mockVideosRepository.Setup(m => m.Search(It.IsAny<IVideoSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVideo>>().Object);
            mockVideosRepository.Setup(m => m.Add(It.IsAny<IVideo>()));
            mockVideosRepository.Setup(m => m.Remove(It.IsAny<IVideo>()));
            mockVideosRepository.Setup(m => m.Deactivate(It.IsAny<IVideo>()));
            mockVideosRepository.Setup(m => m.Update(It.IsAny<IVideo>()));
            // Return
            return mockVideosRepository;
        }
    }

    public class VideosBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "Videos")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<VideoModel>(person);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<VideoModel>(person);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Search_Should_ReturnAListOfVideos()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVideoSearchModel>();
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockVideosRepository.Verify(m => m.Search(It.IsAny<IVideoSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Search_AsListing_Should_ReturnAListOfVideosWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVideoSearchModel>();
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockVideosRepository.Verify(m => m.Search(It.IsAny<IVideoSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "Videos")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            mockVideosRepository.Setup(m => m.Search(It.IsAny<IVideoSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVideo>>().Object);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            var model = VideosMockingSetup.DoMockingSetupForVideoModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockVideosRepository.Verify(m => m.Add(It.IsAny<IVideo>()), Times.Once);
        }
        [Fact][Trait("Category", "Videos")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var mockVideo = VideosMockingSetup.DoMockingSetupForVideo(1);
            mockVideosRepository.Setup(m => m.Search(It.IsAny<IVideoSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IVideo> { mockVideo.Object } );
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVideo.Object);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            var model = VideosMockingSetup.DoMockingSetupForVideoModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockVideosRepository.Verify(m => m.Add(It.IsAny<IVideo>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "Videos")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockVideo = VideosMockingSetup.DoMockingSetupForVideo(1);
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVideo.Object);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            var expectedName = "Stephen King (2)";
            var model = VideosMockingSetup.DoMockingSetupForVideoModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockVideo.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "Videos")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = VideosMockingSetup.DoMockingSetupForVideo(1);
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            var model = VideosMockingSetup.DoMockingSetupForVideoModel(1);
            IVideoModel result = null;
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
        [Fact][Trait("Category", "Videos")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVideo>().Object);
            mockVideosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockVideosRepository.Verify(m => m.Deactivate(It.IsAny<IVideo>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            mockVideosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVideo>().Object);
            mockVideosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockVideosRepository.Verify(m => m.Deactivate(It.IsAny<IVideo>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            mockVideosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "Videos")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            mockVideosRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVideo>().Object);
            mockVideosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockVideosRepository.Verify(m => m.Remove(It.IsAny<IVideo>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            var mockVideosMapper = new Mock<IVideoMapper>();
            mockVideosMapper.Setup(m => m.AreEqual(It.IsAny<IVideoModel>(), It.IsAny<IVideo>())).Returns(() => true);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, mockVideosMapper.Object);
            mockVideosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVideo>().Object);
            mockVideosRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockVideosRepository.Verify(m => m.Remove(It.IsAny<IVideo>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "Videos")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockVideosRepository = VideosMockingSetup.DoMockingSetupForRepository();
            mockVideosRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new VideosBusinessWorkflow(mockVideosRepository.Object, new VideoMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}