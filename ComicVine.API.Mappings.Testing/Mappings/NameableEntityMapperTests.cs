namespace ComicVine.API.Testing.Mappings
{
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Models;
    using People;
    using SearchModels;
    using Xunit;

    public class NameableEntityMapperTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsEntityProperties()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var entity = NameableEntityMapper.MapToEntity<Person, IPersonModel>(model.Object);
            // Assert
            Assert.Equal(model.Object.Name, entity.Name);
            Assert.Equal(model.Object.ShortDescription, entity.ShortDescription);
            Assert.Equal(model.Object.Description, entity.Description);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsEntityProperties()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var existingEntity = new Person { Id = 1 };
            NameableEntityMapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.Name, existingEntity.Name);
            Assert.Equal(model.Object.ShortDescription, existingEntity.ShortDescription);
            Assert.Equal(model.Object.Description, existingEntity.Description);
        }

        [Fact]
        public void Verify_MapToModel_AssignsEntityProperties()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = NameableEntityMapper.MapToModel<IPerson, PersonModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Equal(entity.Object.ShortDescription, model.ShortDescription);
            Assert.Equal(entity.Object.Description, model.Description);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyEntityProperties()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = NameableEntityMapper.MapToModelLite<IPerson, PersonModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Equal(entity.Object.ShortDescription, model.ShortDescription);
            Assert.Equal(entity.Object.Description, model.Description);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyEntityProperties()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = NameableEntityMapper.MapToModelListing<IPerson, PersonModel>(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Null(model.ShortDescription);
            Assert.Null(model.Description);
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsEntitySearchProperties()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var searchModel = NameableEntityMapper.MapToSearchModel<IPersonModel, PersonSearchModel>(model.Object);
            // Assert
            Assert.Equal(model.Object.Name, searchModel.Name);
            Assert.Equal(model.Object.ShortDescription, searchModel.ShortDescription);
            Assert.Equal(model.Object.Description, searchModel.Description);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(1);
            // Act
            var result = NameableEntityMapper.AreEqual(model.Object, entity.Object);
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
            var result = NameableEntityMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.Equal(false, result);
        }
    }
}
