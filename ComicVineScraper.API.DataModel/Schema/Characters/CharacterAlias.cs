// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterAlias")]
    public class CharacterAlias : NameableEntityBase, ICharacterAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterAlias.Character { get { return Character; } set { Character = value as Character; } }
    }
}
