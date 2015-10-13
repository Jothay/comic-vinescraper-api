

// <auto-generated>
// <copyright file="Characters.ICharacterEnemyModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between CharacterEnemy and CharacterEnemyModel.</summary>
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

    public static class CharacterEnemyMapperExtensions
    {
        public static ICharacterEnemyMapper Mapper = new CharacterEnemyMapper();

        public static void OverrideMapper(ICharacterEnemyMapper mapper) { Mapper = mapper; }

        public static ICharacterEnemy MapToEntity(this ICharacterEnemyModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ICharacterEnemyModel model, ref ICharacterEnemy entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ICharacterEnemyModel MapToModel(this ICharacterEnemy entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ICharacterEnemyModel MapToModelLite(this ICharacterEnemy entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ICharacterEnemyModel MapToModelListing(this ICharacterEnemy entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ICharacterEnemySearchModel MapToSearchModel(this ICharacterEnemyModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterEnemyModel model, ICharacterEnemy entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterEnemyMapper : ICharacterEnemyMapper
    {
        public virtual ICharacterEnemy MapToEntity(ICharacterEnemyModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<CharacterEnemy, ICharacterEnemyModel>(model);
            // CharacterEnemy Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.EnemyId = model.EnemyId;
            entity.Enemy = (Character)model.Enemy?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterEnemyModel model, ref ICharacterEnemy entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterEnemy Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.EnemyId = model.EnemyId;
            entity.Enemy = (Character)model.Enemy?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterEnemyModel MapToModel(ICharacterEnemy entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ICharacterEnemy, CharacterEnemyModel>(entity);
            // CharacterEnemy Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.EnemyId = entity.EnemyId;
            model.Enemy = entity.Enemy?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterEnemyModel MapToModelLite(ICharacterEnemy entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ICharacterEnemy, CharacterEnemyModel>(entity);
            // CharacterEnemy Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.EnemyId = entity.EnemyId;
            // Return Entity
            return model;
        }

        public virtual ICharacterEnemyModel MapToModelListing(ICharacterEnemy entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ICharacterEnemy, CharacterEnemyModel>(entity);
            // CharacterEnemy Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.EnemyId = entity.EnemyId;
            // Return Entity
            return model;
        }

        public virtual ICharacterEnemySearchModel MapToSearchModel(ICharacterEnemyModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterEnemyModel, CharacterEnemySearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.EnemyId = model.EnemyId;
            searchModel.EnemyCustomKey = model.Enemy?.CustomKey;
            searchModel.EnemyApiDetailUrl = model.Enemy?.ApiDetailUrl;
            searchModel.EnemySiteDetailUrl = model.Enemy?.SiteDetailUrl;
            searchModel.EnemyName = model.Enemy?.Name;
            searchModel.EnemyShortDescription = model.Enemy?.ShortDescription;
            searchModel.EnemyDescription = model.Enemy?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterEnemyModel model, ICharacterEnemy entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterEnemy Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.EnemyId == entity.EnemyId
                ;
        }
    }
}