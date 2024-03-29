// <auto-generated>
// <copyright file="Characters.CharacterAppearedInIssueBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the CharacterAppearedInIssue business workflows.</summary>
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

    public class CharacterAppearedInIssuesBusinessWorkflow : ICharacterAppearedInIssuesBusinessWorkflow
    {
        public CharacterAppearedInIssuesBusinessWorkflow(ICharacterAppearedInIssuesRepository characterAppearedInIssuesRepository, ICharacterAppearedInIssueMapper characterAppearedInIssueMapper)
        {
            CharacterAppearedInIssuesRepository = characterAppearedInIssuesRepository;
            CharacterAppearedInIssueMapper = characterAppearedInIssueMapper;
        }

        #region Private Variables
        private ICharacterAppearedInIssueMapper CharacterAppearedInIssueMapper { get; }
        private ICharacterAppearedInIssuesRepository CharacterAppearedInIssuesRepository { get; }
        #endregion
        #region Read
        public ICharacterAppearedInIssueModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return CharacterAppearedInIssueMapper.MapToModel(CharacterAppearedInIssuesRepository.Get(id));
        }

        public ICharacterAppearedInIssueModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return CharacterAppearedInIssueMapper.MapToModel(CharacterAppearedInIssuesRepository.Get(key));
        }

        public List<ICharacterAppearedInIssueModel> Search(ICharacterAppearedInIssueSearchModel searchModel, bool asListing = false)
        {
            var results = CharacterAppearedInIssuesRepository.Search(searchModel);
            return asListing
                ? results.Select(CharacterAppearedInIssueMapper.MapToModelListing).ToList()
                : results.Select(CharacterAppearedInIssueMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public ICharacterAppearedInIssueModel Create(ICharacterAppearedInIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(CharacterAppearedInIssueMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = CharacterAppearedInIssueMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            CharacterAppearedInIssuesRepository.Add(newEntity);
            // Try to Save Changes
            CharacterAppearedInIssuesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public ICharacterAppearedInIssueModel Update(ICharacterAppearedInIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = CharacterAppearedInIssuesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (CharacterAppearedInIssueMapper.AreEqual(model, existingEntity))
            {
                return CharacterAppearedInIssueMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            CharacterAppearedInIssueMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            CharacterAppearedInIssuesRepository.Update(CharacterAppearedInIssueMapper.MapToEntity(model));
            // Try to Save Changes
            CharacterAppearedInIssuesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterAppearedInIssuesRepository.Get(id);
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
            var existingEntity = CharacterAppearedInIssuesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(ICharacterAppearedInIssue entity)
        {
            // Deactivate it
            CharacterAppearedInIssuesRepository.Deactivate(entity);
            // Try to Save Changes
            CharacterAppearedInIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = CharacterAppearedInIssuesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = CharacterAppearedInIssuesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(ICharacterAppearedInIssue entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            CharacterAppearedInIssuesRepository.Remove(entity);
            // Try to Save Changes
            CharacterAppearedInIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
