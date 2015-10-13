// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Locations.LocationVolume")]
    public class LocationVolume : EntityBase, ILocationVolume
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ILocationVolume.Location { get { return Location; } set { Location = value as Location; } }

        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume ILocationVolume.Volume { get { return Volume; } set { Volume = value as Volume; } }
    }
}
