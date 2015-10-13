// <auto-generated>
// <copyright file="Series.SeriesLocationInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the SeriesLocation interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVine.API\Interfaces\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ISeriesLocation : IEntity
    {
        // SeriesLocation Properties
        // <None>
        // Related Objects
        int SeriesId { get; set; }
        ISeries Series { get; set; }
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

    public interface ISeriesLocationModel : IEntityModel
    {
        // SeriesLocation Properties
        // <None>
        // Related Objects
        int SeriesId { get; set; }
        ISeriesModel Series { get; set; }
        int LocationId { get; set; }
        ILocationModel Location { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ISeriesLocationSearchModel : IEntitySearchModel
    {
        int? SeriesId { get; set; }
        string SeriesCustomKey { get; set; }
        string SeriesApiDetailUrl { get; set; }
        string SeriesSiteDetailUrl { get; set; }
        string SeriesName { get; set; }
        string SeriesShortDescription { get; set; }
        string SeriesDescription { get; set; }
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
    public interface ISeriesLocationMapper
        : IMapper<
            DataModels.ISeriesLocation,
            Models.ISeriesLocationModel,
            SearchModels.ISeriesLocationSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ISeriesLocationsRepository
        : IRepositoryBase
        , IRepository<DataModels.ISeriesLocation, SearchModels.ISeriesLocationSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ISeriesLocationsBusinessWorkflow
        : IBusinessWorkflow<Models.ISeriesLocationModel, SearchModels.ISeriesLocationSearchModel>
    {
    }
}