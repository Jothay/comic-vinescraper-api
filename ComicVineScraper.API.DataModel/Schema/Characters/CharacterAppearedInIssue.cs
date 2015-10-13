// ReSharper disable ClassNeverInstantiated.Global, ClassWithVirtualMembersNeverInherited.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterAppearedInIssue")]
    public class CharacterAppearedInIssue : EntityBase, ICharacterAppearedInIssue
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterAppearedInIssue.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("AppearedInIssue")]
        public int AppearedInIssueId { get; set; }
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Issue AppearedInIssue { get; set; }
        IIssue ICharacterAppearedInIssue.AppearedInIssue { get { return AppearedInIssue; } set { AppearedInIssue = value as Issue; } }
    }
}
