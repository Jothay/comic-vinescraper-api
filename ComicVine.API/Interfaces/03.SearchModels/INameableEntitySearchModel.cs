namespace ComicVine.API.Interfaces.SearchModels
{
    public interface INameableEntitySearchModel : IEntitySearchModel
    {
        string Name { get; set; }
        string ShortDescription { get; set; }
        string Description { get; set; }
    }
}
