// <auto-generated>
// <copyright file="Characters.ICharacterPowerModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterPower model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
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

    public static class CharacterPowerMapperExtensions
    {
        public static ICharacterPowerMapper Mapper = new CharacterPowerMapper();

        public static void OverrideMapper(ICharacterPowerMapper mapper) { Mapper = mapper; }

        public static ICharacterPower MapToEntity(this ICharacterPowerModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this ICharacterPowerModel model, ref ICharacterPower entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static ICharacterPowerModel MapToModel(this ICharacterPower entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static ICharacterPowerModel MapToModelLite(this ICharacterPower entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static ICharacterPowerModel MapToModelListing(this ICharacterPower entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static ICharacterPowerSearchModel MapToSearchModel(this ICharacterPowerModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterPowerModel model, ICharacterPower entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterPowerMapper : ICharacterPowerMapper
    {
        public virtual ICharacterPower MapToEntity(ICharacterPowerModel model)
        {
            var entity = EntityMapper.MapToEntity<CharacterPower, ICharacterPowerModel>(model);
            // CharacterPower Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.PowerId = model.PowerId;
            entity.Power = (Power)model.Power?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterPowerModel model, ref ICharacterPower entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterPower Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.PowerId = model.PowerId;
            entity.Power = (Power)model.Power?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterPowerModel MapToModel(ICharacterPower entity)
        {
            var model = EntityMapper.MapToModel<ICharacterPower, CharacterPowerModel>(entity);
            // CharacterPower Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.PowerId = entity.PowerId;
            model.Power = entity.Power?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterPowerModel MapToModelLite(ICharacterPower entity)
        {
            var model = EntityMapper.MapToModelLite<ICharacterPower, CharacterPowerModel>(entity);
            // CharacterPower Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.PowerId = entity.PowerId;
            // Return Entity
            return model;
        }

        public virtual ICharacterPowerModel MapToModelListing(ICharacterPower entity)
        {
            var model = EntityMapper.MapToModelListing<ICharacterPower, CharacterPowerModel>(entity);
            // CharacterPower Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.PowerId = entity.PowerId;
            // Return Entity
            return model;
        }

        public virtual ICharacterPowerSearchModel MapToSearchModel(ICharacterPowerModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterPowerModel, CharacterPowerSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.PowerId = model.PowerId;
            searchModel.PowerCustomKey = model.Power?.CustomKey;
            searchModel.PowerApiDetailUrl = model.Power?.ApiDetailUrl;
            searchModel.PowerSiteDetailUrl = model.Power?.SiteDetailUrl;
            searchModel.PowerName = model.Power?.Name;
            searchModel.PowerShortDescription = model.Power?.ShortDescription;
            searchModel.PowerDescription = model.Power?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterPowerModel model, ICharacterPower entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterPower Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.PowerId == entity.PowerId
                ;
        }
    }
}
