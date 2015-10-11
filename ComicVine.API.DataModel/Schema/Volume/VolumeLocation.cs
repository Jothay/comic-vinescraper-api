// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Volumes.VolumeLocation")]
    public class VolumeLocation : EntityBase, IVolumeLocation
    {
        // Related Locations
        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IVolumeLocation.Volume { get { return Volume; } set { Volume = value as Volume; } }

        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation IVolumeLocation.Location { get { return Location; } set { Location = value as Location; } }
    }
}
