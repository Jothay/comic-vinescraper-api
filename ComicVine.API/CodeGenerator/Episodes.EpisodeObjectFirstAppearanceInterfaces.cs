// <auto-generated>
// <copyright file="Episodes.EpisodeObjectFirstAppearanceInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeObjectFirstAppearance interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVine.API\Interfaces\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeObjectFirstAppearance : IEntity
    {
        // EpisodeObjectFirstAppearance Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisode Episode { get; set; }
        int ObjectId { get; set; }
        IObject Object { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeObjectFirstAppearanceModel : IEntityModel
    {
        // EpisodeObjectFirstAppearance Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisodeModel Episode { get; set; }
        int ObjectId { get; set; }
        IObjectModel Object { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IEpisodeObjectFirstAppearanceSearchModel : IEntitySearchModel
    {
        int? EpisodeId { get; set; }
        string EpisodeCustomKey { get; set; }
        string EpisodeApiDetailUrl { get; set; }
        string EpisodeSiteDetailUrl { get; set; }
        string EpisodeName { get; set; }
        string EpisodeShortDescription { get; set; }
        string EpisodeDescription { get; set; }
        int? ObjectId { get; set; }
        string ObjectCustomKey { get; set; }
        string ObjectApiDetailUrl { get; set; }
        string ObjectSiteDetailUrl { get; set; }
        string ObjectName { get; set; }
        string ObjectShortDescription { get; set; }
        string ObjectDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IEpisodeObjectFirstAppearanceMapper
        : IMapper<
            DataModels.IEpisodeObjectFirstAppearance,
            Models.IEpisodeObjectFirstAppearanceModel,
            SearchModels.IEpisodeObjectFirstAppearanceSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IEpisodeObjectFirstAppearancesRepository
        : IRepositoryBase
        , IRepository<DataModels.IEpisodeObjectFirstAppearance, SearchModels.IEpisodeObjectFirstAppearanceSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IEpisodeObjectFirstAppearancesBusinessWorkflow
        : IBusinessWorkflow<Models.IEpisodeObjectFirstAppearanceModel, SearchModels.IEpisodeObjectFirstAppearanceSearchModel>
    {
    }
}