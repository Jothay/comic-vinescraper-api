// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodePerson")]
    public class EpisodePerson : EntityBase, IEpisodePerson
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodePerson.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        IPerson IEpisodePerson.Person { get { return Person; } set { Person = value as Person; } }
    }
}
