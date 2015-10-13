namespace ComicVineScraper.API.Interfaces.DataModels
{
    public interface IEntity
    {
        int Id { get; set; }
        string CustomKey { get; set; }
        bool Active { get; set; }
        System.DateTime CreatedDate { get; set; }
        System.DateTime? UpdatedDate { get; set; }
        string ApiDetailUrl { get; set; }
        string SiteDetailUrl { get; set; }
    }
}
