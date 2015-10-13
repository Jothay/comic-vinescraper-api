// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.MovieObject")]
    public class MovieObject : EntityBase, IMovieObject
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IMovieObject.Movie { get { return Movie; } set { Movie = value as Movie; } }

        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IMovieObject.Object { get { return Object; } set { Object = value as Object; } }
    }
}
