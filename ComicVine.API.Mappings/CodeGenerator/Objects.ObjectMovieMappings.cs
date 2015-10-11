// <auto-generated>
// <copyright file="Objects.IObjectMovieModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectMovie model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Objects
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

    public static class ObjectMovieMapperExtensions
    {
        public static readonly ObjectMovieMapper Mapper = new ObjectMovieMapper();

        public static IObjectMovie MapToEntity(this IObjectMovieModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IObjectMovieModel model, ref IObjectMovie entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IObjectMovieModel MapToModel(this IObjectMovie entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IObjectMovieModel MapToModelLite(this IObjectMovie entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IObjectMovieModel MapToModelListing(this IObjectMovie entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IObjectMovieSearchModel MapToSearchModel(this IObjectMovieModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IObjectMovieModel model, IObjectMovie entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class ObjectMovieMapper : IObjectMovieMapper
    {
        public IObjectMovie MapToEntity(IObjectMovieModel model)
        {
            var entity = EntityMapper.MapToEntity<ObjectMovie, IObjectMovieModel>(model);
            // ObjectMovie Properties
            // <None>
            // Related Objects
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IObjectMovieModel model, ref IObjectMovie entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // ObjectMovie Properties
            // <None>
            // Related Objects
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            entity.MovieId = model.MovieId;
            entity.Movie = (Movie)model.Movie?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IObjectMovieModel MapToModel(IObjectMovie entity)
        {
            var model = EntityMapper.MapToModel<IObjectMovie, ObjectMovieModel>(entity);
            // ObjectMovie Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.Object = entity.Object?.MapToModel();
            model.MovieId = entity.MovieId;
            model.Movie = entity.Movie?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IObjectMovieModel MapToModelLite(IObjectMovie entity)
        {
            var model = EntityMapper.MapToModelLite<IObjectMovie, ObjectMovieModel>(entity);
            // ObjectMovie Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public IObjectMovieModel MapToModelListing(IObjectMovie entity)
        {
            var model = EntityMapper.MapToModelListing<IObjectMovie, ObjectMovieModel>(entity);
            // ObjectMovie Properties
            // <None>
            // Related Objects
            model.ObjectId = entity.ObjectId;
            model.MovieId = entity.MovieId;
            // Return Entity
            return model;
        }

        public IObjectMovieSearchModel MapToSearchModel(IObjectMovieModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IObjectMovieModel, ObjectMovieSearchModel>(model);
            // Search Properties
            searchModel.ObjectId = model.ObjectId;
            searchModel.ObjectCustomKey = model.Object?.CustomKey;
            searchModel.ObjectName = model.Object?.Name;
            searchModel.ObjectDescription = model.Object?.Description;
            searchModel.MovieId = model.MovieId;
            searchModel.MovieCustomKey = model.Movie?.CustomKey;
            searchModel.MovieName = model.Movie?.Name;
            searchModel.MovieDescription = model.Movie?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IObjectMovieModel model, IObjectMovie entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // ObjectMovie Properties
                // <None>
                // Related Objects
                && model.ObjectId == entity.ObjectId
                && model.MovieId == entity.MovieId
                ;
        }
    }
}
