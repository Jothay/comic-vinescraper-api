// <auto-generated>
// <copyright file="Teams.TeamCharacterEnemyModels.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamCharacterEnemy Model and Search Model concrete classes.</summary>
// <remarks>This file was auto-generated using ModelFileMaster.tt in
// ComicVineScraper.API.Models\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class TeamCharacterEnemyModel : EntityModel, ITeamCharacterEnemyModel
    {
        // TeamCharacterEnemy Properties
        // <None>
        // Related Objects
        public int TeamId { get; set; }
        public ITeamModel Team { get; set; }
        public int EnemyId { get; set; }
        public ICharacterModel Enemy { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.SearchModels
{
    public partial class TeamCharacterEnemySearchModel : EntitySearchModel, Interfaces.SearchModels.ITeamCharacterEnemySearchModel
    {
        [ServiceStack.ApiMember(Name = "TeamId", IsRequired = false, Description = "Filter by the Related TeamId")]
        public int? TeamId { get; set; }

        [ServiceStack.ApiMember(Name = "TeamCustomKey", IsRequired = false, Description = "Filter by the Related Team CustomKey (Equals, Case-Insensitive)")]
        public string TeamCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "TeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related Team Api Detail Url (Contains, Case-Insensitive)")]
        public string TeamApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "TeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related Team Site Detail Url (Contains, Case-Insensitive)")]
        public string TeamSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "TeamName", IsRequired = false, Description = "Filter by the Related Team Name (Contains, Case-Insensitive)")]
        public string TeamName { get; set; }

        [ServiceStack.ApiMember(Name = "TeamShortDescription", IsRequired = false, Description = "Filter by the Related Team Short Description (Contains, Case-Insensitive)")]
        public string TeamShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "TeamDescription", IsRequired = false, Description = "Filter by the Related Team Description (Contains, Case-Insensitive)")]
        public string TeamDescription { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyId", IsRequired = false, Description = "Filter by the Related EnemyId")]
        public int? EnemyId { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyCustomKey", IsRequired = false, Description = "Filter by the Related Enemy CustomKey (Equals, Case-Insensitive)")]
        public string EnemyCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyApiDetailUrl", IsRequired = false, Description = "Filter by the Related Enemy Api Detail Url (Contains, Case-Insensitive)")]
        public string EnemyApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "EnemySiteDetailUrl", IsRequired = false, Description = "Filter by the Related Enemy Site Detail Url (Contains, Case-Insensitive)")]
        public string EnemySiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyName", IsRequired = false, Description = "Filter by the Related Enemy Name (Contains, Case-Insensitive)")]
        public string EnemyName { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyShortDescription", IsRequired = false, Description = "Filter by the Related Enemy Short Description (Contains, Case-Insensitive)")]
        public string EnemyShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyDescription", IsRequired = false, Description = "Filter by the Related Enemy Description (Contains, Case-Insensitive)")]
        public string EnemyDescription { get; set; }

    }
}
