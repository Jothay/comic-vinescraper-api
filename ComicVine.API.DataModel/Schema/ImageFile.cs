namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.ImageFile")]
    public partial class ImageFile : NameableEntityBase, IImageFile
    {
        // No ImageFile specific properties
    }
}
