// <auto-generated>
// <copyright file="Locations.ILocationVolumeModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between LocationVolume and LocationVolumeModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
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

        public static ILocationVolume MapToEntity(this ILocationVolumeModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ILocationVolumeModel model, ref ILocationVolume entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ILocationVolumeModel MapToModel(this ILocationVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ILocationVolumeModel MapToModelLite(this ILocationVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ILocationVolumeModel MapToModelListing(this ILocationVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
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
        public virtual ILocationVolume MapToEntity(ILocationVolumeModel model, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual void MapToEntity(ILocationVolumeModel model, ref ILocationVolume entity, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual ILocationVolumeModel MapToModel(ILocationVolume entity, int currentDepth = 1)
        {
            currentDepth++;
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

        public virtual ILocationVolumeModel MapToModelLite(ILocationVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ILocationVolume, LocationVolumeModel>(entity);
            // LocationVolume Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ILocationVolumeModel MapToModelListing(ILocationVolume entity, int currentDepth = 1)
        {
            currentDepth++;
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
