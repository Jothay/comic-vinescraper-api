namespace ComicVine.API.DataModel.Schema
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Episode")]
    public partial class Episode : NameableEntityBase, IEpisode
    {
        [SearchableBoolean]
        public bool HasStaffReview { get; set; }
        public DateTime? AirDate { get; set; }
        public string EpisodeCode { get; set; }
        public int? SeasonNumber { get; set; }
        public int? EpisodeNumber { get; set; }

        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IEpisode.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int? SeriesId { get; set; }
        public virtual Series Series { get; set; }
        ISeries IEpisode.Series { get { return Series; } set { Series = value as Series; } }

        // Associated Objects
        public virtual ICollection<EpisodeAlias> EpisodeAliases { get; set; }
        public virtual ICollection<Character> CharacterCredits { get; set; }
        public virtual ICollection<Character> CharactersDied { get; set; }
        public virtual ICollection<Concept> ConceptCredits { get; set; }
        public virtual ICollection<Location> LocationCredits { get; set; }
        public virtual ICollection<Object> ObjectCredits { get; set; }
        public virtual ICollection<StoryArc> StoryArcCredits { get; set; }
        public virtual ICollection<Team> TeamCredits { get; set; }
        public virtual ICollection<Person> PersonCredits { get; set; }
        public virtual ICollection<Character> CharacterFirstAppearances { get; set; }
        public virtual ICollection<Concept> ConceptFirstAppearances { get; set; }
        public virtual ICollection<Location> LocationFirstAppearances { get; set; }
        public virtual ICollection<Object> ObjectFirstAppearances { get; set; }
        public virtual ICollection<StoryArc> StoryArcFirstAppearances { get; set; }
        public virtual ICollection<Team> TeamFirstAppearances { get; set; }

        ICollection<IEpisodeAlias> IEpisode.EpisodeAliases { get { return (ICollection<IEpisodeAlias>)EpisodeAliases; } set { EpisodeAliases = value as ICollection<EpisodeAlias>; } }
        ICollection<ICharacter> IEpisode.CharacterCredits { get { return (ICollection<ICharacter>)CharacterCredits; } set { CharacterCredits = value as ICollection<Character>; } }
        ICollection<ICharacter> IEpisode.CharactersDied { get { return (ICollection<ICharacter>)CharactersDied; } set { CharactersDied = value as ICollection<Character>; } }
        ICollection<IConcept> IEpisode.ConceptCredits { get { return (ICollection<IConcept>)ConceptCredits; } set { ConceptCredits = value as ICollection<Concept>; } }
        ICollection<ILocation> IEpisode.LocationCredits { get { return (ICollection<ILocation>)LocationCredits; } set { LocationCredits = value as ICollection<Location>; } }
        ICollection<IObject> IEpisode.ObjectCredits { get { return (ICollection<IObject>)ObjectCredits; } set { ObjectCredits = value as ICollection<Object>; } }
        ICollection<IStoryArc> IEpisode.StoryArcCredits { get { return (ICollection<IStoryArc>)StoryArcCredits; } set { StoryArcCredits = value as ICollection<StoryArc>; } }
        ICollection<ITeam> IEpisode.TeamCredits { get { return (ICollection<ITeam>)TeamCredits; } set { TeamCredits = value as ICollection<Team>; } }
        ICollection<IPerson> IEpisode.PersonCredits { get { return (ICollection<IPerson>)PersonCredits; } set { PersonCredits = value as ICollection<Person>; } }
        ICollection<ICharacter> IEpisode.CharacterFirstAppearances { get { return (ICollection<ICharacter>)CharacterFirstAppearances; } set { CharacterFirstAppearances = value as ICollection<Character>; } }
        ICollection<IConcept> IEpisode.ConceptFirstAppearances { get { return (ICollection<IConcept>)ConceptFirstAppearances; } set { ConceptFirstAppearances = value as ICollection<Concept>; } }
        ICollection<ILocation> IEpisode.LocationFirstAppearances { get { return (ICollection<ILocation>)LocationFirstAppearances; } set { LocationFirstAppearances = value as ICollection<Location>; } }
        ICollection<IObject> IEpisode.ObjectFirstAppearances { get { return (ICollection<IObject>)ObjectFirstAppearances; } set { ObjectFirstAppearances = value as ICollection<Object>; } }
        ICollection<IStoryArc> IEpisode.StoryArcFirstAppearances { get { return (ICollection<IStoryArc>)StoryArcFirstAppearances; } set { StoryArcFirstAppearances = value as ICollection<StoryArc>; } }
        ICollection<ITeam> IEpisode.TeamFirstAppearances { get { return (ICollection<ITeam>)TeamFirstAppearances; } set { TeamFirstAppearances = value as ICollection<Team>; } }
    }
}
