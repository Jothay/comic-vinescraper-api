// <auto-generated>
// <copyright file="People.ICreatorCharacterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CreatorCharacter model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICreatorCharacter : IEntity
    {
        // CreatorCharacter Properties
        // <None>
        // Related Objects
        int PersonId { get; set; }
        IPerson Creator { get; set; }
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

    public interface ICreatorCharacterModel : IEntityModel
    {
        // CreatorCharacter Properties
        // <None>
        // Related Objects
        int PersonId { get; set; }
        IPersonModel Creator { get; set; }
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ICreatorCharacterSearchModel : IEntitySearchModel
    {
        int? PersonId { get; set; }
        string CreatorApiDetailUrl { get; set; }
        string CreatorSiteDetailUrl { get; set; }
        string CreatorName { get; set; }
        string CreatorShortDescription { get; set; }
        string CreatorDescription { get; set; }
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
    public interface ICreatorCharacterMapper
        : IMapper<
            DataModels.ICreatorCharacter,
            Models.ICreatorCharacterModel,
            SearchModels.ICreatorCharacterSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ICreatorCharactersRepository
        : IRepositoryBase
        , IRepository<DataModels.ICreatorCharacter, SearchModels.ICreatorCharacterSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ICreatorCharactersBusinessWorkflow
        : IBusinessWorkflow<Models.ICreatorCharacterModel, SearchModels.ICreatorCharacterSearchModel>
    {
    }
}
