// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.TeamAppearedInIssue")]
    public class TeamAppearedInIssue : EntityBase, ITeamAppearedInIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam ITeamAppearedInIssue.Team { get { return Team; } set { Team = value as Team; } }

        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue ITeamAppearedInIssue.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
