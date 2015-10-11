// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Concepts.ConceptAppearedInIssue")]
    public class ConceptAppearedInIssue : EntityBase, IConceptAppearedInIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IConceptAppearedInIssue.Concept { get { return Concept; } set { Concept = value as Concept; } }

        [InverseProperty("Id")][ForeignKey("Issue")]
        public int AppearedInIssueId { get; set; }
        public virtual Issue AppearedInIssue { get; set; }
        IIssue IConceptAppearedInIssue.AppearedInIssue { get { return AppearedInIssue; } set { AppearedInIssue = value as Issue; } }
    }
}
