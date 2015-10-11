

// <auto-generated>
// <copyright file="Characters.ICharacterEnemyModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterEnemy model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterEnemy : IEntity
    {
        // CharacterEnemy Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacter Character { get; set; }
        int EnemyId { get; set; }
        ICharacter Enemy { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterEnemyModel : IEntityModel
    {
        // CharacterEnemy Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        int EnemyId { get; set; }
        ICharacterModel Enemy { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ICharacterEnemySearchModel : IEntitySearchModel
    {
        int? CharacterId { get; set; }
        string CharacterCustomKey { get; set; }
        string CharacterApiDetailUrl { get; set; }
        string CharacterSiteDetailUrl { get; set; }
        string CharacterName { get; set; }
        string CharacterShortDescription { get; set; }
        string CharacterDescription { get; set; }
        int? EnemyId { get; set; }
        string EnemyCustomKey { get; set; }
        string EnemyApiDetailUrl { get; set; }
        string EnemySiteDetailUrl { get; set; }
        string EnemyName { get; set; }
        string EnemyShortDescription { get; set; }
        string EnemyDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ICharacterEnemyMapper
        : IMapper<
            DataModels.ICharacterEnemy,
            Models.ICharacterEnemyModel,
            SearchModels.ICharacterEnemySearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ICharacterEnemiesRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacterEnemy, SearchModels.ICharacterEnemySearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ICharacterEnemiesBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterEnemyModel, SearchModels.ICharacterEnemySearchModel>
    {
    }
}