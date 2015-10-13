// <copyright file="CharacterCreator.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the character creator class</summary>
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    /// <summary>A character creator.</summary>
    /// <seealso cref="T:ComicVineScraper.API.DataModel.Schema.Shared.EntityBase"/>
    /// <seealso cref="T:ComicVineScraper.API.Interfaces.DataModels.ICharacterCreator"/>
    [Table("Characters.CharacterCreator")]
    public class CharacterCreator : EntityBase, ICharacterCreator
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
        ICharacter ICharacterCreator.Character { get { return Character; } set { Character = value as Character; } }

        /// <summary>Gets or sets the identifier of the creator.</summary>
        /// <value>The identifier of the creator.</value>
        [InverseProperty("Id")][ForeignKey("Creator")]
        public int CreatorId { get; set; }

        /// <summary>Gets or sets the creator.</summary>
        /// <value>The creator.</value>
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Person Creator { get; set; }

        /// <summary>Gets or sets the creator.</summary>
        /// <value>The creator.</value>
        IPerson ICharacterCreator.Creator { get { return Creator; } set { Creator = value as Person; } }
        #endregion
    }
}
