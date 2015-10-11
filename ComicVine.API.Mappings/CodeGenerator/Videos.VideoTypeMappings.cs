// <auto-generated>
// <copyright file="Videos.IVideoTypeModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the VideoType model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Videos
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

    public static class VideoTypeMapperExtensions
    {
        public static IVideoTypeMapper Mapper = new VideoTypeMapper();

        public static void OverrideMapper(IVideoTypeMapper mapper) { Mapper = mapper; }

        public static IVideoType MapToEntity(this IVideoTypeModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IVideoTypeModel model, ref IVideoType entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IVideoTypeModel MapToModel(this IVideoType entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IVideoTypeModel MapToModelLite(this IVideoType entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IVideoTypeModel MapToModelListing(this IVideoType entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IVideoTypeSearchModel MapToSearchModel(this IVideoTypeModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IVideoTypeModel model, IVideoType entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class VideoTypeMapper : IVideoTypeMapper
    {
        public virtual IVideoType MapToEntity(IVideoTypeModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<VideoType, IVideoTypeModel>(model);
            // VideoType Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            entity.Videos = model.Videos?.Where(i => i.Active).Select(VideoMapperExtensions.MapToEntity).Cast<Video>().ToList();
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IVideoTypeModel model, ref IVideoType entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // VideoType Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            entity.Videos = model.Videos?.Where(i => i.Active).Select(VideoMapperExtensions.MapToEntity).ToList();
        }

        public virtual IVideoTypeModel MapToModel(IVideoType entity)
        {
            var model = NameableEntityMapper.MapToModel<IVideoType, VideoTypeModel>(entity);
            // VideoType Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.Videos = entity.Videos?.Where(i => i.Active).Select(VideoMapperExtensions.MapToModelLite).ToList();
            // Return Entity
            return model;
        }

        public virtual IVideoTypeModel MapToModelLite(IVideoType entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IVideoType, VideoTypeModel>(entity);
            // VideoType Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IVideoTypeModel MapToModelListing(IVideoType entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IVideoType, VideoTypeModel>(entity);
            // VideoType Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IVideoTypeSearchModel MapToSearchModel(IVideoTypeModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IVideoTypeModel, VideoTypeSearchModel>(model);
            // Search Properties
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IVideoTypeModel model, IVideoType entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // VideoType Properties
                // <None>
                // Related Objects
                // <None>
                ;
        }
    }
}