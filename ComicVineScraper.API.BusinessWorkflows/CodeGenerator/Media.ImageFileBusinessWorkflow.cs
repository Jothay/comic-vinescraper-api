// <auto-generated>
// <copyright file="Media.ImageFileBusinessWorkflow.cs" company="jothay.com">
// Copyright (c) 2015 Jothay Tech, Inc. All rights reserved.
// </copyright>
// <summary>Declares the ImageFile business workflows.</summary>
// <remarks>This file was auto-generated using WorkflowFileMaster.tt in
// ComicVineScraper.API.BusinessWorkflows\CodeGenerator</remarks>
// </auto-generated>
namespace ComicVineScraper.API.BusinessWorkflows//.Media
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

    public class ImageFilesBusinessWorkflow : IImageFilesBusinessWorkflow
    {
        public ImageFilesBusinessWorkflow(IImageFilesRepository imageFilesRepository, IImageFileMapper imageFileMapper)
        {
            ImageFilesRepository = imageFilesRepository;
            ImageFileMapper = imageFileMapper;
        }

        #region Private Variables
        private IImageFileMapper ImageFileMapper { get; }
        private IImageFilesRepository ImageFilesRepository { get; }
        #endregion
        #region Read
        public IImageFileModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return ImageFileMapper.MapToModel(ImageFilesRepository.Get(id));
        }

        public IImageFileModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return ImageFileMapper.MapToModel(ImageFilesRepository.Get(key));
        }

        public List<IImageFileModel> Search(IImageFileSearchModel searchModel, bool asListing = false)
        {
            var results = ImageFilesRepository.Search(searchModel);
            return asListing
                ? results.Select(ImageFileMapper.MapToModelListing).ToList()
                : results.Select(ImageFileMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IImageFileModel Create(IImageFileModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(ImageFileMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = ImageFileMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            ImageFilesRepository.Add(newEntity);
            // Try to Save Changes
            ImageFilesRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IImageFileModel Update(IImageFileModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            //BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = ImageFilesRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (ImageFileMapper.AreEqual(model, existingEntity))
            {
                return ImageFileMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            ImageFileMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            ImageFilesRepository.Update(ImageFileMapper.MapToEntity(model));
            // Try to Save Changes
            ImageFilesRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ImageFilesRepository.Get(id);
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
            var existingEntity = ImageFilesRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IImageFile entity)
        {
            // Deactivate it
            ImageFilesRepository.Deactivate(entity);
            // Try to Save Changes
            ImageFilesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = ImageFilesRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = ImageFilesRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IImageFile entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            ImageFilesRepository.Remove(entity);
            // Try to Save Changes
            ImageFilesRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
