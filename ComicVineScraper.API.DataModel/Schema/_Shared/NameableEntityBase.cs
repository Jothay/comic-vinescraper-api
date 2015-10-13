// <copyright file="NameableEntityBase.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the nameable entity base class</summary>
namespace ComicVineScraper.API.DataModel.Schema.Shared
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>A nameable entity base.</summary>
    /// <seealso cref="T:ComicVineScraper.API.DataModel.Schema.Shared.EntityBase"/>
    /// <seealso cref="T:ComicVineScraper.API.Interfaces.DataModels.INameableEntity"/>
    public class NameableEntityBase : EntityBase, Interfaces.DataModels.INameableEntity
    {
        /// <summary>Gets or sets the name.</summary>
        /// <value>The name.</value>
        [Index]
        [Required]
        [SearchableString]
        public string Name { get; set; }

        /// <summary>Gets or sets information describing the short.</summary>
        /// <value>Information describing the short.</value>
        [SearchableString]
        public string ShortDescription { get; set; }

        /// <summary>Gets or sets the description.</summary>
        /// <value>The description.</value>
        [SearchableString]
        public string Description { get; set; }
    }
}
