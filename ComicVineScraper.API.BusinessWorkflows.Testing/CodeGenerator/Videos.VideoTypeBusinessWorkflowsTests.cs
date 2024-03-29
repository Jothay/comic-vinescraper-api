// <auto-generated>
// <copyright file="Videos.IVideoTypeBusinessWorkflowsTests.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VideoTypesRepository Class.</summary>
// <remarks>This file was auto-generated using BusinessWorkflowsTestingFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows.Testing\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Testing.BusinessWorkflows.Videos
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

    public static class VideoTypesMockingSetup
    {
        public static Mock<IVideoTypeModel> DoMockingSetupForVideoTypeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVideoTypeModel = new Mock<IVideoTypeModel>();
            // Mock Functions
            mockVideoTypeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVideoTypeModel.Setup(m => m.Active).Returns(() => true);
            mockVideoTypeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVideoTypeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoTypeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoTypeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVideoTypeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockVideoTypeModel.Setup(m => m.Videos).Returns(() => new List<IVideoModel>());
            // Return
            return mockVideoTypeModel;
        }

        public static Mock<IVideoType> DoMockingSetupForVideoType(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockVideoType = new Mock<IVideoType>();
            // Mock Functions
            mockVideoType.Setup(m => m.Id).Returns(() => idReturnValue);
            mockVideoType.Setup(m => m.Active).Returns(() => true);
            mockVideoType.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockVideoType.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoType.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockVideoType.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockVideoType.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockVideoType.Setup(m => m.Videos).Returns(() => new List<IVideo>());
            // Return
            return mockVideoType;
        }

        public static Mock<IVideoTypesRepository> DoMockingSetupForRepository()
        {
            var mockVideoTypesRepository = new Mock<IVideoTypesRepository>();
            // Mock Functions
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>()))
                .Returns(() => new Mock<IVideoType>().Object);
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<string>()))
                .Returns(() => new Mock<IVideoType>().Object);
            mockVideoTypesRepository.Setup(m => m.List)
                .Returns(() => new Mock<List<IVideoType>>().Object);
            mockVideoTypesRepository.Setup(m => m.Search(It.IsAny<IVideoTypeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVideoType>>().Object);
            mockVideoTypesRepository.Setup(m => m.Add(It.IsAny<IVideoType>()));
            mockVideoTypesRepository.Setup(m => m.Remove(It.IsAny<IVideoType>()));
            mockVideoTypesRepository.Setup(m => m.Deactivate(It.IsAny<IVideoType>()));
            mockVideoTypesRepository.Setup(m => m.Update(It.IsAny<IVideoType>()));
            // Return
            return mockVideoTypesRepository;
        }
    }

    public class VideoTypesBusinessWorkflowsTests
    {
        #region Read
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<VideoTypeModel>(person);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<VideoTypeModel>(person);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Search_Should_ReturnAListOfVideoTypes()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVideoTypeSearchModel>();
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockVideoTypesRepository.Verify(m => m.Search(It.IsAny<IVideoTypeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Search_AsListing_Should_ReturnAListOfVideoTypesWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IVideoTypeSearchModel>();
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockVideoTypesRepository.Verify(m => m.Search(It.IsAny<IVideoTypeSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            mockVideoTypesRepository.Setup(m => m.Search(It.IsAny<IVideoTypeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IVideoType>>().Object);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockVideoTypesRepository.Verify(m => m.Add(It.IsAny<IVideoType>()), Times.Once);
        }
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var mockVideoType = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            mockVideoTypesRepository.Setup(m => m.Search(It.IsAny<IVideoTypeSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IVideoType> { mockVideoType.Object } );
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVideoType.Object);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockVideoTypesRepository.Verify(m => m.Add(It.IsAny<IVideoType>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockVideoType = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockVideoType.Object);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            var expectedName = "Stephen King (2)";
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockVideoType.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = VideoTypesMockingSetup.DoMockingSetupForVideoType(1);
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            var model = VideoTypesMockingSetup.DoMockingSetupForVideoTypeModel(1);
            IVideoTypeModel result = null;
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
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVideoType>().Object);
            mockVideoTypesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockVideoTypesRepository.Verify(m => m.Deactivate(It.IsAny<IVideoType>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVideoType>().Object);
            mockVideoTypesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockVideoTypesRepository.Verify(m => m.Deactivate(It.IsAny<IVideoType>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            // Act/Assert
            Assert.Throws<System.InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IVideoType>().Object);
            mockVideoTypesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockVideoTypesRepository.Verify(m => m.Remove(It.IsAny<IVideoType>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            var mockVideoTypesMapper = new Mock<IVideoTypeMapper>();
            mockVideoTypesMapper.Setup(m => m.AreEqual(It.IsAny<IVideoTypeModel>(), It.IsAny<IVideoType>())).Returns(() => true);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, mockVideoTypesMapper.Object);
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IVideoType>().Object);
            mockVideoTypesRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockVideoTypesRepository.Verify(m => m.Remove(It.IsAny<IVideoType>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockVideoTypesRepository = VideoTypesMockingSetup.DoMockingSetupForRepository();
            mockVideoTypesRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new VideoTypesBusinessWorkflow(mockVideoTypesRepository.Object, new VideoTypeMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
