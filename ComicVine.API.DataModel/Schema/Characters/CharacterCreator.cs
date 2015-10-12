// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterCreator")]
    public class CharacterCreator : EntityBase, ICharacterCreator
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterCreator.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Creator")]
        public int CreatorId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Person Creator { get; set; }
        IPerson ICharacterCreator.Creator { get { return Creator; } set { Creator = value as Person; } }
    }
}
