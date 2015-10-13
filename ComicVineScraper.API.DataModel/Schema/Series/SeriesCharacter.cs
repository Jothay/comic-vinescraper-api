// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Series.SeriesCharacter")]
    public class SeriesCharacter : EntityBase, ISeriesCharacter
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Series")]
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        ISeries ISeriesCharacter.Series { get { return Series; } set { Series = value as Series; } }

        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ISeriesCharacter.Character { get { return Character; } set { Character = value as Character; } }
    }
}
