// <auto-generated>
// <copyright file="Characters.ICharacterEnemyTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemyTeam model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterEnemyTeam : IEntity
    {
        // CharacterEnemyTeam Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacter Character { get; set; }
        int EnemyTeamId { get; set; }
        ITeam EnemyTeam { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterEnemyTeamModel : IEntityModel
    {
        // CharacterEnemyTeam Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        int EnemyTeamId { get; set; }
        ITeamModel EnemyTeam { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ICharacterEnemyTeamSearchModel : IEntitySearchModel
    {
        int? CharacterId { get; set; }
        string CharacterCustomKey { get; set; }
        string CharacterApiDetailUrl { get; set; }
        string CharacterSiteDetailUrl { get; set; }
        string CharacterName { get; set; }
        string CharacterShortDescription { get; set; }
        string CharacterDescription { get; set; }
        int? EnemyTeamId { get; set; }
        string EnemyTeamCustomKey { get; set; }
        string EnemyTeamApiDetailUrl { get; set; }
        string EnemyTeamSiteDetailUrl { get; set; }
        string EnemyTeamName { get; set; }
        string EnemyTeamShortDescription { get; set; }
        string EnemyTeamDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ICharacterEnemyTeamMapper
        : IMapper<
            DataModels.ICharacterEnemyTeam,
            Models.ICharacterEnemyTeamModel,
            SearchModels.ICharacterEnemyTeamSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ICharacterEnemyTeamsRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacterEnemyTeam, SearchModels.ICharacterEnemyTeamSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ICharacterEnemyTeamsBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterEnemyTeamModel, SearchModels.ICharacterEnemyTeamSearchModel>
    {
    }
}