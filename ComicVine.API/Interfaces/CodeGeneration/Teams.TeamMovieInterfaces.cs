// <auto-generated>
// <copyright file="Teams.ITeamMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamMovie model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ITeamMovie : IEntity
    {
        // TeamMovie Properties
        // <None>
        // Related Objects
        int TeamId { get; set; }
        ITeam Team { get; set; }
        int MovieId { get; set; }
        IMovie Movie { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ITeamMovieModel : IEntityModel
    {
        // TeamMovie Properties
        // <None>
        // Related Objects
        int TeamId { get; set; }
        ITeamModel Team { get; set; }
        int MovieId { get; set; }
        IMovieModel Movie { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ITeamMovieSearchModel : IEntitySearchModel
    {
        int? TeamId { get; set; }
        string TeamCustomKey { get; set; }
        string TeamApiDetailUrl { get; set; }
        string TeamSiteDetailUrl { get; set; }
        string TeamName { get; set; }
        string TeamShortDescription { get; set; }
        string TeamDescription { get; set; }
        int? MovieId { get; set; }
        string MovieCustomKey { get; set; }
        string MovieApiDetailUrl { get; set; }
        string MovieSiteDetailUrl { get; set; }
        string MovieName { get; set; }
        string MovieShortDescription { get; set; }
        string MovieDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ITeamMovieMapper
        : IMapper<
            DataModels.ITeamMovie,
            Models.ITeamMovieModel,
            SearchModels.ITeamMovieSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ITeamMoviesRepository
        : IRepositoryBase
        , IRepository<DataModels.ITeamMovie, SearchModels.ITeamMovieSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ITeamMoviesBusinessWorkflow
        : IBusinessWorkflow<Models.ITeamMovieModel, SearchModels.ITeamMovieSearchModel>
    {
    }
}