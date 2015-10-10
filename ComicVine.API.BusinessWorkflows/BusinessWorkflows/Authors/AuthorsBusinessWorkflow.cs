namespace ComicVine.API.BusinessWorkflows.Authors
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

    public class AuthorsBusinessWorkflow : IAuthorsBusinessWorkflow
    {
        public AuthorsBusinessWorkflow(IAuthorsRepository authorsRepository, IAuthorMapper authorMapper)
        {
            AuthorsRepository = authorsRepository;
            AuthorMapper = authorMapper;
        }

        #region Private Variables
        private IAuthorMapper AuthorMapper { get; }
        private IAuthorsRepository AuthorsRepository { get; }
        #endregion
        #region Read
        public IAuthorModel Get(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            return AuthorMapper.MapToModel(AuthorsRepository.Get(id));
        }

        public IAuthorModel Get(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            return AuthorMapper.MapToModel(AuthorsRepository.Get(key));
        }

        public List<IAuthorModel> Search(IAuthorSearchModel searchModel, bool asListing = false)
        {
            var results = AuthorsRepository.Search(searchModel);
            return asListing
                ? results.Select(AuthorMapper.MapToModelListing).ToList()
                : results.Select(AuthorMapper.MapToModelLite).ToList();
        }
        #endregion
        #region Create
        public IAuthorModel Create(IAuthorModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateIDIsNull(model.Id);
            BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Search for an Existing Record (Don't allow Duplicates
            var results = Search(AuthorMapper.MapToSearchModel(model));
            if (results.Any()) { return results.First(); } // Return the first that matches
            // Map model to a new entity
            var newEntity = AuthorMapper.MapToEntity(model);
            newEntity.CreatedDate = BusinessWorkflowBase.GenDateTime;
            newEntity.UpdatedDate = null;
            newEntity.Active = true;
            // Add it
            AuthorsRepository.Add(newEntity);
            // Try to Save Changes
            AuthorsRepository.SaveChanges();
            // Return the new value
            return Get(newEntity.Id);
        }
        #endregion
        #region Update
        public IAuthorModel Update(IAuthorModel model)
        {
            // Validate model
            BusinessWorkflowBase.ValidateRequiredNullableID(model.Id);
            BusinessWorkflowBase.ValidateRequiredString(model.Name, nameof(model.Name));
            // Find existing entity
            // ReSharper disable once PossibleInvalidOperationException
            var existingEntity = AuthorsRepository.Get(model.Id.Value);
            // Check if we would be applying identical information, if we are, just return the original
            // ReSharper disable once SuspiciousTypeConversion.Global
            if (AuthorMapper.AreEqual(model, existingEntity))
            {
                return AuthorMapper.MapToModel(existingEntity);
            }
            // Map model to an existing entity
            AuthorMapper.MapToEntity(model, ref existingEntity);
            existingEntity.UpdatedDate = BusinessWorkflowBase.GenDateTime;
            // Update it
            AuthorsRepository.Update(AuthorMapper.MapToEntity(model));
            // Try to Save Changes
            AuthorsRepository.SaveChanges();
            // Return the new value
            return Get(existingEntity.Id);
        }
        #endregion
        #region Deactivate
        public bool Deactivate(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = AuthorsRepository.Get(id);
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
            var existingEntity = AuthorsRepository.Get(key);
            if (existingEntity == null)
            {
                throw new InvalidOperationException($"Could not find an entity with key {key} to deactivate it");
            }
            // Do the Deactivate
            return Deactivate(existingEntity);
        }
        protected bool Deactivate(IAuthor entity)
        {
            // Deactivate it
            AuthorsRepository.Deactivate(entity);
            // Try to Save Changes
            AuthorsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
        #region Remove
        public bool Remove(int id)
        {
            BusinessWorkflowBase.ValidateRequiredID(id);
            // Find existing Entity
            var existingEntity = AuthorsRepository.Get(id);
            // Do the Remove
            return Remove(existingEntity);
        }
        public bool Remove(string key)
        {
            BusinessWorkflowBase.ValidateRequiredKey(key);
            // Find existing Entity
            var existingEntity = AuthorsRepository.Get(key);
            // Do the Remove
            return Remove(existingEntity);
        }
        protected bool Remove(IAuthor entity)
        {
            if (entity == null) { return true; } // No entity found to remove, consider it passed
            // Remove it
            AuthorsRepository.Remove(entity);
            // Try to Save Changes
            AuthorsRepository.SaveChanges();
            // Finished!
            return true;
        }
        #endregion
    }
}
