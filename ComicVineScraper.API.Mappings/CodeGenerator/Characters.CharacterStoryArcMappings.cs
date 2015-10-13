// <auto-generated>
// <copyright file="Characters.ICharacterStoryArcModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between CharacterStoryArc and CharacterStoryArcModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVine.API.Mappings//.Characters
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

    public static class CharacterStoryArcMapperExtensions
    {
        public static ICharacterStoryArcMapper Mapper = new CharacterStoryArcMapper();

        public static void OverrideMapper(ICharacterStoryArcMapper mapper) { Mapper = mapper; }

        public static ICharacterStoryArc MapToEntity(this ICharacterStoryArcModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ICharacterStoryArcModel model, ref ICharacterStoryArc entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ICharacterStoryArcModel MapToModel(this ICharacterStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ICharacterStoryArcModel MapToModelLite(this ICharacterStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ICharacterStoryArcModel MapToModelListing(this ICharacterStoryArc entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ICharacterStoryArcSearchModel MapToSearchModel(this ICharacterStoryArcModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterStoryArcModel model, ICharacterStoryArc entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterStoryArcMapper : ICharacterStoryArcMapper
    {
        public virtual ICharacterStoryArc MapToEntity(ICharacterStoryArcModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<CharacterStoryArc, ICharacterStoryArcModel>(model);
            // CharacterStoryArc Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterStoryArcModel model, ref ICharacterStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterStoryArc Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.StoryArcId = model.StoryArcId;
            entity.StoryArc = (StoryArc)model.StoryArc?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterStoryArcModel MapToModel(ICharacterStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ICharacterStoryArc, CharacterStoryArcModel>(entity);
            // CharacterStoryArc Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.StoryArcId = entity.StoryArcId;
            model.StoryArc = entity.StoryArc?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterStoryArcModel MapToModelLite(ICharacterStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ICharacterStoryArc, CharacterStoryArcModel>(entity);
            // CharacterStoryArc Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.StoryArcId = entity.StoryArcId;
            // Return Entity
            return model;
        }

        public virtual ICharacterStoryArcModel MapToModelListing(ICharacterStoryArc entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ICharacterStoryArc, CharacterStoryArcModel>(entity);
            // CharacterStoryArc Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.StoryArcId = entity.StoryArcId;
            // Return Entity
            return model;
        }

        public virtual ICharacterStoryArcSearchModel MapToSearchModel(ICharacterStoryArcModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterStoryArcModel, CharacterStoryArcSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
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

        public virtual bool AreEqual(ICharacterStoryArcModel model, ICharacterStoryArc entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterStoryArc Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.StoryArcId == entity.StoryArcId
                ;
        }
    }
}