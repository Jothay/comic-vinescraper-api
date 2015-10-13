//namespace ComicVine.API.Testing.Repositories.People
//{
//    using System;
//    using System.Data.Entity;
//    using System.Linq;
//    using API.Repositories;
//    using DataModel.Schema;
//    using Interfaces.SearchModels;
//    using Moq;
//    using SearchModels;
//    using Xunit;

//    public class PeopleRepositoryTests
//    {
//        [Fact]
//        public void Verify_Add_Should_AddTheEntityToTheContext()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(false, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            var people = new Person { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore", Description = "a novelist" };
//            // Act
//            repository.Add(people);
//            // Assert
//            mockSetPeople.Verify(x => x.Add(people), Times.Once);
//        }

//        [Fact]
//        public void Verify_Remove_Should_RemoveTheEntityFromTheContext()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            var people = repository.Get(1);
//            // Act
//            repository.Remove(people);
//            // Assert
//            mockSetPeople.Verify(x => x.Remove((Person)people), Times.Once);
//        }

//        [Fact]
//        public void Verify_Deactivate_Should_SetTheActivePropertyToFalseOnTheEntity()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            var people = repository.Get(1);
//            // Act
//            repository.Deactivate(people);
//            // Assert
//            Assert.Equal(false, people.Active);
//        }

//        [Fact]
//        public void Verify_Update_Should_SetTheEntityStateToModified()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            var people = repository.Get(1);
//            people.Name = "TEST";
//            // Act
//            repository.Update(people);
//            // Assert
//            mockContext.Verify(x => x.SetModified(It.IsAny<object>()), Times.Once);
//        }

//        [Fact]
//        public void Verify_Get_ByID_Should_ReturnTheCorrectPerson()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            // Act
//            var people = repository.Get(1);
//            // Assert
//            Assert.Equal("Stephen King", people.Name);
//        }

//        [Fact]
//        public void Verify_Get_ByKey_Should_ReturnTheCorrectPerson()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            // Act
//            var people = repository.Get("KING-STEPHEN");
//            // Assert
//            Assert.Equal("Stephen King", people.Name);
//        }

//        [Fact]
//        public void Verify_List_Should_ReturnAListOfPeopleWithData()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            // Act
//            var people = repository.List.ToArray();
//            // Assert
//            Assert.Equal(2, people.Length);
//            Assert.Equal(1, people[0].Id);
//            Assert.Equal("Stephen King", people[0].Name);
//            Assert.Equal(2, people[1].Id);
//            Assert.Equal("Larry Niven", people[1].Name);
//        }

//        [Fact]
//        public void Verify_Search_Should_ReturnAListOfPeopleWithDataMatchingSearchParameters()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople, true);
//            var repository = new PeopleRepository(mockContext.Object);
//            var searchModel = new Mock<IPersonSearchModel>();
//            // Act
//            var people = repository.Search(searchModel.Object).ToArray();
//            // Assert
//            Assert.Equal(1, people.Length);
//            Assert.Equal(2, people[0].Id);
//            Assert.Equal("Larry Niven", people[0].Name);
//            // Stephen King was filtered out because he was Inactive
//        }

//        [Fact]
//        public void Verify_Search_WithSelectStatement_Should_ReturnAListOfDynamicObjects()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople, true);
//            var repository = new PeopleRepository(mockContext.Object);
//            var searchModel = new Mock<IPersonSearchModel>();
//            // Act
//            var people = repository.Search(searchModel.Object, i => new { i.Id, MyName = i.Name }).ToArray();
//            // Assert
//            Assert.Equal(1, people.Length);
//            Assert.Equal(2, people[0].Id);
//            Assert.Equal("Larry Niven", people[0].MyName);
//            // Stephen King was filtered out because he was Inactive
//        }

//        [Fact]
//        public void Verify_Search_WithModifiedSince_Should_ReturnAListOfPeopleWithDataMatchingSearchParameters()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople, true);
//            var repository = new PeopleRepository(mockContext.Object);
//            var createDate = new DateTime(2015, 05, 28, 10, 45, 00).AddDays(1).AddMinutes(-1);
//            //var searchModel = new Mock<IPersonSearchModel>();
//            //searchModel.Setup(m => m.ModifiedSince).Returns(() => createDate);
//            var searchModel = new PersonSearchModel { ModifiedSince = createDate };
//            // Act
//            var people = repository.Search(searchModel/*.Object*/).ToArray();
//            // Assert
//            Assert.Equal(1, people.Length);
//            Assert.Equal(2, people[0].Id);
//            Assert.Equal("Larry Niven", people[0].Name);
//            // Stephen King was filtered out because he was created before the modified since date
//        }

//        [Fact]
//        public void Verify_Search_WithPaging_Should_ReturnAListOfPeopleWithDataMatchingSearchParameters()
//        {
//            // Arrange
//            Mock<IDbSet<Person>> mockSetPeople;
//            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockSetPeople);
//            var repository = new PeopleRepository(mockContext.Object);
//            var searchModel = new PersonSearchModel { Paging = new Paging { Skip = 1, Take = 1 } };
//            // Act
//            var people = repository.Search(searchModel/*.Object*/).ToArray();
//            // Assert
//            Assert.Equal(1, people.Length);
//            Assert.Equal(2, people[0].Id);
//            Assert.Equal("Larry Niven", people[0].Name);
//            // Stephen King was filtered out because he was Skipped
//        }
//    }
//}
