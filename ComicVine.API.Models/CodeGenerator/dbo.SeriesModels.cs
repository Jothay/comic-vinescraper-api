// <auto-generated>
// <copyright file="dbo.ISeriesModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Series model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class SeriesModel : NameableEntityModel, ISeriesModel
    {
        // Series Properties
        public int Startyear { get; set; }
        // Related Objects
        public int? PublisherId { get; set; }
        public IPublisherModel Publisher { get; set; }
        public int? FirstEpisodeId { get; set; }
        public IEpisodeModel FirstEpisode { get; set; }
        public int? LastEpisodeId { get; set; }
        public IEpisodeModel LastEpisode { get; set; }
        // Associated Objects
        public List<ICharacterModel> CharacterCredits { get; set; }
        public List<IEpisodeModel> Episodes { get; set; }
        public List<ILocationModel> LocationCredits { get; set; }
        public List<ISeriesAliasModel> SeriesAliases { get; set; }
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class SeriesSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.ISeriesSearchModel
    {
        [ServiceStack.ApiMember(Name = "PublisherId", IsRequired = false, Description = "Filter by the Related PublisherId")]
        public int? PublisherId { get; set; }

        [ServiceStack.ApiMember(Name = "PublisherCustomKey", IsRequired = false, Description = "Filter by the Related Publisher CustomKey (Equals, Case-Insensitive)")]
        public string PublisherCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "PublisherApiDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Api Detail Url (Contains, Case-Insensitive)")]
        public string PublisherApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PublisherSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Publisher Site Detail Url (Contains, Case-Insensitive)")]
        public string PublisherSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PublisherName", IsRequired = false, Description = "Filter by the Related Publisher Name (Contains, Case-Insensitive)")]
        public string PublisherName { get; set; }

        [ServiceStack.ApiMember(Name = "PublisherShortDescription", IsRequired = false, Description = "Filter by the Related Publisher Short Description (Contains, Case-Insensitive)")]
        public string PublisherShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "PublisherDescription", IsRequired = false, Description = "Filter by the Related Publisher Description (Contains, Case-Insensitive)")]
        public string PublisherDescription { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeId", IsRequired = false, Description = "Filter by the Related FirstEpisodeId")]
        public int? FirstEpisodeId { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeCustomKey", IsRequired = false, Description = "Filter by the Related FirstEpisode CustomKey (Equals, Case-Insensitive)")]
        public string FirstEpisodeCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related FirstEpisode Api Detail Url (Contains, Case-Insensitive)")]
        public string FirstEpisodeApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related FirstEpisode Site Detail Url (Contains, Case-Insensitive)")]
        public string FirstEpisodeSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeName", IsRequired = false, Description = "Filter by the Related FirstEpisode Name (Contains, Case-Insensitive)")]
        public string FirstEpisodeName { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeShortDescription", IsRequired = false, Description = "Filter by the Related FirstEpisode Short Description (Contains, Case-Insensitive)")]
        public string FirstEpisodeShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "FirstEpisodeDescription", IsRequired = false, Description = "Filter by the Related FirstEpisode Description (Contains, Case-Insensitive)")]
        public string FirstEpisodeDescription { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeId", IsRequired = false, Description = "Filter by the Related LastEpisodeId")]
        public int? LastEpisodeId { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeCustomKey", IsRequired = false, Description = "Filter by the Related LastEpisode CustomKey (Equals, Case-Insensitive)")]
        public string LastEpisodeCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeApiDetailUrl", IsRequired = false, Description = "Filter by the Related LastEpisode Api Detail Url (Contains, Case-Insensitive)")]
        public string LastEpisodeApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related LastEpisode Site Detail Url (Contains, Case-Insensitive)")]
        public string LastEpisodeSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeName", IsRequired = false, Description = "Filter by the Related LastEpisode Name (Contains, Case-Insensitive)")]
        public string LastEpisodeName { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeShortDescription", IsRequired = false, Description = "Filter by the Related LastEpisode Short Description (Contains, Case-Insensitive)")]
        public string LastEpisodeShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "LastEpisodeDescription", IsRequired = false, Description = "Filter by the Related LastEpisode Description (Contains, Case-Insensitive)")]
        public string LastEpisodeDescription { get; set; }

    }
}
