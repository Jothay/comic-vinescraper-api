// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Volumes.VolumeObject")]
    public class VolumeObject : EntityBase, IVolumeObject
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IVolumeObject.Volume { get { return Volume; } set { Volume = value as Volume; } }

        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IVolumeObject.Object { get { return Object; } set { Object = value as Object; } }
    }
}
