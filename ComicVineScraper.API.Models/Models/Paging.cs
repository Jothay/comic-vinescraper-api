namespace ComicVineScraper.API.SearchModels
{
    using Interfaces.SearchModels;

    public class Paging : IPaging
    {
        public int Skip { get; set; }
        public int Take { get; set; }
    }
}
