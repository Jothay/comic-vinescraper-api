// <auto-generated>
// <copyright file="Teams.ITeamCharacterFriendModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamCharacterFriend model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Teams
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Interfaces.BusinessWorkflows;
    using Interfaces.DataModels;
    using Interfaces.Mappers;
    using Interfaces.Models;
    using Interfaces.Repositories;
    using Interfaces.SearchModels;

    public class TeamCharacterFriendsBusinessWorkflow : ITeamCharacterFriendsBusinessWorkflow
    {
        public TeamCharacterFriendsBusinessWorkflow(ITeamCharacterFriendsRepository teamCharacterFriendsRepository, ITeamCharacterFriendMapper teamCharacterFriendMapper)
        {
            TeamCharacterFriendsRepository = teamCharacterFriendsRepository;
            TeamCharacterFriendMapper = teamCharacterFriendMapper;
        }

        #region Private Variables
        private ITeamCharacterFriendMapper TeamCharacterFriendMapper { get; }
        private ITeamCharacterFriendsRepository TeamCharacterFriendsRepository { get; }
        #endregion
        #region Read
        public ITeamCharacterFriendModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return TeamCharacterFriendMapper.MapToModel(TeamCharacterFriendsRepository.Get(id));
        }

        public ITeamCharacterFriendModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return TeamCharacterFriendMapper.MapToModel(TeamCharacterFriendsRepository.Get(key));
        }

        public List<ITeamCharacterFriendModel> Search(ITeamCharacterFriendSearchModel searchModel, bool asListing = false)
        {
            var results = TeamCharacterFriendsRepository.Search(searchModel);
            return asListing
                ? results.Select(TeamCharacterFriendMapper.MapToModelListing).ToList()
                : results.Select(TeamCharacterFriendMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ITeamCharacterFriendModel Create(ITeamCharacterFriendModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(TeamCharacterFriendMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = TeamCharacterFriendMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            TeamCharacterFriendsRepository.Add(newEntity);
            // Try to Save Changes
            TeamCharacterFriendsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ITeamCharacterFriendModel Update(ITeamCharacterFriendModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = TeamCharacterFriendsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (TeamCharacterFriendMapper.AreEqual(model, existingEntity))
            {
                return TeamCharacterFriendMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            TeamCharacterFriendMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            TeamCharacterFriendsRepository.Update(TeamCharacterFriendMapper.MapToEntity(model));
            // Try to Save Changes
            TeamCharacterFriendsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamCharacterFriendsRepository.Get(id);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with id {id} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        public bool Deactivate(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = TeamCharacterFriendsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ITeamCharacterFriend entity)
        {
            // Deactivate it
            TeamCharacterFriendsRepository.Deactivate(entity);
            // Try to Save Changes
            TeamCharacterFriendsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamCharacterFriendsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = TeamCharacterFriendsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ITeamCharacterFriend entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            TeamCharacterFriendsRepository.Remove(entity);
            // Try to Save Changes
            TeamCharacterFriendsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}