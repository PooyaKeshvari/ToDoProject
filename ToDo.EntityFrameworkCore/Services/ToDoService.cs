using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.EntityFrameworkCore.Services
{
    public class ToDoService:Frameworks.Base.BaseService<ToDoDbContext,Domain.Aggregations.ToDoAggregate.ToDo,Guid> , Domain.Repositories.IToDoRepository
    {

        #region [-Ctor-]
        public ToDoService(ToDoDbContext context):base(context)
        {

        }
        #endregion

        #region [-Methods-]

        #region [-override-Select()-]
        public override async Task<List<Domain.Aggregations.ToDoAggregate.ToDo>> Select()
        {
            var q = await DbSet.Include(q => q.Board).ToListAsync();
            return q;
        }
        #endregion

        #region [-GetUnCompletedItem()-]
        public async Task<Domain.Aggregations.ToDoAggregate.ToDo> GetUnCompletedItem()
        {
            var unCompelete = await DbSet.FirstOrDefaultAsync(q => q.Done == false);
            return unCompelete;
        }
        #endregion

        #region [-UpdateStatus()-]
        public async Task UpdateStatus(Guid Id)
        {
            var target =await DbSet.FindAsync(Id);
            if (target.Done == false)
            {
                target.Done = true;
            }
            else
            {
                target.Done = false;
            }

        }
        #endregion

        #region [-FindByTitle(string title)-]
        public async Task<Domain.Aggregations.ToDoAggregate.ToDo> FindByTitle(string title)
        {
            var q = await DbSet.FirstOrDefaultAsync(t => t.Title == title);
            return q;
        }
        #endregion




        #endregion

    }
    }
