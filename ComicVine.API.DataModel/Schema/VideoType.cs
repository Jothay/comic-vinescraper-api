namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.VideoType")]
    public partial class VideoType : NameableEntityBase, IVideoType
    {
        // No VideoType specific properties
    }
}
