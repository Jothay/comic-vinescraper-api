// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Objects.ObjectStoryArc")]
    public class ObjectStoryArc : EntityBase, IObjectStoryArc
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IObjectStoryArc.Object { get { return Object; } set { Object = value as Object; } }

        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IObjectStoryArc.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
