// <auto-generated>
// <copyright file="Characters.ICharacterCreatorModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterCreator model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterCreator : IEntity
    {
        // CharacterCreator Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacter Character { get; set; }
        int CreatorId { get; set; }
        IPerson Creator { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterCreatorModel : IEntityModel
    {
        // CharacterCreator Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        int CreatorId { get; set; }
        IPersonModel Creator { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ICharacterCreatorSearchModel : IEntitySearchModel
    {
        int? CharacterId { get; set; }
        string CharacterCustomKey { get; set; }
        string CharacterApiDetailUrl { get; set; }
        string CharacterSiteDetailUrl { get; set; }
        string CharacterName { get; set; }
        string CharacterShortDescription { get; set; }
        string CharacterDescription { get; set; }
        int? CreatorId { get; set; }
        string CreatorCustomKey { get; set; }
        string CreatorApiDetailUrl { get; set; }
        string CreatorSiteDetailUrl { get; set; }
        string CreatorName { get; set; }
        string CreatorShortDescription { get; set; }
        string CreatorDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ICharacterCreatorMapper
        : IMapper<
            DataModels.ICharacterCreator,
            Models.ICharacterCreatorModel,
            SearchModels.ICharacterCreatorSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ICharacterCreatorsRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacterCreator, SearchModels.ICharacterCreatorSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ICharacterCreatorsBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterCreatorModel, SearchModels.ICharacterCreatorSearchModel>
    {
    }
}