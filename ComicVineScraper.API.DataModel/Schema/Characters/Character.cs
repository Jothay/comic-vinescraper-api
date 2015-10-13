// <copyright file="Character.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the character class</summary>
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    /// <summary>A character.</summary>
    /// <seealso cref="T:ComicVineScraper.API.DataModel.Schema.Shared.NameableEntityBase"/>
    /// <seealso cref="T:ComicVineScraper.API.Interfaces.DataModels.ICharacter"/>
    [Table("Characters.Character")]
    public class Character : NameableEntityBase, ICharacter
    {
        /// <summary>Gets or sets the name of the real.</summary>
        /// <value>The name of the real.</value>
        [StringIsUnicode(false)][SearchableString]
        public string RealName { get; set; }

        /// <summary>Gets or sets the date of birth.</summary>
        /// <value>The date of birth.</value>
        public System.DateTime? DateOfBirth { get; set; }

        #region Related Objects
        /// <summary>Gets or sets the identifier of the primary image file.</summary>
        /// <value>The identifier of the primary image file.</value>
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }

        /// <summary>Gets or sets the primary image file.</summary>
        /// <value>The primary image file.</value>
        public virtual ImageFile PrimaryImageFile { get; set; }

        /// <summary>Gets or sets the primary image file.</summary>
        /// <value>The primary image file.</value>
        IImageFile ICharacter.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        /// <summary>Gets or sets the identifier of the first issue appearance.</summary>
        /// <value>The identifier of the first issue appearance.</value>
        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }

        /// <summary>Gets or sets the first issue appearance.</summary>
        /// <value>The first issue appearance.</value>
        public virtual Issue FirstIssueAppearance { get; set; }

        /// <summary>Gets or sets the first issue appearance.</summary>
        /// <value>The first issue appearance.</value>
        IIssue ICharacter.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        /// <summary>Gets or sets the identifier of the gender.</summary>
        /// <value>The identifier of the gender.</value>
        [InverseProperty("Id")][ForeignKey("Gender")]
        public int GenderId { get; set; }

        /// <summary>Gets or sets the gender.</summary>
        /// <value>The gender.</value>
        public virtual Gender Gender { get; set; }

        /// <summary>Gets or sets the gender.</summary>
        /// <value>The gender.</value>
        IGender ICharacter.Gender { get { return Gender; } set { Gender = value as Gender; } }

        /// <summary>Gets or sets the identifier of the origin.</summary>
        /// <value>The identifier of the origin.</value>
        [InverseProperty("Id")][ForeignKey("Origin")]
        public int OriginId { get; set; }

        /// <summary>Gets or sets the origin.</summary>
        /// <value>The origin.</value>
        public virtual Origin Origin { get; set; }

        /// <summary>Gets or sets the origin.</summary>
        /// <value>The origin.</value>
        IOrigin ICharacter.Origin { get { return Origin; } set { Origin = value as Origin; } }

        /// <summary>Gets or sets the identifier of the publisher.</summary>
        /// <value>The identifier of the publisher.</value>
        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int PublisherId { get; set; }

        /// <summary>Gets or sets the publisher.</summary>
        /// <value>The publisher.</value>
        public virtual Publisher Publisher { get; set; }

        /// <summary>Gets or sets the publisher.</summary>
        /// <value>The publisher.</value>
        IPublisher ICharacter.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }
        #endregion

        #region Associated Objects
        /// <summary>Gets or sets the character aliases.</summary>
        /// <value>The character aliases.</value>
        public virtual ICollection<CharacterAlias> CharacterAliases { get; set; }

        /// <summary>Gets or sets the character creators.</summary>
        /// <value>The character creators.</value>
        public virtual ICollection<CharacterCreator> CharacterCreators { get; set; }

        /// <summary>Gets or sets the character enemies.</summary>
        /// <value>The character enemies.</value>
        public virtual ICollection<CharacterEnemy> CharacterEnemies { get; set; }

        /// <summary>Gets or sets the character enemy teams.</summary>
        /// <value>The character enemy teams.</value>
        public virtual ICollection<CharacterEnemyTeam> CharacterEnemyTeams { get; set; }

        /// <summary>Gets or sets the character friends.</summary>
        /// <value>The character friends.</value>
        public virtual ICollection<CharacterFriend> CharacterFriends { get; set; }

        /// <summary>Gets or sets the character friendly teams.</summary>
        /// <value>The character friendly teams.</value>
        public virtual ICollection<CharacterFriendlyTeam> CharacterFriendlyTeams { get; set; }

        /// <summary>Gets or sets the character issues appeared in.</summary>
        /// <value>The character issues appeared in.</value>
        public virtual ICollection<CharacterAppearedInIssue> CharacterIssuesAppearedIn { get; set; }

        /// <summary>Gets or sets the character issues died in.</summary>
        /// <value>The character issues died in.</value>
        public virtual ICollection<CharacterDiedInIssue> CharacterIssuesDiedIn { get; set; }

        /// <summary>Gets or sets the character issues.</summary>
        /// <value>The character issues.</value>
        public virtual ICollection<CharacterIssue> CharacterIssues { get; set; }

        /// <summary>Gets or sets the character movies.</summary>
        /// <value>The character movies.</value>
        public virtual ICollection<CharacterMovie> CharacterMovies { get; set; }

        /// <summary>Gets or sets the character powers.</summary>
        /// <value>The character powers.</value>
        public virtual ICollection<CharacterPower> CharacterPowers { get; set; }

        /// <summary>Gets or sets the character story arcs.</summary>
        /// <value>The character story arcs.</value>
        public virtual ICollection<CharacterStoryArc> CharacterStoryArcs { get; set; }

        /// <summary>Gets or sets the character teams.</summary>
        /// <value>The character teams.</value>
        public virtual ICollection<CharacterTeam> CharacterTeams { get; set; }

        /// <summary>Gets or sets the character volumes.</summary>
        /// <value>The character volumes.</value>
        public virtual ICollection<CharacterVolume> CharacterVolumes { get; set; }

        /// <summary>Gets or sets the character aliases.</summary>
        /// <value>The character aliases.</value>
        ICollection<ICharacterAlias> ICharacter.CharacterAliases { get { return (ICollection<ICharacterAlias>)CharacterAliases; } set { CharacterAliases = value as ICollection<CharacterAlias>; } }

        /// <summary>Gets or sets the character creators.</summary>
        /// <value>The character creators.</value>
        ICollection<ICharacterCreator> ICharacter.CharacterCreators { get { return (ICollection<ICharacterCreator>)CharacterCreators; } set { CharacterCreators = value as ICollection<CharacterCreator>; } }

        /// <summary>Gets or sets the character enemies.</summary>
        /// <value>The character enemies.</value>
        ICollection<ICharacterEnemy> ICharacter.CharacterEnemies { get { return (ICollection<ICharacterEnemy>)CharacterEnemies; } set { CharacterEnemies = value as ICollection<CharacterEnemy>; } }

        /// <summary>Gets or sets the character enemy teams.</summary>
        /// <value>The character enemy teams.</value>
        ICollection<ICharacterEnemyTeam> ICharacter.CharacterEnemyTeams { get { return (ICollection<ICharacterEnemyTeam>)CharacterEnemyTeams; } set { CharacterEnemyTeams = value as ICollection<CharacterEnemyTeam>; } }

        /// <summary>Gets or sets the character friends.</summary>
        /// <value>The character friends.</value>
        ICollection<ICharacterFriend> ICharacter.CharacterFriends { get { return (ICollection<ICharacterFriend>)CharacterFriends; } set { CharacterFriends = value as ICollection<CharacterFriend>; } }

        /// <summary>Gets or sets the character friendly teams.</summary>
        /// <value>The character friendly teams.</value>
        ICollection<ICharacterFriendlyTeam> ICharacter.CharacterFriendlyTeams { get { return (ICollection<ICharacterFriendlyTeam>)CharacterFriendlyTeams; } set { CharacterFriendlyTeams = value as ICollection<CharacterFriendlyTeam>; } }

        /// <summary>Gets or sets the character issues appeared in.</summary>
        /// <value>The character issues appeared in.</value>
        ICollection<ICharacterAppearedInIssue> ICharacter.CharacterIssuesAppearedIn { get { return (ICollection<ICharacterAppearedInIssue>)CharacterIssuesAppearedIn; } set { CharacterIssuesAppearedIn = value as ICollection<CharacterAppearedInIssue>; } }

        /// <summary>Gets or sets the character issues died in.</summary>
        /// <value>The character issues died in.</value>
        ICollection<ICharacterDiedInIssue> ICharacter.CharacterIssuesDiedIn { get { return (ICollection<ICharacterDiedInIssue>)CharacterIssuesDiedIn; } set { CharacterIssuesDiedIn = value as ICollection<CharacterDiedInIssue>; } }

        /// <summary>Gets or sets the character issues.</summary>
        /// <value>The character issues.</value>
        ICollection<ICharacterIssue> ICharacter.CharacterIssues { get { return (ICollection<ICharacterIssue>)CharacterIssues; } set { CharacterIssues = value as ICollection<CharacterIssue>; } }

        /// <summary>Gets or sets the character movies.</summary>
        /// <value>The character movies.</value>
        ICollection<ICharacterMovie> ICharacter.CharacterMovies { get { return (ICollection<ICharacterMovie>)CharacterMovies; } set { CharacterMovies = value as ICollection<CharacterMovie>; } }

        /// <summary>Gets or sets the character powers.</summary>
        /// <value>The character powers.</value>
        ICollection<ICharacterPower> ICharacter.CharacterPowers { get { return (ICollection<ICharacterPower>)CharacterPowers; } set { CharacterPowers = value as ICollection<CharacterPower>; } }

        /// <summary>Gets or sets the character story arcs.</summary>
        /// <value>The character story arcs.</value>
        ICollection<ICharacterStoryArc> ICharacter.CharacterStoryArcs { get { return (ICollection<ICharacterStoryArc>)CharacterStoryArcs; } set { CharacterStoryArcs = value as ICollection<CharacterStoryArc>; } }

        /// <summary>Gets or sets the character teams.</summary>
        /// <value>The character teams.</value>
        ICollection<ICharacterTeam> ICharacter.CharacterTeams { get { return (ICollection<ICharacterTeam>)CharacterTeams; } set { CharacterTeams = value as ICollection<CharacterTeam>; } }

        /// <summary>Gets or sets the character volumes.</summary>
        /// <value>The character volumes.</value>
        ICollection<ICharacterVolume> ICharacter.CharacterVolumes { get { return (ICollection<ICharacterVolume>)CharacterVolumes; } set { CharacterVolumes = value as ICollection<CharacterVolume>; } }
        #endregion
    }
}
