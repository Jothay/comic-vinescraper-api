// <auto-generated>
// <copyright file="Locations.ILocationAppearedInIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the LocationAppearedInIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Locations
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class LocationAppearedInIssuesRepository : RepositoryBase, ILocationAppearedInIssuesRepository
    {
        public LocationAppearedInIssuesRepository(object context) : base(context) { }

        public void Add(ILocationAppearedInIssue entity)
        {
            Context.LocationAppearedInIssues.Add((LocationAppearedInIssue)entity);
        }

        public void Remove(ILocationAppearedInIssue entity)
        {
            Context.LocationAppearedInIssues.Remove((LocationAppearedInIssue)entity);
        }

        public void Deactivate(ILocationAppearedInIssue entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ILocationAppearedInIssue entity)
        {
            Context.SetModified(entity);
        }

        public ILocationAppearedInIssue Get(int id)
        {
            return Context.LocationAppearedInIssues.FirstOrDefault(r => r.Id == id);
        }

        public ILocationAppearedInIssue Get(string key)
        {
            return Context.LocationAppearedInIssues.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ILocationAppearedInIssue> List => Context.LocationAppearedInIssues;

        public IEnumerable<dynamic> Search(ILocationAppearedInIssueSearchModel searchModel, System.Func<ILocationAppearedInIssue, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ILocationAppearedInIssue> Search(ILocationAppearedInIssueSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ILocationAppearedInIssue> SearchCommon(ILocationAppearedInIssueSearchModel searchModel, bool requireActive)
        {
            return Context.LocationAppearedInIssues
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class LocationAppearedInIssueSearchExtensions
    {
    } // end LocationAppearedInIssueSearchExtensions
}