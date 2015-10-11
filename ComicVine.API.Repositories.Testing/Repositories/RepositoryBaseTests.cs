namespace ComicVine.API.Testing.Repositories
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using API.Repositories;
    using DataModel.Schema;
    using Mocking;
    using Moq;
    using Xunit;

    public class RepositoryBaseTests
    {
        [Fact]
        public void Verify_SaveChanges_Should_RunOnceAndReturnSuccessfully()
        {
            // Arrange
            Mock<IDbSet<Person>> mockSetPeople;
            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(false, out mockSetPeople);
            var repository = new PeopleRepository(mockContext.Object);
            var person = new Person { Active = true, CustomKey = "SALVATORE-RAA", Name = "R.A.A Salvatore" };
            repository.Add(person);
            // Act
            var result = repository.SaveChanges();
            // Assert
            mockContext.Verify(x => x.SaveChanges(), Times.Once);
            Assert.Equal(true, result);
        }

        [Fact]
        public void Verify_SaveChanges_WithBadData_Should_ThrowADbEntityValidationException()
        {
            // Arrange
            Mock<IDbSet<Person>> mockSetPeople;
            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(false, out mockSetPeople);
            mockContext.Setup(m => m.SaveChanges()).Returns(() => { throw new DbEntityValidationException("TEST"); });
            var repository = new PeopleRepository(mockContext.Object);
            // Act/Assert
            Assert.Throws(typeof(DbEntityValidationException), () => { repository.SaveChanges(); });
        }

        [Fact]
        public void Verify_SaveChanges_WithBadData_Should_ThrowADbUpdateException()
        {
            // Arrange
            Mock<IDbSet<Person>> mockSetPeople;
            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(false, out mockSetPeople);
            mockContext.Setup(m => m.SaveChanges()).Returns(() => { throw new DbUpdateException("TEST"); });
            var repository = new PeopleRepository(mockContext.Object);
            // Act/Assert
            Assert.Throws(typeof(DbUpdateException), () => { repository.SaveChanges(); });
        }

        [Fact]
        public void Verify_SaveChanges_WithBadData_Should_ThrowAnException()
        {
            // Arrange
            Mock<IDbSet<Person>> mockSetPeople;
            var mockContext = PeopleMockingSetup.DoMockingSetupForContext(false, out mockSetPeople);
            mockContext.Setup(m => m.SaveChanges()).Returns(() => { throw new Exception("TEST"); });
            var repository = new PeopleRepository(mockContext.Object);
            // Act/Assert
            Assert.Throws(typeof(Exception), () => { repository.SaveChanges(); });
        }
    }
}
