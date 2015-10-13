// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Volumes.Volume")]
    public class Volume : NameableEntityBase, IVolume
    {
        public int Startyear { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IVolume.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("FirstIssue")]
        public int? FirstIssueId { get; set; }
        public virtual Issue FirstIssue { get; set; }
        IIssue IVolume.FirstIssue { get { return FirstIssue; } set { FirstIssue = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("LastIssue")]
        public int? LastIssueId { get; set; }
        public virtual Issue LastIssue { get; set; }
        IIssue IVolume.LastIssue { get { return LastIssue; } set { LastIssue = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int? PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher IVolume.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<VolumeAlias> VolumeAliases { get; set; }
        public virtual ICollection<VolumeCharacter> VolumeCharacters { get; set; }
        public virtual ICollection<VolumeConcept> VolumeConcepts { get; set; }
        public virtual ICollection<VolumeLocation> VolumeLocations { get; set; }
        public virtual ICollection<VolumeObject> VolumeObjects { get; set; }
        public virtual ICollection<VolumeTeam> VolumeTeams { get; set; }
        public virtual ICollection<VolumeWriter> VolumeWriters { get; set; }

        ICollection<IIssue> IVolume.Issues { get { return (ICollection<IIssue>)Issues; } set { Issues = value as ICollection<Issue>; } }
        ICollection<IVolumeAlias> IVolume.VolumeAliases { get { return (ICollection<IVolumeAlias>)VolumeAliases; } set { VolumeAliases = value as ICollection<VolumeAlias>; } }
        ICollection<IVolumeCharacter> IVolume.VolumeCharacters { get { return (ICollection<IVolumeCharacter>)VolumeCharacters; } set { VolumeCharacters = value as ICollection<VolumeCharacter>; } }
        ICollection<IVolumeConcept> IVolume.VolumeConcepts { get { return (ICollection<IVolumeConcept>)VolumeConcepts; } set { VolumeConcepts = value as ICollection<VolumeConcept>; } }
        ICollection<IVolumeLocation> IVolume.VolumeLocations { get { return (ICollection<IVolumeLocation>)VolumeLocations; } set { VolumeLocations = value as ICollection<VolumeLocation>; } }
        ICollection<IVolumeObject> IVolume.VolumeObjects { get { return (ICollection<IVolumeObject>)VolumeObjects; } set { VolumeObjects = value as ICollection<VolumeObject>; } }
        ICollection<IVolumeTeam> IVolume.VolumeTeams { get { return (ICollection<IVolumeTeam>)VolumeTeams; } set { VolumeTeams = value as ICollection<VolumeTeam>; } }
        ICollection<IVolumeWriter> IVolume.VolumeWriters { get { return (ICollection<IVolumeWriter>)VolumeWriters; } set { VolumeWriters = value as ICollection<VolumeWriter>; } }
    }
}
