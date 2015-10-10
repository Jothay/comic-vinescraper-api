namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Volume")]
    public partial class Volume : NameableEntityBase, IVolume
    {
        public int Startyear { get; set; }

        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IVolume.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int? FirstIssueId { get; set; }
        public virtual Issue FirstIssue { get; set; }
        IIssue IVolume.FirstIssue { get { return FirstIssue; } set { FirstIssue = value as Issue; } }
        public int? LastIssueId { get; set; }
        public virtual Issue LastIssue { get; set; }
        IIssue IVolume.LastIssue { get { return LastIssue; } set { LastIssue = value as Issue; } }
        public int? PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher IVolume.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<Character> CharacterCredits { get; set; }
        public virtual ICollection<Concept> ConceptCredits { get; set; }
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Location> LocationCredits { get; set; }
        public virtual ICollection<Object> ObjectCredits { get; set; }
        public virtual ICollection<Person> PersonCredits { get; set; }
        public virtual ICollection<Team> TeamCredits { get; set; }
        public virtual ICollection<VolumeAlias> VolumeAliases { get; set; }

        ICollection<ICharacter> IVolume.CharacterCredits { get { return (ICollection<ICharacter>)CharacterCredits; } set { CharacterCredits = value as ICollection<Character>; } }
        ICollection<IConcept> IVolume.ConceptCredits { get { return (ICollection<IConcept>)ConceptCredits; } set { ConceptCredits = value as ICollection<Concept>; } }
        ICollection<IIssue> IVolume.Issues { get { return (ICollection<IIssue>)Issues; } set { Issues = value as ICollection<Issue>; } }
        ICollection<ILocation> IVolume.LocationCredits { get { return (ICollection<ILocation>)LocationCredits; } set { LocationCredits = value as ICollection<Location>; } }
        ICollection<IObject> IVolume.ObjectCredits { get { return (ICollection<IObject>)ObjectCredits; } set { ObjectCredits = value as ICollection<Object>; } }
        ICollection<IPerson> IVolume.PersonCredits { get { return (ICollection<IPerson>)PersonCredits; } set { PersonCredits = value as ICollection<Person>; } }
        ICollection<ITeam> IVolume.TeamCredits { get { return (ICollection<ITeam>)TeamCredits; } set { TeamCredits = value as ICollection<Team>; } }
        ICollection<IVolumeAlias> IVolume.VolumeAliases { get { return (ICollection<IVolumeAlias>)VolumeAliases; } set { VolumeAliases = value as ICollection<VolumeAlias>; } }
    }
}
