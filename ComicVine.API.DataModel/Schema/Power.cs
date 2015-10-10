namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Power")]
    public partial class Power : NameableEntityBase, IPower
    {
        // Associated Objects
        public virtual ICollection<Character> Characters { get; set; }
        public virtual ICollection<PowerAlias> PowerAliases { get; set; }

        ICollection<ICharacter> IPower.Characters { get { return (ICollection<ICharacter>)Characters; } set { Characters = value as ICollection<Character>; } }
        ICollection<IPowerAlias> IPower.PowerAliases { get { return (ICollection<IPowerAlias>)PowerAliases; } set { PowerAliases = value as ICollection<PowerAlias>; } }
    }
}
