// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Volumes.VolumeCharacter")]
    public class VolumeCharacter : EntityBase, IVolumeCharacter
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IVolumeCharacter.Volume { get { return Volume; } set { Volume = value as Volume; } }

        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter IVolumeCharacter.Character { get { return Character; } set { Character = value as Character; } }
    }
}
