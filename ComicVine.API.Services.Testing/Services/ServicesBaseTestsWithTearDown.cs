namespace ComicVine.API.Testing.Services
{
    using System;
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Mocking;
    using ServiceStack;
    using ServiceStack.Testing;

    public abstract class ServiceTestsSetupTeardown : IDisposable
    {
        protected ServiceStackHost AppHost;
        public void Dispose() { AppHost.Dispose(); }
    }

    public class ServicesTestsWithTearDown : ServiceTestsSetupTeardown
    {
        public ServicesTestsWithTearDown()
        {
            AppHost = new BasicAppHost(typeof(PeopleServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //container.Register<IPersonMapper>(c => new PersonMapper());
                    //container.Register<IModelEntities<Person>>(c => {
                    //    Mock<IDbSet<Person>> mockAuthSet;
                    //    return PeopleMockingSetup.DoMockingSetupForContext(true, out mockAuthSet).Object;
                    //});
                    //container.Register<IPeopleRepository>(c => {
                    //    Mock<IDbSet<Person>> mockAuthSet;
                    //    var mockContext = PeopleMockingSetup.DoMockingSetupForContext(true, out mockAuthSet);
                    //    return PeopleMockingSetup.DoMockingSetupForRepository(ref mockContext).Object;
                    //});
                    container.Register(c => PeopleMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
                    container.Register<IPeopleServices>(c => new PeopleServices(c.Resolve<IPeopleBusinessWorkflow>()));
                }
            }.Init();
        }
    }
}
