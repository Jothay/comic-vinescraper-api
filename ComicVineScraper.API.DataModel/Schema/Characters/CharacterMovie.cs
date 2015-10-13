// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterMovie")]
    public class CharacterMovie : EntityBase, ICharacterMovie
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterMovie.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Movie Movie { get; set; }
        IMovie ICharacterMovie.Movie { get { return Movie; } set { Movie = value as Movie; } }
    }
}
