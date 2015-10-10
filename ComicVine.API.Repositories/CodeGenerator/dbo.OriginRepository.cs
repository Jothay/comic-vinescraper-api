// <auto-generated>
// <copyright file="dbo.IOriginRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the OriginsRepository Class.</summary>
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

    public class OriginsRepository : RepositoryBase, IOriginsRepository
    {
        public OriginsRepository(object context) : base(context) { }

        public void Add(IOrigin entity)
        {
            Context.Origins.Add((Origin)entity);
        }

        public void Remove(IOrigin entity)
        {
            Context.Origins.Remove((Origin)entity);
        }

        public void Deactivate(IOrigin entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IOrigin entity)
        {
            Context.SetModified(entity);
        }

        public IOrigin Get(int id)
        {
            return Context.Origins.FirstOrDefault(r => r.Id == id);
        }

        public IOrigin Get(string key)
        {
            return Context.Origins.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IOrigin> List => Context.Origins;

        public IEnumerable<dynamic> Search(IOriginSearchModel searchModel, System.Func<IOrigin, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IOrigin> Search(IOriginSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IOrigin> SearchCommon(IOriginSearchModel searchModel, bool requireActive)
        {
            return Context.Origins
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class OriginSearchExtensions
    {
    } // end OriginSearchExtensions
}
