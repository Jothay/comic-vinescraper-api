// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationFirstAppearanceModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between EpisodeLocationFirstAppearance and EpisodeLocationFirstAppearanceModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVine.API.Mappings//.Episodes
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

    public static class EpisodeLocationFirstAppearanceMapperExtensions
    {
        public static IEpisodeLocationFirstAppearanceMapper Mapper = new EpisodeLocationFirstAppearanceMapper();

        public static void OverrideMapper(IEpisodeLocationFirstAppearanceMapper mapper) { Mapper = mapper; }

        public static IEpisodeLocationFirstAppearance MapToEntity(this IEpisodeLocationFirstAppearanceModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IEpisodeLocationFirstAppearanceModel model, ref IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IEpisodeLocationFirstAppearanceModel MapToModel(this IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IEpisodeLocationFirstAppearanceModel MapToModelLite(this IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IEpisodeLocationFirstAppearanceModel MapToModelListing(this IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IEpisodeLocationFirstAppearanceSearchModel MapToSearchModel(this IEpisodeLocationFirstAppearanceModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeLocationFirstAppearanceModel model, IEpisodeLocationFirstAppearance entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeLocationFirstAppearanceMapper : IEpisodeLocationFirstAppearanceMapper
    {
        public virtual IEpisodeLocationFirstAppearance MapToEntity(IEpisodeLocationFirstAppearanceModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<EpisodeLocationFirstAppearance, IEpisodeLocationFirstAppearanceModel>(model);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodeLocationFirstAppearanceModel model, ref IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodeLocationFirstAppearanceModel MapToModel(IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IEpisodeLocationFirstAppearance, EpisodeLocationFirstAppearanceModel>(entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodeLocationFirstAppearanceModel MapToModelLite(IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IEpisodeLocationFirstAppearance, EpisodeLocationFirstAppearanceModel>(entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeLocationFirstAppearanceModel MapToModelListing(IEpisodeLocationFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IEpisodeLocationFirstAppearance, EpisodeLocationFirstAppearanceModel>(entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeLocationFirstAppearanceSearchModel MapToSearchModel(IEpisodeLocationFirstAppearanceModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeLocationFirstAppearanceModel, EpisodeLocationFirstAppearanceSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
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

        public virtual bool AreEqual(IEpisodeLocationFirstAppearanceModel model, IEpisodeLocationFirstAppearance entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeLocationFirstAppearance Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.LocationId == entity.LocationId
                ;
        }
    }
}
