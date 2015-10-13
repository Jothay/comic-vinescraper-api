namespace ComicVineScraper.API.Models
{
    public class NameableEntityModel : EntityModel
        , Interfaces.Models.INameableEntityModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class NameableEntitySearchModel : EntitySearchModel
        , Interfaces.SearchModels.INameableEntitySearchModel
    {
        public string Name { get; set; }
        public string ShortDescription { get; set; }
        public string Description { get; set; }
    }
}
