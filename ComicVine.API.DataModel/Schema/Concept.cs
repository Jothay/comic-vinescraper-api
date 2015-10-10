namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Concept")]
    public partial class Concept : NameableEntityBase, IConcept
    {
        public int StartYear { get; set; }

        // Relate Objects
        public int? PrimaryImageId { get; set; }
        public virtual ImageFile PrimaryImage { get; set; }
        IImageFile IConcept.PrimaryImage { get { return PrimaryImage; } set { PrimaryImage = value as ImageFile; } }
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue IConcept.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        // Associated Objects
        public virtual ICollection<ConceptAlias> ConceptAliases { get; set; }
        public virtual ICollection<Issue> IssueAppearances { get; set; }
        public virtual ICollection<Issue> IssueCredits { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<Volume> VolumeCredits { get; set; }

        ICollection<IConceptAlias> IConcept.ConceptAliases { get { return (ICollection<IConceptAlias>)ConceptAliases; } set { ConceptAliases = value as ICollection<ConceptAlias>; } }
        ICollection<IIssue> IConcept.IssueAppearances { get { return (ICollection<IIssue>)IssueAppearances; } set { IssueAppearances = value as ICollection<Issue>; } }
        ICollection<IIssue> IConcept.IssueCredits { get { return (ICollection<IIssue>)IssueCredits; } set { IssueCredits = value as ICollection<Issue>; } }
        ICollection<IMovie> IConcept.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<IVolume> IConcept.VolumeCredits { get { return (ICollection<IVolume>)VolumeCredits; } set { VolumeCredits = value as ICollection<Volume>; } }
    }
}
