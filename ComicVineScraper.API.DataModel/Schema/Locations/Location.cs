// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Locations.Location")]
    public class Location : NameableEntityBase, ILocation
    {
        public int? StartYear { get; set; }

        // Related Object
        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue ILocation.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile ILocation.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<LocationAlias> LocationAliases { get; set; }
        public virtual ICollection<LocationAppearedInIssue> LocationAppearedInIssues { get; set; }
        public virtual ICollection<LocationIssue> LocationIssues { get; set; }
        public virtual ICollection<LocationMovie> LocationMovies { get; set; }
        public virtual ICollection<LocationStoryArc> LocationStoryArcs { get; set; }
        public virtual ICollection<LocationVolume> LocationVolumes { get; set; }

        ICollection<ILocationAlias> ILocation.LocationAliases { get { return (ICollection<ILocationAlias>)LocationAliases; } set { LocationAliases = value as ICollection<LocationAlias>; } }
        ICollection<ILocationAppearedInIssue> ILocation.LocationAppearedInIssues { get { return (ICollection<ILocationAppearedInIssue>)LocationAppearedInIssues; } set { LocationAppearedInIssues = value as ICollection<LocationAppearedInIssue>; } }
        ICollection<ILocationIssue> ILocation.LocationIssues { get { return (ICollection<ILocationIssue>)LocationIssues; } set { LocationIssues = value as ICollection<LocationIssue>; } }
        ICollection<ILocationMovie> ILocation.LocationMovies { get { return (ICollection<ILocationMovie>)LocationMovies; } set { LocationMovies = value as ICollection<LocationMovie>; } }
        ICollection<ILocationStoryArc> ILocation.LocationStoryArcs { get { return (ICollection<ILocationStoryArc>)LocationStoryArcs; } set { LocationStoryArcs = value as ICollection<LocationStoryArc>; } }
        ICollection<ILocationVolume> ILocation.LocationVolumes { get { return (ICollection<ILocationVolume>)LocationVolumes; } set { LocationVolumes = value as ICollection<LocationVolume>; } }
    }
}
