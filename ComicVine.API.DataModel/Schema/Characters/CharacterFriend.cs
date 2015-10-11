// ReSharper disable ClassNeverInstantiated.Global
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("Characters.CharacterFriend")]
    public class CharacterFriend : EntityBase, ICharacterFriend
    {
        // Related Objects
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }
        public virtual Character Character { get; set; }
        ICharacter ICharacterFriend.Character { get { return Character; } set { Character = value as Character; } }

        [InverseProperty("Id")][ForeignKey("Friend")]
        public int FriendId { get; set; }
        public virtual Character Friend { get; set; }
        ICharacter ICharacterFriend.Friend { get { return Friend; } set { Friend = value as Character; } }
    }
}
