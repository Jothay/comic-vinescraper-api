// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Series.SeriesLocation")]
    public class SeriesLocation : EntityBase, ISeriesLocation
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Series")]
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        ISeries ISeriesLocation.Series { get { return Series; } set { Series = value as Series; } }

        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ISeriesLocation.Location { get { return Location; } set { Location = value as Location; } }
    }
}
