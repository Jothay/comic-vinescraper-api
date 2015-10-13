namespace ComicVine.API.Repositories
{
    using System;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Validation;
    using System.Diagnostics;
    using DataModel;
    using Interfaces.Repositories;

    #region Repositories
    public class RepositoryBase : IRepositoryBase
    {
        public RepositoryBase(object context)
        {
            this.context = context == null ? new ModelEntities() : context as IModelEntities;
        }

        public virtual bool SaveChanges()
        {
            try
            {
                return Context.SaveChanges() >= 0;
            }
            catch (DbEntityValidationException ex)
            {
                Trace.WriteLine(ex);
                throw;
            }
            catch (DbUpdateException ex)
            {
                Trace.WriteLine(ex);
                throw;
            }
            catch (Exception ex)
            {
                Trace.WriteLine(ex);
                throw;
            }
        }

        protected IModelEntities context;
        protected IModelEntities Context => context ?? (context = new ModelEntities());
    }
    #endregion
}
