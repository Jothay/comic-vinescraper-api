namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.CharacterAlias")]
    public partial class CharacterAlias : NameableEntityBase, ICharacterAlias
    {
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterAlias.Character { get { return Character; } set { Character = value as Character; } }
    }
}
