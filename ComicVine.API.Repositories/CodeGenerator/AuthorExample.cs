//namespace ComicVine.API.Repositories.Authors
//{
//    using System;
//    using System.Collections.Generic;
//    using System.Linq;
//    using DataModel.Schema;
//    using Interfaces.DataModels;
//    using Interfaces.Repositories;
//    using Interfaces.SearchModels;

//    public class AuthorsRepository : RepositoryBase, IAuthorsRepository
//    {
//        public AuthorsRepository(object context) : base(context) { }

//        public void Add(IAuthor entity)
//        {
//            Context.Authors.Add((Author)entity);
//        }

//        public void Remove(IAuthor entity)
//        {
//            Context.Authors.Remove((Author)entity);
//        }

//        public void Deactivate(IAuthor entity)
//        {
//            entity.Active = false;
//            Update(entity);
//        }

//        public void Update(IAuthor entity)
//        {
//            Context.SetModified(entity);
//        }

//        public IAuthor Get(int id)
//        {
//            return Context.Authors.FirstOrDefault(r => r.ID == id);
//        }

//        public IAuthor Get(string key)
//        {
//            return Context.Authors.FirstOrDefault(r => r.CustomKey == key);
//        }

//        public IEnumerable<IAuthor> List => Context.Authors;

//        public IEnumerable<dynamic> Search(IAuthorSearchModel searchModel, Func<IAuthor, dynamic> selectStatement, bool requireActive = true)
//        {
//            return SearchCommon(searchModel, requireActive)
//                .Select(selectStatement);
//        }

//        public IEnumerable<IAuthor> Search(IAuthorSearchModel searchModel, bool requireActive = true)
//        {
//            return SearchCommon(searchModel, requireActive);
//        }

//        // ReSharper disable once ReturnTypeCanBeEnumerable.Local
//        // ReSharper disable once SuggestBaseTypeForParameter
//        private IQueryable<IAuthor> SearchCommon(IAuthorSearchModel searchModel, bool requireActive)
//        {
//            return Context.Authors
//                .FilterByBaseFilters(searchModel, requireActive)
//                .FilterByNameableBaseFilters(searchModel)
//                .FilterByPaging(searchModel.Paging);
//        }
//    }

//    public static class AuthorSearchExtensions
//    {
//        // No Author Specific Queryable Extensions
//        //public static IQueryable<Author> FilterByName(this IQueryable<Author> query, string name)
//        //{
//        //    return string.IsNullOrWhiteSpace(name)
//        //        ? query
//        //        : query.Where(i => i.Name.Equals(name, StringComparison.CurrentCultureIgnoreCase));
//        //}
//    }
//}
