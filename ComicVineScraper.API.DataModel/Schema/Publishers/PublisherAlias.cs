// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Publishers.PublisherAlias")]
    public class PublisherAlias : NameableEntityBase, IPublisherAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher IPublisherAlias.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }
    }
}
