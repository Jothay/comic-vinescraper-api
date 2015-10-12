// <auto-generated>
// <copyright file="Videos.IVideoTypeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VideoTypesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Repositories.Videos
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

    public static class VideoTypesMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includeVideoTypesData, out Mock<IDbSet<VideoType>> mockSetVideoTypes, bool markAVideoTypeInactive = false)
        {
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetVideoTypes = new Mock<IDbSet<VideoType>>();
            var personData = (!includeVideoTypesData ? new List<VideoType>() : new List<VideoType>
            {
                new VideoType { Id = 1, Active = !markAVideoTypeInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", ApiDetailUrl = "/TEST/KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new VideoType { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", ApiDetailUrl = "/TEST/NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetVideoTypes.As<IQueryable<VideoType>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetVideoTypes.As<IQueryable<VideoType>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetVideoTypes.As<IQueryable<VideoType>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetVideoTypes.As<IQueryable<VideoType>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.VideoTypes).Returns(mockSetVideoTypes.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }

    public class VideoTypesRepositoryTests
    {
        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Add_Should_AddTheEntityToTheContext()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(false, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            var videoTypes = new VideoType { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
            // Act
            repository.Add(videoTypes);
            // Assert
            mockSetVideoTypes.Verify(x => x.Add(videoTypes), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            var videoTypes = repository.Get(1);
            // Act
            repository.Remove(videoTypes);
            // Assert
            mockSetVideoTypes.Verify(x => x.Remove((VideoType)videoTypes), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            var videoTypes = repository.Get(1);
            // Act
            repository.Deactivate(videoTypes);
            // Assert
            Assert.Equal(false, videoTypes.Active);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Update_Should_SetTheEntityStateToModified()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            var videoTypes = repository.Get(1);
            videoTypes.ApiDetailUrl = "/TEST";
            // Act
            repository.Update(videoTypes);
            // Assert
            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Get_ByID_Should_ReturnTheCorrectVideoType()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            // Act
            var videoTypes = repository.Get(1);
            // Assert
            Assert.Equal("Stephen King", videoTypes.Name);            Assert.Equal("/TEST/KING-STEPHEN", videoTypes.ApiDetailUrl);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectVideoType()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            // Act
            var videoTypes = repository.Get("KING-STEPHEN");
            // Assert
            Assert.Equal("Stephen King", videoTypes.Name);            Assert.Equal("/TEST/KING-STEPHEN", videoTypes.ApiDetailUrl);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_List_Should_ReturnAListOfVideoTypesWithData()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            // Act
            var videoTypes = repository.List.ToArray();
            // Assert
            Assert.Equal(2, videoTypes.Length);
            Assert.Equal(1, videoTypes[0].Id);
            Assert.Equal("Stephen King", videoTypes[0].Name);            Assert.Equal("/TEST/KING-STEPHEN", videoTypes[0].ApiDetailUrl);
            Assert.Equal(2, videoTypes[1].Id);
            Assert.Equal("Larry Niven", videoTypes[1].Name);            Assert.Equal("/TEST/NIVEN-LARRY", videoTypes[1].ApiDetailUrl);
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Search_Should_ReturnAListOfVideoTypesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes, true);
            var repository = new VideoTypesRepository(mockContext.Object);
            var searchModel = new Mock<IVideoTypeSearchModel>();
            // Act
            var videoTypes = repository.Search(searchModel.Object).ToArray();
            // Assert
            Assert.Equal(1, videoTypes.Length);
            Assert.Equal(2, videoTypes[0].Id);
            Assert.Equal("Larry Niven", videoTypes[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", videoTypes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes, true);
            var repository = new VideoTypesRepository(mockContext.Object);
            var searchModel = new Mock<IVideoTypeSearchModel>();
            // Act
            var videoTypes = repository.Search(searchModel.Object, i => new { i.Id, MyApiDetailUrl = i.ApiDetailUrl, MyName = i.Name }).ToArray();
            // Assert
            Assert.Equal(1, videoTypes.Length);
            Assert.Equal(2, videoTypes[0].Id);
            Assert.Equal("Larry Niven", videoTypes[0].MyName);            Assert.Equal("/TEST/NIVEN-LARRY", videoTypes[0].MyApiDetailUrl);
            // Stephen King was filtered out because he was Inactive
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfVideoTypesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes, true);
            var repository = new VideoTypesRepository(mockContext.Object);
            var createDate = new System.DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
            //var searchModel = new Mock<IVideoTypeSearchModel>();
            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
            var searchModel = new VideoTypeSearchModel { ModifiedSince = createDate };
            // Act
            var videoTypes = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, videoTypes.Length);
            Assert.Equal(2, videoTypes[0].Id);
            Assert.Equal("Larry Niven", videoTypes[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", videoTypes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was created before the modified since date
        }

        [Fact][Trait("Category", "VideoTypes")]
        public void Verify_Search_WithPaging_Should_ReturnAListOfVideoTypesWithDataMatchingSearchParameters()
        {
            // Arrange
            Mock<IDbSet<VideoType>> mockSetVideoTypes;
            var mockContext = VideoTypesMockingSetup.DoMockingSetupForContext(true, out mockSetVideoTypes);
            var repository = new VideoTypesRepository(mockContext.Object);
            var searchModel = new VideoTypeSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
            // Act
            var videoTypes = repository.Search(searchModel/*.Object*/).ToArray();
            // Assert
            Assert.Equal(1, videoTypes.Length);
            Assert.Equal(2, videoTypes[0].Id);
            Assert.Equal("Larry Niven", videoTypes[0].Name);            Assert.Equal("/TEST/NIVEN-LARRY", videoTypes[0].ApiDetailUrl);
            // Stephen King was filtered out because he was Skipped
        }
    }
}
