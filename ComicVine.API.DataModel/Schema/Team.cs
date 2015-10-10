namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Team")]
    public partial class Team : NameableEntityBase, ITeam
    {
        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile ITeam.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue ITeam.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher ITeam.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<Character> CharacterFriends { get; set; }
        public virtual ICollection<Character> CharacterEnemies { get; set; }
        public virtual ICollection<Issue> IssueAppearances { get; set; }
        public virtual ICollection<Issue> IssueCredits { get; set; }
        public virtual ICollection<Issue> DisbandedInIssues { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<TeamAlias> TeamAliases { get; set; }
        public virtual ICollection<Character> TeamMembers { get; set; }
        public virtual ICollection<StoryArc> StoryArcCredits { get; set; }
        public virtual ICollection<Volume> VolumeCredits { get; set; }

        ICollection<ICharacter> ITeam.CharacterFriends { get { return (ICollection<ICharacter>)CharacterFriends; } set { CharacterFriends = value as ICollection<Character>; } }
        ICollection<ICharacter> ITeam.CharacterEnemies { get { return (ICollection<ICharacter>)CharacterEnemies; } set { CharacterEnemies = value as ICollection<Character>; } }
        ICollection<IIssue> ITeam.IssueAppearances { get { return (ICollection<IIssue>)IssueAppearances; } set { IssueAppearances = value as ICollection<Issue>; } }
        ICollection<IIssue> ITeam.IssueCredits { get { return (ICollection<IIssue>)IssueCredits; } set { IssueCredits = value as ICollection<Issue>; } }
        ICollection<IIssue> ITeam.DisbandedInIssues { get { return (ICollection<IIssue>)DisbandedInIssues; } set { DisbandedInIssues = value as ICollection<Issue>; } }
        ICollection<IMovie> ITeam.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<ITeamAlias> ITeam.TeamAliases { get { return (ICollection<ITeamAlias>)TeamAliases; } set { TeamAliases = value as ICollection<TeamAlias>; } }
        ICollection<ICharacter> ITeam.TeamMembers { get { return (ICollection<ICharacter>)TeamMembers; } set { TeamMembers = value as ICollection<Character>; } }
        ICollection<IStoryArc> ITeam.StoryArcCredits { get { return (ICollection<IStoryArc>)StoryArcCredits; } set { StoryArcCredits = value as ICollection<StoryArc>; } }
        ICollection<IVolume> ITeam.VolumeCredits { get { return (ICollection<IVolume>)VolumeCredits; } set { VolumeCredits = value as ICollection<Volume>; } }
    }
}
