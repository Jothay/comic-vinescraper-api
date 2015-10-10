namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Person")]
    public partial class Person : NameableEntityBase, IPerson
    {
        public string Hometown { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public System.DateTime? BirthDate { get; set; }
        public System.DateTime? DeathDate { get; set; }

        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IPerson.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int? GenderId { get; set; }
        public Gender Gender { get; set; }
        IGender IPerson.Gender { get { return Gender; } set { Gender = value as Gender; } }

        // Associated Objects
        public virtual ICollection<Character> CharactersCreated { get; set; }
        public virtual ICollection<Issue> IssueAppearances { get; set; }
        public virtual ICollection<Issue> IssueCredits { get; set; }
        public virtual ICollection<PersonAlias> PersonAliases { get; set; }
        public virtual ICollection<StoryArc> StoryArcCredits { get; set; }
        public virtual ICollection<Volume> VolumeCredits { get; set; }

        ICollection<ICharacter> IPerson.CharactersCreated { get { return (ICollection<ICharacter>)CharactersCreated; } set { CharactersCreated = value as ICollection<Character>; } }
        ICollection<IIssue> IPerson.IssueAppearances { get { return (ICollection<IIssue>)IssueAppearances; } set { IssueAppearances = value as ICollection<Issue>; } }
        ICollection<IIssue> IPerson.IssueCredits { get { return (ICollection<IIssue>)IssueCredits; } set { IssueCredits = value as ICollection<Issue>; } }
        ICollection<IPersonAlias> IPerson.PersonAliases { get { return (ICollection<IPersonAlias>)PersonAliases; } set { PersonAliases = value as ICollection<PersonAlias>; } }
        ICollection<IStoryArc> IPerson.StoryArcCredits { get { return (ICollection<IStoryArc>)StoryArcCredits; } set { StoryArcCredits = value as ICollection<StoryArc>; } }
        ICollection<IVolume> IPerson.VolumeCredits { get { return (ICollection<IVolume>)VolumeCredits; } set { VolumeCredits = value as ICollection<Volume>; } }
    }
}
