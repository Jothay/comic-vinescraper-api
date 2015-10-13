//namespace ComicVine.API.Testing.Mappings.People
//{
//    using API.Mappings;
//    using DataModel.Schema;
//    using Interfaces.DataModels;
//    using Interfaces.Models;
//    using Moq;
//    using Xunit;

//    public static class PeopleMockingSetup
//    {
//        public static Mock<IPersonModel> DoMockingSetupForPersonModel(int idReturnValue = 0, string name = "Stephen King")
//        {
//            var mockPersonModel = new Mock<IPersonModel>();
//            // Mock Functions
//            mockPersonModel.Setup(m => m.Id).Returns(() => idReturnValue);
//            mockPersonModel.Setup(m => m.Active).Returns(() => true);
//            mockPersonModel.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
//            mockPersonModel.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
//            mockPersonModel.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
//            mockPersonModel.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
//            mockPersonModel.Setup(m => m.UpdatedDate).Returns(() => null);
//            mockPersonModel.Setup(m => m.Name).Returns(() => name);
//            mockPersonModel.Setup(m => m.ShortDescription).Returns(() => "short");
//            mockPersonModel.Setup(m => m.Description).Returns(() => "long");
//            // Return
//            return mockPersonModel;
//        }

//        public static Mock<IPerson> DoMockingSetupForPerson(int idReturnValue = 0)
//        {
//            var mockPerson = new Mock<IPerson>();
//            // Mock Functions
//            mockPerson.Setup(m => m.Id).Returns(() => idReturnValue);
//            mockPerson.Setup(m => m.Active).Returns(() => true);
//            mockPerson.Setup(m => m.CustomKey).Returns(() => "KING-STEPHEN");
//            mockPerson.Setup(m => m.ApiDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
//            mockPerson.Setup(m => m.SiteDetailUrl).Returns(() => "/TEST/KING-STEPHEN");
//            mockPerson.Setup(m => m.CreatedDate).Returns(() => new System.DateTime(2015, 10, 1));
//            mockPerson.Setup(m => m.UpdatedDate).Returns(() => null);
//            mockPerson.Setup(m => m.Name).Returns(() => "Stephen King");
//            mockPerson.Setup(m => m.ShortDescription).Returns(() => "short");
//            mockPerson.Setup(m => m.Description).Returns(() => "long");
//            // Return
//            return mockPerson;
//        }
//    }

//    public class PeopleMapperTestsExample
//    {
//        [Fact]
//        public void Verify_MapToEntity_AssignsPersonProperties()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
//            // Act
//            var entity = mapper.MapToEntity(model.Object);
//            // Assert
//            Assert.Equal(model.Object.Name, entity.Name);
//            Assert.Equal(model.Object.Description, entity.Description);
//        }

//        [Fact]
//        public void Verify_MapToEntity_WithExistingEntity_AssignsPersonProperties()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
//            // Act
//            IPerson existingEntity = new Person { Id = 1 };
//            mapper.MapToEntity(model.Object, ref existingEntity);
//            // Assert
//            Assert.Equal(model.Object.Name, existingEntity.Name);
//            Assert.Equal(model.Object.Description, existingEntity.Description);
//        }

//        [Fact]
//        public void Verify_MapToModel_AssignsPersonProperties()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
//            // Act
//            var model = mapper.MapToModel(entity.Object);
//            // Assert
//            Assert.Equal(entity.Object.Name, model.Name);
//            Assert.Equal(entity.Object.Description, model.Description);
//        }

//        [Fact]
//        public void Verify_MapToModelLite_AssignsLiteOnlyPersonProperties()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
//            // Act
//            var model = mapper.MapToModelLite(entity.Object);
//            // Assert
//            Assert.Equal(entity.Object.Name, model.Name);
//            Assert.Equal(entity.Object.Description, model.Description);
//        }

//        [Fact]
//        public void Verify_MapToModelListing_AssignsListingOnlyPersonProperties()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var entity = PeopleMockingSetup.DoMockingSetupForPerson();
//            // Act
//            var model = mapper.MapToModelListing(entity.Object);
//            // Assert
//            Assert.Equal(entity.Object.Name, model.Name);
//            Assert.Null(model.Description);
//        }

//        [Fact]
//        public void Verify_MapToSearchModel_AssignsPersonSearchProperties()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
//            // Act
//            var searchModel = mapper.MapToSearchModel(model.Object);
//            // Assert
//            Assert.Equal(model.Object.Name, searchModel.Name);
//            Assert.Equal(model.Object.Description, searchModel.Description);
//        }

//        [Fact]
//        public void Verify_AreEqual_WithEqualObjects_ReturnsTrue()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
//            var entity = PeopleMockingSetup.DoMockingSetupForPerson(1);
//            // Act
//            var result = mapper.AreEqual(model.Object, entity.Object);
//            // Assert
//            Assert.True(result);
//        }

//        [Fact]
//        public void Verify_AreEqual_WithDifferentObjects_ReturnsFalse()
//        {
//            // Arrange
//            var mapper = new PersonMapper();
//            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
//            var entity = PeopleMockingSetup.DoMockingSetupForPerson(2);
//            // Act
//            var result = mapper.AreEqual(model.Object, entity.Object);
//            // Assert
//            Assert.False(result);
//        }
//    }
//}
