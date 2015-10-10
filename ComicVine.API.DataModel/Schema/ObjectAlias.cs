namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.ObjectAlias")]
    public partial class ObjectAlias : NameableEntityBase, IObjectAlias
    {
        public int ObjectId { get; set; }
        public virtual Object Object { get; set; }
        IObject IObjectAlias.Object { get { return Object; } set { Object = value as Object; } }
    }
}
