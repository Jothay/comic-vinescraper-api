// <auto-generated>
// <copyright file="Locations.LocationIssueInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationIssue interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface ILocationIssue : IEntity
    {
        // LocationIssue Properties
        // <None>
        // Related Objects
        int LocationId { get; set; }
        ILocation Location { get; set; }
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

    public interface ILocationIssueModel : IEntityModel
    {
        // LocationIssue Properties
        // <None>
        // Related Objects
        int LocationId { get; set; }
        ILocationModel Location { get; set; }
        int IssueId { get; set; }
        IIssueModel Issue { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface ILocationIssueSearchModel : IEntitySearchModel
    {
        int? LocationId { get; set; }
        string LocationCustomKey { get; set; }
        string LocationApiDetailUrl { get; set; }
        string LocationSiteDetailUrl { get; set; }
        string LocationName { get; set; }
        string LocationShortDescription { get; set; }
        string LocationDescription { get; set; }
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
    public interface ILocationIssueMapper
        : IMapper<
            DataModels.ILocationIssue,
            Models.ILocationIssueModel,
            SearchModels.ILocationIssueSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface ILocationIssuesRepository
        : IRepositoryBase
        , IRepository<DataModels.ILocationIssue, SearchModels.ILocationIssueSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface ILocationIssuesBusinessWorkflow
        : IBusinessWorkflow<Models.ILocationIssueModel, SearchModels.ILocationIssueSearchModel>
    {
    }
}
