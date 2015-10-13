// <auto-generated>
// <copyright file="Characters.CharacterFriendBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterFriend business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Characters
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

    public class CharacterFriendsBusinessWorkflow : ICharacterFriendsBusinessWorkflow
    {
        public CharacterFriendsBusinessWorkflow(ICharacterFriendsRepository characterFriendsRepository, ICharacterFriendMapper characterFriendMapper)
        {
            CharacterFriendsRepository = characterFriendsRepository;
            CharacterFriendMapper = characterFriendMapper;
        }

        #region Private Variables
        private ICharacterFriendMapper CharacterFriendMapper { get; }
        private ICharacterFriendsRepository CharacterFriendsRepository { get; }
        #endregion
        #region Read
        public ICharacterFriendModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return CharacterFriendMapper.MapToModel(CharacterFriendsRepository.Get(id));
        }

        public ICharacterFriendModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return CharacterFriendMapper.MapToModel(CharacterFriendsRepository.Get(key));
        }

        public List<ICharacterFriendModel> Search(ICharacterFriendSearchModel searchModel, bool asListing = false)
        {
            var results = CharacterFriendsRepository.Search(searchModel);
            return asListing
                ? results.Select(CharacterFriendMapper.MapToModelListing).ToList()
                : results.Select(CharacterFriendMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ICharacterFriendModel Create(ICharacterFriendModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(CharacterFriendMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = CharacterFriendMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            CharacterFriendsRepository.Add(newEntity);
            // Try to Save Changes
            CharacterFriendsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ICharacterFriendModel Update(ICharacterFriendModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = CharacterFriendsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (CharacterFriendMapper.AreEqual(model, existingEntity))
            {
                return CharacterFriendMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            CharacterFriendMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            CharacterFriendsRepository.Update(CharacterFriendMapper.MapToEntity(model));
            // Try to Save Changes
            CharacterFriendsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterFriendsRepository.Get(id);
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
            var existingEntity = CharacterFriendsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ICharacterFriend entity)
        {
            // Deactivate it
            CharacterFriendsRepository.Deactivate(entity);
            // Try to Save Changes
            CharacterFriendsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterFriendsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = CharacterFriendsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ICharacterFriend entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            CharacterFriendsRepository.Remove(entity);
            // Try to Save Changes
            CharacterFriendsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
