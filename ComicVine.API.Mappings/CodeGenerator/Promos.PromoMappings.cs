// <auto-generated>
// <copyright file="Promos.IPromoModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Promo model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.Promos
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

    public static class PromoMapperExtensions
    {
        public static IPromoMapper Mapper = new PromoMapper();

        public static void OverrideMapper(IPromoMapper mapper) { Mapper = mapper; }

        public static IPromo MapToEntity(this IPromoModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IPromoModel model, ref IPromo entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IPromoModel MapToModel(this IPromo entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IPromoModel MapToModelLite(this IPromo entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IPromoModel MapToModelListing(this IPromo entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IPromoSearchModel MapToSearchModel(this IPromoModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IPromoModel model, IPromo entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class PromoMapper : IPromoMapper
    {
        public virtual IPromo MapToEntity(IPromoModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<Promo, IPromoModel>(model);
            // Promo Properties
            entity.Link = model.Link;
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            entity.AuthorId = model.AuthorId;
            entity.Author = (Person)model.Author?.MapToEntity();
            entity.ResourceTypeId = model.ResourceTypeId;
            entity.ResourceType = (ResourceType)model.ResourceType?.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public virtual void MapToEntity(IPromoModel model, ref IPromo entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Promo Properties
            entity.Link = model.Link;
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile?.MapToEntity();
            entity.AuthorId = model.AuthorId;
            entity.Author = (Person)model.Author?.MapToEntity();
            entity.ResourceTypeId = model.ResourceTypeId;
            entity.ResourceType = (ResourceType)model.ResourceType?.MapToEntity();
            // Associated Objects
            // <None>
        }

        public virtual IPromoModel MapToModel(IPromo entity)
        {
            var model = NameableEntityMapper.MapToModel<IPromo, PromoModel>(entity);
            // Promo Properties
            model.Link = entity.Link;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.PrimaryImageFile = entity.PrimaryImageFile?.MapToModel();
            model.AuthorId = entity.AuthorId;
            model.Author = entity.Author?.MapToModel();
            model.ResourceTypeId = entity.ResourceTypeId;
            model.ResourceType = entity.ResourceType?.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public virtual IPromoModel MapToModelLite(IPromo entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IPromo, PromoModel>(entity);
            // Promo Properties
            model.Link = entity.Link;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.AuthorId = entity.AuthorId;
            model.ResourceTypeId = entity.ResourceTypeId;
            // Return Entity
            return model;
        }

        public virtual IPromoModel MapToModelListing(IPromo entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IPromo, PromoModel>(entity);
            // Promo Properties
            model.Link = entity.Link;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.AuthorId = entity.AuthorId;
            model.ResourceTypeId = entity.ResourceTypeId;
            // Return Entity
            return model;
        }

        public virtual IPromoSearchModel MapToSearchModel(IPromoModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IPromoModel, PromoSearchModel>(model);
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
            searchModel.ResourceTypeId = model.ResourceTypeId;
            searchModel.ResourceTypeCustomKey = model.ResourceType?.CustomKey;
            searchModel.ResourceTypeApiDetailUrl = model.ResourceType?.ApiDetailUrl;
            searchModel.ResourceTypeSiteDetailUrl = model.ResourceType?.SiteDetailUrl;
            searchModel.ResourceTypeName = model.ResourceType?.Name;
            searchModel.ResourceTypeShortDescription = model.ResourceType?.ShortDescription;
            searchModel.ResourceTypeDescription = model.ResourceType?.Description;
            // Return Search Model
            return searchModel;
        }

        public virtual bool AreEqual(IPromoModel model, IPromo entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Promo Properties
                && model.Link == entity.Link
                // Related Objects
                && model.PrimaryImageFileId == entity.PrimaryImageFileId
                && model.AuthorId == entity.AuthorId
                && model.ResourceTypeId == entity.ResourceTypeId
                ;
        }
    }
}