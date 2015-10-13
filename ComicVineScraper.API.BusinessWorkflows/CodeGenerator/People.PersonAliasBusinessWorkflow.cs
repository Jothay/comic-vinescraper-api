// <auto-generated>
// <copyright file="People.IPersonAliasModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the PersonAlias model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.People
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

    public class PersonAliasesBusinessWorkflow : IPersonAliasesBusinessWorkflow
    {
        public PersonAliasesBusinessWorkflow(IPersonAliasesRepository personAliasesRepository, IPersonAliasMapper personAliasMapper)
        {
            PersonAliasesRepository = personAliasesRepository;
            PersonAliasMapper = personAliasMapper;
        }

        #region Private Variables
        private IPersonAliasMapper PersonAliasMapper { get; }
        private IPersonAliasesRepository PersonAliasesRepository { get; }
        #endregion
        #region Read
        public IPersonAliasModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return PersonAliasMapper.MapToModel(PersonAliasesRepository.Get(id));
        }

        public IPersonAliasModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return PersonAliasMapper.MapToModel(PersonAliasesRepository.Get(key));
        }

        public List<IPersonAliasModel> Search(IPersonAliasSearchModel searchModel, bool asListing = false)
        {
            var results = PersonAliasesRepository.Search(searchModel);
            return asListing
                ? results.Select(PersonAliasMapper.MapToModelListing).ToList()
                : results.Select(PersonAliasMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IPersonAliasModel Create(IPersonAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(PersonAliasMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = PersonAliasMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            PersonAliasesRepository.Add(newEntity);
            // Try to Save Changes
            PersonAliasesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IPersonAliasModel Update(IPersonAliasModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = PersonAliasesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (PersonAliasMapper.AreEqual(model, existingEntity))
            {
                return PersonAliasMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            PersonAliasMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            PersonAliasesRepository.Update(PersonAliasMapper.MapToEntity(model));
            // Try to Save Changes
            PersonAliasesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = PersonAliasesRepository.Get(id);
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
            var existingEntity = PersonAliasesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IPersonAlias entity)
        {
            // Deactivate it
            PersonAliasesRepository.Deactivate(entity);
            // Try to Save Changes
            PersonAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = PersonAliasesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = PersonAliasesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IPersonAlias entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            PersonAliasesRepository.Remove(entity);
            // Try to Save Changes
            PersonAliasesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}