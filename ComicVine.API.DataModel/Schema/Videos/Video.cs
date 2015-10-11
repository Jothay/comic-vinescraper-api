// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Videos.Video")]
    public class Video : NameableEntityBase, IVideo
    {
        public string LowUrl { get; set; }
        public string HighUrl { get; set; }
        public string HdUrl { get; set; }
        public string Url { get; set; }
        public int? LengthSeconds { get; set; }
        public System.DateTime? PublishDate { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IVideo.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Person Author { get; set; }
        IPerson IVideo.Author { get { return Author; } set { Author = value as Person; } }

        [InverseProperty("Id")][ForeignKey("VideoType")]
        public int VideoTypeId { get; set; }
        public virtual VideoType VideoType { get; set; }
        IVideoType IVideo.VideoType { get { return VideoType; } set { VideoType = value as VideoType; } }
    }
}
