// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Concepts.ConceptAlias")]
    public class ConceptAlias : NameableEntityBase, IConceptAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IConceptAlias.Concept { get { return Concept; } set { Concept = value as Concept; } }
    }
}
