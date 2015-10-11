// <auto-generated>
// <copyright file="Characters.ICharacterIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterIssue : IEntity
    {
        // CharacterIssue Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacter Character { get; set; }
        int IssueId { get; set; }
        IIssue Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ICharacterIssueModel : IEntityModel
    {
        // CharacterIssue Properties
        // <None>
        // Related Objects
        int CharacterId { get; set; }
        ICharacterModel Character { get; set; }
        int IssueId { get; set; }
        IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ICharacterIssueSearchModel : IEntitySearchModel
    {
        int? CharacterId { get; set; }
        string CharacterCustomKey { get; set; }
        string CharacterApiDetailUrl { get; set; }
        string CharacterSiteDetailUrl { get; set; }
        string CharacterName { get; set; }
        string CharacterShortDescription { get; set; }
        string CharacterDescription { get; set; }
        int? IssueId { get; set; }
        string IssueCustomKey { get; set; }
        string IssueApiDetailUrl { get; set; }
        string IssueSiteDetailUrl { get; set; }
        string IssueName { get; set; }
        string IssueShortDescription { get; set; }
        string IssueDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ICharacterIssueMapper
        : IMapper<
            DataModels.ICharacterIssue,
            Models.ICharacterIssueModel,
            SearchModels.ICharacterIssueSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ICharacterIssuesRepository
        : IRepositoryBase
        , IRepository<DataModels.ICharacterIssue, SearchModels.ICharacterIssueSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ICharacterIssuesBusinessWorkflow
        : IBusinessWorkflow<Models.ICharacterIssueModel, SearchModels.ICharacterIssueSearchModel>
    {
    }
}
