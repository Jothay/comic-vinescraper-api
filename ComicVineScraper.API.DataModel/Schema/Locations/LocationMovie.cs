// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Locations.LocationMovie")]
    public class LocationMovie : EntityBase, ILocationMovie
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Location")]
        public int LocationId { get; set; }
        public virtual Location Location { get; set; }
        ILocation ILocationMovie.Location { get { return Location; } set { Location = value as Location; } }

        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie ILocationMovie.Movie { get { return Movie; } set { Movie = value as Movie; } }
    }
}
