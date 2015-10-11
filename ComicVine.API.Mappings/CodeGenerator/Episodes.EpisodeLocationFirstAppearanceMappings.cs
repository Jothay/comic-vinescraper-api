// <auto-generated>
// <copyright file="Episodes.IEpisodeLocationFirstAppearanceModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeLocationFirstAppearance model interfaces.</summary>
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

    public static class EpisodeLocationFirstAppearanceMapperExtensions
    {
        public static readonly EpisodeLocationFirstAppearanceMapper Mapper = new EpisodeLocationFirstAppearanceMapper();

        public static IEpisodeLocationFirstAppearance MapToEntity(this IEpisodeLocationFirstAppearanceModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IEpisodeLocationFirstAppearanceModel model, ref IEpisodeLocationFirstAppearance entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IEpisodeLocationFirstAppearanceModel MapToModel(this IEpisodeLocationFirstAppearance entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IEpisodeLocationFirstAppearanceModel MapToModelLite(this IEpisodeLocationFirstAppearance entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IEpisodeLocationFirstAppearanceModel MapToModelListing(this IEpisodeLocationFirstAppearance entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IEpisodeLocationFirstAppearanceSearchModel MapToSearchModel(this IEpisodeLocationFirstAppearanceModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeLocationFirstAppearanceModel model, IEpisodeLocationFirstAppearance entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeLocationFirstAppearanceMapper : IEpisodeLocationFirstAppearanceMapper
    {
        public IEpisodeLocationFirstAppearance MapToEntity(IEpisodeLocationFirstAppearanceModel model)
        {
            var entity = EntityMapper.MapToEntity<EpisodeLocationFirstAppearance, IEpisodeLocationFirstAppearanceModel>(model);
            // EpisodeLocationFirstAppearance Properties
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

        public void MapToEntity(IEpisodeLocationFirstAppearanceModel model, ref IEpisodeLocationFirstAppearance entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.LocationId = model.LocationId;
            entity.Location = (Location)model.Location?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IEpisodeLocationFirstAppearanceModel MapToModel(IEpisodeLocationFirstAppearance entity)
        {
            var model = EntityMapper.MapToModel<IEpisodeLocationFirstAppearance, EpisodeLocationFirstAppearanceModel>(entity);
            // EpisodeLocationFirstAppearance Properties
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

        public IEpisodeLocationFirstAppearanceModel MapToModelLite(IEpisodeLocationFirstAppearance entity)
        {
            var model = EntityMapper.MapToModelLite<IEpisodeLocationFirstAppearance, EpisodeLocationFirstAppearanceModel>(entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public IEpisodeLocationFirstAppearanceModel MapToModelListing(IEpisodeLocationFirstAppearance entity)
        {
            var model = EntityMapper.MapToModelListing<IEpisodeLocationFirstAppearance, EpisodeLocationFirstAppearanceModel>(entity);
            // EpisodeLocationFirstAppearance Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.LocationId = entity.LocationId;
            // Return Entity
            return model;
        }

        public IEpisodeLocationFirstAppearanceSearchModel MapToSearchModel(IEpisodeLocationFirstAppearanceModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeLocationFirstAppearanceModel, EpisodeLocationFirstAppearanceSearchModel>(model);
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

        public bool AreEqual(IEpisodeLocationFirstAppearanceModel model, IEpisodeLocationFirstAppearance entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeLocationFirstAppearance Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.LocationId == entity.LocationId
                ;
        }
    }
}
