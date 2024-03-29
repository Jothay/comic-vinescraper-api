// <auto-generated>
// <copyright file="Episodes.EpisodeAliasInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeAlias interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeAlias : INameableEntity
    {
        // EpisodeAlias Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisode Episode { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeAliasModel : INameableEntityModel
    {
        // EpisodeAlias Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisodeModel Episode { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IEpisodeAliasSearchModel : INameableEntitySearchModel
    {
        int? EpisodeId { get; set; }
        string EpisodeCustomKey { get; set; }
        string EpisodeApiDetailUrl { get; set; }
        string EpisodeSiteDetailUrl { get; set; }
        string EpisodeName { get; set; }
        string EpisodeShortDescription { get; set; }
        string EpisodeDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IEpisodeAliasMapper
        : IMapper<
            DataModels.IEpisodeAlias,
            Models.IEpisodeAliasModel,
            SearchModels.IEpisodeAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IEpisodeAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.IEpisodeAlias, SearchModels.IEpisodeAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IEpisodeAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.IEpisodeAliasModel, SearchModels.IEpisodeAliasSearchModel>
    {
    }
}
