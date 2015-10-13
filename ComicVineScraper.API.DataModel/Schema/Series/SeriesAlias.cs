// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Series.SeriesAlias")]
    public class SeriesAlias : NameableEntityBase, ISeriesAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Series")]
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        ISeries ISeriesAlias.Series { get { return Series; } set { Series = value as Series; } }
    }
}
