// <auto-generated>
// <copyright file="Publishers.PublisherAliasBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the PublisherAlias business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Publishers
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

    public class PublisherAliasesBusinessWorkflow : IPublisherAliasesBusinessWorkflow
    {
        public PublisherAliasesBusinessWorkflow(IPublisherAliasesRepository publisherAliasesRepository, IPublisherAliasMapper publisherAliasMapper)
        {
            PublisherAliasesRepository = publisherAliasesRepository;
            PublisherAliasMapper = publisherAliasMapper;
        }

        #region Private Variables
        private IPublisherAliasMapper PublisherAliasMapper { get; }
        private IPublisherAliasesRepository PublisherAliasesRepository { get; }
        #endregion
        #region Read
        public IPublisherAliasModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return PublisherAliasMapper.MapToModel(PublisherAliasesRepository.Get(id));
        }

        public IPublisherAliasModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return PublisherAliasMapper.MapToModel(PublisherAliasesRepository.Get(key));
        }

        public List<IPublisherAliasModel> Search(IPublisherAliasSearchModel searchModel, bool asListing = false)
        {
            var results = PublisherAliasesRepository.Search(searchModel);
            return asListing
                ? results.Select(PublisherAliasMapper.MapToModelListing).ToList()
                : results.Select(PublisherAliasMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IPublisherAliasModel Create(IPublisherAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(PublisherAliasMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = PublisherAliasMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            PublisherAliasesRepository.Add(newEntity);
            // Try to Save Changes
            PublisherAliasesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IPublisherAliasModel Update(IPublisherAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = PublisherAliasesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (PublisherAliasMapper.AreEqual(model, existingEntity))
            {
                return PublisherAliasMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            PublisherAliasMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            PublisherAliasesRepository.Update(PublisherAliasMapper.MapToEntity(model));
            // Try to Save Changes
            PublisherAliasesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = PublisherAliasesRepository.Get(id);
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
            var existingEntity = PublisherAliasesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IPublisherAlias entity)
        {
            // Deactivate it
            PublisherAliasesRepository.Deactivate(entity);
            // Try to Save Changes
            PublisherAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = PublisherAliasesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = PublisherAliasesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IPublisherAlias entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            PublisherAliasesRepository.Remove(entity);
            // Try to Save Changes
            PublisherAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
