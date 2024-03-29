// <auto-generated>
// <copyright file="Episodes.EpisodeCharacterBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the EpisodeCharacter business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Episodes
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

    public class EpisodeCharactersBusinessWorkflow : IEpisodeCharactersBusinessWorkflow
    {
        public EpisodeCharactersBusinessWorkflow(IEpisodeCharactersRepository episodeCharactersRepository, IEpisodeCharacterMapper episodeCharacterMapper)
        {
            EpisodeCharactersRepository = episodeCharactersRepository;
            EpisodeCharacterMapper = episodeCharacterMapper;
        }

        #region Private Variables
        private IEpisodeCharacterMapper EpisodeCharacterMapper { get; }
        private IEpisodeCharactersRepository EpisodeCharactersRepository { get; }
        #endregion
        #region Read
        public IEpisodeCharacterModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return EpisodeCharacterMapper.MapToModel(EpisodeCharactersRepository.Get(id));
        }

        public IEpisodeCharacterModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return EpisodeCharacterMapper.MapToModel(EpisodeCharactersRepository.Get(key));
        }

        public List<IEpisodeCharacterModel> Search(IEpisodeCharacterSearchModel searchModel, bool asListing = false)
        {
            var results = EpisodeCharactersRepository.Search(searchModel);
            return asListing
                ? results.Select(EpisodeCharacterMapper.MapToModelListing).ToList()
                : results.Select(EpisodeCharacterMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IEpisodeCharacterModel Create(IEpisodeCharacterModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(EpisodeCharacterMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = EpisodeCharacterMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            EpisodeCharactersRepository.Add(newEntity);
            // Try to Save Changes
            EpisodeCharactersRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IEpisodeCharacterModel Update(IEpisodeCharacterModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = EpisodeCharactersRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (EpisodeCharacterMapper.AreEqual(model, existingEntity))
            {
                return EpisodeCharacterMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            EpisodeCharacterMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            EpisodeCharactersRepository.Update(EpisodeCharacterMapper.MapToEntity(model));
            // Try to Save Changes
            EpisodeCharactersRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodeCharactersRepository.Get(id);
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
            var existingEntity = EpisodeCharactersRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IEpisodeCharacter entity)
        {
            // Deactivate it
            EpisodeCharactersRepository.Deactivate(entity);
            // Try to Save Changes
            EpisodeCharactersRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = EpisodeCharactersRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = EpisodeCharactersRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IEpisodeCharacter entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            EpisodeCharactersRepository.Remove(entity);
            // Try to Save Changes
            EpisodeCharactersRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
