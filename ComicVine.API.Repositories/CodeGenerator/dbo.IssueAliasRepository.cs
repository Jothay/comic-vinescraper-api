// <auto-generated>
// <copyright file="dbo.IIssueAliasRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssueAliasesRepository Class.</summary>
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

    public class IssueAliasesRepository : RepositoryBase, IIssueAliasesRepository
    {
        public IssueAliasesRepository(object context) : base(context) { }

        public void Add(IIssueAlias entity)
        {
            Context.IssueAliases.Add((IssueAlias)entity);
        }

        public void Remove(IIssueAlias entity)
        {
            Context.IssueAliases.Remove((IssueAlias)entity);
        }

        public void Deactivate(IIssueAlias entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IIssueAlias entity)
        {
            Context.SetModified(entity);
        }

        public IIssueAlias Get(int id)
        {
            return Context.IssueAliases.FirstOrDefault(r => r.Id == id);
        }

        public IIssueAlias Get(string key)
        {
            return Context.IssueAliases.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IIssueAlias> List => Context.IssueAliases;

        public IEnumerable<dynamic> Search(IIssueAliasSearchModel searchModel, System.Func<IIssueAlias, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IIssueAlias> Search(IIssueAliasSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IIssueAlias> SearchCommon(IIssueAliasSearchModel searchModel, bool requireActive)
        {
            return Context.IssueAliases
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByNameableBaseFilters(searchModel)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class IssueAliasSearchExtensions
    {
    } // end IssueAliasSearchExtensions
}