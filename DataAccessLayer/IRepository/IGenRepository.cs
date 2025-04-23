using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.IRepository
{
    // T is a Class it may be any Employee,Department,Student etc
    public interface IGenRepository<T> where T : class 
    {
        void Add(T entity);
        void Update(T entity);
        void Remove(T entity);
        void Remove(int id); // remove by ID
        void RemoveRange(IEnumerable<T> values); // remove by range
        T Get(int id); //To find
        IEnumerable<T> GetAll(
            Expression<Func<T, bool>> filter = null,// 18>age<30
            Func<IQueryable<T>, IOrderedQueryable<T>>
            OrderBy = null,//sorting
            string includeProperties = null //data from multiple table
            );
        //for single record
        T FirstOrDefault(
            Expression<Func<T, bool>> filter = null,
            string includeProperties = null
            );

    }
}
