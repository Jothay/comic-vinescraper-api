// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.TeamCharacterEnemy")]
    public class TeamCharacterEnemy : EntityBase, ITeamCharacterEnemy
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamCharacterEnemy.Team { get { return Team; } set { Team = value as Team; } }

        [InverseProperty("Id")][ForeignKey("Enemy")]
        public int EnemyId { get; set; }
        public virtual Character Enemy { get; set; }
        ICharacter ITeamCharacterEnemy.Enemy { get { return Enemy; } set { Enemy = value as Character; } }
    }
}
