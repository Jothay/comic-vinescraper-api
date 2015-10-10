namespace ComicVine.API.Repositories
{
    using StructureMap.Configuration.DSL;
    using DataModel;
    using Interfaces.Repositories;

    public class RepositoryRegistry  : Registry
    {
        public RepositoryRegistry()
        {
            For<IModelEntities>().Use<ModelEntities>();
            For<IAuthorsRepository>().Use<AuthorsRepository>();
        }
    }
}
