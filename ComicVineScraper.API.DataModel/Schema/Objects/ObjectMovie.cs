// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Objects.ObjectMovie")]
    public class ObjectMovie : EntityBase, IObjectMovie
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IObjectMovie.Object { get { return Object; } set { Object = value as Object; } }

        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IObjectMovie.Movie { get { return Movie; } set { Movie = value as Movie; } }
    }
}
