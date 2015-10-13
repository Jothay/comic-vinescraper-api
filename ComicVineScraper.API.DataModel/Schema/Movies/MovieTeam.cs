// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Movies.MovieTeam")]
    public class MovieTeam : EntityBase, IMovieTeam
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Movie")]
        public int MovieId { get; set; }
        public virtual Movie Movie { get; set; }
        IMovie IMovieTeam.Movie { get { return Movie; } set { Movie = value as Movie; } }

        [InverseProperty("Id")][ForeignKey("Team")]
        public int TeamId { get; set; }
        public virtual Team Team { get; set; }
        ITeam IMovieTeam.Team { get { return Team; } set { Team = value as Team; } }
    }
}
