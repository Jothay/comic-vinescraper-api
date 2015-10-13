namespace ComicVineScraper.API.Testing.Repositories
{
    using System.Collections.Generic;
    using API.Repositories;
    using DataModel;
    using Interfaces.Repositories;
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
        public void Verify_RepositoryRegistry_Should_ConnectPeopleRepository()
        {
            var container = new Container(new RepositoryRegistry());
            var instance = container.GetInstance<IPeopleRepository>();
            Assert.IsType<PeopleRepository>(instance);
        }
    }
}
