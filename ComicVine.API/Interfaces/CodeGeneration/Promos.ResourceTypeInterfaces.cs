// <auto-generated>
// <copyright file="Promos.IResourceTypeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ResourceType model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IResourceType : INameableEntity
    {
        // ResourceType Properties
        string DetailResourceName { get; set; }
        string ListResourceName { get; set; }
        // Related Objects
        // <None>
        // Associated Objects
        ICollection<IPromo> Promos { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IResourceTypeModel : INameableEntityModel
    {
        // ResourceType Properties
        string DetailResourceName { get; set; }
        string ListResourceName { get; set; }
        // Related Objects
        // <None>
        // Associated Objects
        List<IPromoModel> Promos { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IResourceTypeSearchModel : INameableEntitySearchModel
    {
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IResourceTypeMapper
        : IMapper<
            DataModels.IResourceType,
            Models.IResourceTypeModel,
            SearchModels.IResourceTypeSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IResourceTypesRepository
        : IRepositoryBase
        , IRepository<DataModels.IResourceType, SearchModels.IResourceTypeSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IResourceTypesBusinessWorkflow
        : IBusinessWorkflow<Models.IResourceTypeModel, SearchModels.IResourceTypeSearchModel>
    {
    }
}