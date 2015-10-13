// <auto-generated>
// <copyright file="Episodes.EpisodeConceptInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeConcept interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVineScraper.API\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVineScraper.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeConcept : IEntity
    {
        // EpisodeConcept Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisode Episode { get; set; }
        int ConceptId { get; set; }
        IConcept Concept { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IEpisodeConceptModel : IEntityModel
    {
        // EpisodeConcept Properties
        // <None>
        // Related Objects
        int EpisodeId { get; set; }
        IEpisodeModel Episode { get; set; }
        int ConceptId { get; set; }
        IConceptModel Concept { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVineScraper.API.Interfaces.SearchModels
{
    public interface IEpisodeConceptSearchModel : IEntitySearchModel
    {
        int? EpisodeId { get; set; }
        string EpisodeCustomKey { get; set; }
        string EpisodeApiDetailUrl { get; set; }
        string EpisodeSiteDetailUrl { get; set; }
        string EpisodeName { get; set; }
        string EpisodeShortDescription { get; set; }
        string EpisodeDescription { get; set; }
        int? ConceptId { get; set; }
        string ConceptCustomKey { get; set; }
        string ConceptApiDetailUrl { get; set; }
        string ConceptSiteDetailUrl { get; set; }
        string ConceptName { get; set; }
        string ConceptShortDescription { get; set; }
        string ConceptDescription { get; set; }
    }
}

namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IEpisodeConceptMapper
        : IMapper<
            DataModels.IEpisodeConcept,
            Models.IEpisodeConceptModel,
            SearchModels.IEpisodeConceptSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.Repositories
{
    public interface IEpisodeConceptsRepository
        : IRepositoryBase
        , IRepository<DataModels.IEpisodeConcept, SearchModels.IEpisodeConceptSearchModel>
    {
    }
}

namespace ComicVineScraper.API.Interfaces.BusinessWorkflows
{
    public interface IEpisodeConceptsBusinessWorkflow
        : IBusinessWorkflow<Models.IEpisodeConceptModel, SearchModels.IEpisodeConceptSearchModel>
    {
    }
}
