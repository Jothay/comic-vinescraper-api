// <auto-generated>
// <copyright file="Powers.PowerAliasInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PowerAlias interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IPowerAlias : INameableEntity
    {
        // PowerAlias Properties
        // <None>
        // Related Objects
        int PowerId { get; set; }
        IPower Power { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IPowerAliasModel : INameableEntityModel
    {
        // PowerAlias Properties
        // <None>
        // Related Objects
        int PowerId { get; set; }
        IPowerModel Power { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IPowerAliasSearchModel : INameableEntitySearchModel
    {
        int? PowerId { get; set; }
        string PowerCustomKey { get; set; }
        string PowerApiDetailUrl { get; set; }
        string PowerSiteDetailUrl { get; set; }
        string PowerName { get; set; }
        string PowerShortDescription { get; set; }
        string PowerDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IPowerAliasMapper
        : IMapper<
            DataModels.IPowerAlias,
            Models.IPowerAliasModel,
            SearchModels.IPowerAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IPowerAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.IPowerAlias, SearchModels.IPowerAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IPowerAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.IPowerAliasModel, SearchModels.IPowerAliasSearchModel>
    {
    }
}
