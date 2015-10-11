// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("StoryArcs.StoryArcAlias")]
    public class StoryArcAlias : NameableEntityBase, IStoryArcAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IStoryArcAlias.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
