// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Promos.ResourceType")]
    public class ResourceType : NameableEntityBase, IResourceType
    {
        public string DetailResourceName { get; set; }
        public string ListResourceName { get; set; }

        // Associated Objects
        public virtual ICollection<Promo> Promos { get; set; }

        ICollection<IPromo> IResourceType.Promos { get { return (ICollection<IPromo>)Promos; } set { Promos = value as ICollection<Promo>; } }
    }
}
