// <copyright file="CharacterAlias.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the character alias class</summary>
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    /// <summary>A character alias.</summary>
    /// <seealso cref="T:ComicVineScraper.API.DataModel.Schema.Shared.NameableEntityBase"/>
    /// <seealso cref="T:ComicVineScraper.API.Interfaces.DataModels.ICharacterAlias"/>
    [Table("Characters.CharacterAlias")]
    public class CharacterAlias : NameableEntityBase, ICharacterAlias
    {
        #region Related Objects
        /// <summary>Gets or sets the identifier of the character.</summary>
        /// <value>The identifier of the character.</value>
        [InverseProperty("Id")][ForeignKey("Character")]
        public int CharacterId { get; set; }

        /// <summary>Gets or sets the character.</summary>
        /// <value>The character.</value>
        public virtual Character Character { get; set; }

        /// <summary>Gets or sets the character.</summary>
        /// <value>The character.</value>
        ICharacter ICharacterAlias.Character { get { return Character; } set { Character = value as Character; } }
        #endregion
    }
}
