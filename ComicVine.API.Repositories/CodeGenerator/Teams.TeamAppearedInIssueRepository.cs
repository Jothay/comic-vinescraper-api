// <auto-generated>
// <copyright file="Teams.ITeamAppearedInIssueRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamAppearedInIssuesRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Teams
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class TeamAppearedInIssuesRepository : RepositoryBase, ITeamAppearedInIssuesRepository
    {
        public TeamAppearedInIssuesRepository(object context) : base(context) { }

        public void Add(ITeamAppearedInIssue entity)
        {
            Context.TeamAppearedInIssues.Add((TeamAppearedInIssue)entity);
        }

        public void Remove(ITeamAppearedInIssue entity)
        {
            Context.TeamAppearedInIssues.Remove((TeamAppearedInIssue)entity);
        }

        public void Deactivate(ITeamAppearedInIssue entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ITeamAppearedInIssue entity)
        {
            Context.SetModified(entity);
        }

        public ITeamAppearedInIssue Get(int id)
        {
            return Context.TeamAppearedInIssues.FirstOrDefault(r => r.Id == id);
        }

        public ITeamAppearedInIssue Get(string key)
        {
            return Context.TeamAppearedInIssues.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ITeamAppearedInIssue> List => Context.TeamAppearedInIssues;

        public IEnumerable<dynamic> Search(ITeamAppearedInIssueSearchModel searchModel, System.Func<ITeamAppearedInIssue, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ITeamAppearedInIssue> Search(ITeamAppearedInIssueSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ITeamAppearedInIssue> SearchCommon(ITeamAppearedInIssueSearchModel searchModel, bool requireActive)
        {
            return Context.TeamAppearedInIssues
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class TeamAppearedInIssueSearchExtensions
    {
    } // end TeamAppearedInIssueSearchExtensions
}