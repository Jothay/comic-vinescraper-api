// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Powers.PowerAlias")]
    public class PowerAlias : NameableEntityBase, IPowerAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Power")]
        public int PowerId { get; set; }
        public virtual Power Power { get; set; }
        IPower IPowerAlias.Power { get { return Power; } set { Power = value as Power; } }
    }
}
