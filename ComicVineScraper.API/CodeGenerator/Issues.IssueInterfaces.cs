// <auto-generated>
// <copyright file="Issues.IssueInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the Issue interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IIssue : INameableEntity
    {
        // Issue Properties
        bool HasStaffReview { get; set; }
        DateTime? CoverDate { get; set; }
        DateTime? StoreDate { get; set; }
        string IssueNumber { get; set; }
        // Related Objects
        int? PrimaryImageFileId { get; set; }
        IImageFile PrimaryImageFile { get; set; }
        int? VolumeId { get; set; }
        IVolume Volume { get; set; }
        // Associated Objects
        ICollection<IIssueAlias> IssueAliases { get; set; }
        ICollection<IStoryArcIssue> IssueStoryArcs { get; set; }
        ICollection<IIssueWriter> IssueWriters { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IIssueModel : INameableEntityModel
    {
        // Issue Properties
        bool HasStaffReview { get; set; }
        DateTime? CoverDate { get; set; }
        DateTime? StoreDate { get; set; }
        string IssueNumber { get; set; }
        // Related Objects
        int? PrimaryImageFileId { get; set; }
        IImageFileModel PrimaryImageFile { get; set; }
        int? VolumeId { get; set; }
        IVolumeModel Volume { get; set; }
        // Associated Objects
        List<IIssueAliasModel> IssueAliases { get; set; }
        List<IStoryArcIssueModel> IssueStoryArcs { get; set; }
        List<IIssueWriterModel> IssueWriters { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IIssueSearchModel : INameableEntitySearchModel
    {
        int? PrimaryImageFileId { get; set; }
        string PrimaryImageFileCustomKey { get; set; }
        string PrimaryImageFileApiDetailUrl { get; set; }
        string PrimaryImageFileSiteDetailUrl { get; set; }
        string PrimaryImageFileName { get; set; }
        string PrimaryImageFileShortDescription { get; set; }
        string PrimaryImageFileDescription { get; set; }
        int? VolumeId { get; set; }
        string VolumeCustomKey { get; set; }
        string VolumeApiDetailUrl { get; set; }
        string VolumeSiteDetailUrl { get; set; }
        string VolumeName { get; set; }
        string VolumeShortDescription { get; set; }
        string VolumeDescription { get; set; }
        bool? HasStaffReview { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IIssueMapper
        : IMapper<
            DataModels.IIssue,
            Models.IIssueModel,
            SearchModels.IIssueSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IIssuesRepository
        : IRepositoryBase
        , IRepository<DataModels.IIssue, SearchModels.IIssueSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IIssuesBusinessWorkflow
        : IBusinessWorkflow<Models.IIssueModel, SearchModels.IIssueSearchModel>
    {
    }
}
