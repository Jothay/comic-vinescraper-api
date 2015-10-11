// <auto-generated>
// <copyright file="Episodes.IEpisodeObjectModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the EpisodeObject model interfaces.</summary>
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

    public static class EpisodeObjectMapperExtensions
    {
        public static IEpisodeObjectMapper Mapper = new EpisodeObjectMapper();

        public static void OverrideMapper(IEpisodeObjectMapper mapper) { Mapper = mapper; }

        public static IEpisodeObject MapToEntity(this IEpisodeObjectModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IEpisodeObjectModel model, ref IEpisodeObject entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IEpisodeObjectModel MapToModel(this IEpisodeObject entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IEpisodeObjectModel MapToModelLite(this IEpisodeObject entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IEpisodeObjectModel MapToModelListing(this IEpisodeObject entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IEpisodeObjectSearchModel MapToSearchModel(this IEpisodeObjectModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IEpisodeObjectModel model, IEpisodeObject entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class EpisodeObjectMapper : IEpisodeObjectMapper
    {
        public virtual IEpisodeObject MapToEntity(IEpisodeObjectModel model)
        {
            var entity = EntityMapper.MapToEntity<EpisodeObject, IEpisodeObjectModel>(model);
            // EpisodeObject Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IEpisodeObjectModel model, ref IEpisodeObject entity)
        {
            // Assign Base properties
            EntityMapper.MapToEntity(model, ref entity);
            // EpisodeObject Properties
            // <None>
            // Related Objects
            entity.EpisodeId = model.EpisodeId;
            entity.Episode = (Episode)model.Episode?.MapToEntity();
            entity.ObjectId = model.ObjectId;
            entity.Object = (Object)model.Object?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IEpisodeObjectModel MapToModel(IEpisodeObject entity)
        {
            var model = EntityMapper.MapToModel<IEpisodeObject, EpisodeObjectModel>(entity);
            // EpisodeObject Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.Episode = entity.Episode?.MapToModel();
            model.ObjectId = entity.ObjectId;
            model.Object = entity.Object?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IEpisodeObjectModel MapToModelLite(IEpisodeObject entity)
        {
            var model = EntityMapper.MapToModelLite<IEpisodeObject, EpisodeObjectModel>(entity);
            // EpisodeObject Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.ObjectId = entity.ObjectId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeObjectModel MapToModelListing(IEpisodeObject entity)
        {
            var model = EntityMapper.MapToModelListing<IEpisodeObject, EpisodeObjectModel>(entity);
            // EpisodeObject Properties
            // <None>
            // Related Objects
            model.EpisodeId = entity.EpisodeId;
            model.ObjectId = entity.ObjectId;
            // Return Entity
            return model;
        }

        public virtual IEpisodeObjectSearchModel MapToSearchModel(IEpisodeObjectModel model)
        {
            var searchModel = EntityMapper.MapToSearchModel<IEpisodeObjectModel, EpisodeObjectSearchModel>(model);
            // Search Properties
            searchModel.EpisodeId = model.EpisodeId;
            searchModel.EpisodeCustomKey = model.Episode?.CustomKey;
            searchModel.EpisodeApiDetailUrl = model.Episode?.ApiDetailUrl;
            searchModel.EpisodeSiteDetailUrl = model.Episode?.SiteDetailUrl;
            searchModel.EpisodeName = model.Episode?.Name;
            searchModel.EpisodeShortDescription = model.Episode?.ShortDescription;
            searchModel.EpisodeDescription = model.Episode?.Description;
            searchModel.ObjectId = model.ObjectId;
            searchModel.ObjectCustomKey = model.Object?.CustomKey;
            searchModel.ObjectApiDetailUrl = model.Object?.ApiDetailUrl;
            searchModel.ObjectSiteDetailUrl = model.Object?.SiteDetailUrl;
            searchModel.ObjectName = model.Object?.Name;
            searchModel.ObjectShortDescription = model.Object?.ShortDescription;
            searchModel.ObjectDescription = model.Object?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IEpisodeObjectModel model, IEpisodeObject entity)
        {
            return EntityMapper.AreEqual(model, entity)
                // EpisodeObject Properties
                // <None>
                // Related Objects
                && model.EpisodeId == entity.EpisodeId
                && model.ObjectId == entity.ObjectId
                ;
        }
    }
}
