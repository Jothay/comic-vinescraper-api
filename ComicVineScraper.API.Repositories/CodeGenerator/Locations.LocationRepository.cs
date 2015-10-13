// <auto-generated>
// <copyright file="Locations.LocationRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationsRepository class and a series of
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

    public class LocationsRepository : RepositoryBase, ILocationsRepository
    {
        public LocationsRepository(object context) : base(context) { }

        public void Add(ILocation entity)
        {
            Context.Locations.Add((Location)entity);
        }

        public void Remove(ILocation entity)
        {
            Context.Locations.Remove((Location)entity);
        }

        public void Deactivate(ILocation entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ILocation entity)
        {
            Context.SetModified(entity);
        }

        public ILocation Get(int id)
        {
            return Context.Locations.FirstOrDefault(r => r.Id == id);
        }

        public ILocation Get(string key)
        {
            return Context.Locations.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ILocation> List => Context.Locations;

        public IEnumerable<dynamic> Search(ILocationSearchModel searchModel, System.Func<ILocation, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ILocation> Search(ILocationSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ILocation> SearchCommon(ILocationSearchModel searchModel, bool requireActive)
        {
            return Context.Locations
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class LocationSearchExtensions
    {
    } // end LocationSearchExtensions
}
