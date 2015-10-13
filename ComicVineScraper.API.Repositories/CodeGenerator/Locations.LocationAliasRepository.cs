// <auto-generated>
// <copyright file="Locations.LocationAliasRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationAliasesRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Locations
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class LocationAliasesRepository : RepositoryBase, ILocationAliasesRepository
    {
        public LocationAliasesRepository(object context) : base(context) { }

        public void Add(ILocationAlias entity)
        {
            Context.LocationAliases.Add((LocationAlias)entity);
        }

        public void Remove(ILocationAlias entity)
        {
            Context.LocationAliases.Remove((LocationAlias)entity);
        }

        public void Deactivate(ILocationAlias entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ILocationAlias entity)
        {
            Context.SetModified(entity);
        }

        public ILocationAlias Get(int id)
        {
            return Context.LocationAliases.FirstOrDefault(r => r.Id == id);
        }

        public ILocationAlias Get(string key)
        {
            return Context.LocationAliases.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ILocationAlias> List => Context.LocationAliases;

        public IEnumerable<dynamic> Search(ILocationAliasSearchModel searchModel, System.Func<ILocationAlias, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ILocationAlias> Search(ILocationAliasSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ILocationAlias> SearchCommon(ILocationAliasSearchModel searchModel, bool requireActive)
        {
            return Context.LocationAliases
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class LocationAliasSearchExtensions
    {
    } // end LocationAliasSearchExtensions
}
