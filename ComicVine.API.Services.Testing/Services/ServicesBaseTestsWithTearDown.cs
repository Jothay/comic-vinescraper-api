namespace ComicVine.API.Testing.Services
{
    using System;
    using Interfaces.BusinessWorkflows;
    using Mocking;
    using ComicVine.API.Services.Authors;
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
            AppHost = new BasicAppHost(typeof(AuthorsServices).Assembly)
            {
                ConfigureContainer = container =>
                {
                    //container.Register<IAuthorMapper>(c => new AuthorMapper());
                    //container.Register<IModelEntities<Author>>(c =>
                    //{
                    //    Mock<IDbSet<Author>> mockAuthSet;
                    //    return AuthorsMockingSetup.DoMockingSetupForContext(true, out mockAuthSet).Object;
                    //});
                    //container.Register<IAuthorsRepository>(c =>
                    //{
                    //    Mock<IDbSet<Author>> mockAuthSet;
                    //    var mockContext = AuthorsMockingSetup.DoMockingSetupForContext(true, out mockAuthSet);
                    //    return AuthorsMockingSetup.DoMockingSetupForRepository(ref mockContext).Object;
                    //});
                    container.Register(c => AuthorsMockingSetup.DoMockingSetupForBusinessWorkflow().Object);
                    container.Register<IAuthorsServices>(c => new AuthorsServices(c.Resolve<IAuthorsBusinessWorkflow>()));
                }
            }.Init();
        }
    }
}
