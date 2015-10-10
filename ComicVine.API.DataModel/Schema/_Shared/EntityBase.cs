namespace ComicVine.API.DataModel.Schema.Shared
{
    using System;

    public class EntityBase : Interfaces.DataModels.IEntity
    {
        public int Id { get; set; }
        public string CustomKey { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }

        [StringIsUnicode(false)]
        [SearchableString]
        public string ApiDetailUrl { get; set; }

        [StringIsUnicode(false)]
        [SearchableString]
        public string SiteDetailUrl { get; set; }
    }
}
