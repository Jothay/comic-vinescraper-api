// <auto-generated>
// <copyright file="People.PersonAliasInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PersonAlias interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IPersonAlias : INameableEntity
    {
        // PersonAlias Properties
        // <None>
        // Related Objects
        int PersonId { get; set; }
        IPerson Person { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IPersonAliasModel : INameableEntityModel
    {
        // PersonAlias Properties
        // <None>
        // Related Objects
        int PersonId { get; set; }
        IPersonModel Person { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IPersonAliasSearchModel : INameableEntitySearchModel
    {
        int? PersonId { get; set; }
        string PersonCustomKey { get; set; }
        string PersonApiDetailUrl { get; set; }
        string PersonSiteDetailUrl { get; set; }
        string PersonName { get; set; }
        string PersonShortDescription { get; set; }
        string PersonDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IPersonAliasMapper
        : IMapper<
            DataModels.IPersonAlias,
            Models.IPersonAliasModel,
            SearchModels.IPersonAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IPersonAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.IPersonAlias, SearchModels.IPersonAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IPersonAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.IPersonAliasModel, SearchModels.IPersonAliasSearchModel>
    {
    }
}
