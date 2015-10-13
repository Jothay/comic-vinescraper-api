// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.Movie")]
    public class Movie : NameableEntityBase, IMovie
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
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IMovie.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<MovieCharacter> MovieCharacters { get; set; }
        public virtual ICollection<MovieConcept> MovieConcepts { get; set; }
        public virtual ICollection<MovieLocation> MovieLocations { get; set; }
        public virtual ICollection<MovieObject> MovieObjects { get; set; }
        public virtual ICollection<MovieProducer> MovieProducers { get; set; }
        public virtual ICollection<MovieStoryArc> MovieStoryArcs { get; set; }
        public virtual ICollection<MovieStudio> MovieStudios { get; set; }
        public virtual ICollection<MovieTeam> MovieTeams { get; set; }
        public virtual ICollection<MovieWriter> MovieWriters { get; set; }

        ICollection<IMovieCharacter> IMovie.MovieCharacters { get { return (ICollection<IMovieCharacter>)MovieCharacters; } set { MovieCharacters = value as ICollection<MovieCharacter>; } }
        ICollection<IMovieConcept> IMovie.MovieConcepts { get { return (ICollection<IMovieConcept>)MovieConcepts; } set { MovieConcepts = value as ICollection<MovieConcept>; } }
        ICollection<IMovieLocation> IMovie.MovieLocations { get { return (ICollection<IMovieLocation>)MovieLocations; } set { MovieLocations = value as ICollection<MovieLocation>; } }
        ICollection<IMovieObject> IMovie.MovieObjects { get { return (ICollection<IMovieObject>)MovieObjects; } set { MovieObjects = value as ICollection<MovieObject>; } }
        ICollection<IMovieProducer> IMovie.MovieProducers { get { return (ICollection<IMovieProducer>)MovieProducers; } set { MovieProducers = value as ICollection<MovieProducer>; } }
        ICollection<IMovieStoryArc> IMovie.MovieStoryArcs { get { return (ICollection<IMovieStoryArc>)MovieStoryArcs; } set { MovieStoryArcs = value as ICollection<MovieStoryArc>; } }
        ICollection<IMovieStudio> IMovie.MovieStudios { get { return (ICollection<IMovieStudio>)MovieStudios; } set { MovieStudios = value as ICollection<MovieStudio>; } }
        ICollection<IMovieTeam> IMovie.MovieTeams { get { return (ICollection<IMovieTeam>)MovieTeams; } set { MovieTeams = value as ICollection<MovieTeam>; } }
        ICollection<IMovieWriter> IMovie.MovieWriters { get { return (ICollection<IMovieWriter>)MovieWriters; } set { MovieWriters = value as ICollection<MovieWriter>; } }
    }
}
