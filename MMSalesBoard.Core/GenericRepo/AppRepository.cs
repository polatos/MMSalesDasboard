using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using MMSalesBoard.DataAccess.EntityFrameworkCore;

namespace MMSalesBoard.Core.GenericRepo
{
    public class AppRepository<T> : IAppRepository<T> where T : class
    {
        protected ApplicationContext RepositoryContext { get; set; }

        public AppRepository(ApplicationContext repositoryContext) => RepositoryContext = repositoryContext;

        public IEnumerable<T> FindAll()
        {
            return this.RepositoryContext.Set<T>();
        }

        public T Find(Expression<Func<T, bool>> @where)
        {
            return this.RepositoryContext.Set<T>().FirstOrDefault(where);
        }

        public IEnumerable<T> FindByCondition(Expression<Func<T, bool>> expression)
        {
            return this.RepositoryContext.Set<T>().Where(expression);
        }

        public void Create(T entity)
        {
            this.RepositoryContext.Set<T>().Add(entity);
            this.RepositoryContext.SaveChanges();
        }

        public void Update(T entity)
        {
            this.RepositoryContext.Set<T>().Update(entity);
            this.RepositoryContext.SaveChanges();
        }

        public void Delete(T entity)
        {
            this.RepositoryContext.Set<T>().Remove(entity);
            this.RepositoryContext.SaveChanges();
        }
    }
}
