namespace ComicVineScraper.API.Testing.Services
{
    using API.Services;
    using Interfaces.BusinessWorkflows;
    using Xunit;

    public class BaseServicesTests : ServiceTestsSetupTeardown
    {

        [Fact(Skip = "Figure out how to test")]
        public void Verify_TryResolve_PeopleBusinessWorkflow_Should_ReturnProperInstance()
        {
            var result = AppHost.Resolve<IPeopleBusinessWorkflow>();
            Assert.IsType<IPeopleBusinessWorkflow>(result);
        }

        [Fact(Skip = "Figure out how to test")]
        public void Verify_TryResolve_PeopleServices_Should_ReturnProperInstance()
        {
            var result = AppHost.Resolve<IPeopleServices>();
            Assert.IsType<IPeopleServices>(result);
        }
    }
}
