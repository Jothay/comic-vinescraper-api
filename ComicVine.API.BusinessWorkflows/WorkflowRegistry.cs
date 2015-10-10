namespace ComicVine.API.BusinessWorkflows
{
    using StructureMap.Configuration.DSL;
    using Interfaces.Mappers;
    using Mappings.Authors;
    using Authors;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Repositories;
    using Repositories;

    public class WorkflowRegistry  : Registry
    {
        public WorkflowRegistry()
        {
            For<IAuthorMapper>().Use<AuthorMapper>();
            For<IAuthorsRepository>().Use<AuthorsRepository>();
            // if you think that a dependent module will want something else,
            // then put this line in that assembly's Registry
            For<IAuthorsBusinessWorkflow>().Use<AuthorsBusinessWorkflow>();
        }
    }
}
