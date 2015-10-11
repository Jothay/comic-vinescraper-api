// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterIssue")]
    public class CharacterDiedInIssue : EntityBase, ICharacterDiedInIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterDiedInIssue.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("DiedInIssue")]
        public int DiedInIssueId { get; set; }
        public virtual Issue DiedInIssue { get; set; }
        IIssue ICharacterDiedInIssue.DiedInIssue { get { return DiedInIssue; } set { DiedInIssue = value as Issue; } }
    }
}
