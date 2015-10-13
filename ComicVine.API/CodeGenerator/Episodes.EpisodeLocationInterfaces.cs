// <auto-generated>
// <copyright file="Episodes.EpisodeLocationInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeLocation interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVine.API\Interfaces\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeLocation : IEntity
    {
        // EpisodeLocation Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisode Episode { get; set; }
        int LocationId { get; set; }
        ILocation Location { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeLocationModel : IEntityModel
    {
        // EpisodeLocation Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisodeModel Episode { get; set; }
        int LocationId { get; set; }
        ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IEpisodeLocationSearchModel : IEntitySearchModel
    {
        int? EpisodeId { get; set; }
        string EpisodeCustomKey { get; set; }
        string EpisodeApiDetailUrl { get; set; }
        string EpisodeSiteDetailUrl { get; set; }
        string EpisodeName { get; set; }
        string EpisodeShortDescription { get; set; }
        string EpisodeDescription { get; set; }
        int? LocationId { get; set; }
        string LocationCustomKey { get; set; }
        string LocationApiDetailUrl { get; set; }
        string LocationSiteDetailUrl { get; set; }
        string LocationName { get; set; }
        string LocationShortDescription { get; set; }
        string LocationDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IEpisodeLocationMapper
        : IMapper<
            DataModels.IEpisodeLocation,
            Models.IEpisodeLocationModel,
            SearchModels.IEpisodeLocationSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IEpisodeLocationsRepository
        : IRepositoryBase
        , IRepository<DataModels.IEpisodeLocation, SearchModels.IEpisodeLocationSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IEpisodeLocationsBusinessWorkflow
        : IBusinessWorkflow<Models.IEpisodeLocationModel, SearchModels.IEpisodeLocationSearchModel>
    {
    }
}