// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterTeam")]
    public class CharacterTeam : EntityBase, ICharacterTeam
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterTeam.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Team Team { get; set; }
        ITeam ICharacterTeam.Team { get { return Team; } set { Team = value as Team; } }
    }
}
