// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Profiles.Profile")]
    public class Profile : NameableEntityBase, IProfile
    {
        // Associated Objects
        public virtual ICollection<OriginProfile> OriginProfiles { get; set; }

        ICollection<IOriginProfile> IProfile.OriginProfiles { get { return (ICollection<IOriginProfile>)OriginProfiles; } set { OriginProfiles = value as ICollection<OriginProfile>; } }
    }
}
