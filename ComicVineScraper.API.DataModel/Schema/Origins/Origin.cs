// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Origins.Origin")]
    public class Origin : NameableEntityBase, IOrigin
    {
        public string CharacterSet { get; set; }

        // Associated Objects
        public virtual ICollection<OriginProfile> OriginProfiles { get; set; }

        ICollection<IOriginProfile> IOrigin.OriginProfiles { get { return (ICollection<IOriginProfile>)OriginProfiles; } set { OriginProfiles = value as ICollection<OriginProfile>; } }
    }
}
