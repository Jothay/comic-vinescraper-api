// <auto-generated>
// <copyright file="Profiles.IProfileRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ProfilesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Profiles
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ProfilesMockingSetup
    {
        public static Mock<IProfileModel> DoMockingSetupForProfileModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockProfileModel = new Mock<IProfileModel>();
            // Mock Functions
            mockProfileModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockProfileModel.Setup(m => m.Active).Returns(() => true);
            mockProfileModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockProfileModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfileModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfileModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockProfileModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockProfileModel.Setup(m => m.Name).Returns(() => name);
            //mockProfileModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockProfileModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockProfileModel.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfileModel>());
            // Return
            return mockProfileModel;
        }

        public static Mock<IProfile> DoMockingSetupForProfile(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockProfile = new Mock<IProfile>();
            // Mock Functions
            mockProfile.Setup(m => m.Id).Returns(() => idReturnValue);
            mockProfile.Setup(m => m.Active).Returns(() => true);
            mockProfile.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockProfile.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfile.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfile.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockProfile.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockProfile.Setup(m => m.Name).Returns(() => name);
            //mockProfile.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockProfile.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockProfile.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfile>());
            // Return
            return mockProfile;
        }
    }

    public class ProfileMappingExtensionsTests
    {
        [Fact]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ProfileMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IProfileModel>()));
            var mockModel = ProfilesMockingSetup.DoMockingSetupForProfileModel(1);
            ProfileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IProfileModel>()), Times.Once);
        }

        //[Fact]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ProfileMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IProfileModel>(), ref It.IsAny<IProfile>()));
        //    var mockModel = ProfilesMockingSetup.DoMockingSetupForProfileModel(1);
        //    var mockEntity = ProfilesMockingSetup.DoMockingSetupForProfile(1);
        //    ProfileMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IProfileModel>(), ref It.IsAny<IProfile>()), Times.Once);
        //}

        [Fact]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ProfileMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IProfile>()));
            var mockEntity = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            ProfileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IProfile>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ProfileMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IProfile>()));
            var mockEntity = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            ProfileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IProfile>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ProfileMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IProfile>()));
            var mockEntity = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            ProfileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IProfile>()), Times.Once);
        }

        [Fact]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ProfileMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IProfileModel>()));
            var mockModel = ProfilesMockingSetup.DoMockingSetupForProfileModel(1);
            ProfileMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IProfileModel>()), Times.Once);
        }

        public static Mock<IProfile> DoMockingSetupForProfile(int idReturnValue = 0)
        {
            var mockProfile = new Mock<IProfile>();
            // Mock Functions
            mockProfile.Setup(m => m.Id).Returns(() => idReturnValue);
            mockProfile.Setup(m => m.Active).Returns(() => true);
            mockProfile.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockProfile.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfile.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockProfile.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockProfile.Setup(m => m.UpdatedDate).Returns(() => null);
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockProfile.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfile>());
            // Return
            return mockProfile;
        }
    }

    public class ProfilesMappingTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsProfileProperties()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.OriginProfiles?.Count, entity.OriginProfiles?.Count);
            model.VerifyGet(x => x.OriginProfiles, Times.Once);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsProfileProperties()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel();
            // Act
            IProfile existingEntity = new Profile { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.OriginProfiles, Times.Once);
            //Assert.Equal(model.Object.OriginProfiles?.Count, existingEntity.OriginProfiles?.Count);
        }

        [Fact]
        public void Verify_MapToModel_AssignsProfileProperties()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var entity = ProfilesMockingSetup.DoMockingSetupForProfile();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.OriginProfiles?.Count, model.OriginProfiles?.Count);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyProfileProperties()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var entity = ProfilesMockingSetup.DoMockingSetupForProfile();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyProfileProperties()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var entity = ProfilesMockingSetup.DoMockingSetupForProfile();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsProfileSearchProperties()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel(1);
            var entity = ProfilesMockingSetup.DoMockingSetupForProfile(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ProfileMapper();
            var model = ProfilesMockingSetup.DoMockingSetupForProfileModel(1);
            var entity = ProfilesMockingSetup.DoMockingSetupForProfile(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
