// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.MovieStudio")]
    public class MovieStudio : EntityBase, IMovieStudio
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IMovieStudio.Movie { get { return Movie; } set { Movie = value as Movie; } }

        [InverseProperty("Id")][ForeignKey("Studio")]
        public int StudioId { get; set; }
        public virtual Studio Studio { get; set; }
        IStudio IMovieStudio.Studio { get { return Studio; } set { Studio = value as Studio; } }
    }
}
