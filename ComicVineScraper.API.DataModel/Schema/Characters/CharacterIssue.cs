// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterIssue")]
    public class CharacterIssue : EntityBase, ICharacterIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterIssue.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Issue")]
        public int IssueId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Issue Issue { get; set; }
        IIssue ICharacterIssue.Issue { get { return Issue; } set { Issue = value as Issue; } }
    }
}
