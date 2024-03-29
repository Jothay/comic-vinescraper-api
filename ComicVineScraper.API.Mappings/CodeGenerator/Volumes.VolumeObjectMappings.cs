// <auto-generated>
// <copyright file="Volumes.IVolumeObjectMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between VolumeObject and VolumeObjectModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Volumes
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

    public static class VolumeObjectMapperExtensions
    {
        public static IVolumeObjectMapper Mapper = new VolumeObjectMapper();

        public static void OverrideMapper(IVolumeObjectMapper mapper) { Mapper = mapper; }

        public static IVolumeObject MapToEntity(this IVolumeObjectModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IVolumeObjectModel model, ref IVolumeObject entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IVolumeObjectModel MapToModel(this IVolumeObject entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IVolumeObjectModel MapToModelLite(this IVolumeObject entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IVolumeObjectModel MapToModelListing(this IVolumeObject entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IVolumeObjectSearchModel MapToSearchModel(this IVolumeObjectModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IVolumeObjectModel model, IVolumeObject entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class VolumeObjectMapper : IVolumeObjectMapper
    {
        public virtual IVolumeObject MapToEntity(IVolumeObjectModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<VolumeObject, IVolumeObjectModel>(model);
            // VolumeObject Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IVolumeObjectModel model, ref IVolumeObject entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // VolumeObject Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IVolumeObjectModel MapToModel(IVolumeObject entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IVolumeObject, VolumeObjectModel>(entity);
            // VolumeObject Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            model.ObjectId = entity.ObjectId;
            model.Object = entity.Object?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IVolumeObjectModel MapToModelLite(IVolumeObject entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IVolumeObject, VolumeObjectModel>(entity);
            // VolumeObject Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.ObjectId = entity.ObjectId;
            // Return Entity
            return model;
        }

        public virtual IVolumeObjectModel MapToModelListing(IVolumeObject entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IVolumeObject, VolumeObjectModel>(entity);
            // VolumeObject Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.ObjectId = entity.ObjectId;
            // Return Entity
            return model;
        }

        public virtual IVolumeObjectSearchModel MapToSearchModel(IVolumeObjectModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IVolumeObjectModel, VolumeObjectSearchModel>(model);
            // Search Properties
            searchModel.VolumeId = model.VolumeId;
            searchModel.VolumeCustomKey = model.Volume?.CustomKey;
            searchModel.VolumeApiDetailUrl = model.Volume?.ApiDetailUrl;
            searchModel.VolumeSiteDetailUrl = model.Volume?.SiteDetailUrl;
            searchModel.VolumeName = model.Volume?.Name;
            searchModel.VolumeShortDescription = model.Volume?.ShortDescription;
            searchModel.VolumeDescription = model.Volume?.Description;
            searchModel.ObjectId = model.ObjectId;
            searchModel.ObjectCustomKey = model.Object?.CustomKey;
            searchModel.ObjectApiDetailUrl = model.Object?.ApiDetailUrl;
            searchModel.ObjectSiteDetailUrl = model.Object?.SiteDetailUrl;
            searchModel.ObjectName = model.Object?.Name;
            searchModel.ObjectShortDescription = model.Object?.ShortDescription;
            searchModel.ObjectDescription = model.Object?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IVolumeObjectModel model, IVolumeObject entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // VolumeObject Properties
                // <None>
                // Related Objects
                && model.VolumeId == entity.VolumeId
                && model.ObjectId == entity.ObjectId
                ;
        }
    }
}
