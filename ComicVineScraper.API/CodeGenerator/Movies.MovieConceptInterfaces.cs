// <auto-generated>
// <copyright file="Movies.MovieConceptInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieConcept interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVine.API\Interfaces\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IMovieConcept : IEntity
    {
        // MovieConcept Properties
        // <None>
        // Related Objects
        int MovieId { get; set; }
        IMovie Movie { get; set; }
        int ConceptId { get; set; }
        IConcept Concept { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IMovieConceptModel : IEntityModel
    {
        // MovieConcept Properties
        // <None>
        // Related Objects
        int MovieId { get; set; }
        IMovieModel Movie { get; set; }
        int ConceptId { get; set; }
        IConceptModel Concept { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IMovieConceptSearchModel : IEntitySearchModel
    {
        int? MovieId { get; set; }
        string MovieCustomKey { get; set; }
        string MovieApiDetailUrl { get; set; }
        string MovieSiteDetailUrl { get; set; }
        string MovieName { get; set; }
        string MovieShortDescription { get; set; }
        string MovieDescription { get; set; }
        int? ConceptId { get; set; }
        string ConceptCustomKey { get; set; }
        string ConceptApiDetailUrl { get; set; }
        string ConceptSiteDetailUrl { get; set; }
        string ConceptName { get; set; }
        string ConceptShortDescription { get; set; }
        string ConceptDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IMovieConceptMapper
        : IMapper<
            DataModels.IMovieConcept,
            Models.IMovieConceptModel,
            SearchModels.IMovieConceptSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IMovieConceptsRepository
        : IRepositoryBase
        , IRepository<DataModels.IMovieConcept, SearchModels.IMovieConceptSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IMovieConceptsBusinessWorkflow
        : IBusinessWorkflow<Models.IMovieConceptModel, SearchModels.IMovieConceptSearchModel>
    {
    }
}