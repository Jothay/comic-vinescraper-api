// <auto-generated>
// <copyright file="Objects.IObjectModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Object model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IObject : INameableEntity
    {
        // Object Properties
        int? StartYear { get; set; }
        // Related Objects
        int FirstIssueAppearanceId { get; set; }
        IIssue FirstIssueAppearance { get; set; }
        int PrimaryImageFileId { get; set; }
        IImageFile PrimaryImageFile { get; set; }
        // Associated Objects
        ICollection<IObjectAlias> ObjectAliases { get; set; }
        ICollection<IObjectAppearedInIssue> ObjectIssuesAppearedIn { get; set; }
        ICollection<IObjectIssue> ObjectIssues { get; set; }
        ICollection<IObjectMovie> ObjectMovies { get; set; }
        ICollection<IObjectStoryArc> ObjectStoryArcs { get; set; }
        ICollection<IObjectVolume> ObjectVolumes { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IObjectModel : INameableEntityModel
    {
        // Object Properties
        int? StartYear { get; set; }
        // Related Objects
        int FirstIssueAppearanceId { get; set; }
        IIssueModel FirstIssueAppearance { get; set; }
        int PrimaryImageFileId { get; set; }
        IImageFileModel PrimaryImageFile { get; set; }
        // Associated Objects
        List<IObjectAliasModel> ObjectAliases { get; set; }
        List<IObjectAppearedInIssueModel> ObjectIssuesAppearedIn { get; set; }
        List<IObjectIssueModel> ObjectIssues { get; set; }
        List<IObjectMovieModel> ObjectMovies { get; set; }
        List<IObjectStoryArcModel> ObjectStoryArcs { get; set; }
        List<IObjectVolumeModel> ObjectVolumes { get; set; }
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IObjectSearchModel : INameableEntitySearchModel
    {
        int? FirstIssueAppearanceId { get; set; }
        string FirstIssueAppearanceCustomKey { get; set; }
        string FirstIssueAppearanceApiDetailUrl { get; set; }
        string FirstIssueAppearanceSiteDetailUrl { get; set; }
        string FirstIssueAppearanceName { get; set; }
        string FirstIssueAppearanceShortDescription { get; set; }
        string FirstIssueAppearanceDescription { get; set; }
        int? PrimaryImageFileId { get; set; }
        string PrimaryImageFileCustomKey { get; set; }
        string PrimaryImageFileApiDetailUrl { get; set; }
        string PrimaryImageFileSiteDetailUrl { get; set; }
        string PrimaryImageFileName { get; set; }
        string PrimaryImageFileShortDescription { get; set; }
        string PrimaryImageFileDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IObjectMapper
        : IMapper<
            DataModels.IObject,
            Models.IObjectModel,
            SearchModels.IObjectSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IObjectsRepository
        : IRepositoryBase
        , IRepository<DataModels.IObject, SearchModels.IObjectSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IObjectsBusinessWorkflow
        : IBusinessWorkflow<Models.IObjectModel, SearchModels.IObjectSearchModel>
    {
    }
}