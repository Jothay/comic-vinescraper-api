namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Video")]
    public partial class Video : NameableEntityBase, IVideo
    {
        public string LowUrl { get; set; }
        public string HighUrl { get; set; }
        public string HdUrl { get; set; }
        public string Url { get; set; }
        public int? LengthSeconds { get; set; }
        public System.DateTime? PublishDate { get; set; }

        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IVideo.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int AuthorId { get; set; }
        public virtual Author Author { get; set; }
        IAuthor IVideo.Author { get { return Author; } set { Author = value as Author; } }
    }
}
