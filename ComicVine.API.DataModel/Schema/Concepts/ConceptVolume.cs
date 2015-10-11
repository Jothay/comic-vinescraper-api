// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Concepts.ConceptVolume")]
    public class ConceptVolume : EntityBase, IConceptVolume
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Concept")]
        public int ConceptId { get; set; }
        public virtual Concept Concept { get; set; }
        IConcept IConceptVolume.Concept { get { return Concept; } set { Concept = value as Concept; } }

        [InverseProperty("Id")][ForeignKey("Volume")]
        public int VolumeId { get; set; }
        public virtual Volume Volume { get; set; }
        IVolume IConceptVolume.Volume { get { return Volume; } set { Volume = value as Volume; } }
    }
}
