// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("StoryArcs.StoryArcWriter")]
    public class StoryArcWriter : EntityBase, IStoryArcWriter
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc IStoryArcWriter.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }

        [InverseProperty("Id")][ForeignKey("Writer")]
        public int WriterId { get; set; }
        public virtual Person Writer { get; set; }
        IPerson IStoryArcWriter.Writer { get { return Writer; } set { Writer = value as Person; } }
    }
}
