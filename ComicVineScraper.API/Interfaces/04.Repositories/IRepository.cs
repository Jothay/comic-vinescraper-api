namespace ComicVineScraper.API.Interfaces.Repositories
{
    using System;
    using System.Collections.Generic;

    public interface IRepository<TIEntity, TISearchModel>
        where TIEntity : DataModels.IEntity
        where TISearchModel : SearchModels.IEntitySearchModel
    {
        TIEntity Get(int id);
        TIEntity Get(string key);
        IEnumerable<TIEntity> List { get; }
        IEnumerable<dynamic> Search(TISearchModel searchModel, Func<TIEntity, dynamic> selectStatement, bool requireActive = true);
        IEnumerable<TIEntity> Search(TISearchModel searchModel, bool requireActive = true);
        void Add(TIEntity entity);
        void Remove(TIEntity entity);
        void Deactivate(TIEntity entity);
        void Update(TIEntity entity);
    }
}