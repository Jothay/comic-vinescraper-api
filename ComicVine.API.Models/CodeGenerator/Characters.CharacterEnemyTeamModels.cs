// <auto-generated>
// <copyright file="Characters.ICharacterEnemyTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemyTeam model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Models
{
    using System;
    using System.Collections.Generic;
    using Interfaces.Models;

    public partial class CharacterEnemyTeamModel : EntityModel, ICharacterEnemyTeamModel
    {
        // CharacterEnemyTeam Properties
        // <None>
        // Related Objects
        public int CharacterId { get; set; }
        public ICharacterModel Character { get; set; }
        public int EnemyTeamId { get; set; }
        public ITeamModel EnemyTeam { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.SearchModels
{
    public partial class CharacterEnemyTeamSearchModel : EntitySearchModel, Interfaces.SearchModels.ICharacterEnemyTeamSearchModel
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

        [ServiceStack.ApiMember(Name = "EnemyTeamId", IsRequired = false, Description = "Filter by the Related EnemyTeamId")]
        public int? EnemyTeamId { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyTeamCustomKey", IsRequired = false, Description = "Filter by the Related EnemyTeam CustomKey (Equals, Case-Insensitive)")]
        public string EnemyTeamCustomKey { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyTeamApiDetailUrl", IsRequired = false, Description = "Filter by the Related EnemyTeam Api Detail Url (Contains, Case-Insensitive)")]
        public string EnemyTeamApiDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyTeamSiteDetailUrl", IsRequired = false, Description = "Filter by the Related EnemyTeam Site Detail Url (Contains, Case-Insensitive)")]
        public string EnemyTeamSiteDetailUrl { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyTeamName", IsRequired = false, Description = "Filter by the Related EnemyTeam Name (Contains, Case-Insensitive)")]
        public string EnemyTeamName { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyTeamShortDescription", IsRequired = false, Description = "Filter by the Related EnemyTeam Short Description (Contains, Case-Insensitive)")]
        public string EnemyTeamShortDescription { get; set; }

        [ServiceStack.ApiMember(Name = "EnemyTeamDescription", IsRequired = false, Description = "Filter by the Related EnemyTeam Description (Contains, Case-Insensitive)")]
        public string EnemyTeamDescription { get; set; }

    }
}
