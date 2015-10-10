namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Gender")]
    public partial class Gender : NameableEntityBase, IGender
    {
        // No Gender specific properties
    }
}
