namespace ComicVineScraper.API.Interfaces.Mappers
{
    public interface IMapper<TEntity, TModel, TSearchModel>
        where TEntity : DataModels.IEntity
        where TModel : Models.IEntityModel
        where TSearchModel : SearchModels.IEntitySearchModel
    {
        TEntity MapToEntity(TModel model, int currentDepth = 1);
        void MapToEntity(TModel model, ref TEntity entity, int currentDepth = 1);
        TModel MapToModel(TEntity entity, int currentDepth = 1);
        TModel MapToModelLite(TEntity entity, int currentDepth = 1);
        TModel MapToModelListing(TEntity entity, int currentDepth = 1);
        TSearchModel MapToSearchModel(TModel model);
        bool AreEqual(TModel model, TEntity entity);
    }
}
