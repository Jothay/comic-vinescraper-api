// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Concepts.ConceptsMovie")]
    public class ConceptMovie : EntityBase, IConceptMovie
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IConceptMovie.Concept { get { return Concept; } set { Concept = value as Concept; } }

        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IConceptMovie.Movie { get { return Movie; } set { Movie = value as Movie; } }
    }
}
