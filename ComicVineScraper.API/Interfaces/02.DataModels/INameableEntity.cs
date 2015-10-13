namespace ComicVineScraper.API.Interfaces.DataModels
{
    public interface INameableEntity : IEntity
    {
        string Name { get; set; }
        string ShortDescription { get; set; }
        string Description { get; set; }
    }
}
