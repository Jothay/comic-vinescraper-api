namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Series")]
    public partial class Series : NameableEntityBase, ISeries
    {
        public int Startyear { get; set; }

        // Related Objects
        public int? PublisherId { get; set; }
        public virtual Publisher Publisher { get; set; }
        IPublisher ISeries.Publisher { get { return Publisher; } set { Publisher = value as Publisher; } }
        public int? FirstEpisodeId { get; set; }
        public virtual Episode FirstEpisode { get; set; }
        IEpisode ISeries.FirstEpisode { get { return FirstEpisode; } set { FirstEpisode = value as Episode; } }
        public int? LastEpisodeId { get; set; }
        public virtual Episode LastEpisode { get; set; }
        IEpisode ISeries.LastEpisode { get { return LastEpisode; } set { LastEpisode = value as Episode; } }

        // Associated Objects
        public virtual ICollection<Character> CharacterCredits { get; set; }
        public virtual ICollection<Episode> Episodes { get; set; }
        public virtual ICollection<Location> LocationCredits { get; set; }
        public virtual ICollection<SeriesAlias> SeriesAliases { get; set; }

        ICollection<ICharacter> ISeries.CharacterCredits { get { return (ICollection<ICharacter>)CharacterCredits; } set { CharacterCredits = value as ICollection<Character>; } }
        ICollection<IEpisode> ISeries.Episodes { get { return (ICollection<IEpisode>)Episodes; } set { Episodes = value as ICollection<Episode>; } }
        ICollection<ILocation> ISeries.LocationCredits { get { return (ICollection<ILocation>)LocationCredits; } set { LocationCredits = value as ICollection<Location>; } }
        ICollection<ISeriesAlias> ISeries.SeriesAliases { get { return (ICollection<ISeriesAlias>)SeriesAliases; } set { SeriesAliases = value as ICollection<SeriesAlias>; } }
    }
}
