// <auto-generated>
// <copyright file="Objects.IObjectAppearedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectAppearedInIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IObjectAppearedInIssue : IEntity
    {
        // ObjectAppearedInIssue Properties
        // <None>
        // Related Objects
        int ObjectId { get; set; }
        IObject Object { get; set; }
        int AppearedInIssueId { get; set; }
        IIssue AppearedInIssue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IObjectAppearedInIssueModel : IEntityModel
    {
        // ObjectAppearedInIssue Properties
        // <None>
        // Related Objects
        int ObjectId { get; set; }
        IObjectModel Object { get; set; }
        int AppearedInIssueId { get; set; }
        IIssueModel AppearedInIssue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IObjectAppearedInIssueSearchModel : IEntitySearchModel
    {
        int? ObjectId { get; set; }
        string ObjectCustomKey { get; set; }
        string ObjectApiDetailUrl { get; set; }
        string ObjectSiteDetailUrl { get; set; }
        string ObjectName { get; set; }
        string ObjectShortDescription { get; set; }
        string ObjectDescription { get; set; }
        int? AppearedInIssueId { get; set; }
        string AppearedInIssueCustomKey { get; set; }
        string AppearedInIssueApiDetailUrl { get; set; }
        string AppearedInIssueSiteDetailUrl { get; set; }
        string AppearedInIssueName { get; set; }
        string AppearedInIssueShortDescription { get; set; }
        string AppearedInIssueDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IObjectAppearedInIssueMapper
        : IMapper<
            DataModels.IObjectAppearedInIssue,
            Models.IObjectAppearedInIssueModel,
            SearchModels.IObjectAppearedInIssueSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IObjectAppearedInIssuesRepository
        : IRepositoryBase
        , IRepository<DataModels.IObjectAppearedInIssue, SearchModels.IObjectAppearedInIssueSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IObjectAppearedInIssuesBusinessWorkflow
        : IBusinessWorkflow<Models.IObjectAppearedInIssueModel, SearchModels.IObjectAppearedInIssueSearchModel>
    {
    }
}
