// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.Character")]
    public class Character : NameableEntityBase, ICharacter
    {
        [StringIsUnicode(false)][SearchableString]
        public string RealName { get; set; }

        public System.DateTime? DateOfBirth { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile ICharacter.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue ICharacter.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("Gender")]
        public int GenderId { get; set; }
        public virtual Gender Gender { get; set; }
        IGender ICharacter.Gender { get { return Gender; } set { Gender = value as Gender; } }

        [InverseProperty("Id")][ForeignKey("Origin")]
        public int OriginId { get; set; }
        public virtual Origin Origin { get; set; }
        IOrigin ICharacter.Origin { get { return Origin; } set { Origin = value as Origin; } }

        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher ICharacter.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<CharacterAlias> CharacterAliases { get; set; }
        public virtual ICollection<CharacterCreator> CharacterCreators { get; set; }
        public virtual ICollection<CharacterEnemy> CharacterEnemies { get; set; }
        public virtual ICollection<CharacterEnemyTeam> CharacterEnemyTeams { get; set; }
        public virtual ICollection<CharacterFriend> CharacterFriends { get; set; }
        public virtual ICollection<CharacterFriendlyTeam> CharacterFriendlyTeams { get; set; }
        public virtual ICollection<CharacterAppearedInIssue> CharacterIssuesAppearedIn { get; set; }
        public virtual ICollection<CharacterDiedInIssue> CharacterIssuesDiedIn { get; set; }
        public virtual ICollection<CharacterIssue> CharacterIssues { get; set; }
        public virtual ICollection<CharacterMovie> CharacterMovies { get; set; }
        public virtual ICollection<CharacterPower> CharacterPowers { get; set; }
        public virtual ICollection<CharacterStoryArc> CharacterStoryArcs { get; set; }
        public virtual ICollection<CharacterTeam> CharacterTeams { get; set; }
        public virtual ICollection<CharacterVolume> CharacterVolumes { get; set; }

        ICollection<ICharacterAlias> ICharacter.CharacterAliases { get { return (ICollection<ICharacterAlias>)CharacterAliases; } set { CharacterAliases = value as ICollection<CharacterAlias>; } }
        ICollection<ICharacterCreator> ICharacter.CharacterCreators { get { return (ICollection<ICharacterCreator>)CharacterCreators; } set { CharacterCreators = value as ICollection<CharacterCreator>; } }
        ICollection<ICharacterEnemy> ICharacter.CharacterEnemies { get { return (ICollection<ICharacterEnemy>)CharacterEnemies; } set { CharacterEnemies = value as ICollection<CharacterEnemy>; } }
        ICollection<ICharacterEnemyTeam> ICharacter.CharacterEnemyTeams { get { return (ICollection<ICharacterEnemyTeam>)CharacterEnemyTeams; } set { CharacterEnemyTeams = value as ICollection<CharacterEnemyTeam>; } }
        ICollection<ICharacterFriend> ICharacter.CharacterFriends { get { return (ICollection<ICharacterFriend>)CharacterFriends; } set { CharacterFriends = value as ICollection<CharacterFriend>; } }
        ICollection<ICharacterFriendlyTeam> ICharacter.CharacterFriendlyTeams { get { return (ICollection<ICharacterFriendlyTeam>)CharacterFriendlyTeams; } set { CharacterFriendlyTeams = value as ICollection<CharacterFriendlyTeam>; } }
        ICollection<ICharacterAppearedInIssue> ICharacter.CharacterIssuesAppearedIn { get { return (ICollection<ICharacterAppearedInIssue>)CharacterIssuesAppearedIn; } set { CharacterIssuesAppearedIn = value as ICollection<CharacterAppearedInIssue>; } }
        ICollection<ICharacterDiedInIssue> ICharacter.CharacterIssuesDiedIn { get { return (ICollection<ICharacterDiedInIssue>)CharacterIssuesDiedIn; } set { CharacterIssuesDiedIn = value as ICollection<CharacterDiedInIssue>; } }
        ICollection<ICharacterIssue> ICharacter.CharacterIssues { get { return (ICollection<ICharacterIssue>)CharacterIssues; } set { CharacterIssues = value as ICollection<CharacterIssue>; } }
        ICollection<ICharacterMovie> ICharacter.CharacterMovies { get { return (ICollection<ICharacterMovie>)CharacterMovies; } set { CharacterMovies = value as ICollection<CharacterMovie>; } }
        ICollection<ICharacterPower> ICharacter.CharacterPowers { get { return (ICollection<ICharacterPower>)CharacterPowers; } set { CharacterPowers = value as ICollection<CharacterPower>; } }
        ICollection<ICharacterStoryArc> ICharacter.CharacterStoryArcs { get { return (ICollection<ICharacterStoryArc>)CharacterStoryArcs; } set { CharacterStoryArcs = value as ICollection<CharacterStoryArc>; } }
        ICollection<ICharacterTeam> ICharacter.CharacterTeams { get { return (ICollection<ICharacterTeam>)CharacterTeams; } set { CharacterTeams = value as ICollection<CharacterTeam>; } }
        ICollection<ICharacterVolume> ICharacter.CharacterVolumes { get { return (ICollection<ICharacterVolume>)CharacterVolumes; } set { CharacterVolumes = value as ICollection<CharacterVolume>; } }
    }
}
