// <auto-generated>
// <copyright file="Concepts.IConceptAppearedInIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ConceptAppearedInIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Concepts
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

    public class ConceptAppearedInIssuesBusinessWorkflow : IConceptAppearedInIssuesBusinessWorkflow
    {
        public ConceptAppearedInIssuesBusinessWorkflow(IConceptAppearedInIssuesRepository conceptAppearedInIssuesRepository, IConceptAppearedInIssueMapper conceptAppearedInIssueMapper)
        {
            ConceptAppearedInIssuesRepository = conceptAppearedInIssuesRepository;
            ConceptAppearedInIssueMapper = conceptAppearedInIssueMapper;
        }

        #region Private Variables
        private IConceptAppearedInIssueMapper ConceptAppearedInIssueMapper { get; }
        private IConceptAppearedInIssuesRepository ConceptAppearedInIssuesRepository { get; }
        #endregion
        #region Read
        public IConceptAppearedInIssueModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return ConceptAppearedInIssueMapper.MapToModel(ConceptAppearedInIssuesRepository.Get(id));
        }

        public IConceptAppearedInIssueModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return ConceptAppearedInIssueMapper.MapToModel(ConceptAppearedInIssuesRepository.Get(key));
        }

        public List<IConceptAppearedInIssueModel> Search(IConceptAppearedInIssueSearchModel searchModel, bool asListing = false)
        {
            var results = ConceptAppearedInIssuesRepository.Search(searchModel);
            return asListing
                ? results.Select(ConceptAppearedInIssueMapper.MapToModelListing).ToList()
                : results.Select(ConceptAppearedInIssueMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IConceptAppearedInIssueModel Create(IConceptAppearedInIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(ConceptAppearedInIssueMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = ConceptAppearedInIssueMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            ConceptAppearedInIssuesRepository.Add(newEntity);
            // Try to Save Changes
            ConceptAppearedInIssuesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IConceptAppearedInIssueModel Update(IConceptAppearedInIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = ConceptAppearedInIssuesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (ConceptAppearedInIssueMapper.AreEqual(model, existingEntity))
            {
                return ConceptAppearedInIssueMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            ConceptAppearedInIssueMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            ConceptAppearedInIssuesRepository.Update(ConceptAppearedInIssueMapper.MapToEntity(model));
            // Try to Save Changes
            ConceptAppearedInIssuesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ConceptAppearedInIssuesRepository.Get(id);
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
            var existingEntity = ConceptAppearedInIssuesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IConceptAppearedInIssue entity)
        {
            // Deactivate it
            ConceptAppearedInIssuesRepository.Deactivate(entity);
            // Try to Save Changes
            ConceptAppearedInIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ConceptAppearedInIssuesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = ConceptAppearedInIssuesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IConceptAppearedInIssue entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            ConceptAppearedInIssuesRepository.Remove(entity);
            // Try to Save Changes
            ConceptAppearedInIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}