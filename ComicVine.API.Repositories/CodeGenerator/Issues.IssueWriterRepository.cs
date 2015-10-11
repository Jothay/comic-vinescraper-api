// <auto-generated>
// <copyright file="Issues.IIssueWriterRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssueWritersRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Issues
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class IssueWritersRepository : RepositoryBase, IIssueWritersRepository
    {
        public IssueWritersRepository(object context) : base(context) { }

        public void Add(IIssueWriter entity)
        {
            Context.IssueWriters.Add((IssueWriter)entity);
        }

        public void Remove(IIssueWriter entity)
        {
            Context.IssueWriters.Remove((IssueWriter)entity);
        }

        public void Deactivate(IIssueWriter entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IIssueWriter entity)
        {
            Context.SetModified(entity);
        }

        public IIssueWriter Get(int id)
        {
            return Context.IssueWriters.FirstOrDefault(r => r.Id == id);
        }

        public IIssueWriter Get(string key)
        {
            return Context.IssueWriters.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IIssueWriter> List => Context.IssueWriters;

        public IEnumerable<dynamic> Search(IIssueWriterSearchModel searchModel, System.Func<IIssueWriter, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IIssueWriter> Search(IIssueWriterSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IIssueWriter> SearchCommon(IIssueWriterSearchModel searchModel, bool requireActive)
        {
            return Context.IssueWriters
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class IssueWriterSearchExtensions
    {
    } // end IssueWriterSearchExtensions
}