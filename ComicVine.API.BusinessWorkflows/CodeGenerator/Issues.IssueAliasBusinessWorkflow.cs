// <auto-generated>
// <copyright file="Issues.IIssueAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the IssueAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Issues
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

    public class IssueAliasesBusinessWorkflow : IIssueAliasesBusinessWorkflow
    {
        public IssueAliasesBusinessWorkflow(IIssueAliasesRepository issueAliasesRepository, IIssueAliasMapper issueAliasMapper)
        {
            IssueAliasesRepository = issueAliasesRepository;
            IssueAliasMapper = issueAliasMapper;
        }

        #region Private Variables
        private IIssueAliasMapper IssueAliasMapper { get; }
        private IIssueAliasesRepository IssueAliasesRepository { get; }
        #endregion
        #region Read
        public IIssueAliasModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return IssueAliasMapper.MapToModel(IssueAliasesRepository.Get(id));
        }

        public IIssueAliasModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return IssueAliasMapper.MapToModel(IssueAliasesRepository.Get(key));
        }

        public List<IIssueAliasModel> Search(IIssueAliasSearchModel searchModel, bool asListing = false)
        {
            var results = IssueAliasesRepository.Search(searchModel);
            return asListing
                ? results.Select(IssueAliasMapper.MapToModelListing).ToList()
                : results.Select(IssueAliasMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IIssueAliasModel Create(IIssueAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(IssueAliasMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = IssueAliasMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            IssueAliasesRepository.Add(newEntity);
            // Try to Save Changes
            IssueAliasesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IIssueAliasModel Update(IIssueAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = IssueAliasesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (IssueAliasMapper.AreEqual(model, existingEntity))
            {
                return IssueAliasMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            IssueAliasMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            IssueAliasesRepository.Update(IssueAliasMapper.MapToEntity(model));
            // Try to Save Changes
            IssueAliasesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = IssueAliasesRepository.Get(id);
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
            var existingEntity = IssueAliasesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IIssueAlias entity)
        {
            // Deactivate it
            IssueAliasesRepository.Deactivate(entity);
            // Try to Save Changes
            IssueAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = IssueAliasesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = IssueAliasesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IIssueAlias entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            IssueAliasesRepository.Remove(entity);
            // Try to Save Changes
            IssueAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
