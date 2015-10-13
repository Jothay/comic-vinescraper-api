// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Concepts.ConceptIssue")]
    public class ConceptIssue : EntityBase, IConceptIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IConceptIssue.Concept { get { return Concept; } set { Concept = value as Concept; } }

        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue IConceptIssue.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
