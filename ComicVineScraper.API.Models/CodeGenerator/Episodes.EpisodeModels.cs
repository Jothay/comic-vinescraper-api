// <auto-generated>
// <copyright file="Episodes.EpisodeModels.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Episode Model and Search Model concrete classes.</summary>
// <remarks>This file was auto-generated using ModelFileMaster.tt in
// ComicVineScraper.API.Models\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class EpisodeModel : NameableEntityModel, IEpisodeModel
    {
        // Episode Properties
        public bool HasStaffReview { get; set; }
        public DateTime? AirDate { get; set; }
        public string EpisodeCode { get; set; }
        public int? SeasonNumber { get; set; }
        public int? EpisodeNumber { get; set; }
        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int? SeriesId { get; set; }
        public ISeriesModel Series { get; set; }
        // Associated Objects
        public List<IEpisodeAliasModel> EpisodeAliases { get; set; }
        public List<IEpisodeCharacterModel> EpisodeCharacters { get; set; }
        public List<IEpisodeCharacterDiedModel> EpisodeCharactersDied { get; set; }
        public List<IEpisodeCharacterFirstAppearanceModel> EpisodeCharacterFirstAppearances { get; set; }
        public List<IEpisodeConceptModel> EpisodeConcepts { get; set; }
        public List<IEpisodeConceptFirstAppearanceModel> EpisodeConceptFirstAppearances { get; set; }
        public List<IEpisodeLocationModel> EpisodeLocations { get; set; }
        public List<IEpisodeLocationFirstAppearanceModel> EpisodeLocationFirstAppearances { get; set; }
        public List<IEpisodeObjectModel> EpisodeObjects { get; set; }
        public List<IEpisodeObjectFirstAppearanceModel> EpisodeObjectFirstAppearances { get; set; }
        public List<IEpisodePersonModel> EpisodePeople { get; set; }
        public List<IEpisodeStoryArcModel> EpisodeStoryArcs { get; set; }
        public List<IEpisodeStoryArcFirstAppearanceModel> EpisodeStoryArcFirstAppearances { get; set; }
        public List<IEpisodeTeamModel> EpisodeTeams { get; set; }
        public List<IEpisodeTeamFirstAppearanceModel> EpisodeTeamFirstAppearances { get; set; }
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class EpisodeSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.IEpisodeSearchModel
    {
        [ServiceStack.ApiMember(Name = "PrimaryImageFileId", IsRequired = false, Description = "Filter by the Related PrimaryImageFileId")]
        public int? PrimaryImageFileId { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageFileCustomKey", IsRequired = false, Description = "Filter by the Related PrimaryImageFile CustomKey (Equals, Case-Insensitive)")]
        public string PrimaryImageFileCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageFileApiDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Api Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageFileSiteDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Site Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageFileSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageFileName", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Name (Contains, Case-Insensitive)")]
        public string PrimaryImageFileName { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageFileShortDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Short Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageFileDescription", IsRequired = false, Description = "Filter by the Related PrimaryImageFile Description (Contains, Case-Insensitive)")]
        public string PrimaryImageFileDescription { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesId", IsRequired = false, Description = "Filter by the Related SeriesId")]
        public int? SeriesId { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesCustomKey", IsRequired = false, Description = "Filter by the Related Series CustomKey (Equals, Case-Insensitive)")]
        public string SeriesCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesApiDetailUrl", IsRequired = false, Description = "Filter by the Related Series Api Detail Url (Contains, Case-Insensitive)")]
        public string SeriesApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Series Site Detail Url (Contains, Case-Insensitive)")]
        public string SeriesSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesName", IsRequired = false, Description = "Filter by the Related Series Name (Contains, Case-Insensitive)")]
        public string SeriesName { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesShortDescription", IsRequired = false, Description = "Filter by the Related Series Short Description (Contains, Case-Insensitive)")]
        public string SeriesShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "SeriesDescription", IsRequired = false, Description = "Filter by the Related Series Description (Contains, Case-Insensitive)")]
        public string SeriesDescription { get; set; }

        [ServiceStack.ApiMember(Name = "HasStaffReview", IsRequired = false, Description = "The HasStaffReview to search by.")]
        public bool? HasStaffReview { get; set; }

    }
}
