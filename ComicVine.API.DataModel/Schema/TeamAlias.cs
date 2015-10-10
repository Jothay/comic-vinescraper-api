namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.TeamAlias")]
    public partial class TeamAlias : NameableEntityBase, ITeamAlias
    {
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamAlias.Team { get { return Team; } set { Team = value as Team; } }
    }
}
