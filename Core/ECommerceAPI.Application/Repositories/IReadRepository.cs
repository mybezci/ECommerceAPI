using ECommerceAPI.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceAPI.Application.Repositories
{
    public interface IReadRepository<T> : IRepository<T> where T : BaseEntity
    {
        IQueryable<T> GetAll();

        //The data whose condition expression given to the function is true are queried and retrieved.
        IQueryable<T> GetWhere(Expression<Func<T, bool>> method);

        // The first unique data suitable for the condition expression given to the function is queried and retrieved.
        Task<T> GetSingleAsync(Expression<Func<T, bool>> method);
        Task<T> GetByIdAsync(string id);

    }
}
