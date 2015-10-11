// <auto-generated>
// <copyright file="Series.ISeriesLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the SeriesLocation model interfaces.</summary>
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

    public static class SeriesLocationMapperExtensions
    {
        public static ISeriesLocationMapper Mapper = new SeriesLocationMapper();

        public static void OverrideMapper(ISeriesLocationMapper mapper) { Mapper = mapper; }

        public static ISeriesLocation MapToEntity(this ISeriesLocationModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ISeriesLocationModel model, ref ISeriesLocation entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ISeriesLocationModel MapToModel(this ISeriesLocation entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ISeriesLocationModel MapToModelLite(this ISeriesLocation entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ISeriesLocationModel MapToModelListing(this ISeriesLocation entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ISeriesLocationSearchModel MapToSearchModel(this ISeriesLocationModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ISeriesLocationModel model, ISeriesLocation entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class SeriesLocationMapper : ISeriesLocationMapper
    {
        public virtual ISeriesLocation MapToEntity(ISeriesLocationModel model)
        {
            var entity = EntityMapper.MapToEntity<SeriesLocation, ISeriesLocationModel>(model);
            // SeriesLocation Properties
            // <None>
            // Related Objects
            entity.SeriesId = model.SeriesId;
            entity.Series = (Series)model.Series?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ISeriesLocationModel model, ref ISeriesLocation entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // SeriesLocation Properties
            // <None>
            // Related Objects
            entity.SeriesId = model.SeriesId;
            entity.Series = (Series)model.Series?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ISeriesLocationModel MapToModel(ISeriesLocation entity)
        {
            var model = EntityMapper.MapToModel<ISeriesLocation, SeriesLocationModel>(entity);
            // SeriesLocation Properties
            // <None>
            // Related Objects
            model.SeriesId = entity.SeriesId;
            model.Series = entity.Series?.MapToModel();
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ISeriesLocationModel MapToModelLite(ISeriesLocation entity)
        {
            var model = EntityMapper.MapToModelLite<ISeriesLocation, SeriesLocationModel>(entity);
            // SeriesLocation Properties
            // <None>
            // Related Objects
            model.SeriesId = entity.SeriesId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual ISeriesLocationModel MapToModelListing(ISeriesLocation entity)
        {
            var model = EntityMapper.MapToModelListing<ISeriesLocation, SeriesLocationModel>(entity);
            // SeriesLocation Properties
            // <None>
            // Related Objects
            model.SeriesId = entity.SeriesId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual ISeriesLocationSearchModel MapToSearchModel(ISeriesLocationModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ISeriesLocationModel, SeriesLocationSearchModel>(model);
            // Search Properties
            searchModel.SeriesId = model.SeriesId;
            searchModel.SeriesCustomKey = model.Series?.CustomKey;
            searchModel.SeriesApiDetailUrl = model.Series?.ApiDetailUrl;
            searchModel.SeriesSiteDetailUrl = model.Series?.SiteDetailUrl;
            searchModel.SeriesName = model.Series?.Name;
            searchModel.SeriesShortDescription = model.Series?.ShortDescription;
            searchModel.SeriesDescription = model.Series?.Description;
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

        public virtual bool AreEqual(ISeriesLocationModel model, ISeriesLocation entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // SeriesLocation Properties
                // <None>
                // Related Objects
                && model.SeriesId == entity.SeriesId
                && model.LocationId == entity.LocationId
                ;
        }
    }
}