// <auto-generated>
// <copyright file="Locations.ILocationStoryArcMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between LocationStoryArc and LocationStoryArcModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Locations
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

    public static class LocationStoryArcMapperExtensions
    {
        public static ILocationStoryArcMapper Mapper = new LocationStoryArcMapper();

        public static void OverrideMapper(ILocationStoryArcMapper mapper) { Mapper = mapper; }

        public static ILocationStoryArc MapToEntity(this ILocationStoryArcModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ILocationStoryArcModel model, ref ILocationStoryArc entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ILocationStoryArcModel MapToModel(this ILocationStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ILocationStoryArcModel MapToModelLite(this ILocationStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ILocationStoryArcModel MapToModelListing(this ILocationStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ILocationStoryArcSearchModel MapToSearchModel(this ILocationStoryArcModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ILocationStoryArcModel model, ILocationStoryArc entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class LocationStoryArcMapper : ILocationStoryArcMapper
    {
        public virtual ILocationStoryArc MapToEntity(ILocationStoryArcModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<LocationStoryArc, ILocationStoryArcModel>(model);
            // LocationStoryArc Properties
            // <None>
            // Related Objects
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ILocationStoryArcModel model, ref ILocationStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // LocationStoryArc Properties
            // <None>
            // Related Objects
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ILocationStoryArcModel MapToModel(ILocationStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ILocationStoryArc, LocationStoryArcModel>(entity);
            // LocationStoryArc Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            model.StoryArcId = entity.StoryArcId;
            model.StoryArc = entity.StoryArc?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ILocationStoryArcModel MapToModelLite(ILocationStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ILocationStoryArc, LocationStoryArcModel>(entity);
            // LocationStoryArc Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.StoryArcId = entity.StoryArcId;
            // Return Entity
            return model;
        }

        public virtual ILocationStoryArcModel MapToModelListing(ILocationStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ILocationStoryArc, LocationStoryArcModel>(entity);
            // LocationStoryArc Properties
            // <None>
            // Related Objects
            model.LocationId = entity.LocationId;
            model.StoryArcId = entity.StoryArcId;
            // Return Entity
            return model;
        }

        public virtual ILocationStoryArcSearchModel MapToSearchModel(ILocationStoryArcModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ILocationStoryArcModel, LocationStoryArcSearchModel>(model);
            // Search Properties
            searchModel.LocationId = model.LocationId;
            searchModel.LocationCustomKey = model.Location?.CustomKey;
            searchModel.LocationApiDetailUrl = model.Location?.ApiDetailUrl;
            searchModel.LocationSiteDetailUrl = model.Location?.SiteDetailUrl;
            searchModel.LocationName = model.Location?.Name;
            searchModel.LocationShortDescription = model.Location?.ShortDescription;
            searchModel.LocationDescription = model.Location?.Description;
            searchModel.StoryArcId = model.StoryArcId;
            searchModel.StoryArcCustomKey = model.StoryArc?.CustomKey;
            searchModel.StoryArcApiDetailUrl = model.StoryArc?.ApiDetailUrl;
            searchModel.StoryArcSiteDetailUrl = model.StoryArc?.SiteDetailUrl;
            searchModel.StoryArcName = model.StoryArc?.Name;
            searchModel.StoryArcShortDescription = model.StoryArc?.ShortDescription;
            searchModel.StoryArcDescription = model.StoryArc?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ILocationStoryArcModel model, ILocationStoryArc entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // LocationStoryArc Properties
                // <None>
                // Related Objects
                && model.LocationId == entity.LocationId
                && model.StoryArcId == entity.StoryArcId
                ;
        }
    }
}
