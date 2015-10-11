namespace ComicVine.API.Testing.Services.People
{
    using System;
    using System.Collections.Generic;
    using API.Services;
    using Interfaces.Models;
    using Xunit;

    public class PeopleServicesTests : ServicesTestsWithTearDown
    {
        [Fact]
        public void Verify_GetPeople_Should_ReturnAListOfPersonModels()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new GetPeople { Name = "Stephen King", Id = 1, CustomKey = "KING-STEPHEN", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPersonModel>>(response);
        }
        [Fact]
        public void Verify_GetPeopleAsListing_Should_ReturnAListOfPersonModels()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new GetPeopleAsListing { Name = "Stephen King", Id = 1, CustomKey = "KING-STEPHEN", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IPersonModel>>(response);
        }
        [Fact]
        public void Verify_GetPerson_Should_ReturnAnPersonModel()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new GetPerson { ID = 1 });
            Assert.Equal(nameof(IPersonModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_GetPersonByKey_Should_ReturnAnPersonModel()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new GetPersonByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IPersonModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_CreatePerson_Should_ReturnAnPersonModel()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new CreatePerson { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IPersonModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_UpdatePerson_Should_ReturnAnPersonModel()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new UpdatePerson { Id = 1 });
            Assert.Equal(nameof(IPersonModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_DeactivatePerson_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new DeactivatePerson { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact]
        public void Verify_DeactivatePersonByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new DeactivatePersonByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact]
        public void Verify_RemovePerson_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new RemovePerson { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact]
        public void Verify_RemovePersonByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IPeopleServices>();
            var response = service.Any(new RemovePersonByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
