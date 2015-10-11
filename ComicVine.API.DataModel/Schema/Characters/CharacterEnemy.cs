// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterEnemy")]
    public class CharacterEnemy : EntityBase, ICharacterEnemy
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterEnemy.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Enemy")]
        public int EnemyId { get; set; }
        public virtual Character Enemy { get; set; }
        ICharacter ICharacterEnemy.Enemy { get { return Enemy; } set { Enemy = value as Character; } }
    }
}
