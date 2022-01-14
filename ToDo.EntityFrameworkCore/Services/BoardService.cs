using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Domain.Aggregations.BoardAggregate;

namespace ToDo.EntityFrameworkCore.Services
{
    public class BoardService : Frameworks.Base.BaseService<ToDoDbContext, Board, Guid> , Domain.Repositories.IBoardRepository
    {

        #region [-Ctor-]
        public BoardService(ToDoDbContext context) : base(context)
        {

        }
        #endregion

        #region [-Methods-]


        #region [-FindByTitle(string title)-]
        public async Task<Board> FindByTitle(string title)
        {
            var q =await DbSet.FirstOrDefaultAsync(t => t.BoardTitle == title);
            return q;
        }
        #endregion

        


        #endregion

    }
}
