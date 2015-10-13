// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("StoryArcs.StoryArc")]
    public class StoryArc : NameableEntityBase, IStoryArc
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("PrimaryImageFile")]
        public int PrimaryImageFileId { get; set; }
        public virtual ImageFile PrimaryImageFile { get; set; }
        IImageFile IStoryArc.PrimaryImageFile { get { return PrimaryImageFile; } set { PrimaryImageFile = value as ImageFile; } }

        [InverseProperty("Id")][ForeignKey("FirstIssueAppearance")]
        public int FirstIssueAppearanceId { get; set; }
        public virtual Issue FirstIssueAppearance { get; set; }
        IIssue IStoryArc.FirstIssueAppearance { get { return FirstIssueAppearance; } set { FirstIssueAppearance = value as Issue; } }

        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher IStoryArc.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        // Associated Objects
        public virtual ICollection<MovieStoryArc> MovieStoryArcs { get; set; }
        public virtual ICollection<StoryArcAlias> StoryArcAliases { get; set; }
        public virtual ICollection<StoryArcIssue> StoryArcIssues { get; set; }
        public virtual ICollection<StoryArcWriter> StoryArcsWritten { get; set; }

        ICollection<IMovieStoryArc> IStoryArc.MovieStoryArcs { get { return (ICollection<IMovieStoryArc>)MovieStoryArcs; } set { MovieStoryArcs = value as ICollection<MovieStoryArc>; } }
        ICollection<IStoryArcAlias> IStoryArc.StoryArcAliases { get { return (ICollection<IStoryArcAlias>)StoryArcAliases; } set { StoryArcAliases = value as ICollection<StoryArcAlias>; } }
        ICollection<IStoryArcIssue> IStoryArc.StoryArcIssues { get { return (ICollection<IStoryArcIssue>)StoryArcIssues; } set { StoryArcIssues = value as ICollection<StoryArcIssue>; } }
        ICollection<IStoryArcWriter> IStoryArc.StoryArcsWritten { get { return (ICollection<IStoryArcWriter>)StoryArcsWritten; } set { StoryArcsWritten = value as ICollection<StoryArcWriter>; } }
    }
}
