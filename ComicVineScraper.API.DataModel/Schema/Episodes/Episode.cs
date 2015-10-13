// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.Episode")]
    public class Episode : NameableEntityBase, IEpisode
    {
        [SearchableBoolean]
        public bool HasStaffReview { get; set; }
        public DateTime? AirDate { get; set; }
        public string EpisodeCode { get; set; }
        public int? SeasonNumber { get; set; }
        public int? EpisodeNumber { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IEpisode.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("Series")]
        public int? SeriesId { get; set; }
        public virtual Series Series { get; set; }
        ISeries IEpisode.Series { get { return Series; } set { Series = value as Series; } }

        // Associated Objects
        public virtual ICollection<EpisodeAlias> EpisodeAliases { get; set; }
        public virtual ICollection<EpisodeCharacter> EpisodeCharacters { get; set; }
        public virtual ICollection<EpisodeCharacterDied> EpisodeCharactersDied { get; set; }
        public virtual ICollection<EpisodeCharacterFirstAppearance> EpisodeCharacterFirstAppearances { get; set; }
        public virtual ICollection<EpisodeConcept> EpisodeConcepts { get; set; }
        public virtual ICollection<EpisodeConceptFirstAppearance> EpisodeConceptFirstAppearances { get; set; }
        public virtual ICollection<EpisodeLocation> EpisodeLocations { get; set; }
        public virtual ICollection<EpisodeLocationFirstAppearance> EpisodeLocationFirstAppearances { get; set; }
        public virtual ICollection<EpisodeObject> EpisodeObjects { get; set; }
        public virtual ICollection<EpisodeObjectFirstAppearance> EpisodeObjectFirstAppearances { get; set; }
        public virtual ICollection<EpisodePerson> EpisodePeople { get; set; }
        public virtual ICollection<EpisodeStoryArc> EpisodeStoryArcs { get; set; }
        public virtual ICollection<EpisodeStoryArcFirstAppearance> EpisodeStoryArcFirstAppearances { get; set; }
        public virtual ICollection<EpisodeTeam> EpisodeTeams { get; set; }
        public virtual ICollection<EpisodeTeamFirstAppearance> EpisodeTeamFirstAppearances { get; set; }

        ICollection<IEpisodeAlias> IEpisode.EpisodeAliases { get { return (ICollection<IEpisodeAlias>)EpisodeAliases; } set { EpisodeAliases = value as ICollection<EpisodeAlias>; } }
        ICollection<IEpisodeCharacter> IEpisode.EpisodeCharacters { get { return (ICollection<IEpisodeCharacter>)EpisodeCharacters; } set { EpisodeCharacters = value as ICollection<EpisodeCharacter>; } }
        ICollection<IEpisodeCharacterDied> IEpisode.EpisodeCharactersDied { get { return (ICollection<IEpisodeCharacterDied>)EpisodeCharactersDied; } set { EpisodeCharactersDied = value as ICollection<EpisodeCharacterDied>; } }
        ICollection<IEpisodeCharacterFirstAppearance> IEpisode.EpisodeCharacterFirstAppearances { get { return (ICollection<IEpisodeCharacterFirstAppearance>)EpisodeCharacterFirstAppearances; } set { EpisodeCharacterFirstAppearances = value as ICollection<EpisodeCharacterFirstAppearance>; } }
        ICollection<IEpisodeConcept> IEpisode.EpisodeConcepts { get { return (ICollection<IEpisodeConcept>)EpisodeConcepts; } set { EpisodeConcepts = value as ICollection<EpisodeConcept>; } }
        ICollection<IEpisodeConceptFirstAppearance> IEpisode.EpisodeConceptFirstAppearances { get { return (ICollection<IEpisodeConceptFirstAppearance>)EpisodeConceptFirstAppearances; } set { EpisodeConceptFirstAppearances = value as ICollection<EpisodeConceptFirstAppearance>; } }
        ICollection<IEpisodeLocation> IEpisode.EpisodeLocations { get { return (ICollection<IEpisodeLocation>)EpisodeLocations; } set { EpisodeLocations = value as ICollection<EpisodeLocation>; } }
        ICollection<IEpisodeLocationFirstAppearance> IEpisode.EpisodeLocationFirstAppearances { get { return (ICollection<IEpisodeLocationFirstAppearance>)EpisodeLocationFirstAppearances; } set { EpisodeLocationFirstAppearances = value as ICollection<EpisodeLocationFirstAppearance>; } }
        ICollection<IEpisodeObject> IEpisode.EpisodeObjects { get { return (ICollection<IEpisodeObject>)EpisodeObjects; } set { EpisodeObjects = value as ICollection<EpisodeObject>; } }
        ICollection<IEpisodeObjectFirstAppearance> IEpisode.EpisodeObjectFirstAppearances { get { return (ICollection<IEpisodeObjectFirstAppearance>)EpisodeObjectFirstAppearances; } set { EpisodeObjectFirstAppearances = value as ICollection<EpisodeObjectFirstAppearance>; } }
        ICollection<IEpisodePerson> IEpisode.EpisodePeople { get { return (ICollection<IEpisodePerson>)EpisodePeople; } set { EpisodePeople = value as ICollection<EpisodePerson>; } }
        ICollection<IEpisodeStoryArc> IEpisode.EpisodeStoryArcs { get { return (ICollection<IEpisodeStoryArc>)EpisodeStoryArcs; } set { EpisodeStoryArcs = value as ICollection<EpisodeStoryArc>; } }
        ICollection<IEpisodeStoryArcFirstAppearance> IEpisode.EpisodeStoryArcFirstAppearances { get { return (ICollection<IEpisodeStoryArcFirstAppearance>)EpisodeStoryArcFirstAppearances; } set { EpisodeStoryArcFirstAppearances = value as ICollection<EpisodeStoryArcFirstAppearance>; } }
        ICollection<IEpisodeTeam> IEpisode.EpisodeTeams { get { return (ICollection<IEpisodeTeam>)EpisodeTeams; } set { EpisodeTeams = value as ICollection<EpisodeTeam>; } }
        ICollection<IEpisodeTeamFirstAppearance> IEpisode.EpisodeTeamFirstAppearances { get { return (ICollection<IEpisodeTeamFirstAppearance>)EpisodeTeamFirstAppearances; } set { EpisodeTeamFirstAppearances = value as ICollection<EpisodeTeamFirstAppearance>; } }
    }
}
