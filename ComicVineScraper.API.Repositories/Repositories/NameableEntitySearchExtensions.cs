namespace ComicVine.API.Repositories
{
    using System;
    using System.Linq;
    using Interfaces.DataModels;
    using Interfaces.SearchModels;

    public static class NameableEntitySearchExtensions
    {
        public static IQueryable<TINameableEntity> FilterByNameableBaseFilters<TINameableEntity>(this IQueryable<TINameableEntity> query, INameableEntitySearchModel searchModel)
            where TINameableEntity : INameableEntity
        {
            return query
                .FilterByName(searchModel.Name)
                .FilterByShortDescription(searchModel.ShortDescription)
                .FilterByDescription(searchModel.Description);
        }

        public static IQueryable<TINameableEntity> FilterByName<TINameableEntity>(this IQueryable<TINameableEntity> query, string name)
            where TINameableEntity : INameableEntity
        {
            return string.IsNullOrWhiteSpace(name) ? query
                : query.Where(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IQueryable<TINameableEntity> FilterByShortDescription<TINameableEntity>(this IQueryable<TINameableEntity> query, string description)
            where TINameableEntity : INameableEntity
        {
            return string.IsNullOrWhiteSpace(description) ? query
                : query.Where(i => i.ShortDescription.Equals(description, StringComparison.CurrentCultureIgnoreCase));
        }

        public static IQueryable<TINameableEntity> FilterByDescription<TINameableEntity>(this IQueryable<TINameableEntity> query, string description)
            where TINameableEntity : INameableEntity
        {
            return string.IsNullOrWhiteSpace(description) ? query
                : query.Where(i => i.Description.Equals(description, StringComparison.CurrentCultureIgnoreCase));
        }
    }
}
