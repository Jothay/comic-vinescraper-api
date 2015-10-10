namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Producer")]
    public partial class Producer : NameableEntityBase, IProducer
    {
        // No Producer specific properties
    }
}
