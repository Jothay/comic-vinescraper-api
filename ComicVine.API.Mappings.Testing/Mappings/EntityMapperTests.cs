namespace ComicVine.API.Testing.Mappings
{
    using System;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Mocking;
    using Models;
    using ComicVine.API.Mappings;
    using SearchModels;
    using Xunit;

    public class EntityMapperTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsEntityProperties()
        {
            // Arrange
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            var entity = EntityMapper.MapToEntity<Author, IAuthorModel>(model.Object);
            // Assert
            Assert.Equal(model.Object.Id, entity.Id);
            Assert.Equal(model.Object.Active, entity.Active);
            Assert.Equal(model.Object.CustomKey, entity.CustomKey);
            Assert.Equal(model.Object.CreatedDate, entity.CreatedDate);
            Assert.Equal(model.Object.UpdatedDate, entity.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEntityProperties()
        {
            // Arrange
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            var existingEntity = new Author { Id = 1 };
            EntityMapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.Id, existingEntity.Id);
            Assert.Equal(model.Object.Active, existingEntity.Active);
            Assert.Equal(model.Object.CustomKey, existingEntity.CustomKey);
            Assert.Equal(model.Object.CreatedDate, existingEntity.CreatedDate);
            Assert.Equal(model.Object.UpdatedDate, existingEntity.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToModel_AssignsEntityProperties()
        {
            // Arrange
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor();
            // Act
            var model = EntityMapper.MapToModel<IAuthor, AuthorModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Id, model.Id);
            Assert.Equal(entity.Object.Active, model.Active);
            Assert.Equal(entity.Object.CustomKey, model.CustomKey);
            Assert.Equal(entity.Object.CreatedDate, model.CreatedDate);
            Assert.Equal(entity.Object.UpdatedDate, model.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyEntityProperties()
        {
            // Arrange
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor();
            // Act
            var model = EntityMapper.MapToModelLite<IAuthor, AuthorModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Id, model.Id);
            Assert.Equal(entity.Object.Active, model.Active);
            Assert.Equal(entity.Object.CustomKey, model.CustomKey);
            Assert.Equal(entity.Object.CreatedDate, model.CreatedDate);
            Assert.Equal(entity.Object.UpdatedDate, model.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyEntityProperties()
        {
            // Arrange
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor();
            // Act
            var model = EntityMapper.MapToModelListing<IAuthor, AuthorModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Id, model.Id);
            Assert.Equal(entity.Object.Active, model.Active);
            Assert.Equal(entity.Object.CustomKey, model.CustomKey);
            Assert.Equal(new DateTime(1,1,1), model.CreatedDate);
            Assert.Null(model.UpdatedDate);
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsEntitySearchProperties()
        {
            // Arrange
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            var searchModel = EntityMapper.MapToSearchModel<IAuthorModel, AuthorSearchModel>(model.Object);
            // Assert
            Assert.Equal(model.Object.Id, searchModel.Id);
            Assert.Equal(model.Object.CustomKey, searchModel.CustomKey);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel(1);
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor(1);
            // Act
            var result = EntityMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel(1);
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor(2);
            // Act
            var result = EntityMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(false, result);
        }
    }
}
