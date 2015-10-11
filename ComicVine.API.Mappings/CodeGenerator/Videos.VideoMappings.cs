// <auto-generated>
// <copyright file="Videos.IVideoModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Video model interfaces.</summary>
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

    public static class VideoMapperExtensions
    {
        public static IVideoMapper Mapper = new VideoMapper();

        public static void OverrideMapper(IVideoMapper mapper) { Mapper = mapper; }

        public static IVideo MapToEntity(this IVideoModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IVideoModel model, ref IVideo entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IVideoModel MapToModel(this IVideo entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IVideoModel MapToModelLite(this IVideo entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IVideoModel MapToModelListing(this IVideo entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IVideoSearchModel MapToSearchModel(this IVideoModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IVideoModel model, IVideo entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class VideoMapper : IVideoMapper
    {
        public virtual IVideo MapToEntity(IVideoModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<Video, IVideoModel>(model);
            // Video Properties
            entity.LowUrl = model.LowUrl;
            entity.HighUrl = model.HighUrl;
            entity.HdUrl = model.HdUrl;
            entity.Url = model.Url;
            entity.LengthSeconds = model.LengthSeconds;
            entity.PublishDate = model.PublishDate;
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            entity.AuthorId = model.AuthorId;
            entity.Author = (Person)model.Author?.MapToEntity();
            entity.VideoTypeId = model.VideoTypeId;
            entity.VideoType = (VideoType)model.VideoType?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IVideoModel model, ref IVideo entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Video Properties
            entity.LowUrl = model.LowUrl;
            entity.HighUrl = model.HighUrl;
            entity.HdUrl = model.HdUrl;
            entity.Url = model.Url;
            entity.LengthSeconds = model.LengthSeconds;
            entity.PublishDate = model.PublishDate;
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            entity.AuthorId = model.AuthorId;
            entity.Author = (Person)model.Author?.MapToEntity();
            entity.VideoTypeId = model.VideoTypeId;
            entity.VideoType = (VideoType)model.VideoType?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IVideoModel MapToModel(IVideo entity)
        {
            var model = NameableEntityMapper.MapToModel<IVideo, VideoModel>(entity);
            // Video Properties
            model.LowUrl = entity.LowUrl;
            model.HighUrl = entity.HighUrl;
            model.HdUrl = entity.HdUrl;
            model.Url = entity.Url;
            model.LengthSeconds = entity.LengthSeconds;
            model.PublishDate = entity.PublishDate;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.PrimaryImageFile = entity.PrimaryImageFile?.MapToModel();
            model.AuthorId = entity.AuthorId;
            model.Author = entity.Author?.MapToModel();
            model.VideoTypeId = entity.VideoTypeId;
            model.VideoType = entity.VideoType?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IVideoModel MapToModelLite(IVideo entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IVideo, VideoModel>(entity);
            // Video Properties
            model.LowUrl = entity.LowUrl;
            model.HighUrl = entity.HighUrl;
            model.HdUrl = entity.HdUrl;
            model.Url = entity.Url;
            model.LengthSeconds = entity.LengthSeconds;
            model.PublishDate = entity.PublishDate;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.AuthorId = entity.AuthorId;
            model.VideoTypeId = entity.VideoTypeId;
            // Return Entity
            return model;
        }

        public virtual IVideoModel MapToModelListing(IVideo entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IVideo, VideoModel>(entity);
            // Video Properties
            model.LowUrl = entity.LowUrl;
            model.HighUrl = entity.HighUrl;
            model.HdUrl = entity.HdUrl;
            model.Url = entity.Url;
            model.LengthSeconds = entity.LengthSeconds;
            model.PublishDate = entity.PublishDate;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.AuthorId = entity.AuthorId;
            model.VideoTypeId = entity.VideoTypeId;
            // Return Entity
            return model;
        }

        public virtual IVideoSearchModel MapToSearchModel(IVideoModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IVideoModel, VideoSearchModel>(model);
            // Search Properties
            searchModel.PrimaryImageFileId = model.PrimaryImageFileId;
            searchModel.PrimaryImageFileCustomKey = model.PrimaryImageFile?.CustomKey;
            searchModel.PrimaryImageFileApiDetailUrl = model.PrimaryImageFile?.ApiDetailUrl;
            searchModel.PrimaryImageFileSiteDetailUrl = model.PrimaryImageFile?.SiteDetailUrl;
            searchModel.PrimaryImageFileName = model.PrimaryImageFile?.Name;
            searchModel.PrimaryImageFileShortDescription = model.PrimaryImageFile?.ShortDescription;
            searchModel.PrimaryImageFileDescription = model.PrimaryImageFile?.Description;
            searchModel.AuthorId = model.AuthorId;
            searchModel.AuthorCustomKey = model.Author?.CustomKey;
            searchModel.AuthorApiDetailUrl = model.Author?.ApiDetailUrl;
            searchModel.AuthorSiteDetailUrl = model.Author?.SiteDetailUrl;
            searchModel.AuthorName = model.Author?.Name;
            searchModel.AuthorShortDescription = model.Author?.ShortDescription;
            searchModel.AuthorDescription = model.Author?.Description;
            searchModel.VideoTypeId = model.VideoTypeId;
            searchModel.VideoTypeCustomKey = model.VideoType?.CustomKey;
            searchModel.VideoTypeApiDetailUrl = model.VideoType?.ApiDetailUrl;
            searchModel.VideoTypeSiteDetailUrl = model.VideoType?.SiteDetailUrl;
            searchModel.VideoTypeName = model.VideoType?.Name;
            searchModel.VideoTypeShortDescription = model.VideoType?.ShortDescription;
            searchModel.VideoTypeDescription = model.VideoType?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IVideoModel model, IVideo entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Video Properties
                && model.LowUrl == entity.LowUrl
                && model.HighUrl == entity.HighUrl
                && model.HdUrl == entity.HdUrl
                && model.Url == entity.Url
                && model.LengthSeconds == entity.LengthSeconds
                && model.PublishDate == entity.PublishDate
                // Related Objects
                && model.PrimaryImageFileId == entity.PrimaryImageFileId
                && model.AuthorId == entity.AuthorId
                && model.VideoTypeId == entity.VideoTypeId
                ;
        }
    }
}