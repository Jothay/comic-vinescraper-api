// <auto-generated>
// <copyright file="People.CreatorCharacterBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CreatorCharacter business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.People
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

    public class CreatorCharactersBusinessWorkflow : ICreatorCharactersBusinessWorkflow
    {
        public CreatorCharactersBusinessWorkflow(ICreatorCharactersRepository creatorCharactersRepository, ICreatorCharacterMapper creatorCharacterMapper)
        {
            CreatorCharactersRepository = creatorCharactersRepository;
            CreatorCharacterMapper = creatorCharacterMapper;
        }

        #region Private Variables
        private ICreatorCharacterMapper CreatorCharacterMapper { get; }
        private ICreatorCharactersRepository CreatorCharactersRepository { get; }
        #endregion
        #region Read
        public ICreatorCharacterModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return CreatorCharacterMapper.MapToModel(CreatorCharactersRepository.Get(id));
        }

        public ICreatorCharacterModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return CreatorCharacterMapper.MapToModel(CreatorCharactersRepository.Get(key));
        }

        public List<ICreatorCharacterModel> Search(ICreatorCharacterSearchModel searchModel, bool asListing = false)
        {
            var results = CreatorCharactersRepository.Search(searchModel);
            return asListing
                ? results.Select(CreatorCharacterMapper.MapToModelListing).ToList()
                : results.Select(CreatorCharacterMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ICreatorCharacterModel Create(ICreatorCharacterModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(CreatorCharacterMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = CreatorCharacterMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            CreatorCharactersRepository.Add(newEntity);
            // Try to Save Changes
            CreatorCharactersRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ICreatorCharacterModel Update(ICreatorCharacterModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = CreatorCharactersRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (CreatorCharacterMapper.AreEqual(model, existingEntity))
            {
                return CreatorCharacterMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            CreatorCharacterMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            CreatorCharactersRepository.Update(CreatorCharacterMapper.MapToEntity(model));
            // Try to Save Changes
            CreatorCharactersRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CreatorCharactersRepository.Get(id);
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
            var existingEntity = CreatorCharactersRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ICreatorCharacter entity)
        {
            // Deactivate it
            CreatorCharactersRepository.Deactivate(entity);
            // Try to Save Changes
            CreatorCharactersRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CreatorCharactersRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = CreatorCharactersRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ICreatorCharacter entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            CreatorCharactersRepository.Remove(entity);
            // Try to Save Changes
            CreatorCharactersRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
