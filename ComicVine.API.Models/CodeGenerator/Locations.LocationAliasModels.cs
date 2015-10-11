// <auto-generated>
// <copyright file="Locations.ILocationAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class LocationAliasModel : NameableEntityModel, ILocationAliasModel
    {
        // LocationAlias Properties
        // <None>
        // Related Objects
        public int LocationId { get; set; }
        public ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class LocationAliasSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.ILocationAliasSearchModel
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

    }
}
