// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.MovieConcept")]
    public class MovieConcept : EntityBase, IMovieConcept
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IMovieConcept.Movie { get { return Movie; } set { Movie = value as Movie; } }

        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IMovieConcept.Concept { get { return Concept; } set { Concept = value as Concept; } }
    }
}
