// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Objects.ObjectAlias")]
    public class ObjectAlias : NameableEntityBase, IObjectAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Object")]
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IObjectAlias.Object { get { return Object; } set { Object = value as Object; } }
    }
}
