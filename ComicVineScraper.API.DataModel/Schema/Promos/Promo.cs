// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Promos.Promo")]
    public class Promo : NameableEntityBase, IPromo
    {
        [Index]
        public string Link { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IPromo.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("Author")]
        public int AuthorId { get; set; }
        public virtual Person Author { get; set; }
        IPerson IPromo.Author { get { return Author; } set { Author = value as Person; } }

        [InverseProperty("Id")][ForeignKey("ResourceType")]
        public int? ResourceTypeId { get; set; }
        public virtual ResourceType ResourceType { get; set; }
        IResourceType IPromo.ResourceType { get { return ResourceType; } set { ResourceType = value as ResourceType; } }
    }
}
