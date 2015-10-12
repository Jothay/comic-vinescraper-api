// <auto-generated>
// <copyright file="People.IGenderRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the GendersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.People
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class GendersMockingSetup
    {
        public static Mock<IGenderModel> DoMockingSetupForGenderModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockGenderModel = new Mock<IGenderModel>();
            // Mock Functions
            mockGenderModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockGenderModel.Setup(m => m.Active).Returns(() => true);
            mockGenderModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockGenderModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGenderModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGenderModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockGenderModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockGenderModel.Setup(m => m.Name).Returns(() => name);
            //mockGenderModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockGenderModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockGenderModel.Setup(m => m.Characters).Returns(() => new List<ICharacterModel>());
            mockGenderModel.Setup(m => m.People).Returns(() => new List<IPersonModel>());
            // Return
            return mockGenderModel;
        }

        public static Mock<IGender> DoMockingSetupForGender(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockGender = new Mock<IGender>();
            // Mock Functions
            mockGender.Setup(m => m.Id).Returns(() => idReturnValue);
            mockGender.Setup(m => m.Active).Returns(() => true);
            mockGender.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockGender.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGender.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockGender.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockGender.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockGender.Setup(m => m.Name).Returns(() => name);
            //mockGender.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockGender.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            mockGender.Setup(m => m.Characters).Returns(() => new List<ICharacter>());
            mockGender.Setup(m => m.People).Returns(() => new List<IPerson>());
            // Return
            return mockGender;
        }
    }

    public class GenderMappingExtensionsTests
    {
        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<GenderMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IGenderModel>()));
            var mockModel = GendersMockingSetup.DoMockingSetupForGenderModel(1);
            GenderMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IGenderModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "Genders")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<GenderMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IGenderModel>(), ref It.IsAny<IGender>()));
        //    var mockModel = GendersMockingSetup.DoMockingSetupForGenderModel(1);
        //    var mockEntity = GendersMockingSetup.DoMockingSetupForGender(1);
        //    GenderMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IGenderModel>(), ref It.IsAny<IGender>()), Times.Once);
        //}

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<GenderMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IGender>()));
            var mockEntity = GendersMockingSetup.DoMockingSetupForGender(1);
            GenderMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IGender>()), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<GenderMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IGender>()));
            var mockEntity = GendersMockingSetup.DoMockingSetupForGender(1);
            GenderMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IGender>()), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<GenderMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IGender>()));
            var mockEntity = GendersMockingSetup.DoMockingSetupForGender(1);
            GenderMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IGender>()), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<GenderMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IGenderModel>()));
            var mockModel = GendersMockingSetup.DoMockingSetupForGenderModel(1);
            GenderMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IGenderModel>()), Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<GenderMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>()));
            GenderMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = GendersMockingSetup.DoMockingSetupForGenderModel(1);
            var mockEntity = GendersMockingSetup.DoMockingSetupForGender(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IGenderModel>(), It.IsAny<IGender>()), Times.Once);
        }
    }

    public class GendersMappingTests
    {
        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToEntity_AssignsGenderProperties()
        {
            // Arrange
            var mapper = new GenderMapper();
            var model = GendersMockingSetup.DoMockingSetupForGenderModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            //Assert.Equal(model.Object.Characters?.Count, entity.Characters?.Count);
            model.VerifyGet(x => x.Characters, Times.Once);
            //Assert.Equal(model.Object.People?.Count, entity.People?.Count);
            model.VerifyGet(x => x.People, Times.Once);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsGenderProperties()
        {
            // Arrange
            var mapper = new GenderMapper();
            var model = GendersMockingSetup.DoMockingSetupForGenderModel();
            // Act
            IGender existingEntity = new Gender { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.VerifyGet(x => x.Characters, Times.Once);
            //Assert.Equal(model.Object.Characters?.Count, existingEntity.Characters?.Count);
            model.VerifyGet(x => x.People, Times.Once);
            //Assert.Equal(model.Object.People?.Count, existingEntity.People?.Count);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToModel_AssignsGenderProperties()
        {
            // Arrange
            var mapper = new GenderMapper();
            var entity = GendersMockingSetup.DoMockingSetupForGender();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            Assert.Equal(entity.Object.Characters?.Count, model.Characters?.Count);
            Assert.Equal(entity.Object.People?.Count, model.People?.Count);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToModelLite_AssignsLiteOnlyGenderProperties()
        {
            // Arrange
            var mapper = new GenderMapper();
            var entity = GendersMockingSetup.DoMockingSetupForGender();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToModelListing_AssignsListingOnlyGenderProperties()
        {
            // Arrange
            var mapper = new GenderMapper();
            var entity = GendersMockingSetup.DoMockingSetupForGender();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            // <None>
            // Return Entity
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_MapToSearchModel_AssignsGenderSearchProperties()
        {
            // Arrange
            var mapper = new GenderMapper();
            var model = GendersMockingSetup.DoMockingSetupForGenderModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new GenderMapper();
            var model = GendersMockingSetup.DoMockingSetupForGenderModel(1);
            var entity = GendersMockingSetup.DoMockingSetupForGender(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "Genders")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new GenderMapper();
            var model = GendersMockingSetup.DoMockingSetupForGenderModel(1);
            var entity = GendersMockingSetup.DoMockingSetupForGender(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
