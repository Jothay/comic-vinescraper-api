// <auto-generated>
// <copyright file="dbo.IPersonModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Person model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class PersonModel : NameableEntityModel, IPersonModel
    {
        // Person Properties
        public string Hometown { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Website { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? DeathDate { get; set; }
        // Related Objects
        public int PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        public int? GenderId { get; set; }
        public IGenderModel Gender { get; set; }
        // Associated Objects
        public List<ICharacterModel> CharactersCreated { get; set; }
        public List<IIssueModel> IssueAppearances { get; set; }
        public List<IIssueModel> IssueCredits { get; set; }
        public List<IPersonAliasModel> PersonAliases { get; set; }
        public List<IStoryArcModel> StoryArcCredits { get; set; }
        public List<IVolumeModel> VolumeCredits { get; set; }
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class PersonSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.IPersonSearchModel
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

        [ServiceStack.ApiMember(Name = "GenderId", IsRequired = false, Description = "Filter by the Related GenderId")]
        public int? GenderId { get; set; }

        [ServiceStack.ApiMember(Name = "GenderCustomKey", IsRequired = false, Description = "Filter by the Related Gender CustomKey (Equals, Case-Insensitive)")]
        public string GenderCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "GenderApiDetailUrl", IsRequired = false, Description = "Filter by the Related Gender Api Detail Url (Contains, Case-Insensitive)")]
        public string GenderApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "GenderSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Gender Site Detail Url (Contains, Case-Insensitive)")]
        public string GenderSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "GenderName", IsRequired = false, Description = "Filter by the Related Gender Name (Contains, Case-Insensitive)")]
        public string GenderName { get; set; }

        [ServiceStack.ApiMember(Name = "GenderShortDescription", IsRequired = false, Description = "Filter by the Related Gender Short Description (Contains, Case-Insensitive)")]
        public string GenderShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "GenderDescription", IsRequired = false, Description = "Filter by the Related Gender Description (Contains, Case-Insensitive)")]
        public string GenderDescription { get; set; }

    }
}