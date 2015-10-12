// <auto-generated>
// <copyright file="Promos.IResourceTypeRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ResourceTypesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Promos
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class ResourceTypesMockingSetup
    {
        public static Mock<IResourceTypeModel> DoMockingSetupForResourceTypeModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockResourceTypeModel = new Mock<IResourceTypeModel>();
            // Mock Functions
            mockResourceTypeModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockResourceTypeModel.Setup(m => m.Active).Returns(() => true);
            mockResourceTypeModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockResourceTypeModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockResourceTypeModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockResourceTypeModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockResourceTypeModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockResourceTypeModel.Setup(m => m.Name).Returns(() => name);
            //mockResourceTypeModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockResourceTypeModel.Setup(m => m.Description).Returns(() => "long");
            mockResourceTypeModel.Setup(m => m.DetailResourceName).Returns(() => "DetailResourceName");
            mockResourceTypeModel.Setup(m => m.ListResourceName).Returns(() => "ListResourceName");
            // Related Objects
            // <None>
            // Associated Objects
            mockResourceTypeModel.Setup(m => m.Promos).Returns(() => new List<IPromoModel>());
            // Return
            return mockResourceTypeModel;
        }

        public static Mock<IResourceType> DoMockingSetupForResourceType(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockResourceType = new Mock<IResourceType>();
            // Mock Functions
            mockResourceType.Setup(m => m.Id).Returns(() => idReturnValue);
            mockResourceType.Setup(m => m.Active).Returns(() => true);
            mockResourceType.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockResourceType.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockResourceType.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockResourceType.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockResourceType.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockResourceType.Setup(m => m.Name).Returns(() => name);
            //mockResourceType.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockResourceType.Setup(m => m.Description).Returns(() => "long");
            mockResourceType.Setup(m => m.DetailResourceName).Returns(() => "DetailResourceName");
            mockResourceType.Setup(m => m.ListResourceName).Returns(() => "ListResourceName");
            // Related Objects
            // <None>
            // Associated Objects
            mockResourceType.Setup(m => m.Promos).Returns(() => new List<IPromo>());
            // Return
            return mockResourceType;
        }
    }

    public class ResourceTypeMappingExtensionsTests
    {
        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<ResourceTypeMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IResourceTypeModel>()));
            var mockModel = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel(1);
            ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IResourceTypeModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "ResourceTypes")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<ResourceTypeMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IResourceTypeModel>(), ref It.IsAny<IResourceType>()));
        //    var mockModel = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel(1);
        //    var mockEntity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(1);
        //    ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IResourceTypeModel>(), ref It.IsAny<IResourceType>()), Times.Once);
        //}

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ResourceTypeMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IResourceType>()));
            var mockEntity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(1);
            ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IResourceType>()), Times.Once);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ResourceTypeMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IResourceType>()));
            var mockEntity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(1);
            ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IResourceType>()), Times.Once);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ResourceTypeMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IResourceType>()));
            var mockEntity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(1);
            ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IResourceType>()), Times.Once);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<ResourceTypeMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IResourceTypeModel>()));
            var mockModel = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel(1);
            ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IResourceTypeModel>()), Times.Once);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<ResourceTypeMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IResourceTypeModel>(), It.IsAny<IResourceType>()));
            ResourceTypeMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel(1);
            var mockEntity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IResourceTypeModel>(), It.IsAny<IResourceType>()), Times.Once);
        }
    }

    public class ResourceTypesMappingTests
    {
        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToEntity_AssignsResourceTypeProperties()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var model = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.DetailResourceName, entity.DetailResourceName);
            Assert.Equal(model.Object.ListResourceName, entity.ListResourceName);
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.Promos?.Count, entity.Promos?.Count);
            model.VerifyGet(x => x.Promos, Times.Once);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsResourceTypeProperties()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var model = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel();
            // Act
            IResourceType existingEntity = new ResourceType { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.DetailResourceName, existingEntity.DetailResourceName);
            Assert.Equal(model.Object.ListResourceName, existingEntity.ListResourceName);
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.Promos, Times.Once);
            //Assert.Equal(model.Object.Promos?.Count, existingEntity.Promos?.Count);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToModel_AssignsResourceTypeProperties()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var entity = ResourceTypesMockingSetup.DoMockingSetupForResourceType();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.DetailResourceName, model.DetailResourceName);
            Assert.Equal(entity.Object.ListResourceName, model.ListResourceName);
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.Promos?.Count, model.Promos?.Count);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToModelLite_AssignsLiteOnlyResourceTypeProperties()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var entity = ResourceTypesMockingSetup.DoMockingSetupForResourceType();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.DetailResourceName, model.DetailResourceName);
            Assert.Equal(entity.Object.ListResourceName, model.ListResourceName);
            // Related Objects
            // <None>
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToModelListing_AssignsListingOnlyResourceTypeProperties()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var entity = ResourceTypesMockingSetup.DoMockingSetupForResourceType();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.DetailResourceName, model.DetailResourceName);
            Assert.Equal(entity.Object.ListResourceName, model.ListResourceName);
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_MapToSearchModel_AssignsResourceTypeSearchProperties()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var model = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var model = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel(1);
            var entity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "ResourceTypes")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new ResourceTypeMapper();
            var model = ResourceTypesMockingSetup.DoMockingSetupForResourceTypeModel(1);
            var entity = ResourceTypesMockingSetup.DoMockingSetupForResourceType(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
