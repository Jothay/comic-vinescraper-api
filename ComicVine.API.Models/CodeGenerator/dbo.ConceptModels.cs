// <auto-generated>
// <copyright file="dbo.IConceptModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Concept model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class ConceptModel : NameableEntityModel, IConceptModel
    {
        // Concept Properties
        public int StartYear { get; set; }
        // Related Objects
        public int? PrimaryImageId { get; set; }
        public IImageFileModel PrimaryImage { get; set; }
        public int FirstIssueAppearanceId { get; set; }
        public IIssueModel FirstIssueAppearance { get; set; }
        // Associated Objects
        public List<IConceptAliasModel> ConceptAliases { get; set; }
        public List<IIssueModel> IssueAppearances { get; set; }
        public List<IIssueModel> IssueCredits { get; set; }
        public List<IMovieModel> Movies { get; set; }
        public List<IVolumeModel> VolumeCredits { get; set; }
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class ConceptSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.IConceptSearchModel
    {
        [ServiceStack.ApiMember(Name = "PrimaryImageId", IsRequired = false, Description = "Filter by the Related PrimaryImageId")]
        public int? PrimaryImageId { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageCustomKey", IsRequired = false, Description = "Filter by the Related PrimaryImage CustomKey (Equals, Case-Insensitive)")]
        public string PrimaryImageCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageApiDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImage Api Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageSiteDetailUrl", IsRequired = false, Description = "Filter by the Related PrimaryImage Site Detail Url (Contains, Case-Insensitive)")]
        public string PrimaryImageSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageName", IsRequired = false, Description = "Filter by the Related PrimaryImage Name (Contains, Case-Insensitive)")]
        public string PrimaryImageName { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageShortDescription", IsRequired = false, Description = "Filter by the Related PrimaryImage Short Description (Contains, Case-Insensitive)")]
        public string PrimaryImageShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "PrimaryImageDescription", IsRequired = false, Description = "Filter by the Related PrimaryImage Description (Contains, Case-Insensitive)")]
        public string PrimaryImageDescription { get; set; }

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

    }
}