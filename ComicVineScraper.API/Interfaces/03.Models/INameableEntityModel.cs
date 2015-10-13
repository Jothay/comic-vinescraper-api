namespace ComicVine.API.Interfaces.Models
{
    public interface INameableEntityModel : IEntityModel
    {
        string Name { get; set; }
        string ShortDescription { get; set; }
        string Description { get; set; }
    }
}
