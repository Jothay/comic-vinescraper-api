// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("People.PersonAlias")]
    public class PersonAlias : NameableEntityBase, IPersonAlias
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Person")]
        public int PersonId { get; set; }
        public virtual Person Person { get; set; }
        IPerson IPersonAlias.Person { get { return Person; } set { Person = value as Person; } }
    }
}
