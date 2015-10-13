// <auto-generated>
// <copyright file="Movies.IMovieTeamMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between MovieTeam and MovieTeamModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Movies
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.SearchModels;
    using Models;
    using SearchModels;

    public static class MovieTeamMapperExtensions
    {
        public static IMovieTeamMapper Mapper = new MovieTeamMapper();

        public static void OverrideMapper(IMovieTeamMapper mapper) { Mapper = mapper; }

        public static IMovieTeam MapToEntity(this IMovieTeamModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IMovieTeamModel model, ref IMovieTeam entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IMovieTeamModel MapToModel(this IMovieTeam entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IMovieTeamModel MapToModelLite(this IMovieTeam entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IMovieTeamModel MapToModelListing(this IMovieTeam entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IMovieTeamSearchModel MapToSearchModel(this IMovieTeamModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IMovieTeamModel model, IMovieTeam entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class MovieTeamMapper : IMovieTeamMapper
    {
        public virtual IMovieTeam MapToEntity(IMovieTeamModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<MovieTeam, IMovieTeamModel>(model);
            // MovieTeam Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IMovieTeamModel model, ref IMovieTeam entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // MovieTeam Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IMovieTeamModel MapToModel(IMovieTeam entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IMovieTeam, MovieTeamModel>(entity);
            // MovieTeam Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            model.TeamId = entity.TeamId;
            model.Team = entity.Team?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IMovieTeamModel MapToModelLite(IMovieTeam entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IMovieTeam, MovieTeamModel>(entity);
            // MovieTeam Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public virtual IMovieTeamModel MapToModelListing(IMovieTeam entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IMovieTeam, MovieTeamModel>(entity);
            // MovieTeam Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public virtual IMovieTeamSearchModel MapToSearchModel(IMovieTeamModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IMovieTeamModel, MovieTeamSearchModel>(model);
            // Search Properties
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieApiDetailUrl = model.Movie?.ApiDetailUrl;
            searchModel.MovieSiteDetailUrl = model.Movie?.SiteDetailUrl;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieShortDescription = model.Movie?.ShortDescription;
            searchModel.MovieDescription = model.Movie?.Description;
            searchModel.TeamId = model.TeamId;
            searchModel.TeamCustomKey = model.Team?.CustomKey;
            searchModel.TeamApiDetailUrl = model.Team?.ApiDetailUrl;
            searchModel.TeamSiteDetailUrl = model.Team?.SiteDetailUrl;
            searchModel.TeamName = model.Team?.Name;
            searchModel.TeamShortDescription = model.Team?.ShortDescription;
            searchModel.TeamDescription = model.Team?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IMovieTeamModel model, IMovieTeam entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // MovieTeam Properties
                // <None>
                // Related Objects
                && model.MovieId == entity.MovieId
                && model.TeamId == entity.TeamId
                ;
        }
    }
}
