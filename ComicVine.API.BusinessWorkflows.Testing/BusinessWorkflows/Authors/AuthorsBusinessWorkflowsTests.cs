namespace ComicVine.API.Testing.BusinessWorkflows.People
{
    using System;
    using System.Collections.Generic;
    using API.BusinessWorkflows;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Mappings;
    using Mocking;
    using Models;
    using Moq;
    using Xunit;

    public class PeopleBusinessWorkflowsTests
    {
        #region Read
        [Fact]
        public void Verify_Get_ByID_Should_ReturnTheCorrectObjectType()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            // Act
            var person = businessWorkflow.Get(1);
            // Assert
            Assert.IsType<PersonModel>(person);
        }

        [Fact]
        public void Verify_Get_ByKey_Should_ReturnTheCorrectObject()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            // Act
            var person = businessWorkflow.Get("KING-STEPHEN");
            // Assert
            Assert.IsType<PersonModel>(person);
        }

        [Fact]
        public void Verify_Search_Should_ReturnAListOfPeople()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IPersonSearchModel>();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object);
            // Assert
            mockPeopleRepository.Verify(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()), Times.Once);
        }

        [Fact]
        public void Verify_Search_AsListing_Should_ReturnAListOfPeopleWithDataMatchingSearchParametersWithListingMapping()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var searchModel = new Mock<IPersonSearchModel>();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act
            businessWorkflow.Search(searchModel.Object, true);
            // Assert
            mockPeopleRepository.Verify(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()), Times.Once);
        }
        #endregion
        #region Create
        [Fact]
        public void Verify_Create_Should_AddANewEntityObjectToTheDatabase()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new Mock<List<IPerson>>().Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            try { businessWorkflow.Create(model.Object); } catch { /* Ignored */ }
            // Assert
            mockPeopleRepository.Verify(m => m.Add(It.IsAny<IPerson>()), Times.Once);
        }
        [Fact]
        public void Verify_Create_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPerson = PeopleMockingSetup.DoMockingSetupForPerson(1);
            mockPeopleRepository.Setup(m => m.Search(It.IsAny<IPersonSearchModel>(), It.IsAny<bool>()))
                .Returns(() => new List<IPerson> { mockPerson.Object } );
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockPerson.Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel();
            // Act
            try { businessWorkflow.Create(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            mockPeopleRepository.Verify(m => m.Add(It.IsAny<IPerson>()), Times.Never);
        }
        #endregion
        #region Update
        [Fact]
        public void Verify_Update_Should_SetUpdatedDate()
        {
            // Arrange
            var mockPerson = PeopleMockingSetup.DoMockingSetupForPerson(1);
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => mockPerson.Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var expectedName = "Stephen King (2)";
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1, expectedName);
            // Act
            businessWorkflow.Update(model.Object);
            // Assert
            mockPerson.Verify(m => m.UpdatedDate, Times.Once);
        }
        [Fact]
        public void Verify_Update_WithDuplicateData_Should_NotAddAndReturnOriginal()
        {
            // Arrange
            var entity = PeopleMockingSetup.DoMockingSetupForPerson(1);
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => entity.Object);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            var model = PeopleMockingSetup.DoMockingSetupForPersonModel(1);
            IPersonModel result = null;
            // Act
            try { result = businessWorkflow.Update(model.Object); }
            catch { /* ignored, the Get call at the end doesn't work because don't get a real entity with id on it */ }
            // Assert
            Assert.NotNull(result);
            Assert.Equal("Stephen King", result.Name);
            Assert.Null(result.UpdatedDate);
        }
        #endregion
        #region Deactivate
        [Fact]
        public void Verify_Deactivate_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate(1);
            // Assert
            mockPeopleRepository.Verify(m => m.Deactivate(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Deactivate("KING-STEPHEN");
            // Assert
            mockPeopleRepository.Verify(m => m.Deactivate(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Deactivate_ByID_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => null);
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act/Assert
            Assert.Throws<InvalidOperationException>(() => businessWorkflow.Deactivate(1));
        }

        [Fact]
        public void Verify_Deactivate_ByKey_ANonExistingEntity_Should_ThrowAnInvalidOperationException()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            // Act/Assert
            Assert.Throws<InvalidOperationException>(() => businessWorkflow.Deactivate("TEST"));
        }
        #endregion
        #region Remove
        [Fact]
        public void Verify_Remove_ByID_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<int>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove(1);
            // Assert
            mockPeopleRepository.Verify(m => m.Remove(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ByKey_Should_DeactivateTheObjectAndReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            var mockPeopleMapper = new Mock<IPersonMapper>();
            mockPeopleMapper.Setup(m => m.AreEqual(It.IsAny<IPersonModel>(), It.IsAny<IPerson>())).Returns(() => true);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, mockPeopleMapper.Object);
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => new Mock<IPerson>().Object);
            mockPeopleRepository.Setup(m => m.SaveChanges()).Returns(() => true);
            // Act
            var result = businessWorkflow.Remove("KING-STEPHEN");
            // Assert
            mockPeopleRepository.Verify(m => m.Remove(It.IsAny<IPerson>()), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_Remove_ANonExistingEntity_Should_ReturnTrue()
        {
            // Arrange
            var mockPeopleRepository = PeopleMockingSetup.DoMockingSetupForRepository();
            mockPeopleRepository.Setup(m => m.Get(It.IsAny<string>())).Returns(() => null);
            var businessWorkflow = new PeopleBusinessWorkflow(mockPeopleRepository.Object, new PersonMapper());
            // Act
            var result = businessWorkflow.Remove("DOESNT-EXIST");
            // Assert
            Assert.Equal(true, result);
        }
        #endregion
    }
}
