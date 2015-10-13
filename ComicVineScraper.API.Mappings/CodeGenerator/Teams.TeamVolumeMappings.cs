// <auto-generated>
// <copyright file="Teams.ITeamVolumeMappings.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Mapping Layer functions between TeamVolume and TeamVolumeModel.</summary>
// <remarks>This file was auto-generated using MappingFileMaster.tt in
// ComicVineScraper.API.Mappings\CodeGenerator</remarks>
// </auto-generated>
// ReSharper disable ClassWithVirtualMembersNeverInherited.Global, RedundantUsingDirective, UnusedMember.Global, UnusedMethodReturnValue.Global
namespace ComicVineScraper.API.Mappings//.Teams
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

    public static class TeamVolumeMapperExtensions
    {
        public static ITeamVolumeMapper Mapper = new TeamVolumeMapper();

        public static void OverrideMapper(ITeamVolumeMapper mapper) { Mapper = mapper; }

        public static ITeamVolume MapToEntity(this ITeamVolumeModel model, int currentDepth = 1)
        {
            return Mapper.MapToEntity(model, currentDepth);
        }
        public static void MapToEntity(this ITeamVolumeModel model, ref ITeamVolume entity, int currentDepth = 1)
        {
            Mapper.MapToEntity(model, ref entity, currentDepth);
        }
        public static ITeamVolumeModel MapToModel(this ITeamVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModel(entity, currentDepth);
        }
        public static ITeamVolumeModel MapToModelLite(this ITeamVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModelLite(entity, currentDepth);
        }
        public static ITeamVolumeModel MapToModelListing(this ITeamVolume entity, int currentDepth = 1)
        {
            return Mapper.MapToModelListing(entity, currentDepth);
        }
        public static ITeamVolumeSearchModel MapToSearchModel(this ITeamVolumeModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this ITeamVolumeModel model, ITeamVolume entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class TeamVolumeMapper : ITeamVolumeMapper
    {
        public virtual ITeamVolume MapToEntity(ITeamVolumeModel model, int currentDepth = 1)
        {
            currentDepth++;
            var entity = EntityMapper.MapToEntity<TeamVolume, ITeamVolumeModel>(model);
            // TeamVolume Properties
            // <None>
            // Related Objects
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(ITeamVolumeModel model, ref ITeamVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // TeamVolume Properties
            // <None>
            // Related Objects
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            entity.VolumeId = model.VolumeId;
            entity.Volume = (Volume)model.Volume?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual ITeamVolumeModel MapToModel(ITeamVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModel<ITeamVolume, TeamVolumeModel>(entity);
            // TeamVolume Properties
            // <None>
            // Related Objects
            model.TeamId = entity.TeamId;
            model.Team = entity.Team?.MapToModel();
            model.VolumeId = entity.VolumeId;
            model.Volume = entity.Volume?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual ITeamVolumeModel MapToModelLite(ITeamVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelLite<ITeamVolume, TeamVolumeModel>(entity);
            // TeamVolume Properties
            // <None>
            // Related Objects
            model.TeamId = entity.TeamId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ITeamVolumeModel MapToModelListing(ITeamVolume entity, int currentDepth = 1)
        {
            currentDepth++;
            var model = EntityMapper.MapToModelListing<ITeamVolume, TeamVolumeModel>(entity);
            // TeamVolume Properties
            // <None>
            // Related Objects
            model.TeamId = entity.TeamId;
            model.VolumeId = entity.VolumeId;
            // Return Entity
            return model;
        }

        public virtual ITeamVolumeSearchModel MapToSearchModel(ITeamVolumeModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<ITeamVolumeModel, TeamVolumeSearchModel>(model);
            // Search Properties
            searchModel.TeamId = model.TeamId;
            searchModel.TeamCustomKey = model.Team?.CustomKey;
            searchModel.TeamApiDetailUrl = model.Team?.ApiDetailUrl;
            searchModel.TeamSiteDetailUrl = model.Team?.SiteDetailUrl;
            searchModel.TeamName = model.Team?.Name;
            searchModel.TeamShortDescription = model.Team?.ShortDescription;
            searchModel.TeamDescription = model.Team?.Description;
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

        public virtual bool AreEqual(ITeamVolumeModel model, ITeamVolume entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // TeamVolume Properties
                // <None>
                // Related Objects
                && model.TeamId == entity.TeamId
                && model.VolumeId == entity.VolumeId
                ;
        }
    }
}
