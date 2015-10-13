// <auto-generated>
// <copyright file="Promos.ResourceTypeBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ResourceType business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Promos
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

    public class ResourceTypesBusinessWorkflow : IResourceTypesBusinessWorkflow
    {
        public ResourceTypesBusinessWorkflow(IResourceTypesRepository resourceTypesRepository, IResourceTypeMapper resourceTypeMapper)
        {
            ResourceTypesRepository = resourceTypesRepository;
            ResourceTypeMapper = resourceTypeMapper;
        }

        #region Private Variables
        private IResourceTypeMapper ResourceTypeMapper { get; }
        private IResourceTypesRepository ResourceTypesRepository { get; }
        #endregion
        #region Read
        public IResourceTypeModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return ResourceTypeMapper.MapToModel(ResourceTypesRepository.Get(id));
        }

        public IResourceTypeModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return ResourceTypeMapper.MapToModel(ResourceTypesRepository.Get(key));
        }

        public List<IResourceTypeModel> Search(IResourceTypeSearchModel searchModel, bool asListing = false)
        {
            var results = ResourceTypesRepository.Search(searchModel);
            return asListing
                ? results.Select(ResourceTypeMapper.MapToModelListing).ToList()
                : results.Select(ResourceTypeMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IResourceTypeModel Create(IResourceTypeModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(ResourceTypeMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = ResourceTypeMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            ResourceTypesRepository.Add(newEntity);
            // Try to Save Changes
            ResourceTypesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IResourceTypeModel Update(IResourceTypeModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = ResourceTypesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (ResourceTypeMapper.AreEqual(model, existingEntity))
            {
                return ResourceTypeMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            ResourceTypeMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            ResourceTypesRepository.Update(ResourceTypeMapper.MapToEntity(model));
            // Try to Save Changes
            ResourceTypesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ResourceTypesRepository.Get(id);
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
            var existingEntity = ResourceTypesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IResourceType entity)
        {
            // Deactivate it
            ResourceTypesRepository.Deactivate(entity);
            // Try to Save Changes
            ResourceTypesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ResourceTypesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = ResourceTypesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IResourceType entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            ResourceTypesRepository.Remove(entity);
            // Try to Save Changes
            ResourceTypesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
