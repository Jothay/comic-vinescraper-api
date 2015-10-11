// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class EpisodeLocationModel : EntityModel, IEpisodeLocationModel
    {
        // EpisodeLocation Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class EpisodeLocationSearchModel : EntitySearchModel, Interfaces.SearchModels.IEpisodeLocationSearchModel
    {
        [ServiceStack.ApiMember(Name = "EpisodeId", IsRequired = false, Description = "Filter by the Related EpisodeId")]
        public int? EpisodeId { get; set; }

        [ServiceStack.ApiMember(Name = "EpisodeCustomKey", IsRequired = false, Description = "Filter by the Related Episode CustomKey (Equals, Case-Insensitive)")]
        public string EpisodeCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "EpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Episode Api Detail Url (Contains, Case-Insensitive)")]
        public string EpisodeApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "EpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Episode Site Detail Url (Contains, Case-Insensitive)")]
        public string EpisodeSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "EpisodeName", IsRequired = false, Description = "Filter by the Related Episode Name (Contains, Case-Insensitive)")]
        public string EpisodeName { get; set; }

        [ServiceStack.ApiMember(Name = "EpisodeShortDescription", IsRequired = false, Description = "Filter by the Related Episode Short Description (Contains, Case-Insensitive)")]
        public string EpisodeShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "EpisodeDescription", IsRequired = false, Description = "Filter by the Related Episode Description (Contains, Case-Insensitive)")]
        public string EpisodeDescription { get; set; }

        [ServiceStack.ApiMember(Name = "LocationId", IsRequired = false, Description = "Filter by the Related LocationId")]
        public int? LocationId { get; set; }

        [ServiceStack.ApiMember(Name = "LocationCustomKey", IsRequired = false, Description = "Filter by the Related Location CustomKey (Equals, Case-Insensitive)")]
        public string LocationCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "LocationApiDetailUrl", IsRequired = false, Description = "Filter by the Related Location Api Detail Url (Contains, Case-Insensitive)")]
        public string LocationApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "LocationSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Location Site Detail Url (Contains, Case-Insensitive)")]
        public string LocationSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "LocationName", IsRequired = false, Description = "Filter by the Related Location Name (Contains, Case-Insensitive)")]
        public string LocationName { get; set; }

        [ServiceStack.ApiMember(Name = "LocationShortDescription", IsRequired = false, Description = "Filter by the Related Location Short Description (Contains, Case-Insensitive)")]
        public string LocationShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "LocationDescription", IsRequired = false, Description = "Filter by the Related Location Description (Contains, Case-Insensitive)")]
        public string LocationDescription { get; set; }

    }
}
