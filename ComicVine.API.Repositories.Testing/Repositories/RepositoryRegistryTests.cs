namespace ComicVine.API.Testing.Repositories
{
    using System.Collections.Generic;
    using DataModel;
    using Interfaces.Repositories;
    using API.Repositories;
    using StructureMap;
    using StructureMap.Pipeline;
    using Xunit;

    public class RepositoryRegistryTests
    {
        [Fact]
        public void Verify_RepositoryRegistry_Should_ConnectContext()
        {
            var container = new Container(new RepositoryRegistry());
            var instance = container.GetInstance<IModelEntities>(
                new ExplicitArguments(new Dictionary<string, object> { { "connectionString", "name=ModelEntities" } }));
            Assert.IsType<ModelEntities>(instance);
        }

        [Fact]
        public void Verify_RepositoryRegistry_Should_ConnectAuthorsRepository()
        {
            var container = new Container(new RepositoryRegistry());
            var instance = container.GetInstance<IAuthorsRepository>();
            Assert.IsType<AuthorsRepository>(instance);
        }

        //[Fact]
        //public void Verify_RepositoryRegistry_Should_ConnectAuthorsBusinessWorkflow()
        //{
        //    var container = new Container(new RepositoryRegistry());
        //    var instance = container.GetInstance<IAuthorsBusinessWorkflow>();
        //    Assert.IsType<AuthorsBusinessWorkflow>(instance);
        //}
    }
}
