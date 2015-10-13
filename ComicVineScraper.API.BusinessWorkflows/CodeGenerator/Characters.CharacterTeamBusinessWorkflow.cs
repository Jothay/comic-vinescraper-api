// <auto-generated>
// <copyright file="Characters.ICharacterTeamModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the CharacterTeam model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Characters
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

    public class CharacterTeamsBusinessWorkflow : ICharacterTeamsBusinessWorkflow
    {
        public CharacterTeamsBusinessWorkflow(ICharacterTeamsRepository characterTeamsRepository, ICharacterTeamMapper characterTeamMapper)
        {
            CharacterTeamsRepository = characterTeamsRepository;
            CharacterTeamMapper = characterTeamMapper;
        }

        #region Private Variables
        private ICharacterTeamMapper CharacterTeamMapper { get; }
        private ICharacterTeamsRepository CharacterTeamsRepository { get; }
        #endregion
        #region Read
        public ICharacterTeamModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return CharacterTeamMapper.MapToModel(CharacterTeamsRepository.Get(id));
        }

        public ICharacterTeamModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return CharacterTeamMapper.MapToModel(CharacterTeamsRepository.Get(key));
        }

        public List<ICharacterTeamModel> Search(ICharacterTeamSearchModel searchModel, bool asListing = false)
        {
            var results = CharacterTeamsRepository.Search(searchModel);
            return asListing
                ? results.Select(CharacterTeamMapper.MapToModelListing).ToList()
                : results.Select(CharacterTeamMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ICharacterTeamModel Create(ICharacterTeamModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(CharacterTeamMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = CharacterTeamMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            CharacterTeamsRepository.Add(newEntity);
            // Try to Save Changes
            CharacterTeamsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ICharacterTeamModel Update(ICharacterTeamModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = CharacterTeamsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (CharacterTeamMapper.AreEqual(model, existingEntity))
            {
                return CharacterTeamMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            CharacterTeamMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            CharacterTeamsRepository.Update(CharacterTeamMapper.MapToEntity(model));
            // Try to Save Changes
            CharacterTeamsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterTeamsRepository.Get(id);
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
            var existingEntity = CharacterTeamsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ICharacterTeam entity)
        {
            // Deactivate it
            CharacterTeamsRepository.Deactivate(entity);
            // Try to Save Changes
            CharacterTeamsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterTeamsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = CharacterTeamsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ICharacterTeam entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            CharacterTeamsRepository.Remove(entity);
            // Try to Save Changes
            CharacterTeamsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}