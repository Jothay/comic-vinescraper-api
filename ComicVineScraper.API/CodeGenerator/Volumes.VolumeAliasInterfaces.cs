// <auto-generated>
// <copyright file="Volumes.VolumeAliasInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the VolumeAlias interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeAlias : INameableEntity
    {
        // VolumeAlias Properties
        // <None>
        // Related Objects
        int VolumeId { get; set; }
        IVolume Volume { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeAliasModel : INameableEntityModel
    {
        // VolumeAlias Properties
        // <None>
        // Related Objects
        int VolumeId { get; set; }
        IVolumeModel Volume { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IVolumeAliasSearchModel : INameableEntitySearchModel
    {
        int? VolumeId { get; set; }
        string VolumeCustomKey { get; set; }
        string VolumeApiDetailUrl { get; set; }
        string VolumeSiteDetailUrl { get; set; }
        string VolumeName { get; set; }
        string VolumeShortDescription { get; set; }
        string VolumeDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IVolumeAliasMapper
        : IMapper<
            DataModels.IVolumeAlias,
            Models.IVolumeAliasModel,
            SearchModels.IVolumeAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IVolumeAliasesRepository
        : IRepositoryBase
        , IRepository<DataModels.IVolumeAlias, SearchModels.IVolumeAliasSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IVolumeAliasesBusinessWorkflow
        : IBusinessWorkflow<Models.IVolumeAliasModel, SearchModels.IVolumeAliasSearchModel>
    {
    }
}
