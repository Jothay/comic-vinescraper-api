namespace ComicVineScraper.API.Interfaces.Models
{
    public interface IEntityModel
    {
        int? Id { get; set; }
        string CustomKey { get; set; }
        bool Active { get; set; }
        System.DateTime CreatedDate { get; set; }
        System.DateTime? UpdatedDate { get; set; }
        string ApiDetailUrl { get; set; }
        string SiteDetailUrl { get; set; }
    }
}