// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Concepts.Concept")]
    public class Concept : NameableEntityBase, IConcept
    {
        [Index]
        public int StartYear { get; set; }

        // Relate Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int? PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IConcept.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue IConcept.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        // Associated Objects
        public virtual ICollection<ConceptAlias> ConceptAliases { get; set; }
        public virtual ICollection<ConceptAppearedInIssue> ConceptIssuesAppearedIn { get; set; }
        public virtual ICollection<ConceptIssue> ConceptIssues { get; set; }
        public virtual ICollection<ConceptMovie> ConceptMovies { get; set; }
        public virtual ICollection<ConceptVolume> ConceptVolumes { get; set; }

        ICollection<IConceptAlias> IConcept.ConceptAliases { get { return (ICollection<IConceptAlias>)ConceptAliases; } set { ConceptAliases = value as ICollection<ConceptAlias>; } }
        ICollection<IConceptAppearedInIssue> IConcept.ConceptIssuesAppearedIn { get { return (ICollection<IConceptAppearedInIssue>)ConceptIssuesAppearedIn; } set { ConceptIssuesAppearedIn = value as ICollection<ConceptAppearedInIssue>; } }
        ICollection<IConceptIssue> IConcept.ConceptIssues { get { return (ICollection<IConceptIssue>)ConceptIssues; } set { ConceptIssues = value as ICollection<ConceptIssue>; } }
        ICollection<IConceptMovie> IConcept.ConceptMovies { get { return (ICollection<IConceptMovie>)ConceptMovies; } set { ConceptMovies = value as ICollection<ConceptMovie>; } }
        ICollection<IConceptVolume> IConcept.ConceptVolumes { get { return (ICollection<IConceptVolume>)ConceptVolumes; } set { ConceptVolumes = value as ICollection<ConceptVolume>; } }
    }
}
