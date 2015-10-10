namespace ComicVine.API.Testing.Services.Authors
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces.Models;
    using ComicVine.API.Services.Authors;
    using Xunit;

    public class AuthorsServicesTests : ServicesTestsWithTearDown
    {
        [Fact]
        public void Verify_GetAuthors_Should_ReturnAListOfAuthorModels()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new GetAuthors { Name = "Stephen King", Id = 1, CustomKey = "KING-STEPHEN", Description = null, ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IAuthorModel>>(response);
        }
        [Fact]
        public void Verify_GetAuthorsAsListing_Should_ReturnAListOfAuthorModels()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new GetAuthorsAsListing { Name = "Stephen King", Id = 1, CustomKey = "KING-STEPHEN", Description = "famous", ModifiedSince = DateTime.Now, Paging = null });
            Assert.IsType<List<IAuthorModel>>(response);
        }
        [Fact]
        public void Verify_GetAuthor_Should_ReturnAnAuthorModel()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new GetAuthor { ID = 1 });
            Assert.Equal(nameof(IAuthorModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_GetAuthorByKey_Should_ReturnAnAuthorModel()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new GetAuthorByKey { CustomKey = "TEST" });
            Assert.Equal(nameof(IAuthorModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_CreateAuthor_Should_ReturnAnAuthorModel()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new CreateAuthor { Name = "Stephen King", CustomKey = "KING-STEPHEN", Active = true, CreatedDate = DateTime.Now, UpdatedDate = DateTime.Now });
            Assert.Equal(nameof(IAuthorModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_UpdateAuthor_Should_ReturnAnAuthorModel()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new UpdateAuthor { Id = 1 });
            Assert.Equal(nameof(IAuthorModel), response.GetType().Name.Replace("Proxy", ""));
        }
        [Fact]
        public void Verify_DeactivateAuthor_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new DeactivateAuthor { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact]
        public void Verify_DeactivateAuthorByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new DeactivateAuthorByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
        [Fact]
        public void Verify_RemoveAuthor_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new RemoveAuthor { ID = 1 });
            Assert.Equal(true, response);
        }
        [Fact]
        public void Verify_RemoveAuthorByKey_Should_ReturnTrue()
        {
            var service = AppHost.Container.Resolve<IAuthorsServices>();
            var response = service.Any(new RemoveAuthorByKey { CustomKey = "TEST" });
            Assert.Equal(true, response);
        }
    }
}
