// <auto-generated>
// <copyright file="Teams.ITeamCharacterEnemyModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the TeamCharacterEnemy model interfaces.</summary>
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

    public class TeamCharacterEnemiesBusinessWorkflow : ITeamCharacterEnemiesBusinessWorkflow
    {
        public TeamCharacterEnemiesBusinessWorkflow(ITeamCharacterEnemiesRepository teamCharacterEnemiesRepository, ITeamCharacterEnemyMapper teamCharacterEnemyMapper)
        {
            TeamCharacterEnemiesRepository = teamCharacterEnemiesRepository;
            TeamCharacterEnemyMapper = teamCharacterEnemyMapper;
        }

        #region Private Variables
        private ITeamCharacterEnemyMapper TeamCharacterEnemyMapper { get; }
        private ITeamCharacterEnemiesRepository TeamCharacterEnemiesRepository { get; }
        #endregion
        #region Read
        public ITeamCharacterEnemyModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return TeamCharacterEnemyMapper.MapToModel(TeamCharacterEnemiesRepository.Get(id));
        }

        public ITeamCharacterEnemyModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return TeamCharacterEnemyMapper.MapToModel(TeamCharacterEnemiesRepository.Get(key));
        }

        public List<ITeamCharacterEnemyModel> Search(ITeamCharacterEnemySearchModel searchModel, bool asListing = false)
        {
            var results = TeamCharacterEnemiesRepository.Search(searchModel);
            return asListing
                ? results.Select(TeamCharacterEnemyMapper.MapToModelListing).ToList()
                : results.Select(TeamCharacterEnemyMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ITeamCharacterEnemyModel Create(ITeamCharacterEnemyModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(TeamCharacterEnemyMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = TeamCharacterEnemyMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            TeamCharacterEnemiesRepository.Add(newEntity);
            // Try to Save Changes
            TeamCharacterEnemiesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ITeamCharacterEnemyModel Update(ITeamCharacterEnemyModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = TeamCharacterEnemiesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (TeamCharacterEnemyMapper.AreEqual(model, existingEntity))
            {
                return TeamCharacterEnemyMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            TeamCharacterEnemyMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            TeamCharacterEnemiesRepository.Update(TeamCharacterEnemyMapper.MapToEntity(model));
            // Try to Save Changes
            TeamCharacterEnemiesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamCharacterEnemiesRepository.Get(id);
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
            var existingEntity = TeamCharacterEnemiesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ITeamCharacterEnemy entity)
        {
            // Deactivate it
            TeamCharacterEnemiesRepository.Deactivate(entity);
            // Try to Save Changes
            TeamCharacterEnemiesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = TeamCharacterEnemiesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = TeamCharacterEnemiesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ITeamCharacterEnemy entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            TeamCharacterEnemiesRepository.Remove(entity);
            // Try to Save Changes
            TeamCharacterEnemiesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
