// <auto-generated>
// <copyright file="Publishers.IPublisherModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Publisher model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class PublisherModel : NameableEntityModel, IPublisherModel
    {
        // Publisher Properties
        public string LocationAddress { get; set; }
        public string LocationCity { get; set; }
        public string LocationState { get; set; }
        // Related Objects
        public int? PrimaryImageFileId { get; set; }
        public IImageFileModel PrimaryImageFile { get; set; }
        // Associated Objects
        public List<ICharacterModel> CharactersPublished { get; set; }
        public List<IPublisherAliasModel> PublisherAliases { get; set; }
        public List<ISeriesModel> SeriesPublished { get; set; }
        public List<IStoryArcModel> StoryArcsPublished { get; set; }
        public List<ITeamModel> TeamsPublished { get; set; }
        public List<IVolumeModel> VolumesPublished { get; set; }
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class PublisherSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.IPublisherSearchModel
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

    }
}