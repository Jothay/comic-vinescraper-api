// <auto-generated>
// <copyright file="Movies.IMovieStudioModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the MovieStudio model interfaces.</summary>
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

    public static class MovieStudioMapperExtensions
    {
        public static IMovieStudioMapper Mapper = new MovieStudioMapper();

        public static void OverrideMapper(IMovieStudioMapper mapper) { Mapper = mapper; }

        public static IMovieStudio MapToEntity(this IMovieStudioModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IMovieStudioModel model, ref IMovieStudio entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IMovieStudioModel MapToModel(this IMovieStudio entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IMovieStudioModel MapToModelLite(this IMovieStudio entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IMovieStudioModel MapToModelListing(this IMovieStudio entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IMovieStudioSearchModel MapToSearchModel(this IMovieStudioModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IMovieStudioModel model, IMovieStudio entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class MovieStudioMapper : IMovieStudioMapper
    {
        public virtual IMovieStudio MapToEntity(IMovieStudioModel model)
        {
            var entity = EntityMapper.MapToEntity<MovieStudio, IMovieStudioModel>(model);
            // MovieStudio Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.StudioId = model.StudioId;
            entity.Studio = (Studio)model.Studio?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IMovieStudioModel model, ref IMovieStudio entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // MovieStudio Properties
            // <None>
            // Related Objects
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            entity.StudioId = model.StudioId;
            entity.Studio = (Studio)model.Studio?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IMovieStudioModel MapToModel(IMovieStudio entity)
        {
            var model = EntityMapper.MapToModel<IMovieStudio, MovieStudioModel>(entity);
            // MovieStudio Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            model.StudioId = entity.StudioId;
            model.Studio = entity.Studio?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IMovieStudioModel MapToModelLite(IMovieStudio entity)
        {
            var model = EntityMapper.MapToModelLite<IMovieStudio, MovieStudioModel>(entity);
            // MovieStudio Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.StudioId = entity.StudioId;
            // Return Entity
            return model;
        }

        public virtual IMovieStudioModel MapToModelListing(IMovieStudio entity)
        {
            var model = EntityMapper.MapToModelListing<IMovieStudio, MovieStudioModel>(entity);
            // MovieStudio Properties
            // <None>
            // Related Objects
            model.MovieId = entity.MovieId;
            model.StudioId = entity.StudioId;
            // Return Entity
            return model;
        }

        public virtual IMovieStudioSearchModel MapToSearchModel(IMovieStudioModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IMovieStudioModel, MovieStudioSearchModel>(model);
            // Search Properties
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieApiDetailUrl = model.Movie?.ApiDetailUrl;
            searchModel.MovieSiteDetailUrl = model.Movie?.SiteDetailUrl;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieShortDescription = model.Movie?.ShortDescription;
            searchModel.MovieDescription = model.Movie?.Description;
            searchModel.StudioId = model.StudioId;
            searchModel.StudioCustomKey = model.Studio?.CustomKey;
            searchModel.StudioApiDetailUrl = model.Studio?.ApiDetailUrl;
            searchModel.StudioSiteDetailUrl = model.Studio?.SiteDetailUrl;
            searchModel.StudioName = model.Studio?.Name;
            searchModel.StudioShortDescription = model.Studio?.ShortDescription;
            searchModel.StudioDescription = model.Studio?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IMovieStudioModel model, IMovieStudio entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // MovieStudio Properties
                // <None>
                // Related Objects
                && model.MovieId == entity.MovieId
                && model.StudioId == entity.StudioId
                ;
        }
    }
}
