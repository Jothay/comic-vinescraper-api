// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodeObject")]
    public class EpisodeObject : EntityBase, IEpisodeObject
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeObject.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IEpisodeObject.Object { get { return Object; } set { Object = value as Object; } }
    }
}
