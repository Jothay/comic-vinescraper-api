namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.StoryArcAlias")]
    public partial class StoryArcAlias : NameableEntityBase, IStoryArcAlias
    {
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IStoryArcAlias.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
