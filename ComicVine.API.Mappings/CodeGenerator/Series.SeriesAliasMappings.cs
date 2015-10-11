// <auto-generated>
// <copyright file="Series.ISeriesAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Series
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

    public static class SeriesAliasMapperExtensions
    {
        public static ISeriesAliasMapper Mapper = new SeriesAliasMapper();

        public static void OverrideMapper(ISeriesAliasMapper mapper) { Mapper = mapper; }

        public static ISeriesAlias MapToEntity(this ISeriesAliasModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ISeriesAliasModel model, ref ISeriesAlias entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ISeriesAliasModel MapToModel(this ISeriesAlias entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ISeriesAliasModel MapToModelLite(this ISeriesAlias entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ISeriesAliasModel MapToModelListing(this ISeriesAlias entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ISeriesAliasSearchModel MapToSearchModel(this ISeriesAliasModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ISeriesAliasModel model, ISeriesAlias entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class SeriesAliasMapper : ISeriesAliasMapper
    {
        public virtual ISeriesAlias MapToEntity(ISeriesAliasModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<SeriesAlias, ISeriesAliasModel>(model);
            // SeriesAlias Properties
            // <None>
            // Related Objects
            entity.SeriesId = model.SeriesId;
            entity.Series = (Series)model.Series?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ISeriesAliasModel model, ref ISeriesAlias entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // SeriesAlias Properties
            // <None>
            // Related Objects
            entity.SeriesId = model.SeriesId;
            entity.Series = (Series)model.Series?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ISeriesAliasModel MapToModel(ISeriesAlias entity)
        {
            var model = NameableEntityMapper.MapToModel<ISeriesAlias, SeriesAliasModel>(entity);
            // SeriesAlias Properties
            // <None>
            // Related Objects
            model.SeriesId = entity.SeriesId;
            model.Series = entity.Series?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ISeriesAliasModel MapToModelLite(ISeriesAlias entity)
        {
            var model = NameableEntityMapper.MapToModelLite<ISeriesAlias, SeriesAliasModel>(entity);
            // SeriesAlias Properties
            // <None>
            // Related Objects
            model.SeriesId = entity.SeriesId;
            // Return Entity
            return model;
        }

        public virtual ISeriesAliasModel MapToModelListing(ISeriesAlias entity)
        {
            var model = NameableEntityMapper.MapToModelListing<ISeriesAlias, SeriesAliasModel>(entity);
            // SeriesAlias Properties
            // <None>
            // Related Objects
            model.SeriesId = entity.SeriesId;
            // Return Entity
            return model;
        }

        public virtual ISeriesAliasSearchModel MapToSearchModel(ISeriesAliasModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<ISeriesAliasModel, SeriesAliasSearchModel>(model);
            // Search Properties
            searchModel.SeriesId = model.SeriesId;
            searchModel.SeriesCustomKey = model.Series?.CustomKey;
            searchModel.SeriesApiDetailUrl = model.Series?.ApiDetailUrl;
            searchModel.SeriesSiteDetailUrl = model.Series?.SiteDetailUrl;
            searchModel.SeriesName = model.Series?.Name;
            searchModel.SeriesShortDescription = model.Series?.ShortDescription;
            searchModel.SeriesDescription = model.Series?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ISeriesAliasModel model, ISeriesAlias entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // SeriesAlias Properties
                // <None>
                // Related Objects
                && model.SeriesId == entity.SeriesId
                ;
        }
    }
}