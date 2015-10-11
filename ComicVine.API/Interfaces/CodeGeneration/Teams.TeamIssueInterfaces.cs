// <auto-generated>
// <copyright file="Teams.ITeamIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ITeamIssue : IEntity
    {
        // TeamIssue Properties
        // <None>
        // Related Objects
        int TeamId { get; set; }
        ITeam Team { get; set; }
        int IssueId { get; set; }
        IIssue Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ITeamIssueModel : IEntityModel
    {
        // TeamIssue Properties
        // <None>
        // Related Objects
        int TeamId { get; set; }
        ITeamModel Team { get; set; }
        int IssueId { get; set; }
        IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface ITeamIssueSearchModel : IEntitySearchModel
    {
        int? TeamId { get; set; }
        string TeamCustomKey { get; set; }
        string TeamApiDetailUrl { get; set; }
        string TeamSiteDetailUrl { get; set; }
        string TeamName { get; set; }
        string TeamShortDescription { get; set; }
        string TeamDescription { get; set; }
        int? IssueId { get; set; }
        string IssueCustomKey { get; set; }
        string IssueApiDetailUrl { get; set; }
        string IssueSiteDetailUrl { get; set; }
        string IssueName { get; set; }
        string IssueShortDescription { get; set; }
        string IssueDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface ITeamIssueMapper
        : IMapper<
            DataModels.ITeamIssue,
            Models.ITeamIssueModel,
            SearchModels.ITeamIssueSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface ITeamIssuesRepository
        : IRepositoryBase
        , IRepository<DataModels.ITeamIssue, SearchModels.ITeamIssueSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface ITeamIssuesBusinessWorkflow
        : IBusinessWorkflow<Models.ITeamIssueModel, SearchModels.ITeamIssueSearchModel>
    {
    }
}