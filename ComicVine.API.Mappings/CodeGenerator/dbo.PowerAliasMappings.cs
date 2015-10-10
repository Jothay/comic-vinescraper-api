// <auto-generated>
// <copyright file="dbo.IPowerAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PowerAlias model interfaces.</summary>
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

    public static class PowerAliasMapperExtensions
    {
        public static readonly PowerAliasMapper Mapper = new PowerAliasMapper();

        public static IPowerAlias MapToEntity(this IPowerAliasModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IPowerAliasModel model, ref IPowerAlias entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IPowerAliasModel MapToModel(this IPowerAlias entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IPowerAliasModel MapToModelLite(this IPowerAlias entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IPowerAliasModel MapToModelListing(this IPowerAlias entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IPowerAliasSearchModel MapToSearchModel(this IPowerAliasModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IPowerAliasModel model, IPowerAlias entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class PowerAliasMapper : IPowerAliasMapper
    {
        public IPowerAlias MapToEntity(IPowerAliasModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<PowerAlias, IPowerAliasModel>(model);
            // PowerAlias Properties
            // <None>
            // Related Objects
            entity.PowerId = model.PowerId;
            entity.Power = (Power)model.Power.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IPowerAliasModel model, ref IPowerAlias entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // PowerAlias Properties
            // <None>
            // Related Objects
            entity.PowerId = model.PowerId;
            entity.Power = (Power)model.Power.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IPowerAliasModel MapToModel(IPowerAlias entity)
        {
            var model = NameableEntityMapper.MapToModel<IPowerAlias, PowerAliasModel>(entity);
            // PowerAlias Properties
            // <None>
            // Related Objects
            model.PowerId = entity.PowerId;
            model.Power = entity.Power.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IPowerAliasModel MapToModelLite(IPowerAlias entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IPowerAlias, PowerAliasModel>(entity);
            // PowerAlias Properties
            // <None>
            // Related Objects
            model.PowerId = entity.PowerId;
            // Return Entity
            return model;
        }

        public IPowerAliasModel MapToModelListing(IPowerAlias entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IPowerAlias, PowerAliasModel>(entity);
            // PowerAlias Properties
            // <None>
            // Related Objects
            model.PowerId = entity.PowerId;
            // Return Entity
            return model;
        }

        public IPowerAliasSearchModel MapToSearchModel(IPowerAliasModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IPowerAliasModel, PowerAliasSearchModel>(model);
            // Search Properties
            searchModel.PowerId = model.PowerId;
            searchModel.PowerCustomKey = model.Power.CustomKey;
            searchModel.PowerName = model.Power.Name;
            searchModel.PowerDescription = model.Power.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IPowerAliasModel model, IPowerAlias entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // PowerAlias Properties
                // <None>
                // Related Objects
                && model.PowerId == entity.PowerId
                ;
        }
    }
}
