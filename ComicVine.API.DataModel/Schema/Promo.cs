namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Promo")]
    public partial class Promo : NameableEntityBase, IPromo
    {
        public string Link { get; set; }
        public string ResourceType { get; set; }

        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IPromo.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        IAuthor IPromo.Author { get { return Author; } set { Author = value as Author; } }
    }
}
