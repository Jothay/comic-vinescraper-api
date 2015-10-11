// <auto-generated>
// <copyright file="Movies.IMovieWriterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieWriter model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Movies
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

    public static class MovieWriterMapperExtensions
    {
        public static IMovieWriterMapper Mapper = new MovieWriterMapper();

        public static void OverrideMapper(IMovieWriterMapper mapper) { Mapper = mapper; }

        public static IMovieWriter MapToEntity(this IMovieWriterModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IMovieWriterModel model, ref IMovieWriter entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IMovieWriterModel MapToModel(this IMovieWriter entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IMovieWriterModel MapToModelLite(this IMovieWriter entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IMovieWriterModel MapToModelListing(this IMovieWriter entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IMovieWriterSearchModel MapToSearchModel(this IMovieWriterModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IMovieWriterModel model, IMovieWriter entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class MovieWriterMapper : IMovieWriterMapper
    {
        public virtual IMovieWriter MapToEntity(IMovieWriterModel model)
        {
            var entity = EntityMapper.MapToEntity<MovieWriter, IMovieWriterModel>(model);
            // MovieWriter Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IMovieWriterModel model, ref IMovieWriter entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // MovieWriter Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IMovieWriterModel MapToModel(IMovieWriter entity)
        {
            var model = EntityMapper.MapToModel<IMovieWriter, MovieWriterModel>(entity);
            // MovieWriter Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            model.WriterId = entity.WriterId;
            model.Writer = entity.Writer?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IMovieWriterModel MapToModelLite(IMovieWriter entity)
        {
            var model = EntityMapper.MapToModelLite<IMovieWriter, MovieWriterModel>(entity);
            // MovieWriter Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IMovieWriterModel MapToModelListing(IMovieWriter entity)
        {
            var model = EntityMapper.MapToModelListing<IMovieWriter, MovieWriterModel>(entity);
            // MovieWriter Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IMovieWriterSearchModel MapToSearchModel(IMovieWriterModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IMovieWriterModel, MovieWriterSearchModel>(model);
            // Search Properties
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieApiDetailUrl = model.Movie?.ApiDetailUrl;
            searchModel.MovieSiteDetailUrl = model.Movie?.SiteDetailUrl;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieShortDescription = model.Movie?.ShortDescription;
            searchModel.MovieDescription = model.Movie?.Description;
            searchModel.WriterId = model.WriterId;
            searchModel.WriterCustomKey = model.Writer?.CustomKey;
            searchModel.WriterApiDetailUrl = model.Writer?.ApiDetailUrl;
            searchModel.WriterSiteDetailUrl = model.Writer?.SiteDetailUrl;
            searchModel.WriterName = model.Writer?.Name;
            searchModel.WriterShortDescription = model.Writer?.ShortDescription;
            searchModel.WriterDescription = model.Writer?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IMovieWriterModel model, IMovieWriter entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // MovieWriter Properties
                // <None>
                // Related Objects
                && model.MovieId == entity.MovieId
                && model.WriterId == entity.WriterId
                ;
        }
    }
}