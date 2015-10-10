// <auto-generated>
// <copyright file="dbo.IPublisherAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PublisherAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IPublisherAlias : INameableEntity
    {
        // PublisherAlias Properties
        // <None>
        // Related Objects
        int PublisherId { get; set; }
        IPublisher Publisher { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IPublisherAliasModel : INameableEntityModel
    {
        // PublisherAlias Properties
        // <None>
        // Related Objects
        int PublisherId { get; set; }
        IPublisherModel Publisher { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IPublisherAliasSearchModel : INameableEntitySearchModel
    {
        int? PublisherId { get; set; }
        string PublisherCustomKey { get; set; }
        string PublisherApiDetailUrl { get; set; }
        string PublisherSiteDetailUrl { get; set; }
        string PublisherName { get; set; }
        string PublisherShortDescription { get; set; }
        string PublisherDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IPublisherAliasMapper
        : IMapper<
            DataModels.IPublisherAlias,
            Models.IPublisherAliasModel,
            SearchModels.IPublisherAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IPublisherAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.IPublisherAlias, SearchModels.IPublisherAliasSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IPublisherAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.IPublisherAliasModel, SearchModels.IPublisherAliasSearchModel>
    {
    }
}