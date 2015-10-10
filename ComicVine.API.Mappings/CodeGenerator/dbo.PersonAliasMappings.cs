// <auto-generated>
// <copyright file="dbo.IPersonAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PersonAlias model interfaces.</summary>
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

    public static class PersonAliasMapperExtensions
    {
        public static readonly PersonAliasMapper Mapper = new PersonAliasMapper();

        public static IPersonAlias MapToEntity(this IPersonAliasModel model)
        {
            return Mapper.MapToEntity(model);
        }
        public static void MapToEntity(this IPersonAliasModel model, ref IPersonAlias entity)
        {
            Mapper.MapToEntity(model, ref entity);
        }
        public static IPersonAliasModel MapToModel(this IPersonAlias entity)
        {
            return Mapper.MapToModel(entity);
        }
        public static IPersonAliasModel MapToModelLite(this IPersonAlias entity)
        {
            return Mapper.MapToModelLite(entity);
        }
        public static IPersonAliasModel MapToModelListing(this IPersonAlias entity)
        {
            return Mapper.MapToModelListing(entity);
        }
        public static IPersonAliasSearchModel MapToSearchModel(this IPersonAliasModel model)
        {
            return Mapper.MapToSearchModel(model);
        }
        public static bool AreEqual(this IPersonAliasModel model, IPersonAlias entity)
        {
            return Mapper.AreEqual(model, entity);
        }
    }

    public class PersonAliasMapper : IPersonAliasMapper
    {
        public IPersonAlias MapToEntity(IPersonAliasModel model)
        {
            var entity = NameableEntityMapper.MapToEntity<PersonAlias, IPersonAliasModel>(model);
            // PersonAlias Properties
            // <None>
            // Related Objects
            entity.PersonId = model.PersonId;
            entity.Person = (Person)model.Person.MapToEntity();
            // Associated Objects
            // <None>
            // Return Entity
            return entity;
        }

        public void MapToEntity(IPersonAliasModel model, ref IPersonAlias entity)
        {
            // Assign Base properties
            NameableEntityMapper.MapToEntity(model, ref entity);
            // PersonAlias Properties
            // <None>
            // Related Objects
            entity.PersonId = model.PersonId;
            entity.Person = (Person)model.Person.MapToEntity();
            // Associated Objects
            // <None>
        }

        public IPersonAliasModel MapToModel(IPersonAlias entity)
        {
            var model = NameableEntityMapper.MapToModel<IPersonAlias, PersonAliasModel>(entity);
            // PersonAlias Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            model.Person = entity.Person.MapToModel();
            // Associated Objects
            // <None>
            // Return Entity
            return model;
        }

        public IPersonAliasModel MapToModelLite(IPersonAlias entity)
        {
            var model = NameableEntityMapper.MapToModelLite<IPersonAlias, PersonAliasModel>(entity);
            // PersonAlias Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            // Return Entity
            return model;
        }

        public IPersonAliasModel MapToModelListing(IPersonAlias entity)
        {
            var model = NameableEntityMapper.MapToModelListing<IPersonAlias, PersonAliasModel>(entity);
            // PersonAlias Properties
            // <None>
            // Related Objects
            model.PersonId = entity.PersonId;
            // Return Entity
            return model;
        }

        public IPersonAliasSearchModel MapToSearchModel(IPersonAliasModel model)
        {
            var searchModel = NameableEntityMapper.MapToSearchModel<IPersonAliasModel, PersonAliasSearchModel>(model);
            // Search Properties
            searchModel.PersonId = model.PersonId;
            searchModel.PersonCustomKey = model.Person.CustomKey;
            searchModel.PersonName = model.Person.Name;
            searchModel.PersonDescription = model.Person.Description;
            // Return Search Model
            return searchModel;
        }

        public bool AreEqual(IPersonAliasModel model, IPersonAlias entity)
        {
            return NameableEntityMapper.AreEqual(model, entity)
                // PersonAlias Properties
                // <None>
                // Related Objects
                && model.PersonId == entity.PersonId
                ;
        }
    }
}
