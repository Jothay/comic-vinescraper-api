// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocation model interfaces.</summary>
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

    public static class EpisodeLocationMapperExtensions
    {
        public static readonly EpisodeLocationMapper Mapper = new EpisodeLocationMapper();

        public static IEpisodeLocation MapToEntity(this IEpisodeLocationModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IEpisodeLocationModel model, ref IEpisodeLocation entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IEpisodeLocationModel MapToModel(this IEpisodeLocation entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IEpisodeLocationModel MapToModelLite(this IEpisodeLocation entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IEpisodeLocationModel MapToModelListing(this IEpisodeLocation entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IEpisodeLocationSearchModel MapToSearchModel(this IEpisodeLocationModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeLocationModel model, IEpisodeLocation entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeLocationMapper : IEpisodeLocationMapper
    {
        public IEpisodeLocation MapToEntity(IEpisodeLocationModel model)
        {
            var entity = EntityMapper.MapToEntity<EpisodeLocation, IEpisodeLocationModel>(model);
            // EpisodeLocation Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IEpisodeLocationModel model, ref IEpisodeLocation entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeLocation Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IEpisodeLocationModel MapToModel(IEpisodeLocation entity)
        {
            var model = EntityMapper.MapToModel<IEpisodeLocation, EpisodeLocationModel>(entity);
            // EpisodeLocation Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.LocationId = entity.LocationId;
            model.Location = entity.Location?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IEpisodeLocationModel MapToModelLite(IEpisodeLocation entity)
        {
            var model = EntityMapper.MapToModelLite<IEpisodeLocation, EpisodeLocationModel>(entity);
            // EpisodeLocation Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public IEpisodeLocationModel MapToModelListing(IEpisodeLocation entity)
        {
            var model = EntityMapper.MapToModelListing<IEpisodeLocation, EpisodeLocationModel>(entity);
            // EpisodeLocation Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public IEpisodeLocationSearchModel MapToSearchModel(IEpisodeLocationModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeLocationModel, EpisodeLocationSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeDescription = model.Episode?.Description;
            searchModel.LocationId = model.LocationId;
            searchModel.LocationCustomKey = model.Location?.CustomKey;
            searchModel.LocationName = model.Location?.Name;
            searchModel.LocationDescription = model.Location?.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IEpisodeLocationModel model, IEpisodeLocation entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeLocation Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.LocationId == entity.LocationId
                ;
        }
    }
}
