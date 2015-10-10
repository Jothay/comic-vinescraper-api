namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Studio")]
    public partial class Studio : NameableEntityBase, IStudio
    {
        // No Studio specific properties
    }
}
