﻿namespace ComicVineScraper.API.Testing.Mappings
{
    using System;
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Models;
    using People;
    using SearchModels;
    using Xunit;

    public class EntityMapperTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsEntityProperties()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var entity = EntityMapper.MapToEntity<Person, IPersonModel>(model.Object);
            // Assert
            Assert.Equal(model.Object.Id, entity.Id);
            Assert.Equal(model.Object.Active, entity.Active);
            Assert.Equal(model.Object.CustomKey, entity.CustomKey);
            Assert.Equal(model.Object.ApiDetailUrl, entity.ApiDetailUrl);
            Assert.Equal(model.Object.SiteDetailUrl, entity.SiteDetailUrl);
            Assert.Equal(model.Object.CreatedDate, entity.CreatedDate);
            Assert.Equal(model.Object.UpdatedDate, entity.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEntityProperties()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var existingEntity = new Person { Id = 1 };
            EntityMapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.Id, existingEntity.Id);
            Assert.Equal(model.Object.Active, existingEntity.Active);
            Assert.Equal(model.Object.CustomKey, existingEntity.CustomKey);
            Assert.Equal(model.Object.ApiDetailUrl, existingEntity.ApiDetailUrl);
            Assert.Equal(model.Object.SiteDetailUrl, existingEntity.SiteDetailUrl);
            Assert.Equal(model.Object.CreatedDate, existingEntity.CreatedDate);
            Assert.Equal(model.Object.UpdatedDate, existingEntity.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToModel_AssignsEntityProperties()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = EntityMapper.MapToModel<IPerson, PersonModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Id, model.Id);
            Assert.Equal(entity.Object.Active, model.Active);
            Assert.Equal(entity.Object.CustomKey, model.CustomKey);
            Assert.Equal(entity.Object.ApiDetailUrl, model.ApiDetailUrl);
            Assert.Equal(entity.Object.SiteDetailUrl, model.SiteDetailUrl);
            Assert.Equal(entity.Object.CreatedDate, model.CreatedDate);
            Assert.Equal(entity.Object.UpdatedDate, model.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyEntityProperties()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = EntityMapper.MapToModelLite<IPerson, PersonModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Id, model.Id);
            Assert.Equal(entity.Object.Active, model.Active);
            Assert.Equal(entity.Object.CustomKey, model.CustomKey);
            Assert.Equal(entity.Object.ApiDetailUrl, model.ApiDetailUrl);
            Assert.Equal(entity.Object.SiteDetailUrl, model.SiteDetailUrl);
            Assert.Equal(entity.Object.CreatedDate, model.CreatedDate);
            Assert.Equal(entity.Object.UpdatedDate, model.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyEntityProperties()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = EntityMapper.MapToModelListing<IPerson, PersonModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Id, model.Id);
            Assert.Equal(entity.Object.Active, model.Active);
            Assert.Equal(entity.Object.CustomKey, model.CustomKey);
            Assert.Null(model.ApiDetailUrl);
            Assert.Null(model.SiteDetailUrl);
            Assert.Equal(new DateTime(1,1,1), model.CreatedDate);
            Assert.Null(model.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsEntitySearchProperties()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var searchModel = EntityMapper.MapToSearchModel<IPersonModel, PersonSearchModel>(model.Object);
            // Assert
            Assert.Equal(model.Object.Id, searchModel.Id);
            Assert.Equal(model.Object.CustomKey, searchModel.CustomKey);
            Assert.Equal(model.Object.ApiDetailUrl, searchModel.ApiDetailUrl);
            Assert.Equal(model.Object.SiteDetailUrl, searchModel.SiteDetailUrl);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(1);
            // Act
            var result = EntityMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(2);
            // Act
            var result = EntityMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(false, result);
        }
    }
}
