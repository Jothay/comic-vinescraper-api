// <auto-generated>
// <copyright file="Volumes.IVolumeWriterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeWriter model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeWriter : IEntity
    {
        // VolumeWriter Properties
        // <None>
        // Related Objects
        int VolumeId { get; set; }
        IVolume Volume { get; set; }
        int WriterId { get; set; }
        IPerson Writer { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IVolumeWriterModel : IEntityModel
    {
        // VolumeWriter Properties
        // <None>
        // Related Objects
        int VolumeId { get; set; }
        IVolumeModel Volume { get; set; }
        int WriterId { get; set; }
        IPersonModel Writer { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IVolumeWriterSearchModel : IEntitySearchModel
    {
        int? VolumeId { get; set; }
        string VolumeCustomKey { get; set; }
        string VolumeApiDetailUrl { get; set; }
        string VolumeSiteDetailUrl { get; set; }
        string VolumeName { get; set; }
        string VolumeShortDescription { get; set; }
        string VolumeDescription { get; set; }
        int? WriterId { get; set; }
        string WriterCustomKey { get; set; }
        string WriterApiDetailUrl { get; set; }
        string WriterSiteDetailUrl { get; set; }
        string WriterName { get; set; }
        string WriterShortDescription { get; set; }
        string WriterDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IVolumeWriterMapper
        : IMapper<
            DataModels.IVolumeWriter,
            Models.IVolumeWriterModel,
            SearchModels.IVolumeWriterSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IVolumeWritersRepository
        : IRepositoryBase
        , IRepository<DataModels.IVolumeWriter, SearchModels.IVolumeWriterSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IVolumeWritersBusinessWorkflow
        : IBusinessWorkflow<Models.IVolumeWriterModel, SearchModels.IVolumeWriterSearchModel>
    {
    }
}