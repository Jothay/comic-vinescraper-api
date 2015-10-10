namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.ConceptAlias")]
    public partial class ConceptAlias : NameableEntityBase, IConceptAlias
    {
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IConceptAlias.Concept { get { return Concept; } set { Concept = value as Concept; } }
    }
}
