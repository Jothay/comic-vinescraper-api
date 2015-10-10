namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Location")]
    public partial class Location : NameableEntityBase, ILocation
    {
        public int? StartYear { get; set; }

        // Related Object
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue ILocation.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile ILocation.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<LocationAlias> LocationAliases { get; set; }
        public virtual ICollection<Issue> IssueAppearances { get; set; }
        public virtual ICollection<Issue> IssueCredits { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<StoryArc> StoryArcCredits { get; set; }
        public virtual ICollection<Volume> VolumeCredits { get; set; }

        ICollection<ILocationAlias> ILocation.LocationAliases { get { return (ICollection<ILocationAlias>)LocationAliases; } set { LocationAliases = value as ICollection<LocationAlias>; } }
        ICollection<IIssue> ILocation.IssueAppearances { get { return (ICollection<IIssue>)IssueAppearances; } set { IssueAppearances = value as ICollection<Issue>; } }
        ICollection<IIssue> ILocation.IssueCredits { get { return (ICollection<IIssue>)IssueCredits; } set { IssueCredits = value as ICollection<Issue>; } }
        ICollection<IMovie> ILocation.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<IStoryArc> ILocation.StoryArcCredits { get { return (ICollection<IStoryArc>)StoryArcCredits; } set { StoryArcCredits = value as ICollection<StoryArc>; } }
        ICollection<IVolume> ILocation.VolumeCredits { get { return (ICollection<IVolume>)VolumeCredits; } set { VolumeCredits = value as ICollection<Volume>; } }
    }
}
