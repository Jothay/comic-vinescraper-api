// <auto-generated>
// <copyright file="Volumes.IVolumeLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeLocation model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Volumes
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

    public static class VolumeLocationMapperExtensions
    {
        public static IVolumeLocationMapper Mapper = new VolumeLocationMapper();

        public static void OverrideMapper(IVolumeLocationMapper mapper) { Mapper = mapper; }

        public static IVolumeLocation MapToEntity(this IVolumeLocationModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IVolumeLocationModel model, ref IVolumeLocation entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IVolumeLocationModel MapToModel(this IVolumeLocation entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IVolumeLocationModel MapToModelLite(this IVolumeLocation entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IVolumeLocationModel MapToModelListing(this IVolumeLocation entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IVolumeLocationSearchModel MapToSearchModel(this IVolumeLocationModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IVolumeLocationModel model, IVolumeLocation entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class VolumeLocationMapper : IVolumeLocationMapper
    {
        public virtual IVolumeLocation MapToEntity(IVolumeLocationModel model)
        {
            var entity = EntityMapper.MapToEntity<VolumeLocation, IVolumeLocationModel>(model);
            // VolumeLocation Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IVolumeLocationModel model, ref IVolumeLocation entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // VolumeLocation Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IVolumeLocationModel MapToModel(IVolumeLocation entity)
        {
            var model = EntityMapper.MapToModel<IVolumeLocation, VolumeLocationModel>(entity);
            // VolumeLocation Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IVolumeLocationModel MapToModelLite(IVolumeLocation entity)
        {
            var model = EntityMapper.MapToModelLite<IVolumeLocation, VolumeLocationModel>(entity);
            // VolumeLocation Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual IVolumeLocationModel MapToModelListing(IVolumeLocation entity)
        {
            var model = EntityMapper.MapToModelListing<IVolumeLocation, VolumeLocationModel>(entity);
            // VolumeLocation Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual IVolumeLocationSearchModel MapToSearchModel(IVolumeLocationModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IVolumeLocationModel, VolumeLocationSearchModel>(model);
            // Search Properties
            searchModel.VolumeId = model.VolumeId;
            searchModel.VolumeCustomKey = model.Volume?.CustomKey;
            searchModel.VolumeApiDetailUrl = model.Volume?.ApiDetailUrl;
            searchModel.VolumeSiteDetailUrl = model.Volume?.SiteDetailUrl;
            searchModel.VolumeName = model.Volume?.Name;
            searchModel.VolumeShortDescription = model.Volume?.ShortDescription;
            searchModel.VolumeDescription = model.Volume?.Description;
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

        public virtual bool AreEqual(IVolumeLocationModel model, IVolumeLocation entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // VolumeLocation Properties
                // <None>
                // Related Objects
                && model.VolumeId == entity.VolumeId
                && model.LocationId == entity.LocationId
                ;
        }
    }
}
