// <auto-generated>
// <copyright file="Volumes.IVolumeObjectModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeObject model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class VolumeObjectModel : EntityModel, IVolumeObjectModel
    {
        // VolumeObject Properties
        // <None>
        // Related Objects
        public int VolumeId { get; set; }
        public IVolumeModel Volume { get; set; }
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class VolumeObjectSearchModel : EntitySearchModel, Interfaces.SearchModels.IVolumeObjectSearchModel
    {
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

    }
}
