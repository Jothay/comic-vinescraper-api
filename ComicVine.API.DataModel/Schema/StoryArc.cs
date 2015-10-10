namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.StoryArc")]
    public partial class StoryArc : NameableEntityBase, IStoryArc
    {
        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IStoryArc.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue IStoryArc.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher IStoryArc.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<Issue> Issues { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
        public virtual ICollection<StoryArcAlias> StoryArcAliases { get; set; }

        ICollection<IIssue> IStoryArc.Issues { get { return (ICollection<IIssue>)Issues; } set { Issues = value as ICollection<Issue>; } }
        ICollection<IMovie> IStoryArc.Movies { get { return (ICollection<IMovie>)Movies; } set { Movies = value as ICollection<Movie>; } }
        ICollection<IStoryArcAlias> IStoryArc.StoryArcAliases { get { return (ICollection<IStoryArcAlias>)StoryArcAliases; } set { StoryArcAliases = value as ICollection<StoryArcAlias>; } }
    }
}
