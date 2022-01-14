using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ToDo.Domain.Repositories
{
    // for special Methods in Flow
    [ScopedService]
    public interface IToDoRepository:Contract.Repository.IRepository<Aggregations.ToDoAggregate.ToDo,Guid>
    {
        Task<Aggregations.ToDoAggregate.ToDo> GetUnCompletedItem();
        Task UpdateStatus(Guid id);
        Task<Aggregations.ToDoAggregate.ToDo> FindByTitle(string title);


    }
}
