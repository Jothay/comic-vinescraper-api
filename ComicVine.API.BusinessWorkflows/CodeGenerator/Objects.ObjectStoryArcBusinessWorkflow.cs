// <auto-generated>
// <copyright file="Objects.IObjectStoryArcModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the ObjectStoryArc model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Objects
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

    public class ObjectStoryArcsBusinessWorkflow : IObjectStoryArcsBusinessWorkflow
    {
        public ObjectStoryArcsBusinessWorkflow(IObjectStoryArcsRepository objectStoryArcsRepository, IObjectStoryArcMapper objectStoryArcMapper)
        {
            ObjectStoryArcsRepository = objectStoryArcsRepository;
            ObjectStoryArcMapper = objectStoryArcMapper;
        }

        #region Private Variables
        private IObjectStoryArcMapper ObjectStoryArcMapper { get; }
        private IObjectStoryArcsRepository ObjectStoryArcsRepository { get; }
        #endregion
        #region Read
        public IObjectStoryArcModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return ObjectStoryArcMapper.MapToModel(ObjectStoryArcsRepository.Get(id));
        }

        public IObjectStoryArcModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return ObjectStoryArcMapper.MapToModel(ObjectStoryArcsRepository.Get(key));
        }

        public List<IObjectStoryArcModel> Search(IObjectStoryArcSearchModel searchModel, bool asListing = false)
        {
            var results = ObjectStoryArcsRepository.Search(searchModel);
            return asListing
                ? results.Select(ObjectStoryArcMapper.MapToModelListing).ToList()
                : results.Select(ObjectStoryArcMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IObjectStoryArcModel Create(IObjectStoryArcModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(ObjectStoryArcMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = ObjectStoryArcMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            ObjectStoryArcsRepository.Add(newEntity);
            // Try to Save Changes
            ObjectStoryArcsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IObjectStoryArcModel Update(IObjectStoryArcModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = ObjectStoryArcsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (ObjectStoryArcMapper.AreEqual(model, existingEntity))
            {
                return ObjectStoryArcMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            ObjectStoryArcMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            ObjectStoryArcsRepository.Update(ObjectStoryArcMapper.MapToEntity(model));
            // Try to Save Changes
            ObjectStoryArcsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ObjectStoryArcsRepository.Get(id);
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
            var existingEntity = ObjectStoryArcsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IObjectStoryArc entity)
        {
            // Deactivate it
            ObjectStoryArcsRepository.Deactivate(entity);
            // Try to Save Changes
            ObjectStoryArcsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ObjectStoryArcsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = ObjectStoryArcsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IObjectStoryArc entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            ObjectStoryArcsRepository.Remove(entity);
            // Try to Save Changes
            ObjectStoryArcsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
