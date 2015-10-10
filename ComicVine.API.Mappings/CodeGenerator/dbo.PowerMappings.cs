// <auto-generated>
// <copyright file="dbo.IPowerModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Power model interfaces.</summary>
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

    public static class PowerMapperExtensions
    {
        public static readonly PowerMapper Mapper = new PowerMapper();

        public static IPower MapToEntity(this IPowerModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IPowerModel model, ref IPower entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IPowerModel MapToModel(this IPower entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IPowerModel MapToModelLite(this IPower entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IPowerModel MapToModelListing(this IPower entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IPowerSearchModel MapToSearchModel(this IPowerModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IPowerModel model, IPower entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class PowerMapper : IPowerMapper
    {
        public IPower MapToEntity(IPowerModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<Power, IPowerModel>(model);
            // Power Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            entity.Characters = model.Characters?.Where(i => i.Active).Select(CharacterMapperExtensions.MapToEntity).Cast<Character>().ToList();
            entity.PowerAliases = model.PowerAliases?.Where(i => i.Active).Select(PowerAliasMapperExtensions.MapToEntity).Cast<PowerAlias>().ToList();
            // Return Entity
            return entity;
        }

        public void MapToEntity(IPowerModel model, ref IPower entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // Power Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            entity.Characters = (ICollection<ICharacter>)model.Characters?.Where(i => i.Active).Select(CharacterMapperExtensions.MapToEntity).Cast<Character>();
            entity.PowerAliases = (ICollection<IPowerAlias>)model.PowerAliases?.Where(i => i.Active).Select(PowerAliasMapperExtensions.MapToEntity).Cast<PowerAlias>();
        }

        public IPowerModel MapToModel(IPower entity)
        {
            var model = NameableEntityMapper.MapToModel<IPower, PowerModel>(entity);
            // Power Properties
            // <None>
            // Related Objects
            // <None>
            // Associated Objects
            model.Characters = entity.Characters?.Where(i => i.Active).Select(CharacterMapperExtensions.MapToModel).ToList();
            model.PowerAliases = entity.PowerAliases?.Where(i => i.Active).Select(PowerAliasMapperExtensions.MapToModel).ToList();
            // Return Entity
            return model;
        }

        public IPowerModel MapToModelLite(IPower entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IPower, PowerModel>(entity);
            // Power Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public IPowerModel MapToModelListing(IPower entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IPower, PowerModel>(entity);
            // Power Properties
            // <None>
            // Related Objects
            // <None>
            // Return Entity
            return model;
        }

        public IPowerSearchModel MapToSearchModel(IPowerModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IPowerModel, PowerSearchModel>(model);
            // Search Properties
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IPowerModel model, IPower entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // Power Properties
                // <None>
                // Related Objects
                // <None>
                ;
        }
    }
}
