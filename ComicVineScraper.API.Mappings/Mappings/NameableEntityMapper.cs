namespace ComicVineScraper.API.Mappings
{
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Interfaces.SearchModels;

    public static class NameableEntityMapper
    {
        public static TEntity MapToEntity<TEntity, TModel>(TModel model)
            where TEntity : INameableEntity
            where TModel : INameableEntityModel
        {
            // Create an instance
            var entity = EntityMapper.MapToEntity<TEntity, TModel>(model);
            // Assign Properties
            entity.Name = model.Name;
            entity.ShortDescription = model.ShortDescription;
            entity.Description = model.Description;
            // Return the Result
            return entity;
        }

        public static void MapToEntity<TEntity, TModel>(TModel model, ref TEntity entity)
            where TEntity : INameableEntity
            where TModel : INameableEntityModel
        {
            // Assign Properties
            EntityMapper.MapToEntity(model, ref entity);
            entity.Name = model.Name;
            entity.ShortDescription = model.ShortDescription;
            entity.Description = model.Description;
        }

        public static TModel MapToModel<TEntity, TModel>(TEntity entity)
            where TEntity : INameableEntity
            where TModel : INameableEntityModel
        {
            // Create an Instance
            var model = EntityMapper.MapToModel<TEntity, TModel>(entity);
            // Assign Properties
            model.Name = entity.Name;
            model.ShortDescription = entity.ShortDescription;
            model.Description = entity.Description;
            // Return the Result
            return model;
        }

        public static TModel MapToModelLite<TEntity, TModel>(TEntity entity)
            where TEntity : INameableEntity
            where TModel : INameableEntityModel
        {
            // Create an Instance
            var model = EntityMapper.MapToModelLite<TEntity, TModel>(entity);
            // Assign Properties
            model.Name = entity.Name;
            model.ShortDescription = entity.ShortDescription;
            model.Description = entity.Description;
            // Return the Result
            return model;
        }

        public static TModel MapToModelListing<TEntity, TModel>(TEntity entity)
            where TEntity : INameableEntity
            where TModel : INameableEntityModel
        {
            // Create an Instance
            var model = EntityMapper.MapToModelListing<TEntity, TModel>(entity);
            // Assign Properties
            model.Name = entity.Name;
            // Return the Result
            return model;
        }

        public static TSearchModel MapToSearchModel<TModel, TSearchModel>(TModel model)
            where TModel : INameableEntityModel
            where TSearchModel : INameableEntitySearchModel
        {
            // Create an Instance
            var searchModel = EntityMapper.MapToSearchModel<TModel, TSearchModel>(model);
            // Assign Properties
            searchModel.Name = model.Name;
            searchModel.ShortDescription = model.ShortDescription;
            searchModel.Description = model.Description;
            // Return the Result
            return searchModel;
        }

        public static bool AreEqual<TModel, TEntity>(TModel model, TEntity entity)
            where TModel : INameableEntityModel
            where TEntity : INameableEntity
        {
            return EntityMapper.AreEqual(model, entity)
                && string.Equals(model.Name, entity.Name)
                && string.Equals(model.ShortDescription, entity.ShortDescription)
                && string.Equals(model.Description, entity.Description);
        }
    }
}
