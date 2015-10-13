// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Objects.Object")]
    public class Object : NameableEntityBase, IObject
    {
        public int? StartYear { get; set; }

        // Related Object
        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue IObject.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IObject.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        // Associated Objects
        public virtual ICollection<ObjectAlias> ObjectAliases { get; set; }
        public virtual ICollection<ObjectAppearedInIssue> ObjectIssuesAppearedIn { get; set; }
        public virtual ICollection<ObjectIssue> ObjectIssues { get; set; }
        public virtual ICollection<ObjectMovie> ObjectMovies { get; set; }
        public virtual ICollection<ObjectStoryArc> ObjectStoryArcs { get; set; }
        public virtual ICollection<ObjectVolume> ObjectVolumes { get; set; }

        ICollection<IObjectAlias> IObject.ObjectAliases { get { return (ICollection<IObjectAlias>)ObjectAliases; } set { ObjectAliases = value as ICollection<ObjectAlias>; } }
        ICollection<IObjectAppearedInIssue> IObject.ObjectIssuesAppearedIn { get { return (ICollection<IObjectAppearedInIssue>)ObjectIssuesAppearedIn; } set { ObjectIssuesAppearedIn = value as ICollection<ObjectAppearedInIssue>; } }
        ICollection<IObjectIssue> IObject.ObjectIssues { get { return (ICollection<IObjectIssue>)ObjectIssues; } set { ObjectIssues = value as ICollection<ObjectIssue>; } }
        ICollection<IObjectMovie> IObject.ObjectMovies { get { return (ICollection<IObjectMovie>)ObjectMovies; } set { ObjectMovies = value as ICollection<ObjectMovie>; } }
        ICollection<IObjectStoryArc> IObject.ObjectStoryArcs { get { return (ICollection<IObjectStoryArc>)ObjectStoryArcs; } set { ObjectStoryArcs = value as ICollection<ObjectStoryArc>; } }
        ICollection<IObjectVolume> IObject.ObjectVolumes { get { return (ICollection<IObjectVolume>)ObjectVolumes; } set { ObjectVolumes = value as ICollection<ObjectVolume>; } }
    }
}
