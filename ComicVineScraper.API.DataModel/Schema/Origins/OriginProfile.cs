// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Origins.Origin")]
    public class OriginProfile : EntityBase, IOriginProfile
    {
        // Related Origins
        [InverseProperty("Id")][ForeignKey("Origin")]
        public int OriginId { get; set; }
        public virtual Origin Origin { get; set; }
        IOrigin IOriginProfile.Origin { get { return Origin; } set { Origin = value as Origin; } }

        [InverseProperty("Id")][ForeignKey("Profile")]
        public int ProfileId { get; set; }
        public virtual Profile Profile { get; set; }
        IProfile IOriginProfile.Profile { get { return Profile; } set { Profile = value as Profile; } }
    }
}
