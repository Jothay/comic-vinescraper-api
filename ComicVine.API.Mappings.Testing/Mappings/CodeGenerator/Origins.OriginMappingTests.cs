// <auto-generated>
// <copyright file="Origins.IOriginRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the OriginsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Origins
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class OriginsMockingSetup
    {
        public static Mock<IOriginModel> DoMockingSetupForOriginModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockOriginModel = new Mock<IOriginModel>();
            // Mock Functions
            mockOriginModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockOriginModel.Setup(m => m.Active).Returns(() => true);
            mockOriginModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockOriginModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockOriginModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockOriginModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockOriginModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockOriginModel.Setup(m => m.Name).Returns(() => name);
            //mockOriginModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockOriginModel.Setup(m => m.Description).Returns(() => "long");
            mockOriginModel.Setup(m => m.CharacterSet).Returns(() => "CharacterSet");
            // Related Objects
            // <None>
            // Associated Objects
            mockOriginModel.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfileModel>());
            // Return
            return mockOriginModel;
        }

        public static Mock<IOrigin> DoMockingSetupForOrigin(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockOrigin = new Mock<IOrigin>();
            // Mock Functions
            mockOrigin.Setup(m => m.Id).Returns(() => idReturnValue);
            mockOrigin.Setup(m => m.Active).Returns(() => true);
            mockOrigin.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockOrigin.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockOrigin.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockOrigin.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockOrigin.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockOrigin.Setup(m => m.Name).Returns(() => name);
            //mockOrigin.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockOrigin.Setup(m => m.Description).Returns(() => "long");
            mockOrigin.Setup(m => m.CharacterSet).Returns(() => "CharacterSet");
            // Related Objects
            // <None>
            // Associated Objects
            mockOrigin.Setup(m => m.OriginProfiles).Returns(() => new List<IOriginProfile>());
            // Return
            return mockOrigin;
        }
    }

    public class OriginMappingExtensionsTests
    {
        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<OriginMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IOriginModel>(), It.IsAny<int>()));
            var mockModel = OriginsMockingSetup.DoMockingSetupForOriginModel(1);
            OriginMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IOriginModel>(), It.IsAny<int>()), Times.Once);
        }

        //[Fact][Trait("Category", "Origins")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<OriginMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IOriginModel>(), ref It.IsAny<IOrigin>(), It.IsAny<int>()));
        //    var mockModel = OriginsMockingSetup.DoMockingSetupForOriginModel(1);
        //    var mockEntity = OriginsMockingSetup.DoMockingSetupForOrigin(1);
        //    OriginMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IOriginModel>(), ref It.IsAny<IOrigin>(), It.IsAny<int>()), Times.Once);
        //}

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<OriginMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IOrigin>(), It.IsAny<int>()));
            var mockEntity = OriginsMockingSetup.DoMockingSetupForOrigin(1);
            OriginMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IOrigin>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<OriginMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IOrigin>(), It.IsAny<int>()));
            var mockEntity = OriginsMockingSetup.DoMockingSetupForOrigin(1);
            OriginMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IOrigin>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<OriginMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IOrigin>(), It.IsAny<int>()));
            var mockEntity = OriginsMockingSetup.DoMockingSetupForOrigin(1);
            OriginMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IOrigin>(), It.IsAny<int>()), Times.Once);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<OriginMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IOriginModel>()));
            var mockModel = OriginsMockingSetup.DoMockingSetupForOriginModel(1);
            OriginMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IOriginModel>()), Times.Once);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<OriginMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IOriginModel>(), It.IsAny<IOrigin>()));
            OriginMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = OriginsMockingSetup.DoMockingSetupForOriginModel(1);
            var mockEntity = OriginsMockingSetup.DoMockingSetupForOrigin(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IOriginModel>(), It.IsAny<IOrigin>()), Times.Once);
        }
    }

    public class OriginsMappingTests
    {
        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToEntity_AssignsOriginProperties()
        {
            // Arrange
            var mapper = new OriginMapper();
            var model = OriginsMockingSetup.DoMockingSetupForOriginModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.CharacterSet, entity.CharacterSet);
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.OriginProfiles?.Count, entity.OriginProfiles?.Count);
            model.VerifyGet(x => x.OriginProfiles, Times.Once);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsOriginProperties()
        {
            // Arrange
            var mapper = new OriginMapper();
            var model = OriginsMockingSetup.DoMockingSetupForOriginModel();
            // Act
            IOrigin existingEntity = new Origin { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.CharacterSet, existingEntity.CharacterSet);
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.OriginProfiles, Times.Once);
            //Assert.Equal(model.Object.OriginProfiles?.Count, existingEntity.OriginProfiles?.Count);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToModel_AssignsOriginProperties()
        {
            // Arrange
            var mapper = new OriginMapper();
            var entity = OriginsMockingSetup.DoMockingSetupForOrigin();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.CharacterSet, model.CharacterSet);
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.OriginProfiles?.Count, model.OriginProfiles?.Count);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToModelLite_AssignsLiteOnlyOriginProperties()
        {
            // Arrange
            var mapper = new OriginMapper();
            var entity = OriginsMockingSetup.DoMockingSetupForOrigin();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.CharacterSet, model.CharacterSet);
            // Related Objects
            // <None>
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToModelListing_AssignsListingOnlyOriginProperties()
        {
            // Arrange
            var mapper = new OriginMapper();
            var entity = OriginsMockingSetup.DoMockingSetupForOrigin();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.CharacterSet, model.CharacterSet);
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_MapToSearchModel_AssignsOriginSearchProperties()
        {
            // Arrange
            var mapper = new OriginMapper();
            var model = OriginsMockingSetup.DoMockingSetupForOriginModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new OriginMapper();
            var model = OriginsMockingSetup.DoMockingSetupForOriginModel(1);
            var entity = OriginsMockingSetup.DoMockingSetupForOrigin(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "Origins")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new OriginMapper();
            var model = OriginsMockingSetup.DoMockingSetupForOriginModel(1);
            var entity = OriginsMockingSetup.DoMockingSetupForOrigin(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
