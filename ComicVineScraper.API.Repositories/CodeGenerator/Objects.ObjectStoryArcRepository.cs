// <auto-generated>
// <copyright file="Objects.ObjectStoryArcRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ObjectStoryArcsRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Objects
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class ObjectStoryArcsRepository : RepositoryBase, IObjectStoryArcsRepository
    {
        public ObjectStoryArcsRepository(object context) : base(context) { }

        public void Add(IObjectStoryArc entity)
        {
            Context.ObjectStoryArcs.Add((ObjectStoryArc)entity);
        }

        public void Remove(IObjectStoryArc entity)
        {
            Context.ObjectStoryArcs.Remove((ObjectStoryArc)entity);
        }

        public void Deactivate(IObjectStoryArc entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IObjectStoryArc entity)
        {
            Context.SetModified(entity);
        }

        public IObjectStoryArc Get(int id)
        {
            return Context.ObjectStoryArcs.FirstOrDefault(r => r.Id == id);
        }

        public IObjectStoryArc Get(string key)
        {
            return Context.ObjectStoryArcs.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IObjectStoryArc> List => Context.ObjectStoryArcs;

        public IEnumerable<dynamic> Search(IObjectStoryArcSearchModel searchModel, System.Func<IObjectStoryArc, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IObjectStoryArc> Search(IObjectStoryArcSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IObjectStoryArc> SearchCommon(IObjectStoryArcSearchModel searchModel, bool requireActive)
        {
            return Context.ObjectStoryArcs
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class ObjectStoryArcSearchExtensions
    {
    } // end ObjectStoryArcSearchExtensions
}
