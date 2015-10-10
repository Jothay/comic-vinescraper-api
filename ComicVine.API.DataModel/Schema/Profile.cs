namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Profile")]
    public partial class Profile : NameableEntityBase, IProfile
    {
        // No Profile specific properties
    }
}
