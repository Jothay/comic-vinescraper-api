// <auto-generated>
// <copyright file="Episodes.IEpisodeCharacterFirstAppearanceMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between EpisodeCharacterFirstAppearance and EpisodeCharacterFirstAppearanceModel.</summary>
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

    public static class EpisodeCharacterFirstAppearanceMapperExtensions
    {
        public static IEpisodeCharacterFirstAppearanceMapper Mapper = new EpisodeCharacterFirstAppearanceMapper();

        public static void OverrideMapper(IEpisodeCharacterFirstAppearanceMapper mapper) { Mapper = mapper; }

        public static IEpisodeCharacterFirstAppearance MapToEntity(this IEpisodeCharacterFirstAppearanceModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this IEpisodeCharacterFirstAppearanceModel model, ref IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static IEpisodeCharacterFirstAppearanceModel MapToModel(this IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static IEpisodeCharacterFirstAppearanceModel MapToModelLite(this IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static IEpisodeCharacterFirstAppearanceModel MapToModelListing(this IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static IEpisodeCharacterFirstAppearanceSearchModel MapToSearchModel(this IEpisodeCharacterFirstAppearanceModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeCharacterFirstAppearanceModel model, IEpisodeCharacterFirstAppearance entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeCharacterFirstAppearanceMapper : IEpisodeCharacterFirstAppearanceMapper
    {
        public virtual IEpisodeCharacterFirstAppearance MapToEntity(IEpisodeCharacterFirstAppearanceModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<EpisodeCharacterFirstAppearance, IEpisodeCharacterFirstAppearanceModel>(model);
            // EpisodeCharacterFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodeCharacterFirstAppearanceModel model, ref IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeCharacterFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodeCharacterFirstAppearanceModel MapToModel(IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<IEpisodeCharacterFirstAppearance, EpisodeCharacterFirstAppearanceModel>(entity);
            // EpisodeCharacterFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodeCharacterFirstAppearanceModel MapToModelLite(IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<IEpisodeCharacterFirstAppearance, EpisodeCharacterFirstAppearanceModel>(entity);
            // EpisodeCharacterFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.CharacterId = entity.CharacterId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeCharacterFirstAppearanceModel MapToModelListing(IEpisodeCharacterFirstAppearance entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<IEpisodeCharacterFirstAppearance, EpisodeCharacterFirstAppearanceModel>(entity);
            // EpisodeCharacterFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.CharacterId = entity.CharacterId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeCharacterFirstAppearanceSearchModel MapToSearchModel(IEpisodeCharacterFirstAppearanceModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeCharacterFirstAppearanceModel, EpisodeCharacterFirstAppearanceSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IEpisodeCharacterFirstAppearanceModel model, IEpisodeCharacterFirstAppearance entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeCharacterFirstAppearance Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.CharacterId == entity.CharacterId
                ;
        }
    }
}
