// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterPower")]
    public class CharacterPower : EntityBase, ICharacterPower
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterPower.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Power")]
        public int PowerId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Power Power { get; set; }
        IPower ICharacterPower.Power { get { return Power; } set { Power = value as Power; } }
    }
}
