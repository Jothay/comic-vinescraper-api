// <auto-generated>
// <copyright file="Volumes.IVolumeWriterModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between VolumeWriter and VolumeWriterModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
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

    public static class VolumeWriterMapperExtensions
    {
        public static IVolumeWriterMapper Mapper = new VolumeWriterMapper();

        public static void OverrideMapper(IVolumeWriterMapper mapper) { Mapper = mapper; }

        public static IVolumeWriter MapToEntity(this IVolumeWriterModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IVolumeWriterModel model, ref IVolumeWriter entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IVolumeWriterModel MapToModel(this IVolumeWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IVolumeWriterModel MapToModelLite(this IVolumeWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IVolumeWriterModel MapToModelListing(this IVolumeWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IVolumeWriterSearchModel MapToSearchModel(this IVolumeWriterModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IVolumeWriterModel model, IVolumeWriter entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class VolumeWriterMapper : IVolumeWriterMapper
    {
        public virtual IVolumeWriter MapToEntity(IVolumeWriterModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<VolumeWriter, IVolumeWriterModel>(model);
            // VolumeWriter Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IVolumeWriterModel model, ref IVolumeWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // VolumeWriter Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IVolumeWriterModel MapToModel(IVolumeWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IVolumeWriter, VolumeWriterModel>(entity);
            // VolumeWriter Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            model.WriterId = entity.WriterId;
            model.Writer = entity.Writer?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IVolumeWriterModel MapToModelLite(IVolumeWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IVolumeWriter, VolumeWriterModel>(entity);
            // VolumeWriter Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IVolumeWriterModel MapToModelListing(IVolumeWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IVolumeWriter, VolumeWriterModel>(entity);
            // VolumeWriter Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IVolumeWriterSearchModel MapToSearchModel(IVolumeWriterModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IVolumeWriterModel, VolumeWriterSearchModel>(model);
            // Search Properties
            searchModel.VolumeId = model.VolumeId;
            searchModel.VolumeCustomKey = model.Volume?.CustomKey;
            searchModel.VolumeApiDetailUrl = model.Volume?.ApiDetailUrl;
            searchModel.VolumeSiteDetailUrl = model.Volume?.SiteDetailUrl;
            searchModel.VolumeName = model.Volume?.Name;
            searchModel.VolumeShortDescription = model.Volume?.ShortDescription;
            searchModel.VolumeDescription = model.Volume?.Description;
            searchModel.WriterId = model.WriterId;
            searchModel.WriterCustomKey = model.Writer?.CustomKey;
            searchModel.WriterApiDetailUrl = model.Writer?.ApiDetailUrl;
            searchModel.WriterSiteDetailUrl = model.Writer?.SiteDetailUrl;
            searchModel.WriterName = model.Writer?.Name;
            searchModel.WriterShortDescription = model.Writer?.ShortDescription;
            searchModel.WriterDescription = model.Writer?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IVolumeWriterModel model, IVolumeWriter entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // VolumeWriter Properties
                // <None>
                // Related Objects
                && model.VolumeId == entity.VolumeId
                && model.WriterId == entity.WriterId
                ;
        }
    }
}
