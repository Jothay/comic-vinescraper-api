// <auto-generated>
// <copyright file="Movies.IMovieStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieStoryArc model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class MovieStoryArcModel : EntityModel, IMovieStoryArcModel
    {
        // MovieStoryArc Properties
        // <None>
        // Related Objects
        public int MovieId { get; set; }
        public IMovieModel Movie { get; set; }
        public int StoryArcId { get; set; }
        public IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class MovieStoryArcSearchModel : EntitySearchModel, Interfaces.SearchModels.IMovieStoryArcSearchModel
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

        [ServiceStack.ApiMember(Name = "StoryArcId", IsRequired = false, Description = "Filter by the Related StoryArcId")]
        public int? StoryArcId { get; set; }

        [ServiceStack.ApiMember(Name = "StoryArcCustomKey", IsRequired = false, Description = "Filter by the Related StoryArc CustomKey (Equals, Case-Insensitive)")]
        public string StoryArcCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "StoryArcApiDetailUrl", IsRequired = false, Description = "Filter by the Related StoryArc Api Detail Url (Contains, Case-Insensitive)")]
        public string StoryArcApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "StoryArcSiteDetailUrl", IsRequired = false, Description = "Filter by the Related StoryArc Site Detail Url (Contains, Case-Insensitive)")]
        public string StoryArcSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "StoryArcName", IsRequired = false, Description = "Filter by the Related StoryArc Name (Contains, Case-Insensitive)")]
        public string StoryArcName { get; set; }

        [ServiceStack.ApiMember(Name = "StoryArcShortDescription", IsRequired = false, Description = "Filter by the Related StoryArc Short Description (Contains, Case-Insensitive)")]
        public string StoryArcShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "StoryArcDescription", IsRequired = false, Description = "Filter by the Related StoryArc Description (Contains, Case-Insensitive)")]
        public string StoryArcDescription { get; set; }

    }
}