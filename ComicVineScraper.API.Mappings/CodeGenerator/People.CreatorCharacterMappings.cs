// <auto-generated>
// <copyright file="People.ICreatorCharacterModel.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved. ComicVine Original Api Copyright (c) ComicVine a subsidiary of CBS.
// </copyright>
// <summary>Implements the Mapping Layer functions between CreatorCharacter and CreatorCharacterModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in ComicVine.API.Mappings\Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVine.API.Mappings//.People
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

    public static class CreatorCharacterMapperExtensions
    {
        public static ICreatorCharacterMapper Mapper = new CreatorCharacterMapper();

        public static void OverrideMapper(ICreatorCharacterMapper mapper) { Mapper = mapper; }

        public static ICreatorCharacter MapToEntity(this ICreatorCharacterModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ICreatorCharacterModel model, ref ICreatorCharacter entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ICreatorCharacterModel MapToModel(this ICreatorCharacter entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ICreatorCharacterModel MapToModelLite(this ICreatorCharacter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ICreatorCharacterModel MapToModelListing(this ICreatorCharacter entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ICreatorCharacterSearchModel MapToSearchModel(this ICreatorCharacterModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICreatorCharacterModel model, ICreatorCharacter entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CreatorCharacterMapper : ICreatorCharacterMapper
    {
        public virtual ICreatorCharacter MapToEntity(ICreatorCharacterModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<CreatorCharacter, ICreatorCharacterModel>(model);
            // CreatorCharacter Properties
            // <None>
            // Related Objects
            entity.PersonId = model.PersonId;
            entity.Creator = (Person)model.Creator?.MapToEntity();
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICreatorCharacterModel model, ref ICreatorCharacter entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CreatorCharacter Properties
            // <None>
            // Related Objects
            entity.PersonId = model.PersonId;
            entity.Creator = (Person)model.Creator?.MapToEntity();
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICreatorCharacterModel MapToModel(ICreatorCharacter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ICreatorCharacter, CreatorCharacterModel>(entity);
            // CreatorCharacter Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            model.Creator = entity.Creator?.MapToModel();
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICreatorCharacterModel MapToModelLite(ICreatorCharacter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ICreatorCharacter, CreatorCharacterModel>(entity);
            // CreatorCharacter Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            model.CharacterId = entity.CharacterId;
            // Return Entity
            return model;
        }

        public virtual ICreatorCharacterModel MapToModelListing(ICreatorCharacter entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ICreatorCharacter, CreatorCharacterModel>(entity);
            // CreatorCharacter Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            model.CharacterId = entity.CharacterId;
            // Return Entity
            return model;
        }

        public virtual ICreatorCharacterSearchModel MapToSearchModel(ICreatorCharacterModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICreatorCharacterModel, CreatorCharacterSearchModel>(model);
            // Search Properties
            searchModel.PersonId = model.PersonId;
            searchModel.CreatorApiDetailUrl = model.Creator?.ApiDetailUrl;
            searchModel.CreatorSiteDetailUrl = model.Creator?.SiteDetailUrl;
            searchModel.CreatorName = model.Creator?.Name;
            searchModel.CreatorShortDescription = model.Creator?.ShortDescription;
            searchModel.CreatorDescription = model.Creator?.Description;
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

        public virtual bool AreEqual(ICreatorCharacterModel model, ICreatorCharacter entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CreatorCharacter Properties
                // <None>
                // Related Objects
                && model.PersonId == entity.PersonId
                && model.CharacterId == entity.CharacterId
                ;
        }
    }
}