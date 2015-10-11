// <auto-generated>
// <copyright file="People.ICreatorCharacterModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CreatorCharacter model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
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

        public static ICreatorCharacter MapToEntity(this ICreatorCharacterModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICreatorCharacterModel model, ref ICreatorCharacter entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICreatorCharacterModel MapToModel(this ICreatorCharacter entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICreatorCharacterModel MapToModelLite(this ICreatorCharacter entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICreatorCharacterModel MapToModelListing(this ICreatorCharacter entity)
        {
            return Mapper.MapToModelListing(entity);
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
        public virtual ICreatorCharacter MapToEntity(ICreatorCharacterModel model)
        {
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

        public virtual void MapToEntity(ICreatorCharacterModel model, ref ICreatorCharacter entity)
        {
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

        public virtual ICreatorCharacterModel MapToModel(ICreatorCharacter entity)
        {
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

        public virtual ICreatorCharacterModel MapToModelLite(ICreatorCharacter entity)
        {
            var model = EntityMapper.MapToModelLite<ICreatorCharacter, CreatorCharacterModel>(entity);
            // CreatorCharacter Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            model.CharacterId = entity.CharacterId;
            // Return Entity
            return model;
        }

        public virtual ICreatorCharacterModel MapToModelListing(ICreatorCharacter entity)
        {
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
