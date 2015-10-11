// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Teams.Team")]
    public class Team : NameableEntityBase, ITeam
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile ITeam.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue ITeam.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher ITeam.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<TeamAlias> TeamAliases { get; set; }
        public virtual ICollection<TeamCharacterEnemy> TeamCharacterEnemies { get; set; }
        public virtual ICollection<TeamCharacterFriend> TeamCharacterFriends { get; set; }
        public virtual ICollection<TeamAppearedInIssue> TeamIssuesAppearedIn { get; set; }
        public virtual ICollection<TeamDisbandedInIssue> TeamIssuesDisbandedIn { get; set; }
        public virtual ICollection<TeamIssue> TeamIssues { get; set; }
        public virtual ICollection<TeamMember> TeamMembers { get; set; }
        public virtual ICollection<TeamMovie> TeamMovies { get; set; }
        public virtual ICollection<TeamStoryArc> TeamStoryArcs { get; set; }
        public virtual ICollection<TeamVolume> TeamVolumes { get; set; }

        ICollection<ITeamAlias> ITeam.TeamAliases { get { return (ICollection<ITeamAlias>)TeamAliases; } set { TeamAliases = value as ICollection<TeamAlias>; } }
        ICollection<ITeamCharacterEnemy> ITeam.TeamCharacterEnemies { get { return (ICollection<ITeamCharacterEnemy>)TeamCharacterEnemies; } set { TeamCharacterEnemies = value as ICollection<TeamCharacterEnemy>; } }
        ICollection<ITeamCharacterFriend> ITeam.TeamCharacterFriends { get { return (ICollection<ITeamCharacterFriend>)TeamCharacterFriends; } set { TeamCharacterFriends = value as ICollection<TeamCharacterFriend>; } }
        ICollection<ITeamAppearedInIssue> ITeam.TeamIssuesAppearedIn { get { return (ICollection<ITeamAppearedInIssue>)TeamIssuesAppearedIn; } set { TeamIssuesAppearedIn = value as ICollection<TeamAppearedInIssue>; } }
        ICollection<ITeamDisbandedInIssue> ITeam.TeamIssuesDisbandedIn { get { return (ICollection<ITeamDisbandedInIssue>)TeamIssuesDisbandedIn; } set { TeamIssuesDisbandedIn = value as ICollection<TeamDisbandedInIssue>; } }
        ICollection<ITeamIssue> ITeam.TeamIssues { get { return (ICollection<ITeamIssue>)TeamIssues; } set { TeamIssues = value as ICollection<TeamIssue>; } }
        ICollection<ITeamMember> ITeam.TeamMembers { get { return (ICollection<ITeamMember>)TeamMembers; } set { TeamMembers = value as ICollection<TeamMember>; } }
        ICollection<ITeamMovie> ITeam.TeamMovies { get { return (ICollection<ITeamMovie>)TeamMovies; } set { TeamMovies = value as ICollection<TeamMovie>; } }
        ICollection<ITeamStoryArc> ITeam.TeamStoryArcs { get { return (ICollection<ITeamStoryArc>)TeamStoryArcs; } set { TeamStoryArcs = value as ICollection<TeamStoryArc>; } }
        ICollection<ITeamVolume> ITeam.TeamVolumes { get { return (ICollection<ITeamVolume>)TeamVolumes; } set { TeamVolumes = value as ICollection<TeamVolume>; } }
    }
}
