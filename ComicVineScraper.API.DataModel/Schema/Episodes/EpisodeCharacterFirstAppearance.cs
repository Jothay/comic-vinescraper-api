// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodeCharacterFirstAppearance")]
    public class EpisodeCharacterFirstAppearance : EntityBase, IEpisodeCharacterFirstAppearance
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeCharacterFirstAppearance.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter IEpisodeCharacterFirstAppearance.Character { get { return Character; } set { Character = value as Character; } }
    }
}
