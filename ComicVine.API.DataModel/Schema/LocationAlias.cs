namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.LocationAlias")]
    public partial class LocationAlias : NameableEntityBase, ILocationAlias
    {
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ILocationAlias.Location { get { return Location; } set { Location = value as Location; } }
    }
}
