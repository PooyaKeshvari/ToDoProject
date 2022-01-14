using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ToDo.Application.Abstracts
{
    [ScopedService]

    public interface IToDoAppService
    {
        Task<Dtos.ToDoDto> GetByIdAsync(Guid id);
        Task<Dtos.ToDoDto> GetUnCompletedItem();
        Task UpdateStatus(Guid id);
        Task<List<Dtos.ToDoDto>> GetAllAsync();
        Task PostAsync(Dtos.ToDoNoneQueryDto entity);
        Task PutAsync(Guid id,Dtos.ToDoNoneQueryDto entity);
        Task DeleteAsync(Guid id);
    }
}
