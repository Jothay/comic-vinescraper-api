namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.PowerAlias")]
    public partial class PowerAlias : NameableEntityBase, IPowerAlias
    {
        public int PowerId { get; set; }
        public virtual Power Power { get; set; }
        IPower IPowerAlias.Power { get { return Power; } set { Power = value as Power; } }
    }
}
