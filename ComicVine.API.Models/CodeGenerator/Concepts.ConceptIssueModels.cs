// <auto-generated>
// <copyright file="Concepts.IConceptIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class ConceptIssueModel : EntityModel, IConceptIssueModel
    {
        // ConceptIssue Properties
        // <None>
        // Related Objects
        public int ConceptId { get; set; }
        public IConceptModel Concept { get; set; }
        public int IssueId { get; set; }
        public IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class ConceptIssueSearchModel : EntitySearchModel, Interfaces.SearchModels.IConceptIssueSearchModel
    {
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
