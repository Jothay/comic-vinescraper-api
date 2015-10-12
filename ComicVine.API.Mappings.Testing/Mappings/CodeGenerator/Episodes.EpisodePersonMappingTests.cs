// <auto-generated>
// <copyright file="Episodes.IEpisodePersonRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodePeopleRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryTestingFileMaster.tt in ComicVine.API.Repositories.Testing\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Testing.Mappings.Episodes
{
    using System.Collections.Generic;
    using API.Models;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Moq;
    using Xunit;

    public static class EpisodePeopleMockingSetup
    {
        public static Mock<IEpisodePersonModel> DoMockingSetupForEpisodePersonModel(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodePersonModel = new Mock<IEpisodePersonModel>();
            // Mock Functions
            mockEpisodePersonModel.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodePersonModel.Setup(m => m.Active).Returns(() => true);
            mockEpisodePersonModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodePersonModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodePersonModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodePersonModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodePersonModel.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodePersonModel.Setup(m => m.Name).Returns(() => name);
            //mockEpisodePersonModel.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodePersonModel.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodePersonModel.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodePersonModel.Setup(m => m.Episode).Returns(() => new EpisodeModel());
            mockEpisodePersonModel.Setup(m => m.PersonId).Returns(() => 1);
            mockEpisodePersonModel.Setup(m => m.Person).Returns(() => new PersonModel());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodePersonModel;
        }

        public static Mock<IEpisodePerson> DoMockingSetupForEpisodePerson(int idReturnValue = 0, string name = "Stephen King")
        {
            var mockEpisodePerson = new Mock<IEpisodePerson>();
            // Mock Functions
            mockEpisodePerson.Setup(m => m.Id).Returns(() => idReturnValue);
            mockEpisodePerson.Setup(m => m.Active).Returns(() => true);
            mockEpisodePerson.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
            mockEpisodePerson.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodePerson.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
            mockEpisodePerson.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
            mockEpisodePerson.Setup(m => m.UpdatedDate).Returns(() => null);
            //mockEpisodePerson.Setup(m => m.Name).Returns(() => name);
            //mockEpisodePerson.Setup(m => m.ShortDescription).Returns(() => "short");
            //mockEpisodePerson.Setup(m => m.Description).Returns(() => "long");
            // <None>
            // Related Objects
            mockEpisodePerson.Setup(m => m.EpisodeId).Returns(() => 1);
            mockEpisodePerson.Setup(m => m.Episode).Returns(() => new Episode());
            mockEpisodePerson.Setup(m => m.PersonId).Returns(() => 1);
            mockEpisodePerson.Setup(m => m.Person).Returns(() => new Person());
            // Associated Objects
            // <None>
            // Return
            return mockEpisodePerson;
        }
    }

    public class EpisodePersonMappingExtensionsTests
    {
        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToEntityExtension_CallsMapToEntity()
        {
            // Arrange
            var mockMapper = new Mock<EpisodePersonMapper>();
            mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodePersonModel>()));
            var mockModel = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel(1);
            EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToEntity();
            // Assert
            mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodePersonModel>()), Times.Once);
        }

        //[Fact][Trait("Category", "EpisodePeople")]
        //public void Verify_MapToEntityWithExistingExtension_CallsMapToEntity()
        //{
        //    // Arrange
        //    var mockMapper = new Mock<EpisodePersonMapper>();
        //    mockMapper.Setup(x => x.MapToEntity(It.IsAny<IEpisodePersonModel>(), ref It.IsAny<IEpisodePerson>()));
        //    var mockModel = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel(1);
        //    var mockEntity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(1);
        //    EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
        //    // Act
        //    mockModel.Object.MapToEntity(ref mockEntity);
        //    // Assert
        //    mockMapper.Verify(x => x.MapToEntity(It.IsAny<IEpisodePersonModel>(), ref It.IsAny<IEpisodePerson>()), Times.Once);
        //}

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodePersonMapper>();
            mockMapper.Setup(x => x.MapToModel(It.IsAny<IEpisodePerson>()));
            var mockEntity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(1);
            EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModel();
            // Assert
            mockMapper.Verify(x => x.MapToModel(It.IsAny<IEpisodePerson>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToModelLiteExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodePersonMapper>();
            mockMapper.Setup(x => x.MapToModelLite(It.IsAny<IEpisodePerson>()));
            var mockEntity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(1);
            EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelLite();
            // Assert
            mockMapper.Verify(x => x.MapToModelLite(It.IsAny<IEpisodePerson>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToModelListingExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodePersonMapper>();
            mockMapper.Setup(x => x.MapToModelListing(It.IsAny<IEpisodePerson>()));
            var mockEntity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(1);
            EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockEntity.Object.MapToModelListing();
            // Assert
            mockMapper.Verify(x => x.MapToModelListing(It.IsAny<IEpisodePerson>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToSearchModelExtension_CallsMapToModel()
        {
            // Arrange
            var mockMapper = new Mock<EpisodePersonMapper>();
            mockMapper.Setup(x => x.MapToSearchModel(It.IsAny<IEpisodePersonModel>()));
            var mockModel = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel(1);
            EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
            // Act
            mockModel.Object.MapToSearchModel();
            // Assert
            mockMapper.Verify(x => x.MapToSearchModel(It.IsAny<IEpisodePersonModel>()), Times.Once);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_AreEqualExtension_CallsAreEqual()
        {
            // Arrange
            var mockMapper = new Mock<EpisodePersonMapper>();
            mockMapper.Setup(x => x.AreEqual(It.IsAny<IEpisodePersonModel>(), It.IsAny<IEpisodePerson>()));
            EpisodePersonMapperExtensions.OverrideMapper(mockMapper.Object);
            var mockModel = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel(1);
            var mockEntity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(1);
            // Act
            mockModel.Object.AreEqual(mockEntity.Object);
            // Assert
            mockMapper.Verify(x => x.AreEqual(It.IsAny<IEpisodePersonModel>(), It.IsAny<IEpisodePerson>()), Times.Once);
        }
    }

    public class EpisodePeopleMappingTests
    {
        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToEntity_AssignsEpisodePersonProperties()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var model = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel();
            // Act
            var entity = mapper.MapToEntity(model.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, entity.EpisodeId);
            Assert.Equal(model.Object.PersonId, entity.PersonId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEpisodePersonProperties()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var model = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel();
            // Act
            IEpisodePerson existingEntity = new EpisodePerson { Id = 1 };
            mapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(model.Object.EpisodeId, existingEntity.EpisodeId);
            Assert.Equal(model.Object.PersonId, existingEntity.PersonId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToModel_AssignsEpisodePersonProperties()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var entity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson();
            // Act
            var model = mapper.MapToModel(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.PersonId, model.PersonId);
            // Associated Objects
            // <None>
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToModelLite_AssignsLiteOnlyEpisodePersonProperties()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var entity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson();
            // Act
            var model = mapper.MapToModelLite(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.PersonId, model.PersonId);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToModelListing_AssignsListingOnlyEpisodePersonProperties()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var entity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson();
            // Act
            var model = mapper.MapToModelListing(entity.Object);
            // Assert
            // <None>
            // Related Objects
            Assert.Equal(entity.Object.EpisodeId, model.EpisodeId);
            Assert.Equal(entity.Object.PersonId, model.PersonId);
            // Return Entity
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_MapToSearchModel_AssignsEpisodePersonSearchProperties()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var model = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel();
            // Act
            var searchModel = mapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.EpisodeId, searchModel.EpisodeId);
            Assert.Equal(model.Object.Episode?.CustomKey, searchModel.EpisodeCustomKey);
            Assert.Equal(model.Object.Episode?.ApiDetailUrl, searchModel.EpisodeApiDetailUrl);
            Assert.Equal(model.Object.Episode?.SiteDetailUrl, searchModel.EpisodeSiteDetailUrl);
            Assert.Equal(model.Object.Episode?.Name, searchModel.EpisodeName);
            Assert.Equal(model.Object.Episode?.ShortDescription, searchModel.EpisodeShortDescription);
            Assert.Equal(model.Object.Episode?.Description, searchModel.EpisodeDescription);
            Assert.Equal(model.Object.PersonId, searchModel.PersonId);
            Assert.Equal(model.Object.Person?.CustomKey, searchModel.PersonCustomKey);
            Assert.Equal(model.Object.Person?.ApiDetailUrl, searchModel.PersonApiDetailUrl);
            Assert.Equal(model.Object.Person?.SiteDetailUrl, searchModel.PersonSiteDetailUrl);
            Assert.Equal(model.Object.Person?.Name, searchModel.PersonName);
            Assert.Equal(model.Object.Person?.ShortDescription, searchModel.PersonShortDescription);
            Assert.Equal(model.Object.Person?.Description, searchModel.PersonDescription);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var model = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel(1);
            var entity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(1);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact][Trait("Category", "EpisodePeople")]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var mapper = new EpisodePersonMapper();
            var model = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePersonModel(1);
            var entity = EpisodePeopleMockingSetup.DoMockingSetupForEpisodePerson(2);
            // Act
            var result = mapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
