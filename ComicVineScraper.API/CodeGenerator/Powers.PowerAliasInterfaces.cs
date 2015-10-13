// <auto-generated>
// <copyright file="Powers.PowerAliasInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PowerAlias interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVine.API\Interfaces\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVine.API.Interfaces.DataModels
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

namespace ComicVine.API.Interfaces.Models
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

namespace ComicVine.API.Interfaces.SearchModels
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

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IPowerAliasMapper
        : IMapper<
            DataModels.IPowerAlias,
            Models.IPowerAliasModel,
            SearchModels.IPowerAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IPowerAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.IPowerAlias, SearchModels.IPowerAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IPowerAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.IPowerAliasModel, SearchModels.IPowerAliasSearchModel>
    {
    }
}