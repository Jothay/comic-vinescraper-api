// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterStoryArc")]
    public class CharacterStoryArc : EntityBase, ICharacterStoryArc
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterStoryArc.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("StoryArc")]
        public int StoryArcId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual StoryArc StoryArc { get; set; }
        IStoryArc ICharacterStoryArc.StoryArc { get { return StoryArc; } set { StoryArc = value as StoryArc; } }
    }
}
