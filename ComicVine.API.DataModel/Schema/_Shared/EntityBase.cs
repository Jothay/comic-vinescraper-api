// <copyright file="EntityBase.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the entity base class</summary>
namespace ComicVine.API.DataModel.Schema.Shared
{
    using System;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    /// <summary>An entity base.</summary>
    /// <seealso cref="T:ComicVine.API.Interfaces.DataModels.IEntity"/>
    public class EntityBase : Interfaces.DataModels.IEntity
    {
        /// <summary>Gets or sets the identifier.</summary>
        /// <value>The identifier.</value>
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        /// <summary>Gets or sets the custom key.</summary>
        /// <value>The custom key.</value>
        [Index]
        public string CustomKey { get; set; }

        /// <summary>Gets or sets a value indicating whether the active.</summary>
        /// <value>true if active, false if not.</value>
        [Index]
        public bool Active { get; set; }

        /// <summary>Gets or sets the created date.</summary>
        /// <value>The created date.</value>
        public DateTime CreatedDate { get; set; }

        /// <summary>Gets or sets the updated date.</summary>
        /// <value>The updated date.</value>
        public DateTime? UpdatedDate { get; set; }

        /// <summary>Gets or sets URL of the API detail.</summary>
        /// <value>The API detail URL.</value>
        [Index]
        [StringIsUnicode(false)]
        [SearchableString]
        public string ApiDetailUrl { get; set; }

        /// <summary>Gets or sets URL of the site detail.</summary>
        /// <value>The site detail URL.</value>
        [Index]
        [StringIsUnicode(false)]
        [SearchableString]
        public string SiteDetailUrl { get; set; }
    }
}
