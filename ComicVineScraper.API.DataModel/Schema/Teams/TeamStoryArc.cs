// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.TeamStoryArc")]
    public class TeamStoryArc : EntityBase, ITeamStoryArc
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamStoryArc.Team { get { return Team; } set { Team = value as Team; } }

        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc ITeamStoryArc.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
