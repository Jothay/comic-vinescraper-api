// <auto-generated>
// <copyright file="Episodes.IEpisodeConceptFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeConceptFirstAppearance model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class EpisodeConceptFirstAppearanceModel : EntityModel, IEpisodeConceptFirstAppearanceModel
    {
        // EpisodeConceptFirstAppearance Properties
        // <None>
        // Related Objects
        public int EpisodeId { get; set; }
        public IEpisodeModel Episode { get; set; }
        public int ConceptId { get; set; }
        public IConceptModel Concept { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class EpisodeConceptFirstAppearanceSearchModel : EntitySearchModel, Interfaces.SearchModels.IEpisodeConceptFirstAppearanceSearchModel
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

        [ServiceStack.ApiMember(Name = "ConceptId", IsRequired = false, Description = "Filter by the Related ConceptId")]
        public int? ConceptId { get; set; }

        [ServiceStack.ApiMember(Name = "ConceptCustomKey", IsRequired = false, Description = "Filter by the Related Concept CustomKey (Equals, Case-Insensitive)")]
        public string ConceptCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "ConceptApiDetailUrl", IsRequired = false, Description = "Filter by the Related Concept Api Detail Url (Contains, Case-Insensitive)")]
        public string ConceptApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "ConceptSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Concept Site Detail Url (Contains, Case-Insensitive)")]
        public string ConceptSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "ConceptName", IsRequired = false, Description = "Filter by the Related Concept Name (Contains, Case-Insensitive)")]
        public string ConceptName { get; set; }

        [ServiceStack.ApiMember(Name = "ConceptShortDescription", IsRequired = false, Description = "Filter by the Related Concept Short Description (Contains, Case-Insensitive)")]
        public string ConceptShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "ConceptDescription", IsRequired = false, Description = "Filter by the Related Concept Description (Contains, Case-Insensitive)")]
        public string ConceptDescription { get; set; }

    }
}
