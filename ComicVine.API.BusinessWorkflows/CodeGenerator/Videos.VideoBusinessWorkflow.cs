// <auto-generated>
// <copyright file="Videos.IVideoModel.cs" company="clarityventures.com">
// Copyright (c) 2015 Clarity Ventures, Inc. All rights reserved.
// </copyright>
// <summary>Implements the Video model interfaces.</summary>
// <remarks>This file was autogenerated using InterfaceFileMaster.tt in ComicVine.API\Interfaces\00.AutoGenerated</remarks>
// </auto-generated>
namespace ComicVine.API.BusinessWorkflows//.Videos
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

    public class VideosBusinessWorkflow : IVideosBusinessWorkflow
    {
        public VideosBusinessWorkflow(IVideosRepository videosRepository, IVideoMapper videoMapper)
        {
            VideosRepository = videosRepository;
            VideoMapper = videoMapper;
        }

        #region Private Variables
        private IVideoMapper VideoMapper { get; }
        private IVideosRepository VideosRepository { get; }
        #endregion
        #region Read
        public IVideoModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return VideoMapper.MapToModel(VideosRepository.Get(id));
        }

        public IVideoModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return VideoMapper.MapToModel(VideosRepository.Get(key));
        }

        public List<IVideoModel> Search(IVideoSearchModel searchModel, bool asListing = false)
        {
            var results = VideosRepository.Search(searchModel);
            return asListing
                ? results.Select(VideoMapper.MapToModelListing).ToList()
                : results.Select(VideoMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IVideoModel Create(IVideoModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(VideoMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = VideoMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            VideosRepository.Add(newEntity);
            // Try to Save Changes
            VideosRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IVideoModel Update(IVideoModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = VideosRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (VideoMapper.AreEqual(model, existingEntity))
            {
                return VideoMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            VideoMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            VideosRepository.Update(VideoMapper.MapToEntity(model));
            // Try to Save Changes
            VideosRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VideosRepository.Get(id);
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
            var existingEntity = VideosRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IVideo entity)
        {
            // Deactivate it
            VideosRepository.Deactivate(entity);
            // Try to Save Changes
            VideosRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = VideosRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = VideosRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IVideo entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            VideosRepository.Remove(entity);
            // Try to Save Changes
            VideosRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
