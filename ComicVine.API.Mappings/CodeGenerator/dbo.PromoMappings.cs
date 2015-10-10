// <auto-generated>
// <copyright file="dbo.IPromoModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Promo model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.Mappings//.dbo
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
        public static readonly PromoMapper Mapper = new PromoMapper();

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
        public IPromo MapToEntity(IPromoModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<Promo, IPromoModel>(model);
            // Promo Properties
            entity.Link = model.Link;
            entity.ResourceType = model.ResourceType;
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile.MapToEntity();
            entity.AuthorId = model.AuthorId;
            entity.Author = (Author)model.Author.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IPromoModel model, ref IPromo entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Promo Properties
            entity.Link = model.Link;
            entity.ResourceType = model.ResourceType;
            // Related Objects
            entity.PrimaryImageFileId = model.PrimaryImageFileId;
            entity.PrimaryImageFile = (ImageFile)model.PrimaryImageFile.MapToEntity();
            entity.AuthorId = model.AuthorId;
            entity.Author = (Author)model.Author.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IPromoModel MapToModel(IPromo entity)
        {
            var model = NameableEntityMapper.MapToModel<IPromo, PromoModel>(entity);
            // Promo Properties
            model.Link = entity.Link;
            model.ResourceType = entity.ResourceType;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.PrimaryImageFile = entity.PrimaryImageFile.MapToModel();
            model.AuthorId = entity.AuthorId;
            model.Author = entity.Author.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IPromoModel MapToModelLite(IPromo entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IPromo, PromoModel>(entity);
            // Promo Properties
            model.Link = entity.Link;
            model.ResourceType = entity.ResourceType;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.AuthorId = entity.AuthorId;
            // Return Entity
            return model;
        }

        public IPromoModel MapToModelListing(IPromo entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IPromo, PromoModel>(entity);
            // Promo Properties
            model.Link = entity.Link;
            model.ResourceType = entity.ResourceType;
            // Related Objects
            model.PrimaryImageFileId = entity.PrimaryImageFileId;
            model.AuthorId = entity.AuthorId;
            // Return Entity
            return model;
        }

        public IPromoSearchModel MapToSearchModel(IPromoModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IPromoModel, PromoSearchModel>(model);
            // Search Properties
            searchModel.PrimaryImageFileId = model.PrimaryImageFileId;
            searchModel.PrimaryImageFileCustomKey = model.PrimaryImageFile.CustomKey;
            searchModel.PrimaryImageFileName = model.PrimaryImageFile.Name;
            searchModel.PrimaryImageFileDescription = model.PrimaryImageFile.Description;
            searchModel.AuthorId = model.AuthorId;
            searchModel.AuthorCustomKey = model.Author.CustomKey;
            searchModel.AuthorName = model.Author.Name;
            searchModel.AuthorDescription = model.Author.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IPromoModel model, IPromo entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Promo Properties
                && model.Link == entity.Link
                && model.ResourceType == entity.ResourceType
                // Related Objects
                && model.PrimaryImageFileId == entity.PrimaryImageFileId
                && model.AuthorId == entity.AuthorId
                ;
        }
    }
}