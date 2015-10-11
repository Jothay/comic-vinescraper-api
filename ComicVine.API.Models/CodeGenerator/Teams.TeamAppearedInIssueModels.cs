// <auto-generated>
// <copyright file="Teams.ITeamAppearedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamAppearedInIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class TeamAppearedInIssueModel : EntityModel, ITeamAppearedInIssueModel
    {
        // TeamAppearedInIssue Properties
        // <None>
        // Related Objects
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class TeamAppearedInIssueSearchModel : EntitySearchModel, Interfaces.SearchModels.ITeamAppearedInIssueSearchModel
    {
        [ServiceStack.ApiMember(Name = "TeamId", IsRequired = false, Description = "Filter by the Related TeamId")]
        public int? TeamId { get; set; }

        [ServiceStack.ApiMember(Name = "TeamCustomKey", IsRequired = false, Description = "Filter by the Related Team CustomKey (Equals, Case-Insensitive)")]
        public string TeamCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "TeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related Team Api Detail Url (Contains, Case-Insensitive)")]
        public string TeamApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "TeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Team Site Detail Url (Contains, Case-Insensitive)")]
        public string TeamSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "TeamName", IsRequired = false, Description = "Filter by the Related Team Name (Contains, Case-Insensitive)")]
        public string TeamName { get; set; }

        [ServiceStack.ApiMember(Name = "TeamShortDescription", IsRequired = false, Description = "Filter by the Related Team Short Description (Contains, Case-Insensitive)")]
        public string TeamShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "TeamDescription", IsRequired = false, Description = "Filter by the Related Team Description (Contains, Case-Insensitive)")]
        public string TeamDescription { get; set; }

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
