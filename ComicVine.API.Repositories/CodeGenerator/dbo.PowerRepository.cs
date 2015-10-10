// <auto-generated>
// <copyright file="dbo.IPowerRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PowersRepository Class.</summary>
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

    public class PowersRepository : RepositoryBase, IPowersRepository
    {
        public PowersRepository(object context) : base(context) { }

        public void Add(IPower entity)
        {
            Context.Powers.Add((Power)entity);
        }

        public void Remove(IPower entity)
        {
            Context.Powers.Remove((Power)entity);
        }

        public void Deactivate(IPower entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IPower entity)
        {
            Context.SetModified(entity);
        }

        public IPower Get(int id)
        {
            return Context.Powers.FirstOrDefault(r => r.Id == id);
        }

        public IPower Get(string key)
        {
            return Context.Powers.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IPower> List => Context.Powers;

        public IEnumerable<dynamic> Search(IPowerSearchModel searchModel, System.Func<IPower, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IPower> Search(IPowerSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IPower> SearchCommon(IPowerSearchModel searchModel, bool requireActive)
        {
            return Context.Powers
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class PowerSearchExtensions
    {
    } // end PowerSearchExtensions
}
