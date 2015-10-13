// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Episodes.EpisodeConcept")]
    public class EpisodeConcept : EntityBase, IEpisodeConcept
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Episode")]
        public int EpisodeId { get; set; }
        public virtual Episode Episode { get; set; }
        IEpisode IEpisodeConcept.Episode { get { return Episode; } set { Episode = value as Episode; } }

        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IEpisodeConcept.Concept { get { return Concept; } set { Concept = value as Concept; } }
    }
}
