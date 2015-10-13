// <auto-generated>
// <copyright file="Origins.OriginProfileInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the OriginProfile interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
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

namespace ComicVineScraper.API.Interfaces.Models
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

namespace ComicVineScraper.API.Interfaces.SearchModels
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

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IOriginProfileMapper
        : IMapper<
            DataModels.IOriginProfile,
            Models.IOriginProfileModel,
            SearchModels.IOriginProfileSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IOriginProfilesRepository
        : IRepositoryBase
        , IRepository<DataModels.IOriginProfile, SearchModels.IOriginProfileSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IOriginProfilesBusinessWorkflow
        : IBusinessWorkflow<Models.IOriginProfileModel, SearchModels.IOriginProfileSearchModel>
    {
    }
}
