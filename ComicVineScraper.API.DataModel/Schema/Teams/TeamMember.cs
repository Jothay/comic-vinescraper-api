// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.TeamMember")]
    public class TeamMember : EntityBase, ITeamMember
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamMember.Team { get { return Team; } set { Team = value as Team; } }

        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ITeamMember.Character { get { return Character; } set { Character = value as Character; } }
    }
}
