namespace ComicVineScraper.API.Repositories
{
    using System;
    using System.Linq;
    using Interfaces.DataModels;
    using Interfaces.SearchModels;

    public static class EntitySearchExtensions
    {
        public static IQueryable<TIEntity> FilterByBaseFilters<TIEntity>(this IQueryable<TIEntity> query, IEntitySearchModel searchModel, bool requireActive = true)
            where TIEntity : IEntity
        {
            if (requireActive) { query = query.FilterByActive(); }
            return query
                .FilterByID(searchModel.Id)
                .FilterByCustomKey(searchModel.CustomKey)
                .FilterByApiDetailUrl(searchModel.ApiDetailUrl)
                .FilterBySiteDetailUrl(searchModel.SiteDetailUrl)
                .FilterByModifiedSince(searchModel.ModifiedSince);
        }

        public static IQueryable<TIEntity> FilterByActive<TIEntity>(this IQueryable<TIEntity> query)
            where TIEntity : IEntity
        {
            return query.Where(i => i.Active);
        }

        public static IQueryable<TIEntity> FilterByID<TIEntity>(this IQueryable<TIEntity> query, int? id)
            where TIEntity : IEntity
        {
            return (!id.HasValue || id.Value <= 0) ? query : query.Where(i => i.Id == id.Value);
        }

        public static IQueryable<TIEntity> FilterByCustomKey<TIEntity>(this IQueryable<TIEntity> query, string customKey)
            where TIEntity : IEntity
        {
            return string.IsNullOrWhiteSpace(customKey) ? query
                : query.Where(i => i.CustomKey.Equals(customKey, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IQueryable<TIEntity> FilterByApiDetailUrl<TIEntity>(this IQueryable<TIEntity> query, string url)
            where TIEntity : IEntity
        {
            return string.IsNullOrWhiteSpace(url) ? query
                : query.Where(i => i.ApiDetailUrl.Equals(url, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IQueryable<TIEntity> FilterBySiteDetailUrl<TIEntity>(this IQueryable<TIEntity> query, string url)
            where TIEntity : IEntity
        {
            return string.IsNullOrWhiteSpace(url) ? query
                : query.Where(i => i.SiteDetailUrl.Equals(url, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IQueryable<TIEntity> FilterByModifiedSince<TIEntity>(this IQueryable<TIEntity> query, DateTime? modifiedSince)
            where TIEntity : IEntity
        {
            if (!modifiedSince.HasValue) { return query; }
            return query
                .Where(i => i.UpdatedDate.HasValue && i.UpdatedDate.Value > modifiedSince.Value
                            || i.CreatedDate > modifiedSince.Value);
        }

        public static IQueryable<TIEntity> FilterByPaging<TIEntity>(this IQueryable<TIEntity> query, IPaging paging)
            where TIEntity : IEntity
        {
            return paging == null ? query : query.Skip(paging.Skip).Take(paging.Take);
        }
    }
}
