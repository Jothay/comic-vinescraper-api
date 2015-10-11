// <auto-generated>
// <copyright file="Episodes.IEpisodeTeamFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeTeamFirstAppearance model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
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

    public static class EpisodeTeamFirstAppearanceMapperExtensions
    {
        public static IEpisodeTeamFirstAppearanceMapper Mapper = new EpisodeTeamFirstAppearanceMapper();

        public static void OverrideMapper(IEpisodeTeamFirstAppearanceMapper mapper) { Mapper = mapper; }

        public static IEpisodeTeamFirstAppearance MapToEntity(this IEpisodeTeamFirstAppearanceModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IEpisodeTeamFirstAppearanceModel model, ref IEpisodeTeamFirstAppearance entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IEpisodeTeamFirstAppearanceModel MapToModel(this IEpisodeTeamFirstAppearance entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IEpisodeTeamFirstAppearanceModel MapToModelLite(this IEpisodeTeamFirstAppearance entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IEpisodeTeamFirstAppearanceModel MapToModelListing(this IEpisodeTeamFirstAppearance entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IEpisodeTeamFirstAppearanceSearchModel MapToSearchModel(this IEpisodeTeamFirstAppearanceModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeTeamFirstAppearanceModel model, IEpisodeTeamFirstAppearance entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeTeamFirstAppearanceMapper : IEpisodeTeamFirstAppearanceMapper
    {
        public virtual IEpisodeTeamFirstAppearance MapToEntity(IEpisodeTeamFirstAppearanceModel model)
        {
            var entity = EntityMapper.MapToEntity<EpisodeTeamFirstAppearance, IEpisodeTeamFirstAppearanceModel>(model);
            // EpisodeTeamFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodeTeamFirstAppearanceModel model, ref IEpisodeTeamFirstAppearance entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeTeamFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.TeamId = model.TeamId;
            entity.Team = (Team)model.Team?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodeTeamFirstAppearanceModel MapToModel(IEpisodeTeamFirstAppearance entity)
        {
            var model = EntityMapper.MapToModel<IEpisodeTeamFirstAppearance, EpisodeTeamFirstAppearanceModel>(entity);
            // EpisodeTeamFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.TeamId = entity.TeamId;
            model.Team = entity.Team?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodeTeamFirstAppearanceModel MapToModelLite(IEpisodeTeamFirstAppearance entity)
        {
            var model = EntityMapper.MapToModelLite<IEpisodeTeamFirstAppearance, EpisodeTeamFirstAppearanceModel>(entity);
            // EpisodeTeamFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeTeamFirstAppearanceModel MapToModelListing(IEpisodeTeamFirstAppearance entity)
        {
            var model = EntityMapper.MapToModelListing<IEpisodeTeamFirstAppearance, EpisodeTeamFirstAppearanceModel>(entity);
            // EpisodeTeamFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.TeamId = entity.TeamId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeTeamFirstAppearanceSearchModel MapToSearchModel(IEpisodeTeamFirstAppearanceModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeTeamFirstAppearanceModel, EpisodeTeamFirstAppearanceSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
            searchModel.TeamId = model.TeamId;
            searchModel.TeamCustomKey = model.Team?.CustomKey;
            searchModel.TeamApiDetailUrl = model.Team?.ApiDetailUrl;
            searchModel.TeamSiteDetailUrl = model.Team?.SiteDetailUrl;
            searchModel.TeamName = model.Team?.Name;
            searchModel.TeamShortDescription = model.Team?.ShortDescription;
            searchModel.TeamDescription = model.Team?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IEpisodeTeamFirstAppearanceModel model, IEpisodeTeamFirstAppearance entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeTeamFirstAppearance Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.TeamId == entity.TeamId
                ;
        }
    }
}
