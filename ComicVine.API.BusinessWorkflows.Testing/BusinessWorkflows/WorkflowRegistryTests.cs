namespace ComicVine.API.Testing.BusinessWorkflows
{
    using Interfaces.BusinessWorkflows;
    using Interfaces.Mappers;
    using Interfaces.Repositories;
    using Mappings.Authors;
    using Repositories;
    using ComicVine.API.BusinessWorkflows;
    using ComicVine.API.BusinessWorkflows.Authors;
    using StructureMap;
    using Xunit;

    public class WorkflowRegistryTests
    {
        [Fact]
        public void Verify_WorkflowRegistry_Should_ConnectAuthorMapper()
        {
            var container = new Container(new WorkflowRegistry());
            var instance = container.GetInstance<IAuthorMapper>();
            Assert.IsType<AuthorMapper>(instance);
        }

        [Fact]
        public void Verify_WorkflowRegistry_Should_ConnectAuthorsRepository()
        {
            var container = new Container(new WorkflowRegistry());
            var instance = container.GetInstance<IAuthorsRepository>();
            Assert.IsType<AuthorsRepository>(instance);
        }

        [Fact]
        public void Verify_WorkflowRegistry_Should_ConnectAuthorsBusinessWorkflow()
        {
            var container = new Container(new WorkflowRegistry());
            var instance = container.GetInstance<IAuthorsBusinessWorkflow>();
            Assert.IsType<AuthorsBusinessWorkflow>(instance);
        }
    }
}
