// <copyright file="Character.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the character class</summary>
namespace ComicVine.API.DataModel.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Character")]
    public partial class Character : NameableEntityBase, ICharacter
    {
        [StringIsUnicode(false)]
        [SearchableString]
        public string RealName { get; set; }

        public DateTime? DateOfBirth { get; set; }

        // Related Objects
        public int PrimaryImageId { get; set; }
        public virtual ImageFile PrimaryImage { get; set; }
        IImageFile ICharacter.PrimaryImage { get { return PrimaryImage; } set { PrimaryImage = value as ImageFile; } }
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue ICharacter.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        IGender ICharacter.Gender { get { return Gender; } set { Gender = value as Gender; } }
        public int OriginId { get; set; }
        public virtual Origin Origin { get; set; }
        IOrigin ICharacter.Origin { get { return Origin; } set { Origin = value as Origin; } }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher ICharacter.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<Author> Creators { get; set; }
        public virtual ICollection<CharacterAlias> CharacterAliases { get; set; }
        public virtual ICollection<Character> Friends { get; set; }
        public virtual ICollection<Character> Enemies { get; set; }
        public virtual ICollection<Team> Teams { get; set; }
        public virtual ICollection<Team> FriendlyTeams { get; set; }
        public virtual ICollection<Team> EnemyTeams { get; set; }
        public virtual ICollection<Issue> IssueAppearances { get; set; }
        public virtual ICollection<Issue> IssuesDiedIn { get; set; }
        public virtual ICollection<Issue> IssueCredits { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Power> Powers { get; set; }
        public virtual ICollection<StoryArc> StoryArcCredits { get; set; }
        public virtual ICollection<Volume> VolumeCredits { get; set; }

        ICollection<ICharacterAlias> ICharacter.CharacterAliases { get { return (ICollection<ICharacterAlias>)CharacterAliases; } set { CharacterAliases = value as ICollection<CharacterAlias>; } }
        ICollection<ICharacter> ICharacter.Friends { get { return (ICollection<ICharacter>)Friends; } set { Friends = value as ICollection<Character>; } }
        ICollection<ICharacter> ICharacter.Enemies { get { return (ICollection<ICharacter>)Enemies; } set { Enemies = value as ICollection<Character>; } }
        ICollection<ITeam> ICharacter.Teams { get { return (ICollection<ITeam>)Teams; } set { Teams = value as ICollection<Team>; } }
        ICollection<ITeam> ICharacter.FriendlyTeams { get { return (ICollection<ITeam>)FriendlyTeams; } set { FriendlyTeams = value as ICollection<Team>; } }
        ICollection<ITeam> ICharacter.EnemyTeams { get { return (ICollection<ITeam>)EnemyTeams; } set { EnemyTeams = value as ICollection<Team>; } }
        ICollection<IIssue> ICharacter.IssueAppearances { get { return (ICollection<IIssue>)IssueAppearances; } set { IssueAppearances = value as ICollection<Issue>; } }
        ICollection<IIssue> ICharacter.IssuesDiedIn { get { return (ICollection<IIssue>)IssuesDiedIn; } set { IssuesDiedIn = value as ICollection<Issue>; } }
        ICollection<IIssue> ICharacter.IssueCredits { get { return (ICollection<IIssue>)IssueCredits; } set { IssueCredits = value as ICollection<Issue>; } }
        ICollection<IStoryArc> ICharacter.StoryArcCredits { get { return (ICollection<IStoryArc>)StoryArcCredits; } set { StoryArcCredits = value as ICollection<StoryArc>; } }
        ICollection<IVolume> ICharacter.VolumeCredits { get { return (ICollection<IVolume>)VolumeCredits; } set { VolumeCredits = value as ICollection<Volume>; } }
        ICollection<IMovie> ICharacter.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<IPower> ICharacter.Powers { get { return (ICollection<IPower>)Powers; } set { Powers = value as ICollection<Power>; } }
        ICollection<IAuthor> ICharacter.Creators { get { return (ICollection<IAuthor>)Creators; } set { Creators = value as ICollection<Author>; } }
    }
}
