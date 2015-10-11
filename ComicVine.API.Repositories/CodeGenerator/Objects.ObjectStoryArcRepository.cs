// <auto-generated>
// <copyright file="Objects.IObjectStoryArcRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectStoryArcsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Objects
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