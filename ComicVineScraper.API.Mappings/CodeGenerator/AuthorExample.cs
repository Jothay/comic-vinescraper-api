//namespace ComicVine.API.Mappings.Authors
//{
//    using DataModel.Schema;
//    using Interfaces.DataModels;
//    using Interfaces.Mappers;
//    using Interfaces.Models;
//    using Interfaces.SearchModels;
//    using Models;
//    using SearchModels;

//    public class AuthorMapper : IAuthorMapper
//    {
//        public IAuthor MapToEntity(IAuthorModel model)
//        {
//            var entity = NameableEntityMapper.MapToEntity<Author, IAuthorModel>(model);
//            // Assign Properties
//            // <None>
//            // Return Entity
//            return entity;
//        }

//        public void MapToEntity(IAuthorModel model, ref IAuthor entity)
//        {
//            // Assign Base properties
//            NameableEntityMapper.MapToEntity(model, ref entity);
//            // Assign Properties
//            // <None>
//        }

//        public IAuthorModel MapToModel(IAuthor entity)
//        {
//            var model = NameableEntityMapper.MapToModel<IAuthor, AuthorModel>(entity);
//            // Assign Properties
//            // <None>
//            // Return Entity
//            return model;
//        }

//        public IAuthorModel MapToModelLite(IAuthor entity)
//        {
//            var model = NameableEntityMapper.MapToModelLite<IAuthor, AuthorModel>(entity);
//            // Assign Properties
//            // <None>
//            // Return Entity
//            return model;
//        }

//        public IAuthorModel MapToModelListing(IAuthor entity)
//        {
//            var model = NameableEntityMapper.MapToModelListing<IAuthor, AuthorModel>(entity);
//            // Assign Properties
//            // <None>
//            // Return Entity
//            return model;
//        }

//        public IAuthorSearchModel MapToSearchModel(IAuthorModel model)
//        {
//            var searchModel = NameableEntityMapper.MapToSearchModel<IAuthorModel, AuthorSearchModel>(model);
//            // Assign Properties
//            // <None>
//            // Return Entity
//            return searchModel;
//        }

//        public bool AreEqual(IAuthorModel model, IAuthor entity)
//        {
//            return NameableEntityMapper.AreEqual(model, entity);
//        }
//    }
//}
