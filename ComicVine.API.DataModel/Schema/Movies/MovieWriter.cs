// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.MovieWriter")]
    public class MovieWriter : EntityBase, IMovieWriter
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IMovieWriter.Movie { get { return Movie; } set { Movie = value as Movie; } }

        [InverseProperty("Id")][ForeignKey("Writer")]
        public int WriterId { get; set; }
        public virtual Person Writer { get; set; }
        IPerson IMovieWriter.Writer { get { return Writer; } set { Writer = value as Person; } }
    }
}
