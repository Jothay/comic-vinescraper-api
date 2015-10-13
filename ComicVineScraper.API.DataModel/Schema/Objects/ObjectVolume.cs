// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Objects.ObjectVolume")]
    public class ObjectVolume : EntityBase, IObjectVolume
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IObjectVolume.Object { get { return Object; } set { Object = value as Object; } }

        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IObjectVolume.Volume { get { return Volume; } set { Volume = value as Volume; } }
    }
}
