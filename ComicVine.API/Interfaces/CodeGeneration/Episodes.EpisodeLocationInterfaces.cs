// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
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
