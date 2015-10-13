// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Volumes.VolumeWriter")]
    public class VolumeWriter : EntityBase, IVolumeWriter
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IVolumeWriter.Volume { get { return Volume; } set { Volume = value as Volume; } }

        [InverseProperty("Id")][ForeignKey("Writer")]
        public int WriterId { get; set; }
        public virtual Person Writer { get; set; }
        IPerson IVolumeWriter.Writer { get { return Writer; } set { Writer = value as Person; } }
    }
}
