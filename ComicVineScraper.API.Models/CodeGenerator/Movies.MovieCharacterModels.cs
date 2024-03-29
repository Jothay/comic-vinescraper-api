// <auto-generated>
// <copyright file="Movies.MovieCharacterModels.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieCharacter Model and Search Model concrete classes.</summary>
// <remarks>This file was auto-generated using ModelFileMaster.tt in
// ComicVineScraper.API.Models\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class MovieCharacterModel : EntityModel, IMovieCharacterModel
    {
        // MovieCharacter Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class MovieCharacterSearchModel : EntitySearchModel, Interfaces.SearchModels.IMovieCharacterSearchModel
    {
        [ServiceStack.ApiMember(Name = "MovieId", IsRequired = false, Description = "Filter by the Related MovieId")]
        public int? MovieId { get; set; }

        [ServiceStack.ApiMember(Name = "MovieCustomKey", IsRequired = false, Description = "Filter by the Related Movie CustomKey (Equals, Case-Insensitive)")]
        public string MovieCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "MovieApiDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Api Detail Url (Contains, Case-Insensitive)")]
        public string MovieApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "MovieSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Movie Site Detail Url (Contains, Case-Insensitive)")]
        public string MovieSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "MovieName", IsRequired = false, Description = "Filter by the Related Movie Name (Contains, Case-Insensitive)")]
        public string MovieName { get; set; }

        [ServiceStack.ApiMember(Name = "MovieShortDescription", IsRequired = false, Description = "Filter by the Related Movie Short Description (Contains, Case-Insensitive)")]
        public string MovieShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "MovieDescription", IsRequired = false, Description = "Filter by the Related Movie Description (Contains, Case-Insensitive)")]
        public string MovieDescription { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterId", IsRequired = false, Description = "Filter by the Related CharacterId")]
        public int? CharacterId { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterCustomKey", IsRequired = false, Description = "Filter by the Related Character CustomKey (Equals, Case-Insensitive)")]
        public string CharacterCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Character Api Detail Url (Contains, Case-Insensitive)")]
        public string CharacterApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Character Site Detail Url (Contains, Case-Insensitive)")]
        public string CharacterSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterName", IsRequired = false, Description = "Filter by the Related Character Name (Contains, Case-Insensitive)")]
        public string CharacterName { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterShortDescription", IsRequired = false, Description = "Filter by the Related Character Short Description (Contains, Case-Insensitive)")]
        public string CharacterShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterDescription", IsRequired = false, Description = "Filter by the Related Character Description (Contains, Case-Insensitive)")]
        public string CharacterDescription { get; set; }

    }
}
