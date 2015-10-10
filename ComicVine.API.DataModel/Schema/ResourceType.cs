namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.ResourceType")]
    public partial class ResourceType : NameableEntityBase, IResourceType
    {
        public string DetailResourceName { get; set; }
        public string ListResourceName { get; set; }
    }
}
