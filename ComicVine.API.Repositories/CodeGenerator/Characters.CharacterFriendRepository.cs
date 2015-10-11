// <auto-generated>
// <copyright file="Characters.ICharacterFriendRepository.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterFriendsRepository Class.</summary>
// <remarks>This file was autogenerated using RepositoryFileMaster.tt in ComicVine.API.Repositories\Repositories\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVine.API.Repositories//.Characters
{
    using System.Collections.Generic;
    using System.Linq;
    using DataModel.Schema;
    using Interfaces.DataModels;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class CharacterFriendsRepository : RepositoryBase, ICharacterFriendsRepository
    {
        public CharacterFriendsRepository(object context) : base(context) { }

        public void Add(ICharacterFriend entity)
        {
            Context.CharacterFriends.Add((CharacterFriend)entity);
        }

        public void Remove(ICharacterFriend entity)
        {
            Context.CharacterFriends.Remove((CharacterFriend)entity);
        }

        public void Deactivate(ICharacterFriend entity)
        {
            entity.Active = false;
            Update(entity);
        }

        public void Update(ICharacterFriend entity)
        {
            Context.SetModified(entity);
        }

        public ICharacterFriend Get(int id)
        {
            return Context.CharacterFriends.FirstOrDefault(r => r.Id == id);
        }

        public ICharacterFriend Get(string key)
        {
            return Context.CharacterFriends.FirstOrDefault(r => r.CustomKey == key);
        }

        public IEnumerable<ICharacterFriend> List => Context.CharacterFriends;

        public IEnumerable<dynamic> Search(ICharacterFriendSearchModel searchModel, System.Func<ICharacterFriend, dynamic> selectStatement, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive)
                .Select(selectStatement);
        }

        public IEnumerable<ICharacterFriend> Search(ICharacterFriendSearchModel searchModel, bool requireActive = true)
        {
            return SearchCommon(searchModel, requireActive);
        }

        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
        // ReSharper disable once SuggestBaseTypeForParameter
        private IQueryable<ICharacterFriend> SearchCommon(ICharacterFriendSearchModel searchModel, bool requireActive)
        {
            return Context.CharacterFriends
                .FilterByBaseFilters(searchModel, requireActive)
                .FilterByPaging(searchModel.Paging);
        }
    }

    public static partial class CharacterFriendSearchExtensions
    {
    } // end CharacterFriendSearchExtensions
}