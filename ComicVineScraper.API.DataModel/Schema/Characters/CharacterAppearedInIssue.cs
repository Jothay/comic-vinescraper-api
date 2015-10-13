// <copyright file="CharacterAppearedInIssue.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the character appeared in issue class</summary>
namespace ComicVineScraper.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    /// <summary>A character appeared in issue.</summary>
    /// <seealso cref="T:ComicVineScraper.API.DataModel.Schema.Shared.EntityBase"/>
    /// <seealso cref="T:ComicVineScraper.API.Interfaces.DataModels.ICharacterAppearedInIssue"/>
    [Table("Characters.CharacterAppearedInIssue")]
    public class CharacterAppearedInIssue : EntityBase, ICharacterAppearedInIssue
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
        ICharacter ICharacterAppearedInIssue.Character { get { return Character; } set { Character = value as Character; } }

        /// <summary>Gets or sets the identifier of the appeared in issue.</summary>
        /// <value>The identifier of the appeared in issue.</value>
        [InverseProperty("Id")][ForeignKey("AppearedInIssue")]
        public int AppearedInIssueId { get; set; }

        /// <summary>Gets or sets the appeared in issue.</summary>
        /// <value>The appeared in issue.</value>
        [MapLiteDepthAllowed(Depth = 1)]
        public virtual Issue AppearedInIssue { get; set; }

        /// <summary>Gets or sets the appeared in issue.</summary>
        /// <value>The appeared in issue.</value>
        IIssue ICharacterAppearedInIssue.AppearedInIssue { get { return AppearedInIssue; } set { AppearedInIssue = value as Issue; } }
        #endregion
    }
}
