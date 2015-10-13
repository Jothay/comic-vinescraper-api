namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IPaging
    {
        int Skip { get; set; }
        int Take { get; set; }
    }
}