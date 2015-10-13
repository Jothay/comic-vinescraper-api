// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Series.Series")]
    public class Series : NameableEntityBase, ISeries
    {
        [Index]
        public int Startyear { get; set; }

        // Related Objects
        [InverseProperty("Id")][ForeignKey("Publisher")]
        public int? PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher ISeries.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }

        [InverseProperty("Id")][ForeignKey("FirstEpisode")]
        public int? FirstEpisodeId { get; set; }
        public virtual Episode FirstEpisode { get; set; }
        IEpisode ISeries.FirstEpisode { get { return FirstEpisode; } set { FirstEpisode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("LastEpisode")]
        public int? LastEpisodeId { get; set; }
        public virtual Episode LastEpisode { get; set; }
        IEpisode ISeries.LastEpisode { get { return LastEpisode; } set { LastEpisode = value as Episode; } }

        // Associated Objects
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<SeriesAlias> SeriesAliases { get; set; }
        public virtual ICollection<SeriesCharacter> SeriesCharacters { get; set; }
        public virtual ICollection<SeriesLocation> SeriesLocations { get; set; }

        ICollection<IEpisode> ISeries.Episodes { get { return (ICollection<IEpisode>)Episodes; } set { Episodes = value as ICollection<Episode>; } }
        ICollection<ISeriesAlias> ISeries.SeriesAliases { get { return (ICollection<ISeriesAlias>)SeriesAliases; } set { SeriesAliases = value as ICollection<SeriesAlias>; } }
        ICollection<ISeriesCharacter> ISeries.SeriesCharacters { get { return (ICollection<ISeriesCharacter>)SeriesCharacters; } set { SeriesCharacters = value as ICollection<SeriesCharacter>; } }
        ICollection<ISeriesLocation> ISeries.SeriesLocations { get { return (ICollection<ISeriesLocation>)SeriesLocations; } set { SeriesLocations = value as ICollection<SeriesLocation>; } }
    }
}
