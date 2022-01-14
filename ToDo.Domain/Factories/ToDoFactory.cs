using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;
using ToDo.Domain.Aggregations.ToDoAggregate;
using ToDo.Domain.Repositories;

namespace ToDo.Domain.Factories
{
    //For new Domain Side Dto for ApplicationLayer
    [ScopedService]
    public class ToDoFactory
    {

        #region [-Ctor-]
        public ToDoFactory(IToDoRepository toDoRepository)
        {
            Repository = toDoRepository;
        }
        #endregion

        #region [-Props-]
        public Repositories.IToDoRepository Repository { get; set; }
        #endregion

        #region [-Methods-]

        #region [-CheckAndPass()-]
        public async Task<Aggregations.ToDoAggregate.ToDo> CheckAndPass(string title, bool done, DateTime created, DateTime updated, Guid boardId)
        {
            var current = await Repository.FindByTitle(title);
            if (current == null)
            {
                return new Aggregations.ToDoAggregate.ToDo(title, done, created, updated, boardId);
            }
            else
            {
                return null;
            }
        }
        #endregion

        #region [-DtoConvertor-]
        public Aggregations.ToDoAggregate.ToDo DtoConvertor(Application.Contract.Frameworks.Abstract.IToDoDto dto)
        {

            var model = new Aggregations.ToDoAggregate.ToDo();
            model.Title = dto.Title;
            model.Updated = dto.Updated;
            model.Created = dto.Created;
            model.BoardId = dto.BoardId;
            model.Done = dto.Done;
            return model;
        }

        #region [-DtoConvertor-]
        public Aggregations.ToDoAggregate.ToDo DtoConvertor(Application.Contract.Frameworks.Abstract.IToDoNoneQueryDto dto)
        {

            var model = new Aggregations.ToDoAggregate.ToDo();
            model.Title = dto.Title;
            model.Updated = dto.Updated;
            model.Created = dto.Created;
            model.BoardId = dto.BoardId;
            model.Done = dto.Done;
            return model;
        }
        #endregion


        #endregion

        #endregion


    }
}
