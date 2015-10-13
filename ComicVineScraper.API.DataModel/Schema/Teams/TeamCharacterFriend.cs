// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.TeamCharacterFriend")]
    public class TeamCharacterFriend : EntityBase, ITeamCharacterFriend
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamCharacterFriend.Team { get { return Team; } set { Team = value as Team; } }

        [InverseProperty("Id")][ForeignKey("Friend")]
        public int FriendId { get; set; }
        public virtual Character Friend { get; set; }
        ICharacter ITeamCharacterFriend.Friend { get { return Friend; } set { Friend = value as Character; } }
    }
}
