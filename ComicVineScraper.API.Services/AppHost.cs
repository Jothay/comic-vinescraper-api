namespace ComicVineScraper.API.Services
{
    using System.Configuration;
    using ServiceStack;
    using ServiceStack.Configuration;
    using StructureMap;
    using StructureMap.Graph;

    internal class AppHost : AppHostBase
    {
        /// <summary>Default constructor. Base constructor requires a name and assembly to locate web
        ///          service classes.</summary>
        public AppHost()
            : base(ConfigurationManager.AppSettings["APIName"], typeof(PeopleServices).Assembly)
        {
        }

        /// <summary>Application specific configuration This method should initialize any IoC resources
        ///          utilized by your web service classes.</summary>
        /// <param name="container">.</param>
        public override void Configure(Funq.Container container)
        {
            container.Adapter = new StructureMapContainerAdapter();
#pragma warning disable 618
            var config = ObjectFactory.Container;
#pragma warning restore 618
            config.Configure(x =>
            {
                x.Scan(scanner =>
                {
                    scanner.AssembliesFromApplicationBaseDirectory();
                    //scanner.AddAllTypesOf(typeof (IWorkflowBased<>));
                    scanner.LookForRegistries();
                });
                /*x.For<IDefaultData>().Use<DefaultData>();
                x.For<IAccountWorkflow>().Use<DeltaAccountWorkflow>();
                x.For<IProductWorkflow>().Use<DeltaProductWorkflow>();
                x.For<ISalesChannelWorkflow>().Use<DeltaSalesChannelWorkflow>();
                For<IAccountWorkflow>().Use<AccountWorkflow>();
                For<IAccountTypeWorkflow>().Use<AccountTypeWorkflow>();
                For<IAccountEntities>().Use<ClarityEcommerceEntities>();
                For<IAccountPricePointWorkflow>().Use<AccountPricePointWorkflow>();
                For<IProductWorkflow>().Use<ProductWorkflow>();*/
            });
        }
    }

    /// <summary>Class StructureMapContainerAdapter.</summary>
    /// <seealso cref="T:ServiceStack.Configuration.IContainerAdapter"/>
    public class StructureMapContainerAdapter : IContainerAdapter
    {
#pragma warning disable 618
        public T TryResolve<T>()
        {
            return ObjectFactory.Container.TryGetInstance<T>();
        }

        public T Resolve<T>()
        {
            return ObjectFactory.Container.TryGetInstance<T>();
        }
#pragma warning restore 618
    }
}
