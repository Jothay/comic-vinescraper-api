// <auto-generated>
// <copyright file="StoryArcs.IStoryArcIssueModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the StoryArcIssue model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.StoryArcs
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

    public class StoryArcIssuesBusinessWorkflow : IStoryArcIssuesBusinessWorkflow
    {
        public StoryArcIssuesBusinessWorkflow(IStoryArcIssuesRepository storyArcIssuesRepository, IStoryArcIssueMapper storyArcIssueMapper)
        {
            StoryArcIssuesRepository = storyArcIssuesRepository;
            StoryArcIssueMapper = storyArcIssueMapper;
        }

        #region Private Variables
        private IStoryArcIssueMapper StoryArcIssueMapper { get; }
        private IStoryArcIssuesRepository StoryArcIssuesRepository { get; }
        #endregion
        #region Read
        public IStoryArcIssueModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return StoryArcIssueMapper.MapToModel(StoryArcIssuesRepository.Get(id));
        }

        public IStoryArcIssueModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return StoryArcIssueMapper.MapToModel(StoryArcIssuesRepository.Get(key));
        }

        public List<IStoryArcIssueModel> Search(IStoryArcIssueSearchModel searchModel, bool asListing = false)
        {
            var results = StoryArcIssuesRepository.Search(searchModel);
            return asListing
                ? results.Select(StoryArcIssueMapper.MapToModelListing).ToList()
                : results.Select(StoryArcIssueMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IStoryArcIssueModel Create(IStoryArcIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(StoryArcIssueMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = StoryArcIssueMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            StoryArcIssuesRepository.Add(newEntity);
            // Try to Save Changes
            StoryArcIssuesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IStoryArcIssueModel Update(IStoryArcIssueModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = StoryArcIssuesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (StoryArcIssueMapper.AreEqual(model, existingEntity))
            {
                return StoryArcIssueMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            StoryArcIssueMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            StoryArcIssuesRepository.Update(StoryArcIssueMapper.MapToEntity(model));
            // Try to Save Changes
            StoryArcIssuesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = StoryArcIssuesRepository.Get(id);
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
            var existingEntity = StoryArcIssuesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IStoryArcIssue entity)
        {
            // Deactivate it
            StoryArcIssuesRepository.Deactivate(entity);
            // Try to Save Changes
            StoryArcIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = StoryArcIssuesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = StoryArcIssuesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IStoryArcIssue entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            StoryArcIssuesRepository.Remove(entity);
            // Try to Save Changes
            StoryArcIssuesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
