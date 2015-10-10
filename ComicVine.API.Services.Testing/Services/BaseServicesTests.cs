namespace ComicVine.API.Testing.Services
{
    using Interfaces.BusinessWorkflows;
    using ComicVine.API.Services.Authors;
    using Xunit;

    public class BaseServicesTests : ServiceTestsSetupTeardown
    {

        [Fact(Skip = "Figure out how to test")]
        public void Verify_TryResolve_AuthorsBusinessWorkflow_Should_ReturnProperInstance()
        {
            var result = AppHost.Resolve<IAuthorsBusinessWorkflow>();
            Assert.IsType<IAuthorsBusinessWorkflow>(result);
        }

        [Fact(Skip = "Figure out how to test")]
        public void Verify_TryResolve_AuthorsServices_Should_ReturnProperInstance()
        {
            var result = AppHost.Resolve<IAuthorsServices>();
            Assert.IsType<IAuthorsServices>(result);
        }
    }
}
