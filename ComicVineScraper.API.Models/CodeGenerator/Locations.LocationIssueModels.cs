// <auto-generated>
// <copyright file="Locations.LocationIssueModels.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationIssue Model and Search Model concrete classes.</summary>
// <remarks>This file was auto-generated using ModelFileMaster.tt in
// ComicVineScraper.API.Models\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class LocationIssueModel : EntityModel, ILocationIssueModel
    {
        // LocationIssue Properties
        // <None>
        // Related Objects
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class LocationIssueSearchModel : EntitySearchModel, Interfaces.SearchModels.ILocationIssueSearchModel
    {
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

        [ServiceStack.ApiMember(Name = "IssueId", IsRequired = false, Description = "Filter by the Related IssueId")]
        public int? IssueId { get; set; }

        [ServiceStack.ApiMember(Name = "IssueCustomKey", IsRequired = false, Description = "Filter by the Related Issue CustomKey (Equals, Case-Insensitive)")]
        public string IssueCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "IssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related Issue Api Detail Url (Contains, Case-Insensitive)")]
        public string IssueApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "IssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Issue Site Detail Url (Contains, Case-Insensitive)")]
        public string IssueSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "IssueName", IsRequired = false, Description = "Filter by the Related Issue Name (Contains, Case-Insensitive)")]
        public string IssueName { get; set; }

        [ServiceStack.ApiMember(Name = "IssueShortDescription", IsRequired = false, Description = "Filter by the Related Issue Short Description (Contains, Case-Insensitive)")]
        public string IssueShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "IssueDescription", IsRequired = false, Description = "Filter by the Related Issue Description (Contains, Case-Insensitive)")]
        public string IssueDescription { get; set; }

    }
}
