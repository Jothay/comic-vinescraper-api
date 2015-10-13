// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterFriendlyTeam")]
    public class CharacterFriendlyTeam : EntityBase, ICharacterFriendlyTeam
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterFriendlyTeam.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("FriendlyTeam")]
        public int FriendlyTeamId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Team FriendlyTeam { get; set; }
        ITeam ICharacterFriendlyTeam.FriendlyTeam { get { return FriendlyTeam; } set { FriendlyTeam = value as Team; } }
    }
}
