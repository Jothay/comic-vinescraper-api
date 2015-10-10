// <auto-generated>
// <copyright file="dbo.ISeriesAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ISeriesAlias : INameableEntity
    {
        // SeriesAlias Properties
        // <None>
        // Related Objects
        int SeriesId { get; set; }
        ISeries Series { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ISeriesAliasModel : INameableEntityModel
    {
        // SeriesAlias Properties
        // <None>
        // Related Objects
        int SeriesId { get; set; }
        ISeriesModel Series { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ISeriesAliasSearchModel : INameableEntitySearchModel
    {
        int? SeriesId { get; set; }
        string SeriesCustomKey { get; set; }
        string SeriesApiDetailUrl { get; set; }
        string SeriesSiteDetailUrl { get; set; }
        string SeriesName { get; set; }
        string SeriesShortDescription { get; set; }
        string SeriesDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ISeriesAliasMapper
        : IMapper<
            DataModels.ISeriesAlias,
            Models.ISeriesAliasModel,
            SearchModels.ISeriesAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ISeriesAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.ISeriesAlias, SearchModels.ISeriesAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ISeriesAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.ISeriesAliasModel, SearchModels.ISeriesAliasSearchModel>
    {
    }
}