// <auto-generated>
// <copyright file="Teams.TeamAppearedInIssueInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the TeamAppearedInIssue interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ITeamAppearedInIssue : IEntity
    {
        // TeamAppearedInIssue Properties
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

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface ITeamAppearedInIssueModel : IEntityModel
    {
        // TeamAppearedInIssue Properties
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

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface ITeamAppearedInIssueSearchModel : IEntitySearchModel
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

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface ITeamAppearedInIssueMapper
        : IMapper<
            DataModels.ITeamAppearedInIssue,
            Models.ITeamAppearedInIssueModel,
            SearchModels.ITeamAppearedInIssueSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface ITeamAppearedInIssuesRepository
        : IRepositoryBase
        , IRepository<DataModels.ITeamAppearedInIssue, SearchModels.ITeamAppearedInIssueSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface ITeamAppearedInIssuesBusinessWorkflow
        : IBusinessWorkflow<Models.ITeamAppearedInIssueModel, SearchModels.ITeamAppearedInIssueSearchModel>
    {
    }
}
