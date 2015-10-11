// <auto-generated>
// <copyright file="Objects.IObjectAppearedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectAppearedInIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class ObjectAppearedInIssueModel : EntityModel, IObjectAppearedInIssueModel
    {
        // ObjectAppearedInIssue Properties
        // <None>
        // Related Objects
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        public int AppearedInIssueId { get; set; }
        public IIssueModel AppearedInIssue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class ObjectAppearedInIssueSearchModel : EntitySearchModel, Interfaces.SearchModels.IObjectAppearedInIssueSearchModel
    {
        [ServiceStack.ApiMember(Name = "ObjectId", IsRequired = false, Description = "Filter by the Related ObjectId")]
        public int? ObjectId { get; set; }

        [ServiceStack.ApiMember(Name = "ObjectCustomKey", IsRequired = false, Description = "Filter by the Related Object CustomKey (Equals, Case-Insensitive)")]
        public string ObjectCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "ObjectApiDetailUrl", IsRequired = false, Description = "Filter by the Related Object Api Detail Url (Contains, Case-Insensitive)")]
        public string ObjectApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "ObjectSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Object Site Detail Url (Contains, Case-Insensitive)")]
        public string ObjectSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "ObjectName", IsRequired = false, Description = "Filter by the Related Object Name (Contains, Case-Insensitive)")]
        public string ObjectName { get; set; }

        [ServiceStack.ApiMember(Name = "ObjectShortDescription", IsRequired = false, Description = "Filter by the Related Object Short Description (Contains, Case-Insensitive)")]
        public string ObjectShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "ObjectDescription", IsRequired = false, Description = "Filter by the Related Object Description (Contains, Case-Insensitive)")]
        public string ObjectDescription { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueId", IsRequired = false, Description = "Filter by the Related AppearedInIssueId")]
        public int? AppearedInIssueId { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueCustomKey", IsRequired = false, Description = "Filter by the Related AppearedInIssue CustomKey (Equals, Case-Insensitive)")]
        public string AppearedInIssueCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueApiDetailUrl", IsRequired = false, Description = "Filter by the Related AppearedInIssue Api Detail Url (Contains, Case-Insensitive)")]
        public string AppearedInIssueApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueSiteDetailUrl", IsRequired = false, Description = "Filter by the Related AppearedInIssue Site Detail Url (Contains, Case-Insensitive)")]
        public string AppearedInIssueSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueName", IsRequired = false, Description = "Filter by the Related AppearedInIssue Name (Contains, Case-Insensitive)")]
        public string AppearedInIssueName { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueShortDescription", IsRequired = false, Description = "Filter by the Related AppearedInIssue Short Description (Contains, Case-Insensitive)")]
        public string AppearedInIssueShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "AppearedInIssueDescription", IsRequired = false, Description = "Filter by the Related AppearedInIssue Description (Contains, Case-Insensitive)")]
        public string AppearedInIssueDescription { get; set; }

    }
}
