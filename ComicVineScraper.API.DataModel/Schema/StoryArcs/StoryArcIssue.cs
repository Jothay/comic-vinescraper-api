// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("StoryArcs.StoryArcIssue")]
    public class StoryArcIssue : EntityBase, IStoryArcIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IStoryArcIssue.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }

        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        public virtual Issue Issue { get; set; }
        IIssue IStoryArcIssue.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
