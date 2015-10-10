// <copyright file="Author.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the author class</summary>
namespace ComicVine.API.DataModel.Schema
{
    using System.ComponentModel.DataAnnotations.Schema;
    using Interfaces.DataModels;
    using Shared;

    [Table("dbo.Author")]
    public partial class Author : NameableEntityBase, IAuthor
    {
        // No Author specific properties
    }
}
