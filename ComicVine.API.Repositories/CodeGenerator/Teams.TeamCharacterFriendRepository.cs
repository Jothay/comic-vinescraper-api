// <auto-generated>
// <copyright file="Teams.ITeamCharacterFriendRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamCharacterFriendsRepository Class.</summary>
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

    public class TeamCharacterFriendsRepository : RepositoryBase, ITeamCharacterFriendsRepository
    {
        public TeamCharacterFriendsRepository(object context) : base(context) { }

        public void Add(ITeamCharacterFriend entity)
        {
            Context.TeamCharacterFriends.Add((TeamCharacterFriend)entity);
        }

        public void Remove(ITeamCharacterFriend entity)
        {
            Context.TeamCharacterFriends.Remove((TeamCharacterFriend)entity);
        }

        public void Deactivate(ITeamCharacterFriend entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ITeamCharacterFriend entity)
        {
            Context.SetModified(entity);
        }

        public ITeamCharacterFriend Get(int id)
        {
            return Context.TeamCharacterFriends.FirstOrDefault(r => r.Id == id);
        }

        public ITeamCharacterFriend Get(string key)
        {
            return Context.TeamCharacterFriends.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ITeamCharacterFriend> List => Context.TeamCharacterFriends;

        public IEnumerable<dynamic> Search(ITeamCharacterFriendSearchModel searchModel, System.Func<ITeamCharacterFriend, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ITeamCharacterFriend> Search(ITeamCharacterFriendSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ITeamCharacterFriend> SearchCommon(ITeamCharacterFriendSearchModel searchModel, bool requireActive)
        {
            return Context.TeamCharacterFriends
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class TeamCharacterFriendSearchExtensions
    {
    } // end TeamCharacterFriendSearchExtensions
}
