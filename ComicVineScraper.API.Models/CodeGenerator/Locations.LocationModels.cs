// <auto-generated>
// <copyright file="Locations.LocationModels.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Location Model and Search Model concrete classes.</summary>
// <remarks>This file was auto-generated using ModelFileMaster.tt in
// ComicVineScraper.API.Models\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class LocationModel : NameableEntityModel, ILocationModel
    {
        // Location Properties
        public int? StartYear { get; set; }
        // Related Objects
        public int FirstIssueAppearanceId { get; set; }
        public IIssueModel FirstIssueAppearance { get; set; }
        public int PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        // Associated Objects
        public List<ILocationAliasModel> LocationAliases { get; set; }
        public List<ILocationAppearedInIssueModel> LocationAppearedInIssues { get; set; }
        public List<ILocationIssueModel> LocationIssues { get; set; }
        public List<ILocationMovieModel> LocationMovies { get; set; }
        public List<ILocationStoryArcModel> LocationStoryArcs { get; set; }
        public List<ILocationVolumeModel> LocationVolumes { get; set; }
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class LocationSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.ILocationSearchModel
    {
        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceId", IsRequired = false, Description = "Filter by the Related FirstIssueAppearanceId")]
        public int? FirstIssueAppearanceId { get; set; }

        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceCustomKey", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance CustomKey (Equals, Case-Insensitive)")]
        public string FirstIssueAppearanceCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceApiDetailUrl", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Api Detail Url (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceSiteDetailUrl", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Site Detail Url (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceName", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Name (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceName { get; set; }

        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceShortDescription", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Short Description (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "FirstIssueAppearanceDescription", IsRequired = false, Description = "Filter by the Related FirstIssueAppearance Description (Contains, Case-Insensitive)")]
        public string FirstIssueAppearanceDescription { get; set; }

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

    }
}
