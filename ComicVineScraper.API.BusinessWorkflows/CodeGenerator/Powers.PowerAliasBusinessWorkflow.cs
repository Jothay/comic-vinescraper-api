// <auto-generated>
// <copyright file="Powers.IPowerAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PowerAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Powers
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

    public class PowerAliasesBusinessWorkflow : IPowerAliasesBusinessWorkflow
    {
        public PowerAliasesBusinessWorkflow(IPowerAliasesRepository powerAliasesRepository, IPowerAliasMapper powerAliasMapper)
        {
            PowerAliasesRepository = powerAliasesRepository;
            PowerAliasMapper = powerAliasMapper;
        }

        #region Private Variables
        private IPowerAliasMapper PowerAliasMapper { get; }
        private IPowerAliasesRepository PowerAliasesRepository { get; }
        #endregion
        #region Read
        public IPowerAliasModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return PowerAliasMapper.MapToModel(PowerAliasesRepository.Get(id));
        }

        public IPowerAliasModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return PowerAliasMapper.MapToModel(PowerAliasesRepository.Get(key));
        }

        public List<IPowerAliasModel> Search(IPowerAliasSearchModel searchModel, bool asListing = false)
        {
            var results = PowerAliasesRepository.Search(searchModel);
            return asListing
                ? results.Select(PowerAliasMapper.MapToModelListing).ToList()
                : results.Select(PowerAliasMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IPowerAliasModel Create(IPowerAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(PowerAliasMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = PowerAliasMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            PowerAliasesRepository.Add(newEntity);
            // Try to Save Changes
            PowerAliasesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IPowerAliasModel Update(IPowerAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = PowerAliasesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (PowerAliasMapper.AreEqual(model, existingEntity))
            {
                return PowerAliasMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            PowerAliasMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            PowerAliasesRepository.Update(PowerAliasMapper.MapToEntity(model));
            // Try to Save Changes
            PowerAliasesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = PowerAliasesRepository.Get(id);
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
            var existingEntity = PowerAliasesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IPowerAlias entity)
        {
            // Deactivate it
            PowerAliasesRepository.Deactivate(entity);
            // Try to Save Changes
            PowerAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = PowerAliasesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = PowerAliasesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IPowerAlias entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            PowerAliasesRepository.Remove(entity);
            // Try to Save Changes
            PowerAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}