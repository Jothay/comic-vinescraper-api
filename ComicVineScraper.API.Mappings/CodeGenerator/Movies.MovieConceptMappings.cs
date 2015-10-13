// <auto-generated>
// <copyright file="Movies.IMovieConceptMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between MovieConcept and MovieConceptModel.</summary>
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

    public static class MovieConceptMapperExtensions
    {
        public static IMovieConceptMapper Mapper = new MovieConceptMapper();

        public static void OverrideMapper(IMovieConceptMapper mapper) { Mapper = mapper; }

        public static IMovieConcept MapToEntity(this IMovieConceptModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IMovieConceptModel model, ref IMovieConcept entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IMovieConceptModel MapToModel(this IMovieConcept entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IMovieConceptModel MapToModelLite(this IMovieConcept entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IMovieConceptModel MapToModelListing(this IMovieConcept entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IMovieConceptSearchModel MapToSearchModel(this IMovieConceptModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IMovieConceptModel model, IMovieConcept entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class MovieConceptMapper : IMovieConceptMapper
    {
        public virtual IMovieConcept MapToEntity(IMovieConceptModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<MovieConcept, IMovieConceptModel>(model);
            // MovieConcept Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.ConceptId = model.ConceptId;
            entity.Concept = (Concept)model.Concept?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IMovieConceptModel model, ref IMovieConcept entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // MovieConcept Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.ConceptId = model.ConceptId;
            entity.Concept = (Concept)model.Concept?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IMovieConceptModel MapToModel(IMovieConcept entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IMovieConcept, MovieConceptModel>(entity);
            // MovieConcept Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            model.ConceptId = entity.ConceptId;
            model.Concept = entity.Concept?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IMovieConceptModel MapToModelLite(IMovieConcept entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IMovieConcept, MovieConceptModel>(entity);
            // MovieConcept Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.ConceptId = entity.ConceptId;
            // Return Entity
            return model;
        }

        public virtual IMovieConceptModel MapToModelListing(IMovieConcept entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IMovieConcept, MovieConceptModel>(entity);
            // MovieConcept Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.ConceptId = entity.ConceptId;
            // Return Entity
            return model;
        }

        public virtual IMovieConceptSearchModel MapToSearchModel(IMovieConceptModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IMovieConceptModel, MovieConceptSearchModel>(model);
            // Search Properties
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieApiDetailUrl = model.Movie?.ApiDetailUrl;
            searchModel.MovieSiteDetailUrl = model.Movie?.SiteDetailUrl;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieShortDescription = model.Movie?.ShortDescription;
            searchModel.MovieDescription = model.Movie?.Description;
            searchModel.ConceptId = model.ConceptId;
            searchModel.ConceptCustomKey = model.Concept?.CustomKey;
            searchModel.ConceptApiDetailUrl = model.Concept?.ApiDetailUrl;
            searchModel.ConceptSiteDetailUrl = model.Concept?.SiteDetailUrl;
            searchModel.ConceptName = model.Concept?.Name;
            searchModel.ConceptShortDescription = model.Concept?.ShortDescription;
            searchModel.ConceptDescription = model.Concept?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IMovieConceptModel model, IMovieConcept entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // MovieConcept Properties
                // <None>
                // Related Objects
                && model.MovieId == entity.MovieId
                && model.ConceptId == entity.ConceptId
                ;
        }
    }
}
