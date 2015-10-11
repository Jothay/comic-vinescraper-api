// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Powers.Power")]
    public class Power : NameableEntityBase, IPower
    {
        // Associated Objects
        public virtual ICollection<CharacterPower> CharacterPowers { get; set; }
        public virtual ICollection<PowerAlias> PowerAliases { get; set; }

        ICollection<ICharacterPower> IPower.CharacterPowers { get { return (ICollection<ICharacterPower>)CharacterPowers; } set { CharacterPowers = value as ICollection<CharacterPower>; } }
        ICollection<IPowerAlias> IPower.PowerAliases { get { return (ICollection<IPowerAlias>)PowerAliases; } set { PowerAliases = value as ICollection<PowerAlias>; } }
    }
}
