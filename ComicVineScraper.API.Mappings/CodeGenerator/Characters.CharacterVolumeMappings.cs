// <auto-generated>
// <copyright file="Characters.ICharacterVolumeMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between CharacterVolume and CharacterVolumeModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Characters
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

    public static class CharacterVolumeMapperExtensions
    {
        public static ICharacterVolumeMapper Mapper = new CharacterVolumeMapper();

        public static void OverrideMapper(ICharacterVolumeMapper mapper) { Mapper = mapper; }

        public static ICharacterVolume MapToEntity(this ICharacterVolumeModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ICharacterVolumeModel model, ref ICharacterVolume entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ICharacterVolumeModel MapToModel(this ICharacterVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ICharacterVolumeModel MapToModelLite(this ICharacterVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ICharacterVolumeModel MapToModelListing(this ICharacterVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ICharacterVolumeSearchModel MapToSearchModel(this ICharacterVolumeModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ICharacterVolumeModel model, ICharacterVolume entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class CharacterVolumeMapper : ICharacterVolumeMapper
    {
        public virtual ICharacterVolume MapToEntity(ICharacterVolumeModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<CharacterVolume, ICharacterVolumeModel>(model);
            // CharacterVolume Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ICharacterVolumeModel model, ref ICharacterVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // CharacterVolume Properties
            // <None>
            // Related Objects
            entity.CharacterId = model.CharacterId;
            entity.Character = (Character)model.Character?.MapToEntity();
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ICharacterVolumeModel MapToModel(ICharacterVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ICharacterVolume, CharacterVolumeModel>(entity);
            // CharacterVolume Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.Character = entity.Character?.MapToModel();
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ICharacterVolumeModel MapToModelLite(ICharacterVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ICharacterVolume, CharacterVolumeModel>(entity);
            // CharacterVolume Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ICharacterVolumeModel MapToModelListing(ICharacterVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ICharacterVolume, CharacterVolumeModel>(entity);
            // CharacterVolume Properties
            // <None>
            // Related Objects
            model.CharacterId = entity.CharacterId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ICharacterVolumeSearchModel MapToSearchModel(ICharacterVolumeModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ICharacterVolumeModel, CharacterVolumeSearchModel>(model);
            // Search Properties
            searchModel.CharacterId = model.CharacterId;
            searchModel.CharacterCustomKey = model.Character?.CustomKey;
            searchModel.CharacterApiDetailUrl = model.Character?.ApiDetailUrl;
            searchModel.CharacterSiteDetailUrl = model.Character?.SiteDetailUrl;
            searchModel.CharacterName = model.Character?.Name;
            searchModel.CharacterShortDescription = model.Character?.ShortDescription;
            searchModel.CharacterDescription = model.Character?.Description;
            searchModel.VolumeId = model.VolumeId;
            searchModel.VolumeCustomKey = model.Volume?.CustomKey;
            searchModel.VolumeApiDetailUrl = model.Volume?.ApiDetailUrl;
            searchModel.VolumeSiteDetailUrl = model.Volume?.SiteDetailUrl;
            searchModel.VolumeName = model.Volume?.Name;
            searchModel.VolumeShortDescription = model.Volume?.ShortDescription;
            searchModel.VolumeDescription = model.Volume?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(ICharacterVolumeModel model, ICharacterVolume entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // CharacterVolume Properties
                // <None>
                // Related Objects
                && model.CharacterId == entity.CharacterId
                && model.VolumeId == entity.VolumeId
                ;
        }
    }
}
