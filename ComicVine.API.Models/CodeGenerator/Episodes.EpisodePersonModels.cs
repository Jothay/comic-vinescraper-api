// <auto-generated>
// <copyright file="Episodes.IEpisodePersonModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodePerson model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class EpisodePersonModel : EntityModel, IEpisodePersonModel
    {
        // EpisodePerson Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int PersonId { get; set; }
        public IPersonModel Person { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class EpisodePersonSearchModel : EntitySearchModel, Interfaces.SearchModels.IEpisodePersonSearchModel
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

        [ServiceStack.ApiMember(Name = "PersonId", IsRequired = false, Description = "Filter by the Related PersonId")]
        public int? PersonId { get; set; }

        [ServiceStack.ApiMember(Name = "PersonCustomKey", IsRequired = false, Description = "Filter by the Related Person CustomKey (Equals, Case-Insensitive)")]
        public string PersonCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "PersonApiDetailUrl", IsRequired = false, Description = "Filter by the Related Person Api Detail Url (Contains, Case-Insensitive)")]
        public string PersonApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PersonSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Person Site Detail Url (Contains, Case-Insensitive)")]
        public string PersonSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PersonName", IsRequired = false, Description = "Filter by the Related Person Name (Contains, Case-Insensitive)")]
        public string PersonName { get; set; }

        [ServiceStack.ApiMember(Name = "PersonShortDescription", IsRequired = false, Description = "Filter by the Related Person Short Description (Contains, Case-Insensitive)")]
        public string PersonShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "PersonDescription", IsRequired = false, Description = "Filter by the Related Person Description (Contains, Case-Insensitive)")]
        public string PersonDescription { get; set; }

    }
}
