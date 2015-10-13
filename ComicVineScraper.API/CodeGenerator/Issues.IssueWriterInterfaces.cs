// <auto-generated>
// <copyright file="Issues.IssueWriterInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the IssueWriter interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IIssueWriter : IEntity
    {
        // IssueWriter Properties
        // <None>
        // Related Objects
        int IssueId { get; set; }
        IIssue Issue { get; set; }
        int WriterId { get; set; }
        IPerson Writer { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IIssueWriterModel : IEntityModel
    {
        // IssueWriter Properties
        // <None>
        // Related Objects
        int IssueId { get; set; }
        IIssueModel Issue { get; set; }
        int WriterId { get; set; }
        IPersonModel Writer { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IIssueWriterSearchModel : IEntitySearchModel
    {
        int? IssueId { get; set; }
        string IssueCustomKey { get; set; }
        string IssueApiDetailUrl { get; set; }
        string IssueSiteDetailUrl { get; set; }
        string IssueName { get; set; }
        string IssueShortDescription { get; set; }
        string IssueDescription { get; set; }
        int? WriterId { get; set; }
        string WriterCustomKey { get; set; }
        string WriterApiDetailUrl { get; set; }
        string WriterSiteDetailUrl { get; set; }
        string WriterName { get; set; }
        string WriterShortDescription { get; set; }
        string WriterDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IIssueWriterMapper
        : IMapper<
            DataModels.IIssueWriter,
            Models.IIssueWriterModel,
            SearchModels.IIssueWriterSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IIssueWritersRepository
        : IRepositoryBase
        , IRepository<DataModels.IIssueWriter, SearchModels.IIssueWriterSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IIssueWritersBusinessWorkflow
        : IBusinessWorkflow<Models.IIssueWriterModel, SearchModels.IIssueWriterSearchModel>
    {
    }
}
