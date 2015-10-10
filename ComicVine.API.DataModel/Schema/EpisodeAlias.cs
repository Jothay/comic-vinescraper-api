namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.EpisodeAlias")]
    public partial class EpisodeAlias : NameableEntityBase, IEpisodeAlias
    {
        // No EpisodeAlias specific properties
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeAlias.Episode { get { return Episode; } set { Episode = value as Episode; } }
    }
}
