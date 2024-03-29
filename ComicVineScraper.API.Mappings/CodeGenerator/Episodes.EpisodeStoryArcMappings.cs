// <auto-generated>
// <copyright file="Episodes.IEpisodeStoryArcMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between EpisodeStoryArc and EpisodeStoryArcModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Episodes
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

    public static class EpisodeStoryArcMapperExtensions
    {
        public static IEpisodeStoryArcMapper Mapper = new EpisodeStoryArcMapper();

        public static void OverrideMapper(IEpisodeStoryArcMapper mapper) { Mapper = mapper; }

        public static IEpisodeStoryArc MapToEntity(this IEpisodeStoryArcModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IEpisodeStoryArcModel model, ref IEpisodeStoryArc entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IEpisodeStoryArcModel MapToModel(this IEpisodeStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IEpisodeStoryArcModel MapToModelLite(this IEpisodeStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IEpisodeStoryArcModel MapToModelListing(this IEpisodeStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IEpisodeStoryArcSearchModel MapToSearchModel(this IEpisodeStoryArcModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeStoryArcModel model, IEpisodeStoryArc entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeStoryArcMapper : IEpisodeStoryArcMapper
    {
        public virtual IEpisodeStoryArc MapToEntity(IEpisodeStoryArcModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<EpisodeStoryArc, IEpisodeStoryArcModel>(model);
            // EpisodeStoryArc Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodeStoryArcModel model, ref IEpisodeStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeStoryArc Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodeStoryArcModel MapToModel(IEpisodeStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IEpisodeStoryArc, EpisodeStoryArcModel>(entity);
            // EpisodeStoryArc Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.StoryArcId = entity.StoryArcId;
            model.StoryArc = entity.StoryArc?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodeStoryArcModel MapToModelLite(IEpisodeStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IEpisodeStoryArc, EpisodeStoryArcModel>(entity);
            // EpisodeStoryArc Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.StoryArcId = entity.StoryArcId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeStoryArcModel MapToModelListing(IEpisodeStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IEpisodeStoryArc, EpisodeStoryArcModel>(entity);
            // EpisodeStoryArc Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.StoryArcId = entity.StoryArcId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeStoryArcSearchModel MapToSearchModel(IEpisodeStoryArcModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeStoryArcModel, EpisodeStoryArcSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
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

        public virtual bool AreEqual(IEpisodeStoryArcModel model, IEpisodeStoryArc entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeStoryArc Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.StoryArcId == entity.StoryArcId
                ;
        }
    }
}
