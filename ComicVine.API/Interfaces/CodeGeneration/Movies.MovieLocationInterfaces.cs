// <auto-generated>
// <copyright file="Movies.IMovieLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IMovieLocation : IEntity
    {
        // MovieLocation Properties
        // <None>
        // Related Objects
        int MovieId { get; set; }
        IMovie Movie { get; set; }
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

    public interface IMovieLocationModel : IEntityModel
    {
        // MovieLocation Properties
        // <None>
        // Related Objects
        int MovieId { get; set; }
        IMovieModel Movie { get; set; }
        int LocationId { get; set; }
        ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IMovieLocationSearchModel : IEntitySearchModel
    {
        int? MovieId { get; set; }
        string MovieCustomKey { get; set; }
        string MovieApiDetailUrl { get; set; }
        string MovieSiteDetailUrl { get; set; }
        string MovieName { get; set; }
        string MovieShortDescription { get; set; }
        string MovieDescription { get; set; }
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
    public interface IMovieLocationMapper
        : IMapper<
            DataModels.IMovieLocation,
            Models.IMovieLocationModel,
            SearchModels.IMovieLocationSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IMovieLocationsRepository
        : IRepositoryBase
        , IRepository<DataModels.IMovieLocation, SearchModels.IMovieLocationSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IMovieLocationsBusinessWorkflow
        : IBusinessWorkflow<Models.IMovieLocationModel, SearchModels.IMovieLocationSearchModel>
    {
    }
}
