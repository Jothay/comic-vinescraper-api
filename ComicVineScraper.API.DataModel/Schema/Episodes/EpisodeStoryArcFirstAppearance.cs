// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodeStoryArcFirstAppearance")]
    public class EpisodeStoryArcFirstAppearance : EntityBase, IEpisodeStoryArcFirstAppearance
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeStoryArcFirstAppearance.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IEpisodeStoryArcFirstAppearance.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
