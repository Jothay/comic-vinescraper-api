// <auto-generated>
// <copyright file="Characters.ICharacterVolumeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterVolume model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>

namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class CharacterVolumeModel : EntityModel, ICharacterVolumeModel
    {
        // CharacterVolume Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class CharacterVolumeSearchModel : EntitySearchModel, Interfaces.SearchModels.ICharacterVolumeSearchModel
    {
        [ServiceStack.ApiMember(Name = "CharacterId", IsRequired = false, Description = "Filter by the Related CharacterId")]
        public int? CharacterId { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterCustomKey", IsRequired = false, Description = "Filter by the Related Character CustomKey (Equals, Case-Insensitive)")]
        public string CharacterCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterApiDetailUrl", IsRequired = false, Description = "Filter by the Related Character Api Detail Url (Contains, Case-Insensitive)")]
        public string CharacterApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Character Site Detail Url (Contains, Case-Insensitive)")]
        public string CharacterSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterName", IsRequired = false, Description = "Filter by the Related Character Name (Contains, Case-Insensitive)")]
        public string CharacterName { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterShortDescription", IsRequired = false, Description = "Filter by the Related Character Short Description (Contains, Case-Insensitive)")]
        public string CharacterShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "CharacterDescription", IsRequired = false, Description = "Filter by the Related Character Description (Contains, Case-Insensitive)")]
        public string CharacterDescription { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeId", IsRequired = false, Description = "Filter by the Related VolumeId")]
        public int? VolumeId { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeCustomKey", IsRequired = false, Description = "Filter by the Related Volume CustomKey (Equals, Case-Insensitive)")]
        public string VolumeCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeApiDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Api Detail Url (Contains, Case-Insensitive)")]
        public string VolumeApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Volume Site Detail Url (Contains, Case-Insensitive)")]
        public string VolumeSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeName", IsRequired = false, Description = "Filter by the Related Volume Name (Contains, Case-Insensitive)")]
        public string VolumeName { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeShortDescription", IsRequired = false, Description = "Filter by the Related Volume Short Description (Contains, Case-Insensitive)")]
        public string VolumeShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "VolumeDescription", IsRequired = false, Description = "Filter by the Related Volume Description (Contains, Case-Insensitive)")]
        public string VolumeDescription { get; set; }

    }
}
