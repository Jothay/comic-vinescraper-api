namespace ComicVine.API.Testing.Mappings.People
{
    using API.Mappings;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Mocking;
    using Xunit;

    public class PeopleMapperTests
    {
        [Fact]
        public void Verify_MapToEntity_AssignsPersonProperties()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var entity = personMapper.MapToEntity(model.Object);
            // Assert
            Assert.Equal(model.Object.Name, entity.Name);
            Assert.Equal(model.Object.Description, entity.Description);
        }

        [Fact]
        public void Verify_MapToEntity_WithExistingEntity_AssignsPersonProperties()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            IPerson existingEntity = new Person { Id = 1 };
            personMapper.MapToEntity(model.Object, ref existingEntity);
            // Assert
            Assert.Equal(model.Object.Name, existingEntity.Name);
            Assert.Equal(model.Object.Description, existingEntity.Description);
        }

        [Fact]
        public void Verify_MapToModel_AssignsPersonProperties()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = personMapper.MapToModel(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Equal(entity.Object.Description, model.Description);
        }

        [Fact]
        public void Verify_MapToModelLite_AssignsLiteOnlyPersonProperties()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = personMapper.MapToModelLite(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Equal(entity.Object.Description, model.Description);
        }

        [Fact]
        public void Verify_MapToModelListing_AssignsListingOnlyPersonProperties()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
            // Act
            var model = personMapper.MapToModelListing(entity.Object);
            // Assert
            Assert.Equal(entity.Object.Name, model.Name);
            Assert.Null(model.Description);
        }

        [Fact]
        public void Verify_MapToSearchModel_AssignsPersonSearchProperties()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            var searchModel = personMapper.MapToSearchModel(model.Object);
            // Assert
            Assert.Equal(model.Object.Name, searchModel.Name);
            Assert.Equal(model.Object.Description, searchModel.Description);
        }

        [Fact]
        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(1);
            // Act
            var result = personMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.True(result);
        }

        [Fact]
        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
        {
            // Arrange
            var personMapper = new PersonMapper();
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(2);
            // Act
            var result = personMapper.AreEqual(model.Object, entity.Object);
            // Assert
            Assert.False(result);
        }
    }
}
