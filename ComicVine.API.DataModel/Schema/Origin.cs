namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Origin")]
    public partial class Origin : NameableEntityBase, IOrigin
    {
        public string CharacterSet { get; set; }

        // Associated Objects
        public virtual ICollection<Profile> Profiles { get; set; }

        ICollection<IProfile> IOrigin.Profiles { get { return (ICollection<IProfile>)Profiles; } set { Profiles = value as ICollection<Profile>; } }
    }
}
