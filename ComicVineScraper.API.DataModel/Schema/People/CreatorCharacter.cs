// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("People.CreatorCharacter")]
    public class CreatorCharacter : EntityBase, ICreatorCharacter
    {
        // Related Origins
        [InverseProperty("Id")][ForeignKey("Creator")]
        public int PersonId { get; set; }
        public virtual Person Creator { get; set; }
        IPerson ICreatorCharacter.Creator { get { return Creator; } set { Creator = value as Person; } }

        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICreatorCharacter.Character { get { return Character; } set { Character = value as Character; } }
    }
}
