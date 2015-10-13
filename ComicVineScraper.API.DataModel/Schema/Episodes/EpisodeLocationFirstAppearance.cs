// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodeLocationFirstAppearance")]
    public class EpisodeLocationFirstAppearance : EntityBase, IEpisodeLocationFirstAppearance
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeLocationFirstAppearance.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation IEpisodeLocationFirstAppearance.Location { get { return Location; } set { Location = value as Location; } }
    }
}
