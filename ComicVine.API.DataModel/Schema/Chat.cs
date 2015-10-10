namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Chat")]
    public partial class Chat : NameableEntityBase, IChat
    {
        [StringIsUnicode(false)]
        [SearchableString]
        public string ChannelName { get; set; }

        [StringIsUnicode(false)]
        public string PasswordHash { get; set; }

        // Related Objects
        public int ImageFileId { get; set; }
        public ImageFile ImageFile { get; set; }
        IImageFile IChat.ImageFile { get { return ImageFile; } set { ImageFile = value as ImageFile; } }
    }
}
