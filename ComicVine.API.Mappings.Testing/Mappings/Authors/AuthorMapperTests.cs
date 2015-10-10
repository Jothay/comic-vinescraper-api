namespace ComicVine.API.Testing.Mappings.Authors
{
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Mocking;
    using API.Mappings.Authors;
    using Xunit;

    public class AuthorsMapperTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsAuthorProperties()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            var entity = authorMapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.Name, entity.Name);
            Assert.Equal(model.Object.Description, entity.Description);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsAuthorProperties()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            IAuthor existingEntity = new Author { Id = 1 };
            authorMapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.Name, existingEntity.Name);
            Assert.Equal(model.Object.Description, existingEntity.Description);
        }

        [Fact]
        public void Verify_MapToModel_AssignsAuthorProperties()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor();
            // Act
            var model = authorMapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Equal(entity.Object.Description, model.Description);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyAuthorProperties()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor();
            // Act
            var model = authorMapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Equal(entity.Object.Description, model.Description);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyAuthorProperties()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor();
            // Act
            var model = authorMapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Null(model.Description);
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsAuthorSearchProperties()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel();
            // Act
            var searchModel = authorMapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.Name, searchModel.Name);
            Assert.Equal(model.Object.Description, searchModel.Description);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel(1);
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor(1);
            // Act
            var result = authorMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var authorMapper = new AuthorMapper();
            var model = AuthorsMockingSetup.DoMockingSetupForAuthorModel(1);
            var entity = AuthorsMockingSetup.DoMockingSetupForAuthor(2);
            // Act
            var result = authorMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(false, result);
        }
    }
}
