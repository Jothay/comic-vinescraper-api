// <auto-generated>
// <copyright file="Characters.CharacterTeamInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterTeam interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterTeam : IEntity
    {
        // CharacterTeam Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacter Character { get; set; }
        int TeamId { get; set; }
        ITeam Team { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterTeamModel : IEntityModel
    {
        // CharacterTeam Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        int TeamId { get; set; }
        ITeamModel Team { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface ICharacterTeamSearchModel : IEntitySearchModel
    {
        int? CharacterId { get; set; }
        string CharacterCustomKey { get; set; }
        string CharacterApiDetailUrl { get; set; }
        string CharacterSiteDetailUrl { get; set; }
        string CharacterName { get; set; }
        string CharacterShortDescription { get; set; }
        string CharacterDescription { get; set; }
        int? TeamId { get; set; }
        string TeamCustomKey { get; set; }
        string TeamApiDetailUrl { get; set; }
        string TeamSiteDetailUrl { get; set; }
        string TeamName { get; set; }
        string TeamShortDescription { get; set; }
        string TeamDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface ICharacterTeamMapper
        : IMapper<
            DataModels.ICharacterTeam,
            Models.ICharacterTeamModel,
            SearchModels.ICharacterTeamSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface ICharacterTeamsRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacterTeam, SearchModels.ICharacterTeamSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface ICharacterTeamsBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterTeamModel, SearchModels.ICharacterTeamSearchModel>
    {
    }
}
