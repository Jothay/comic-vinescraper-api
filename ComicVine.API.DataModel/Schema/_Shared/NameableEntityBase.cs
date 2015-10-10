namespace ComicVine.API.DataModel.Schema.Shared
{
    using System.ComponentModel.DataAnnotations;

    public class NameableEntityBase : EntityBase, Interfaces.DataModels.INameableEntity
    {
        [Required]
        [SearchableString]
        public string Name { get; set; }

        [SearchableString]
        public string ShortDescription { get; set; }

        [SearchableString]
        public string Description { get; set; }
    }
}
