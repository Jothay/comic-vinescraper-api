// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.MovieProducer")]
    public class MovieProducer : EntityBase, IMovieProducer
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IMovieProducer.Movie { get { return Movie; } set { Movie = value as Movie; } }

        [InverseProperty("Id")][ForeignKey("Producer")]
        public int ProducerId { get; set; }
        public virtual Person Producer { get; set; }
        IPerson IMovieProducer.Producer { get { return Producer; } set { Producer = value as Person; } }
    }
}
