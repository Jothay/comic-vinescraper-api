// <auto-generated>
// <copyright file="Origins.OriginModels.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Origin Model and Search Model concrete classes.</summary>
// <remarks>This file was auto-generated using ModelFileMaster.tt in
// ComicVineScraper.API.Models\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class OriginModel : NameableEntityModel, IOriginModel
    {
        // Origin Properties
        public string CharacterSet { get; set; }
        // Related Objects
        // <None>
        // Associated Objects
        public List<IOriginProfileModel> OriginProfiles { get; set; }
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class OriginSearchModel : NameableEntitySearchModel, Interfaces.SearchModels.IOriginSearchModel
    {
        // No Origin Search Properties
    }
}
