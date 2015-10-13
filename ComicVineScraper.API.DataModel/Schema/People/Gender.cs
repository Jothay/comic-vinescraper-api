// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("People.Gender")]
    public class Gender : NameableEntityBase, IGender
    {
        // Associated Objects
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<Person> People { get; set; }

        ICollection<ICharacter> IGender.Characters { get { return (ICollection<ICharacter>)Characters; } set { Characters = value as ICollection<Character>; } }
        ICollection<IPerson> IGender.People { get { return (ICollection<IPerson>)People; } set { People = value as ICollection<Person>; } }
    }
}
