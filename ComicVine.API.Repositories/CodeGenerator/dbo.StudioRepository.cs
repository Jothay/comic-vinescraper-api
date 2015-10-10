// <auto-generated>
// <copyright file="dbo.IStudioRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StudiosRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.dbo
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class StudiosRepository : RepositoryBase, IStudiosRepository
    {
        public StudiosRepository(object context) : base(context) { }

        public void Add(IStudio entity)
        {
            Context.Studios.Add((Studio)entity);
        }

        public void Remove(IStudio entity)
        {
            Context.Studios.Remove((Studio)entity);
        }

        public void Deactivate(IStudio entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IStudio entity)
        {
            Context.SetModified(entity);
        }

        public IStudio Get(int id)
        {
            return Context.Studios.FirstOrDefault(r => r.Id == id);
        }

        public IStudio Get(string key)
        {
            return Context.Studios.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IStudio> List => Context.Studios;

        public IEnumerable<dynamic> Search(IStudioSearchModel searchModel, System.Func<IStudio, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IStudio> Search(IStudioSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IStudio> SearchCommon(IStudioSearchModel searchModel, bool requireActive)
        {
            return Context.Studios
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class StudioSearchExtensions
    {
    } // end StudioSearchExtensions
}
