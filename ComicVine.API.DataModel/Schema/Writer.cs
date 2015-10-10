namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Writer")]
    public partial class Writer : NameableEntityBase, IWriter
    {
        // No Writer specific properties
    }
}
