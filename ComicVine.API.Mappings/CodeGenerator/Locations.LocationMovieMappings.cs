// <auto-generated>
// <copyright file="Locations.ILocationMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationMovie model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Locations
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

    public static class LocationMovieMapperExtensions
    {
        public static readonly LocationMovieMapper Mapper = new LocationMovieMapper();

        public static ILocationMovie MapToEntity(this ILocationMovieModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ILocationMovieModel model, ref ILocationMovie entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ILocationMovieModel MapToModel(this ILocationMovie entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ILocationMovieModel MapToModelLite(this ILocationMovie entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ILocationMovieModel MapToModelListing(this ILocationMovie entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ILocationMovieSearchModel MapToSearchModel(this ILocationMovieModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ILocationMovieModel model, ILocationMovie entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class LocationMovieMapper : ILocationMovieMapper
    {
        public ILocationMovie MapToEntity(ILocationMovieModel model)
        {
            var entity = EntityMapper.MapToEntity<LocationMovie, ILocationMovieModel>(model);
            // LocationMovie Properties
            // <None>
            // Related Objects
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(ILocationMovieModel model, ref ILocationMovie entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // LocationMovie Properties
            // <None>
            // Related Objects
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public ILocationMovieModel MapToModel(ILocationMovie entity)
        {
            var model = EntityMapper.MapToModel<ILocationMovie, LocationMovieModel>(entity);
            // LocationMovie Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public ILocationMovieModel MapToModelLite(ILocationMovie entity)
        {
            var model = EntityMapper.MapToModelLite<ILocationMovie, LocationMovieModel>(entity);
            // LocationMovie Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public ILocationMovieModel MapToModelListing(ILocationMovie entity)
        {
            var model = EntityMapper.MapToModelListing<ILocationMovie, LocationMovieModel>(entity);
            // LocationMovie Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public ILocationMovieSearchModel MapToSearchModel(ILocationMovieModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ILocationMovieModel, LocationMovieSearchModel>(model);
            // Search Properties
            searchModel.LocationId = model.LocationId;
            searchModel.LocationCustomKey = model.Location?.CustomKey;
            searchModel.LocationName = model.Location?.Name;
            searchModel.LocationDescription = model.Location?.Description;
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieDescription = model.Movie?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(ILocationMovieModel model, ILocationMovie entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // LocationMovie Properties
                // <None>
                // Related Objects
                && model.LocationId == entity.LocationId
                && model.MovieId == entity.MovieId
                ;
        }
    }
}
