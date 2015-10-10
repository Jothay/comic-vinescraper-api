namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.SeriesAlias")]
    public partial class SeriesAlias : NameableEntityBase, ISeriesAlias
    {
        public int SeriesId { get; set; }
        public virtual Series Series { get; set; }
        ISeries ISeriesAlias.Series { get { return Series; } set { Series = value as Series; } }
    }
}
