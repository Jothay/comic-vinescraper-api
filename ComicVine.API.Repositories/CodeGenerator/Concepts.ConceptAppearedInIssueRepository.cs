// <auto-generated>
// <copyright file="Concepts.IConceptAppearedInIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptAppearedInIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Concepts
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class ConceptAppearedInIssuesRepository : RepositoryBase, IConceptAppearedInIssuesRepository
    {
        public ConceptAppearedInIssuesRepository(object context) : base(context) { }

        public void Add(IConceptAppearedInIssue entity)
        {
            Context.ConceptAppearedInIssues.Add((ConceptAppearedInIssue)entity);
        }

        public void Remove(IConceptAppearedInIssue entity)
        {
            Context.ConceptAppearedInIssues.Remove((ConceptAppearedInIssue)entity);
        }

        public void Deactivate(IConceptAppearedInIssue entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IConceptAppearedInIssue entity)
        {
            Context.SetModified(entity);
        }

        public IConceptAppearedInIssue Get(int id)
        {
            return Context.ConceptAppearedInIssues.FirstOrDefault(r => r.Id == id);
        }

        public IConceptAppearedInIssue Get(string key)
        {
            return Context.ConceptAppearedInIssues.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IConceptAppearedInIssue> List => Context.ConceptAppearedInIssues;

        public IEnumerable<dynamic> Search(IConceptAppearedInIssueSearchModel searchModel, System.Func<IConceptAppearedInIssue, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IConceptAppearedInIssue> Search(IConceptAppearedInIssueSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IConceptAppearedInIssue> SearchCommon(IConceptAppearedInIssueSearchModel searchModel, bool requireActive)
        {
            return Context.ConceptAppearedInIssues
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class ConceptAppearedInIssueSearchExtensions
    {
    } // end ConceptAppearedInIssueSearchExtensions
}
