// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.TeamVolume")]
    public class TeamVolume : EntityBase, ITeamVolume
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamVolume.Team { get { return Team; } set { Team = value as Team; } }

        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume ITeamVolume.Volume { get { return Volume; } set { Volume = value as Volume; } }
    }
}
