// <auto-generated>
// <copyright file="Movies.IMovieLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieLocation model interfaces.</summary>
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

    public static class MovieLocationMapperExtensions
    {
        public static IMovieLocationMapper Mapper = new MovieLocationMapper();

        public static void OverrideMapper(IMovieLocationMapper mapper) { Mapper = mapper; }

        public static IMovieLocation MapToEntity(this IMovieLocationModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IMovieLocationModel model, ref IMovieLocation entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IMovieLocationModel MapToModel(this IMovieLocation entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IMovieLocationModel MapToModelLite(this IMovieLocation entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IMovieLocationModel MapToModelListing(this IMovieLocation entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IMovieLocationSearchModel MapToSearchModel(this IMovieLocationModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IMovieLocationModel model, IMovieLocation entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class MovieLocationMapper : IMovieLocationMapper
    {
        public virtual IMovieLocation MapToEntity(IMovieLocationModel model)
        {
            var entity = EntityMapper.MapToEntity<MovieLocation, IMovieLocationModel>(model);
            // MovieLocation Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IMovieLocationModel model, ref IMovieLocation entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // MovieLocation Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IMovieLocationModel MapToModel(IMovieLocation entity)
        {
            var model = EntityMapper.MapToModel<IMovieLocation, MovieLocationModel>(entity);
            // MovieLocation Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IMovieLocationModel MapToModelLite(IMovieLocation entity)
        {
            var model = EntityMapper.MapToModelLite<IMovieLocation, MovieLocationModel>(entity);
            // MovieLocation Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual IMovieLocationModel MapToModelListing(IMovieLocation entity)
        {
            var model = EntityMapper.MapToModelListing<IMovieLocation, MovieLocationModel>(entity);
            // MovieLocation Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual IMovieLocationSearchModel MapToSearchModel(IMovieLocationModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IMovieLocationModel, MovieLocationSearchModel>(model);
            // Search Properties
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieApiDetailUrl = model.Movie?.ApiDetailUrl;
            searchModel.MovieSiteDetailUrl = model.Movie?.SiteDetailUrl;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieShortDescription = model.Movie?.ShortDescription;
            searchModel.MovieDescription = model.Movie?.Description;
            searchModel.LocationId = model.LocationId;
            searchModel.LocationCustomKey = model.Location?.CustomKey;
            searchModel.LocationApiDetailUrl = model.Location?.ApiDetailUrl;
            searchModel.LocationSiteDetailUrl = model.Location?.SiteDetailUrl;
            searchModel.LocationName = model.Location?.Name;
            searchModel.LocationShortDescription = model.Location?.ShortDescription;
            searchModel.LocationDescription = model.Location?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IMovieLocationModel model, IMovieLocation entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // MovieLocation Properties
                // <None>
                // Related Objects
                && model.MovieId == entity.MovieId
                && model.LocationId == entity.LocationId
                ;
        }
    }
}
