// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterEnemyTeam")]
    public class CharacterEnemyTeam : EntityBase, ICharacterEnemyTeam
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterEnemyTeam.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("EnemyTeam")]
        public int EnemyTeamId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Team EnemyTeam { get; set; }
        ITeam ICharacterEnemyTeam.EnemyTeam { get { return EnemyTeam; } set { EnemyTeam = value as Team; } }
    }
}
