// <auto-generated>
// <copyright file="Concepts.IConceptMovieMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between ConceptMovie and ConceptMovieModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Concepts
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

    public static class ConceptMovieMapperExtensions
    {
        public static IConceptMovieMapper Mapper = new ConceptMovieMapper();

        public static void OverrideMapper(IConceptMovieMapper mapper) { Mapper = mapper; }

        public static IConceptMovie MapToEntity(this IConceptMovieModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IConceptMovieModel model, ref IConceptMovie entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IConceptMovieModel MapToModel(this IConceptMovie entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IConceptMovieModel MapToModelLite(this IConceptMovie entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IConceptMovieModel MapToModelListing(this IConceptMovie entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IConceptMovieSearchModel MapToSearchModel(this IConceptMovieModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IConceptMovieModel model, IConceptMovie entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ConceptMovieMapper : IConceptMovieMapper
    {
        public virtual IConceptMovie MapToEntity(IConceptMovieModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<ConceptMovie, IConceptMovieModel>(model);
            // ConceptMovie Properties
            // <None>
            // Related Objects
            entity.ConceptId = model.ConceptId;
            entity.Concept = (Concept)model.Concept?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IConceptMovieModel model, ref IConceptMovie entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // ConceptMovie Properties
            // <None>
            // Related Objects
            entity.ConceptId = model.ConceptId;
            entity.Concept = (Concept)model.Concept?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IConceptMovieModel MapToModel(IConceptMovie entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IConceptMovie, ConceptMovieModel>(entity);
            // ConceptMovie Properties
            // <None>
            // Related Objects
            model.ConceptId = entity.ConceptId;
            model.Concept = entity.Concept?.MapToModel();
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IConceptMovieModel MapToModelLite(IConceptMovie entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IConceptMovie, ConceptMovieModel>(entity);
            // ConceptMovie Properties
            // <None>
            // Related Objects
            model.ConceptId = entity.ConceptId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public virtual IConceptMovieModel MapToModelListing(IConceptMovie entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IConceptMovie, ConceptMovieModel>(entity);
            // ConceptMovie Properties
            // <None>
            // Related Objects
            model.ConceptId = entity.ConceptId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public virtual IConceptMovieSearchModel MapToSearchModel(IConceptMovieModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IConceptMovieModel, ConceptMovieSearchModel>(model);
            // Search Properties
            searchModel.ConceptId = model.ConceptId;
            searchModel.ConceptCustomKey = model.Concept?.CustomKey;
            searchModel.ConceptApiDetailUrl = model.Concept?.ApiDetailUrl;
            searchModel.ConceptSiteDetailUrl = model.Concept?.SiteDetailUrl;
            searchModel.ConceptName = model.Concept?.Name;
            searchModel.ConceptShortDescription = model.Concept?.ShortDescription;
            searchModel.ConceptDescription = model.Concept?.Description;
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieApiDetailUrl = model.Movie?.ApiDetailUrl;
            searchModel.MovieSiteDetailUrl = model.Movie?.SiteDetailUrl;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieShortDescription = model.Movie?.ShortDescription;
            searchModel.MovieDescription = model.Movie?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IConceptMovieModel model, IConceptMovie entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // ConceptMovie Properties
                // <None>
                // Related Objects
                && model.ConceptId == entity.ConceptId
                && model.MovieId == entity.MovieId
                ;
        }
    }
}
