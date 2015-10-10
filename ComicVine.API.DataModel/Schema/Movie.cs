namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Movie")]
    public partial class Movie : NameableEntityBase, IMovie
    {
        [SearchableBoolean]
        public bool HasStaffReview { get; set; }
        [StringIsUnicode(false)][SearchableString]
        public string Distributor { get; set; }
        public decimal? BoxOfficeRevenue { get; set; }
        public decimal? TotalRevenue { get; set; }
        public decimal? Budget { get; set; }
        public decimal? Rating { get; set; }
        public System.DateTime? ReleaseDate { get; set; }
        public decimal? RunTime { get; set; }

        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IMovie.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Concept> Concepts { get; set; }
        public virtual ICollection<Location> LocationCredits { get; set; }
        public virtual ICollection<Object> ObjectCredits { get; set; }
        public virtual ICollection<Producer> ProducerCredits { get; set; }
        public virtual ICollection<Studio> StudioCredits { get; set; }
        public virtual ICollection<Team> TeamCredits { get; set; }
        public virtual ICollection<Writer> WriterCredits { get; set; }

        ICollection<ICharacter> IMovie.Characters { get { return (ICollection<ICharacter>)Characters; } set { Characters = value as ICollection<Character>; } }
        ICollection<IConcept> IMovie.Concepts { get { return (ICollection<IConcept>)Concepts; } set { Concepts = value as ICollection<Concept>; } }
        ICollection<ILocation> IMovie.LocationCredits { get { return (ICollection<ILocation>)LocationCredits; } set { LocationCredits = value as ICollection<Location>; } }
        ICollection<IObject> IMovie.ObjectCredits { get { return (ICollection<IObject>)ObjectCredits; } set { ObjectCredits = value as ICollection<Object>; } }
        ICollection<IProducer> IMovie.ProducerCredits { get { return (ICollection<IProducer>)ProducerCredits; } set { ProducerCredits = value as ICollection<Producer>; } }
        ICollection<IStudio> IMovie.StudioCredits { get { return (ICollection<IStudio>)StudioCredits; } set { StudioCredits = value as ICollection<Studio>; } }
        ICollection<ITeam> IMovie.TeamCredits { get { return (ICollection<ITeam>)TeamCredits; } set { TeamCredits = value as ICollection<Team>; } }
        ICollection<IWriter> IMovie.WriterCredits { get { return (ICollection<IWriter>)WriterCredits; } set { WriterCredits = value as ICollection<Writer>; } }
    }
}
