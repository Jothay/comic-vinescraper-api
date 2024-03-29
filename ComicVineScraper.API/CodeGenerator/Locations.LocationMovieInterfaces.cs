// <auto-generated>
// <copyright file="Locations.LocationMovieInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationMovie interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ILocationMovie : IEntity
    {
        // LocationMovie Properties
        // <None>
        // Related Objects
        int LocationId { get; set; }
        ILocation Location { get; set; }
        int MovieId { get; set; }
        IMovie Movie { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ILocationMovieModel : IEntityModel
    {
        // LocationMovie Properties
        // <None>
        // Related Objects
        int LocationId { get; set; }
        ILocationModel Location { get; set; }
        int MovieId { get; set; }
        IMovieModel Movie { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface ILocationMovieSearchModel : IEntitySearchModel
    {
        int? LocationId { get; set; }
        string LocationCustomKey { get; set; }
        string LocationApiDetailUrl { get; set; }
        string LocationSiteDetailUrl { get; set; }
        string LocationName { get; set; }
        string LocationShortDescription { get; set; }
        string LocationDescription { get; set; }
        int? MovieId { get; set; }
        string MovieCustomKey { get; set; }
        string MovieApiDetailUrl { get; set; }
        string MovieSiteDetailUrl { get; set; }
        string MovieName { get; set; }
        string MovieShortDescription { get; set; }
        string MovieDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface ILocationMovieMapper
        : IMapper<
            DataModels.ILocationMovie,
            Models.ILocationMovieModel,
            SearchModels.ILocationMovieSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface ILocationMoviesRepository
        : IRepositoryBase
        , IRepository<DataModels.ILocationMovie, SearchModels.ILocationMovieSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface ILocationMoviesBusinessWorkflow
        : IBusinessWorkflow<Models.ILocationMovieModel, SearchModels.ILocationMovieSearchModel>
    {
    }
}
