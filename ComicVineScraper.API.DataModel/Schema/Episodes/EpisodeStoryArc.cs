// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodeStoryArc")]
    public class EpisodeStoryArc : EntityBase, IEpisodeStoryArc
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeStoryArc.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IEpisodeStoryArc.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
