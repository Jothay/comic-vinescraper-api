namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Object")]
    public partial class Object : NameableEntityBase, IObject
    {
        public int? StartYear { get; set; }

        // Related Object
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue IObject.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IObject.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<Issue> IssueAppearances { get; set; }
        public virtual ICollection<Issue> IssueCredits { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<ObjectAlias> ObjectAliases { get; set; }
        public virtual ICollection<StoryArc> StoryArcCredits { get; set; }
        public virtual ICollection<Volume> VolumeCredits { get; set; }

        ICollection<IIssue> IObject.IssueAppearances { get { return (ICollection<IIssue>)IssueAppearances; } set { IssueAppearances = value as ICollection<Issue>; } }
        ICollection<IIssue> IObject.IssueCredits { get { return (ICollection<IIssue>)IssueCredits; } set { IssueCredits = value as ICollection<Issue>; } }
        ICollection<IMovie> IObject.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<IObjectAlias> IObject.ObjectAliases { get { return (ICollection<IObjectAlias>)ObjectAliases; } set { ObjectAliases = value as ICollection<ObjectAlias>; } }
        ICollection<IStoryArc> IObject.StoryArcCredits { get { return (ICollection<IStoryArc>)StoryArcCredits; } set { StoryArcCredits = value as ICollection<StoryArc>; } }
        ICollection<IVolume> IObject.VolumeCredits { get { return (ICollection<IVolume>)VolumeCredits; } set { VolumeCredits = value as ICollection<Volume>; } }
    }
}
