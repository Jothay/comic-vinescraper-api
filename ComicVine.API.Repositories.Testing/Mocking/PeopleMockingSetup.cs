namespace ComicVine.API.Testing.Mocking
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using DataModel.Schema;
    using Moq;

    public static class PeopleMockingSetup
    {
        public static Mock<DataModel.ModelEntities> DoMockingSetupForContext(bool includePeopleData, out Mock<IDbSet<Person>> mockSetPersons, bool markAPersonInactive = false)
        {
            var createDate = new DateTime(2015, 05, 28, 10, 45, 00);
            var mockContext = new Mock<DataModel.ModelEntities>();
            // Apply Data and set up IQueryable
            mockSetPersons = new Mock<IDbSet<Person>>();
            var personData = (!includePeopleData ? new List<Person>() : new List<Person>
            {
                new Person { Id = 1, Active = !markAPersonInactive, CreatedDate = createDate, CustomKey = "KING-STEPHEN", Name = "Stephen King", Description = "a famous novelist" },
                new Person { Id = 2, Active = true, CreatedDate = createDate.AddDays(1), CustomKey = "NIVEN-LARRY", Name = "Larry Niven", Description = "a novelist" }
            }).AsQueryable();
            mockSetPersons.As<IQueryable<Person>>().Setup(m => m.Provider).Returns(personData.Provider);
            mockSetPersons.As<IQueryable<Person>>().Setup(m => m.Expression).Returns(personData.Expression);
            mockSetPersons.As<IQueryable<Person>>().Setup(m => m.ElementType).Returns(personData.ElementType);
            mockSetPersons.As<IQueryable<Person>>().Setup(m => m.GetEnumerator()).Returns(personData.GetEnumerator());
            mockContext.Setup(m => m.People).Returns(mockSetPersons.Object);
            mockContext.Setup(m => m.SetModified(It.IsAny<object>())).Callback(() => { });
            // Return
            return mockContext;
        }
    }
}
