using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Contract.Repository
{
    public interface IRepository<E_Entity, P_PrimaryKey> where E_Entity:class
    {

        Task InsertAsync(E_Entity entity);
        Task UpdateAsync(E_Entity entity);
        Task DeleteAsync(P_PrimaryKey id);
        Task DeleteAsync(E_Entity entity);
        Task<List<E_Entity>> Select();
        Task<E_Entity> FindByIdAsync(P_PrimaryKey id);
        Task SaveChanges();

    }
}
