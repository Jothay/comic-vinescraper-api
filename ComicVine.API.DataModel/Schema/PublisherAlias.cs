namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.PublisherAlias")]
    public partial class PublisherAlias : NameableEntityBase, IPublisherAlias
    {
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher IPublisherAlias.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }
    }
}
