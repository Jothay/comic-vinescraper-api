// <auto-generated>
// <copyright file="Origins.IOriginProfileModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the OriginProfile model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IOriginProfile : IEntity
    {
        // OriginProfile Properties
        // <None>
        // Related Objects
        int OriginId { get; set; }
        IOrigin Origin { get; set; }
        int ProfileId { get; set; }
        IProfile Profile { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IOriginProfileModel : IEntityModel
    {
        // OriginProfile Properties
        // <None>
        // Related Objects
        int OriginId { get; set; }
        IOriginModel Origin { get; set; }
        int ProfileId { get; set; }
        IProfileModel Profile { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IOriginProfileSearchModel : IEntitySearchModel
    {
        int? OriginId { get; set; }
        string OriginCustomKey { get; set; }
        string OriginApiDetailUrl { get; set; }
        string OriginSiteDetailUrl { get; set; }
        string OriginName { get; set; }
        string OriginShortDescription { get; set; }
        string OriginDescription { get; set; }
        int? ProfileId { get; set; }
        string ProfileCustomKey { get; set; }
        string ProfileApiDetailUrl { get; set; }
        string ProfileSiteDetailUrl { get; set; }
        string ProfileName { get; set; }
        string ProfileShortDescription { get; set; }
        string ProfileDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IOriginProfileMapper
        : IMapper<
            DataModels.IOriginProfile,
            Models.IOriginProfileModel,
            SearchModels.IOriginProfileSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IOriginProfilesRepository
        : IRepositoryBase
        , IRepository<DataModels.IOriginProfile, SearchModels.IOriginProfileSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IOriginProfilesBusinessWorkflow
        : IBusinessWorkflow<Models.IOriginProfileModel, SearchModels.IOriginProfileSearchModel>
    {
    }
}