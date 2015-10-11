namespace ComicVine.API.Testing.BusinessWorkflows
{
    using API.BusinessWorkflows;
    using Interfaces.BusinessWorkflows;
    using Interfaces.Mappers;
    using Interfaces.Repositories;
    using Repositories;
    using Mappings;
    using StructureMap;
    using Xunit;

    public class WorkflowRegistryTests
    {
        [Fact]
        public void Verify_WorkflowRegistry_Should_ConnectPersonMapper()
        {
            var container = new Container(new WorkflowRegistry());
            var instance = container.GetInstance<IPersonMapper>();
            Assert.IsType<PersonMapper>(instance);
        }

        [Fact]
        public void Verify_WorkflowRegistry_Should_ConnectPeopleRepository()
        {
            var container = new Container(new WorkflowRegistry());
            var instance = container.GetInstance<IPeopleRepository>();
            Assert.IsType<PeopleRepository>(instance);
        }

        [Fact]
        public void Verify_WorkflowRegistry_Should_ConnectPeopleBusinessWorkflow()
        {
            var container = new Container(new WorkflowRegistry());
            var instance = container.GetInstance<IPeopleBusinessWorkflow>();
            Assert.IsType<PeopleBusinessWorkflow>(instance);
        }
    }
}
