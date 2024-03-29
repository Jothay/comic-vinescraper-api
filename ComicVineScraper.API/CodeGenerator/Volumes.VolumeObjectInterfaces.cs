// <auto-generated>
// <copyright file="Volumes.VolumeObjectInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeObject interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeObject : IEntity
    {
        // VolumeObject Properties
        // <None>
        // Related Objects
        int VolumeId { get; set; }
        IVolume Volume { get; set; }
        int ObjectId { get; set; }
        IObject Object { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeObjectModel : IEntityModel
    {
        // VolumeObject Properties
        // <None>
        // Related Objects
        int VolumeId { get; set; }
        IVolumeModel Volume { get; set; }
        int ObjectId { get; set; }
        IObjectModel Object { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IVolumeObjectSearchModel : IEntitySearchModel
    {
        int? VolumeId { get; set; }
        string VolumeCustomKey { get; set; }
        string VolumeApiDetailUrl { get; set; }
        string VolumeSiteDetailUrl { get; set; }
        string VolumeName { get; set; }
        string VolumeShortDescription { get; set; }
        string VolumeDescription { get; set; }
        int? ObjectId { get; set; }
        string ObjectCustomKey { get; set; }
        string ObjectApiDetailUrl { get; set; }
        string ObjectSiteDetailUrl { get; set; }
        string ObjectName { get; set; }
        string ObjectShortDescription { get; set; }
        string ObjectDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IVolumeObjectMapper
        : IMapper<
            DataModels.IVolumeObject,
            Models.IVolumeObjectModel,
            SearchModels.IVolumeObjectSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IVolumeObjectsRepository
        : IRepositoryBase
        , IRepository<DataModels.IVolumeObject, SearchModels.IVolumeObjectSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IVolumeObjectsBusinessWorkflow
        : IBusinessWorkflow<Models.IVolumeObjectModel, SearchModels.IVolumeObjectSearchModel>
    {
    }
}
