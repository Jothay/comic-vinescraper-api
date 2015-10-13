// <auto-generated>
// <copyright file="Objects.IObjectAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class ObjectAliasModel : NameableEntityModel, IObjectAliasModel
    {
        // ObjectAlias Properties
        // <None>
        // Related Objects
        public int ObjectId { get; set; }
        public IObjectModel Object { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class ObjectAliasSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.IObjectAliasSearchModel
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

    }
}