// <auto-generated>
// <copyright file="Volumes.IVolumeTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VolumeTeam model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Volumes
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

    public static class VolumeTeamMapperExtensions
    {
        public static readonly VolumeTeamMapper Mapper = new VolumeTeamMapper();

        public static IVolumeTeam MapToEntity(this IVolumeTeamModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IVolumeTeamModel model, ref IVolumeTeam entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IVolumeTeamModel MapToModel(this IVolumeTeam entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IVolumeTeamModel MapToModelLite(this IVolumeTeam entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IVolumeTeamModel MapToModelListing(this IVolumeTeam entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IVolumeTeamSearchModel MapToSearchModel(this IVolumeTeamModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IVolumeTeamModel model, IVolumeTeam entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class VolumeTeamMapper : IVolumeTeamMapper
    {
        public IVolumeTeam MapToEntity(IVolumeTeamModel model)
        {
            var entity = EntityMapper.MapToEntity<VolumeTeam, IVolumeTeamModel>(model);
            // VolumeTeam Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IVolumeTeamModel model, ref IVolumeTeam entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // VolumeTeam Properties
            // <None>
            // Related Objects
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IVolumeTeamModel MapToModel(IVolumeTeam entity)
        {
            var model = EntityMapper.MapToModel<IVolumeTeam, VolumeTeamModel>(entity);
            // VolumeTeam Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            model.TeamId = entity.TeamId;
            model.Team = entity.Team?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IVolumeTeamModel MapToModelLite(IVolumeTeam entity)
        {
            var model = EntityMapper.MapToModelLite<IVolumeTeam, VolumeTeamModel>(entity);
            // VolumeTeam Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public IVolumeTeamModel MapToModelListing(IVolumeTeam entity)
        {
            var model = EntityMapper.MapToModelListing<IVolumeTeam, VolumeTeamModel>(entity);
            // VolumeTeam Properties
            // <None>
            // Related Objects
            model.VolumeId = entity.VolumeId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public IVolumeTeamSearchModel MapToSearchModel(IVolumeTeamModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IVolumeTeamModel, VolumeTeamSearchModel>(model);
            // Search Properties
            searchModel.VolumeId = model.VolumeId;
            searchModel.VolumeCustomKey = model.Volume?.CustomKey;
            searchModel.VolumeName = model.Volume?.Name;
            searchModel.VolumeDescription = model.Volume?.Description;
            searchModel.TeamId = model.TeamId;
            searchModel.TeamCustomKey = model.Team?.CustomKey;
            searchModel.TeamName = model.Team?.Name;
            searchModel.TeamDescription = model.Team?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IVolumeTeamModel model, IVolumeTeam entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // VolumeTeam Properties
                // <None>
                // Related Objects
                && model.VolumeId == entity.VolumeId
                && model.TeamId == entity.TeamId
                ;
        }
    }
}
