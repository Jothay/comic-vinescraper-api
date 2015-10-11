// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Chats.Chat")]
    public class Chat : NameableEntityBase, IChat
    {
        [StringIsUnicode(false)]
        [SearchableString]
        public string ChannelName { get; set; }

        [StringIsUnicode(false)]
        public string PasswordHash { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("ImageFile")]
        public int ImageFileId { get; set; }
        public ImageFile ImageFile { get; set; }
        IImageFile IChat.ImageFile { get { return ImageFile; } set { ImageFile = value as ImageFile; } }
    }
}
