namespace ComicVineScraper.API.Models
{
    using System;

    public class EntityModel : Interfaces.Models.IEntityModel
    {
        public int? Id { get; set; }
        public string CustomKey { get; set; }
        public string ApiDetailUrl { get; set; }
        public string SiteDetailUrl { get; set; }
        public bool Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
    }
}

namespace ComicVineScraper.API.SearchModels
{
    using System;
    using Interfaces.SearchModels;

    public partial class EntitySearchModel : IEntitySearchModel
    {
        public int? Id { get; set; }
        public string CustomKey { get; set; }
        public string ApiDetailUrl { get; set; }
        public string SiteDetailUrl { get; set; }
        public DateTime? ModifiedSince { get; set; }
        public IPaging Paging { get; set; }
    }
}
