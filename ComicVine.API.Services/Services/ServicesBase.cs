namespace ComicVine.API.Services
{
    using System;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using ServiceStack;

    public class EntityModelBase : IEntityModel
    {
        public int? Id { get; set; }
        public string CustomKey { get; set; }
        public string ApiDetailUrl { get; set; }
        public string SiteDetailUrl { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }

    public class NameableEntityModelBase : EntityModelBase, INameableEntityModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }

    public class EntitySearchModelBase : IEntitySearchModel
    {
        public int? Id { get; set; }
        public string CustomKey { get; set; }
        public string ApiDetailUrl { get; set; }
        public string SiteDetailUrl { get; set; }
        public DateTime? ModifiedSince { get; set; }
        public IPaging Paging { get; set; }
    }

    public class NameableEntitySearchModelBase : EntitySearchModelBase, INameableEntitySearchModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }

    public class ImplementsID
    {
        [ApiMember(Name = "ID", IsRequired = true, Description = "The Identifier")]
        public int ID { get; set; }
    }

    public class ImplementsKey
    {
        [ApiMember(Name = "CustomKey", IsRequired = true, Description = "The Key")]
        public string CustomKey { get; set; }
    }

    //public class ServicesBase : Service {
    //public ServicesBase(BusinessWorkflowsController workflows = null)
    //{
    //    if (workflows != null) { this.workflows = workflows; }
    //}

    //private BusinessWorkflowsController workflows;
    //public BusinessWorkflowsController Workflows => workflows ?? (workflows = new BusinessWorkflowsController());
    //}
}
