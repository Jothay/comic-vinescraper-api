namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.VolumeAlias")]
    public partial class VolumeAlias : NameableEntityBase, IVolumeAlias
    {
        // Related Objects
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IVolumeAlias.Volume { get { return Volume; } set { Volume = value as Volume; } }
    }
}
