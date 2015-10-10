namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.PersonAlias")]
    public partial class PersonAlias : NameableEntityBase, IPersonAlias
    {
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        IPerson IPersonAlias.Person { get { return Person; } set { Person = value as Person; } }
    }
}
