// <auto-generated>
// <copyright file="Movies.MovieStoryArcInterfaces.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the MovieStoryArc interfaces including Entity, Model, Search Model, Mapper,
// Repository and Business Workflow in the appropriate namespaces.</summary>
// <remarks>This file was auto-generated using InterfaceFileMaster.tt in
// ComicVine.API\Interfaces\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable RedundantUsingDirective, UnusedMemberInSuper.Global
namespace ComicVine.API.Interfaces.DataModels
{
    using System;
    using System.Collections.Generic;

    public interface IMovieStoryArc : IEntity
    {
        // MovieStoryArc Properties
        // <None>
        // Related Objects
        int MovieId { get; set; }
        IMovie Movie { get; set; }
        int StoryArcId { get; set; }
        IStoryArc StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.Models
{
    using System;
    using System.Collections.Generic;

    public interface IMovieStoryArcModel : IEntityModel
    {
        // MovieStoryArc Properties
        // <None>
        // Related Objects
        int MovieId { get; set; }
        IMovieModel Movie { get; set; }
        int StoryArcId { get; set; }
        IStoryArcModel StoryArc { get; set; }
        // Associated Objects
        // <None>
    }
}

namespace ComicVine.API.Interfaces.SearchModels
{
    public interface IMovieStoryArcSearchModel : IEntitySearchModel
    {
        int? MovieId { get; set; }
        string MovieCustomKey { get; set; }
        string MovieApiDetailUrl { get; set; }
        string MovieSiteDetailUrl { get; set; }
        string MovieName { get; set; }
        string MovieShortDescription { get; set; }
        string MovieDescription { get; set; }
        int? StoryArcId { get; set; }
        string StoryArcCustomKey { get; set; }
        string StoryArcApiDetailUrl { get; set; }
        string StoryArcSiteDetailUrl { get; set; }
        string StoryArcName { get; set; }
        string StoryArcShortDescription { get; set; }
        string StoryArcDescription { get; set; }
    }
}

namespace ComicVine.API.Interfaces.Mappers
{
    public interface IMovieStoryArcMapper
        : IMapper<
            DataModels.IMovieStoryArc,
            Models.IMovieStoryArcModel,
            SearchModels.IMovieStoryArcSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.Repositories
{
    public interface IMovieStoryArcsRepository
        : IRepositoryBase
        , IRepository<DataModels.IMovieStoryArc, SearchModels.IMovieStoryArcSearchModel>
    {
    }
}

namespace ComicVine.API.Interfaces.BusinessWorkflows
{
    public interface IMovieStoryArcsBusinessWorkflow
        : IBusinessWorkflow<Models.IMovieStoryArcModel, SearchModels.IMovieStoryArcSearchModel>
    {
    }
}