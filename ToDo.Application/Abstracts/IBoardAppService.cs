using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;

namespace ToDo.Application.Abstracts
{
    [ScopedService]
    public interface IBoardAppService
    {
        Task<Dtos.BoardDto> GetByIdAsync(Guid id);
        Task<List<Dtos.BoardDto>> GetAllAsync();
        Task PostAsync(Dtos.BoardNoneQueryDto entity);
        Task PutAsync(Guid id,Dtos.BoardNoneQueryDto entity);
        Task DeleteAsync(Guid id);
    }
}
