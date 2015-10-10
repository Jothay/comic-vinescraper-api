namespace ComicVine.API.Interfaces.Mappers
{
    public interface IMapper<TEntity, TModel, TSearchModel>
        where TEntity : DataModels.IEntity
        where TModel : Models.IEntityModel
        where TSearchModel : SearchModels.IEntitySearchModel
    {
        TEntity MapToEntity(TModel model);
        void MapToEntity(TModel model, ref TEntity entity);
        TModel MapToModel(TEntity entity);
        TModel MapToModelLite(TEntity entity);
        TModel MapToModelListing(TEntity entity);
        TSearchModel MapToSearchModel(TModel model);
        bool AreEqual(TModel model, TEntity entity);
    }
}
