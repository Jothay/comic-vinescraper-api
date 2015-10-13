namespace ComicVine.API.Mappings
{
    using System;
    using Interfaces.DataModels;
    using Interfaces.Models;
    using Interfaces.SearchModels;

    public static class EntityMapper
    {
        public static TEntity MapToEntity<TEntity, TModel>(TModel model)
            where TEntity : IEntity
            where TModel : IEntityModel
        {
            // Create an instance
            var entity = Activator.CreateInstance<TEntity>();
            // Assign Properties
            if (model.Id.HasValue) { entity.Id = model.Id.Value; }
            entity.Active = model.Active;
            entity.CreatedDate = model.CreatedDate;
            entity.UpdatedDate = model.UpdatedDate;
            entity.CustomKey = model.CustomKey;
            entity.ApiDetailUrl = model.ApiDetailUrl;
            entity.SiteDetailUrl = model.SiteDetailUrl;
            // Return the Result
            return entity;
        }

        public static void MapToEntity<TEntity, TModel>(TModel model, ref TEntity entity)
            where TEntity : IEntity
            where TModel : IEntityModel
        {
            // Assign Properties
            if (model.Id.HasValue) { entity.Id = model.Id.Value; }
            entity.Active = model.Active;
            entity.CreatedDate = model.CreatedDate;
            entity.UpdatedDate = model.UpdatedDate;
            entity.CustomKey = model.CustomKey;
            entity.ApiDetailUrl = model.ApiDetailUrl;
            entity.SiteDetailUrl = model.SiteDetailUrl;
        }

        public static TModel MapToModel<TEntity, TModel>(TEntity entity)
            where TEntity : IEntity
            where TModel : IEntityModel
        {
            // Create an Instance
            var model = Activator.CreateInstance<TModel>();
            // Assign Properties
            model.Id = entity.Id;
            model.Active = entity.Active;
            model.CreatedDate = entity.CreatedDate;
            model.UpdatedDate = entity.UpdatedDate;
            model.CustomKey = entity.CustomKey;
            model.ApiDetailUrl = entity.ApiDetailUrl;
            model.SiteDetailUrl = entity.SiteDetailUrl;
            // Return the Result
            return model;
        }

        public static TModel MapToModelLite<TEntity, TModel>(TEntity entity)
            where TEntity : IEntity
            where TModel : IEntityModel
        {
            // Create an Instance
            var model = Activator.CreateInstance<TModel>();
            // Assign Properties
            model.Id = entity.Id;
            model.Active = entity.Active;
            model.CreatedDate = entity.CreatedDate;
            model.UpdatedDate = entity.UpdatedDate;
            model.CustomKey = entity.CustomKey;
            model.ApiDetailUrl = entity.ApiDetailUrl;
            model.SiteDetailUrl = entity.SiteDetailUrl;
            // Return the Result
            return model;
        }

        public static TModel MapToModelListing<TEntity, TModel>(TEntity entity)
            where TEntity : IEntity
            where TModel : IEntityModel
        {
            // Create an Instance
            var model = Activator.CreateInstance<TModel>();
            // Assign Properties
            model.Id = entity.Id;
            model.Active = entity.Active;
            model.CustomKey = entity.CustomKey;
            // Return the Result
            return model;
        }

        public static TSearchModel MapToSearchModel<TModel, TSearchModel>(TModel model)
            where TModel : IEntityModel
            where TSearchModel : IEntitySearchModel
        {
            // Create an Instance
            var searchModel = Activator.CreateInstance<TSearchModel>();
            // Assign Properties
            searchModel.Id = model.Id;
            searchModel.CustomKey = model.CustomKey;
            searchModel.ApiDetailUrl = model.ApiDetailUrl;
            searchModel.SiteDetailUrl = model.SiteDetailUrl;
            // Return the Result
            return searchModel;
        }

        ///// <summary>Map the properties of one object to another by name, assumes property types match.</summary>
        ///// <typeparam name="TSource">Type of the source.</typeparam>
        ///// <typeparam name="TTarget">Type of the target.</typeparam>
        ///// <param name="source">Source for the.</param>
        ///// <param name="target">The target to act on.</param>
        ///// <returns>A TTarget.</returns>
        //public static TTarget MapProperties<TSource, TTarget>(this TSource source, TTarget target)
        //{
        //    // get property list of the target object.
        //    // this is a reflection extension which simply gets properties (CanWrite = true).
        //    var tprops = target.GetType().GetProperties().Where(p => p.CanRead && p.CanWrite);
        //    tprops.ToList().ForEach(prop =>
        //    {
        //        // check whether source object has the the property
        //        var sp = source.GetType().GetProperty(prop.Name);
        //        if (sp != null)
        //        {
        //            // if yes, copy the value to the matching property
        //            var value = sp.GetValue(source, null);
        //            target.GetType().GetProperty(prop.Name).SetValue(target, value, null);
        //        }
        //    });
        //    return target;
        //}

        public static bool AreEqual<TModel, TEntity>(TModel model, TEntity entity)
            where TModel : IEntityModel
            where TEntity : IEntity
        {
            // NOTE: Intentionally not checking dates
            return model.Id == entity.Id
                && model.Active == entity.Active
                && string.Equals(model.CustomKey, entity.CustomKey)
                && string.Equals(model.ApiDetailUrl, entity.ApiDetailUrl)
                && string.Equals(model.SiteDetailUrl, entity.SiteDetailUrl);
        }
    }
}
