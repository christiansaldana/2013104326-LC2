using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace NewLine.Entities.IRepositories
{
    interface IRepository<TEntity> where TEntity : class
    {

       
        void add(TEntity entity);        
        void addRange(IEnumerable<TEntity> entities);
        TEntity Get(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerator<TEntity> Find(Expression<Func<TEntity, bool>> predicate);             
        void Update(TEntity entity);
        void UpdateRange(IEnumerable<TEntity> entities);       
        void Delete(TEntity entity);
        void DeleteRange(IEnumerable<TEntity> entities);

    }
}
