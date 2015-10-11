// <auto-generated>
// <copyright file="Locations.ILocationVolumeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationVolume model interfaces.</summary>
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

    public static class LocationVolumeMapperExtensions
    {
        public static ILocationVolumeMapper Mapper = new LocationVolumeMapper();

        public static void OverrideMapper(ILocationVolumeMapper mapper) { Mapper = mapper; }

        public static ILocationVolume MapToEntity(this ILocationVolumeModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ILocationVolumeModel model, ref ILocationVolume entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ILocationVolumeModel MapToModel(this ILocationVolume entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ILocationVolumeModel MapToModelLite(this ILocationVolume entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ILocationVolumeModel MapToModelListing(this ILocationVolume entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ILocationVolumeSearchModel MapToSearchModel(this ILocationVolumeModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ILocationVolumeModel model, ILocationVolume entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class LocationVolumeMapper : ILocationVolumeMapper
    {
        public virtual ILocationVolume MapToEntity(ILocationVolumeModel model)
        {
            var entity = EntityMapper.MapToEntity<LocationVolume, ILocationVolumeModel>(model);
            // LocationVolume Properties
            // <None>
            // Related Objects
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ILocationVolumeModel model, ref ILocationVolume entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // LocationVolume Properties
            // <None>
            // Related Objects
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ILocationVolumeModel MapToModel(ILocationVolume entity)
        {
            var model = EntityMapper.MapToModel<ILocationVolume, LocationVolumeModel>(entity);
            // LocationVolume Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ILocationVolumeModel MapToModelLite(ILocationVolume entity)
        {
            var model = EntityMapper.MapToModelLite<ILocationVolume, LocationVolumeModel>(entity);
            // LocationVolume Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ILocationVolumeModel MapToModelListing(ILocationVolume entity)
        {
            var model = EntityMapper.MapToModelListing<ILocationVolume, LocationVolumeModel>(entity);
            // LocationVolume Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ILocationVolumeSearchModel MapToSearchModel(ILocationVolumeModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ILocationVolumeModel, LocationVolumeSearchModel>(model);
            // Search Properties
            searchModel.LocationId = model.LocationId;
            searchModel.LocationCustomKey = model.Location?.CustomKey;
            searchModel.LocationApiDetailUrl = model.Location?.ApiDetailUrl;
            searchModel.LocationSiteDetailUrl = model.Location?.SiteDetailUrl;
            searchModel.LocationName = model.Location?.Name;
            searchModel.LocationShortDescription = model.Location?.ShortDescription;
            searchModel.LocationDescription = model.Location?.Description;
            searchModel.VolumeId = model.VolumeId;
            searchModel.VolumeCustomKey = model.Volume?.CustomKey;
            searchModel.VolumeApiDetailUrl = model.Volume?.ApiDetailUrl;
            searchModel.VolumeSiteDetailUrl = model.Volume?.SiteDetailUrl;
            searchModel.VolumeName = model.Volume?.Name;
            searchModel.VolumeShortDescription = model.Volume?.ShortDescription;
            searchModel.VolumeDescription = model.Volume?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ILocationVolumeModel model, ILocationVolume entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // LocationVolume Properties
                // <None>
                // Related Objects
                && model.LocationId == entity.LocationId
                && model.VolumeId == entity.VolumeId
                ;
        }
    }
}
