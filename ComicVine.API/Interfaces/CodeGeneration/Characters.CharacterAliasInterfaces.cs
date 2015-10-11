// <auto-generated>
// <copyright file="Characters.ICharacterAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterAlias : INameableEntity
    {
        // CharacterAlias Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacter Character { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterAliasModel : INameableEntityModel
    {
        // CharacterAlias Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ICharacterAliasSearchModel : INameableEntitySearchModel
    {
        int? CharacterId { get; set; }
        string CharacterCustomKey { get; set; }
        string CharacterApiDetailUrl { get; set; }
        string CharacterSiteDetailUrl { get; set; }
        string CharacterName { get; set; }
        string CharacterShortDescription { get; set; }
        string CharacterDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ICharacterAliasMapper
        : IMapper<
            DataModels.ICharacterAlias,
            Models.ICharacterAliasModel,
            SearchModels.ICharacterAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ICharacterAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacterAlias, SearchModels.ICharacterAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ICharacterAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterAliasModel, SearchModels.ICharacterAliasSearchModel>
    {
    }
}