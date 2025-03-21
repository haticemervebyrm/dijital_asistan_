using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using dijital_asistan.Data;
using Microsoft.EntityFrameworkCore;

namespace dijital_asistan.Abstract
{
        public interface IRepository<T> where T : class
        {
        List<T> GetAll();
        T GetByFilter(Expression<Func<T, bool>> predicate);

        T GetById(int id);
        void Create(T entity);
        void Update(T entity);
        void Delete(int id);
        int Count();

        int FilteredCount(Expression<Func<T, bool>> predicate);
        List<T> GetFilteredList(Expression<Func<T, bool>> predicate);

        }
}
