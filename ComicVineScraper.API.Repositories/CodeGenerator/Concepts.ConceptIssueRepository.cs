// <auto-generated>
// <copyright file="Concepts.ConceptIssueRepository.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ConceptIssuesRepository class and a series of
// IQueryable extensions for the search process.</summary>
// <remarks>This file was auto-generated using RepositoryFileMaster.tt in
// ComicVineScraper.API.Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.Repositories//.Concepts
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class ConceptIssuesRepository : RepositoryBase, IConceptIssuesRepository
    {
        public ConceptIssuesRepository(object context) : base(context) { }

        public void Add(IConceptIssue entity)
        {
            Context.ConceptIssues.Add((ConceptIssue)entity);
        }

        public void Remove(IConceptIssue entity)
        {
            Context.ConceptIssues.Remove((ConceptIssue)entity);
        }

        public void Deactivate(IConceptIssue entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(IConceptIssue entity)
        {
            Context.SetModified(entity);
        }

        public IConceptIssue Get(int id)
        {
            return Context.ConceptIssues.FirstOrDefault(r => r.Id == id);
        }

        public IConceptIssue Get(string key)
        {
            return Context.ConceptIssues.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<IConceptIssue> List => Context.ConceptIssues;

        public IEnumerable<dynamic> Search(IConceptIssueSearchModel searchModel, System.Func<IConceptIssue, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<IConceptIssue> Search(IConceptIssueSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<IConceptIssue> SearchCommon(IConceptIssueSearchModel searchModel, bool requireActive)
        {
            return Context.ConceptIssues
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class ConceptIssueSearchExtensions
    {
    } // end ConceptIssueSearchExtensions
}
