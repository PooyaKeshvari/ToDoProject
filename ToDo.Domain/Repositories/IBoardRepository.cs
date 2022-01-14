using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;
using ToDo.Domain.Aggregations.BoardAggregate;

namespace ToDo.Domain.Repositories
{
    // for special Methods in Flow
    [ScopedService]
    public interface IBoardRepository : Contract.Repository.IRepository<Board, Guid>
    {
        Task<Board> FindByTitle(string title);
    }
}
