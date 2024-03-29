// <auto-generated>
// <copyright file="Locations.LocationStoryArcRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the LocationStoryArcsRepository class and a series of
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

    public class LocationStoryArcsRepository : RepositoryBase, ILocationStoryArcsRepository
    {
        public LocationStoryArcsRepository(object context) : base(context) { }

        public void Add(ILocationStoryArc entity)
        {
            Context.LocationStoryArcs.Add((LocationStoryArc)entity);
        }

        public void Remove(ILocationStoryArc entity)
        {
            Context.LocationStoryArcs.Remove((LocationStoryArc)entity);
        }

        public void Deactivate(ILocationStoryArc entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ILocationStoryArc entity)
        {
            Context.SetModified(entity);
        }

        public ILocationStoryArc Get(int id)
        {
            return Context.LocationStoryArcs.FirstOrDefault(r => r.Id == id);
        }

        public ILocationStoryArc Get(string key)
        {
            return Context.LocationStoryArcs.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ILocationStoryArc> List => Context.LocationStoryArcs;

        public IEnumerable<dynamic> Search(ILocationStoryArcSearchModel searchModel, System.Func<ILocationStoryArc, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ILocationStoryArc> Search(ILocationStoryArcSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ILocationStoryArc> SearchCommon(ILocationStoryArcSearchModel searchModel, bool requireActive)
        {
            return Context.LocationStoryArcs
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class LocationStoryArcSearchExtensions
    {
    } // end LocationStoryArcSearchExtensions
}
