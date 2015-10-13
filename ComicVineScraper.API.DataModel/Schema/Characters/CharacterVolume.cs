// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterVolume")]
    public class CharacterVolume : EntityBase, ICharacterVolume
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterVolume.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Volume Volume { get; set; }
        IVolume ICharacterVolume.Volume { get { return Volume; } set { Volume = value as Volume; } }
    }
}
