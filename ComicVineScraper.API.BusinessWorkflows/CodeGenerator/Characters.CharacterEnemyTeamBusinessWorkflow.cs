// <auto-generated>
// <copyright file="Characters.CharacterEnemyTeamBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterEnemyTeam business workflows.</summary>
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

    public class CharacterEnemyTeamsBusinessWorkflow : ICharacterEnemyTeamsBusinessWorkflow
    {
        public CharacterEnemyTeamsBusinessWorkflow(ICharacterEnemyTeamsRepository characterEnemyTeamsRepository, ICharacterEnemyTeamMapper characterEnemyTeamMapper)
        {
            CharacterEnemyTeamsRepository = characterEnemyTeamsRepository;
            CharacterEnemyTeamMapper = characterEnemyTeamMapper;
        }

        #region Private Variables
        private ICharacterEnemyTeamMapper CharacterEnemyTeamMapper { get; }
        private ICharacterEnemyTeamsRepository CharacterEnemyTeamsRepository { get; }
        #endregion
        #region Read
        public ICharacterEnemyTeamModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return CharacterEnemyTeamMapper.MapToModel(CharacterEnemyTeamsRepository.Get(id));
        }

        public ICharacterEnemyTeamModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return CharacterEnemyTeamMapper.MapToModel(CharacterEnemyTeamsRepository.Get(key));
        }

        public List<ICharacterEnemyTeamModel> Search(ICharacterEnemyTeamSearchModel searchModel, bool asListing = false)
        {
            var results = CharacterEnemyTeamsRepository.Search(searchModel);
            return asListing
                ? results.Select(CharacterEnemyTeamMapper.MapToModelListing).ToList()
                : results.Select(CharacterEnemyTeamMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ICharacterEnemyTeamModel Create(ICharacterEnemyTeamModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(CharacterEnemyTeamMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = CharacterEnemyTeamMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            CharacterEnemyTeamsRepository.Add(newEntity);
            // Try to Save Changes
            CharacterEnemyTeamsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ICharacterEnemyTeamModel Update(ICharacterEnemyTeamModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = CharacterEnemyTeamsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (CharacterEnemyTeamMapper.AreEqual(model, existingEntity))
            {
                return CharacterEnemyTeamMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            CharacterEnemyTeamMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            CharacterEnemyTeamsRepository.Update(CharacterEnemyTeamMapper.MapToEntity(model));
            // Try to Save Changes
            CharacterEnemyTeamsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterEnemyTeamsRepository.Get(id);
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
            var existingEntity = CharacterEnemyTeamsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ICharacterEnemyTeam entity)
        {
            // Deactivate it
            CharacterEnemyTeamsRepository.Deactivate(entity);
            // Try to Save Changes
            CharacterEnemyTeamsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterEnemyTeamsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = CharacterEnemyTeamsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ICharacterEnemyTeam entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            CharacterEnemyTeamsRepository.Remove(entity);
            // Try to Save Changes
            CharacterEnemyTeamsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
