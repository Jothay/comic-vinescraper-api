// <auto-generated>
// <copyright file="StoryArcs.IStoryArcWriterMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between StoryArcWriter and StoryArcWriterModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.StoryArcs
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

    public static class StoryArcWriterMapperExtensions
    {
        public static IStoryArcWriterMapper Mapper = new StoryArcWriterMapper();

        public static void OverrideMapper(IStoryArcWriterMapper mapper) { Mapper = mapper; }

        public static IStoryArcWriter MapToEntity(this IStoryArcWriterModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IStoryArcWriterModel model, ref IStoryArcWriter entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IStoryArcWriterModel MapToModel(this IStoryArcWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IStoryArcWriterModel MapToModelLite(this IStoryArcWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IStoryArcWriterModel MapToModelListing(this IStoryArcWriter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IStoryArcWriterSearchModel MapToSearchModel(this IStoryArcWriterModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IStoryArcWriterModel model, IStoryArcWriter entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class StoryArcWriterMapper : IStoryArcWriterMapper
    {
        public virtual IStoryArcWriter MapToEntity(IStoryArcWriterModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<StoryArcWriter, IStoryArcWriterModel>(model);
            // StoryArcWriter Properties
            // <None>
            // Related Objects
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IStoryArcWriterModel model, ref IStoryArcWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // StoryArcWriter Properties
            // <None>
            // Related Objects
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            entity.WriterId = model.WriterId;
            entity.Writer = (Person)model.Writer?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IStoryArcWriterModel MapToModel(IStoryArcWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IStoryArcWriter, StoryArcWriterModel>(entity);
            // StoryArcWriter Properties
            // <None>
            // Related Objects
            model.StoryArcId = entity.StoryArcId;
            model.StoryArc = entity.StoryArc?.MapToModel();
            model.WriterId = entity.WriterId;
            model.Writer = entity.Writer?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IStoryArcWriterModel MapToModelLite(IStoryArcWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IStoryArcWriter, StoryArcWriterModel>(entity);
            // StoryArcWriter Properties
            // <None>
            // Related Objects
            model.StoryArcId = entity.StoryArcId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IStoryArcWriterModel MapToModelListing(IStoryArcWriter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IStoryArcWriter, StoryArcWriterModel>(entity);
            // StoryArcWriter Properties
            // <None>
            // Related Objects
            model.StoryArcId = entity.StoryArcId;
            model.WriterId = entity.WriterId;
            // Return Entity
            return model;
        }

        public virtual IStoryArcWriterSearchModel MapToSearchModel(IStoryArcWriterModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IStoryArcWriterModel, StoryArcWriterSearchModel>(model);
            // Search Properties
            searchModel.StoryArcId = model.StoryArcId;
            searchModel.StoryArcCustomKey = model.StoryArc?.CustomKey;
            searchModel.StoryArcApiDetailUrl = model.StoryArc?.ApiDetailUrl;
            searchModel.StoryArcSiteDetailUrl = model.StoryArc?.SiteDetailUrl;
            searchModel.StoryArcName = model.StoryArc?.Name;
            searchModel.StoryArcShortDescription = model.StoryArc?.ShortDescription;
            searchModel.StoryArcDescription = model.StoryArc?.Description;
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

        public virtual bool AreEqual(IStoryArcWriterModel model, IStoryArcWriter entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // StoryArcWriter Properties
                // <None>
                // Related Objects
                && model.StoryArcId == entity.StoryArcId
                && model.WriterId == entity.WriterId
                ;
        }
    }
}
