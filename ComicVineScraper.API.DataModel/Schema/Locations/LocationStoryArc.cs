// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Locations.LocationStoryArc")]
    public class LocationStoryArc : EntityBase, ILocationStoryArc
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ILocationStoryArc.Location { get { return Location; } set { Location = value as Location; } }

        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc ILocationStoryArc.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
