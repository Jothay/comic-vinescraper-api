namespace ComicVineScraper.API.Interfaces.SearchModels
{
    using System;

    public interface IEntitySearchModel
    {
        int? Id { get; set; }
        string CustomKey { get; set; }
        string ApiDetailUrl { get; set; }
        string SiteDetailUrl { get; set; }
        DateTime? ModifiedSince { get; set; }
        IPaging Paging { get; set; }
    }
}
