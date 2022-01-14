using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Dtos;
using ToDo.Domain.Factories;
using ToDo.Domain.Repositories;

namespace ToDo.Application.Services
{
    public class ToDoAppService : Abstracts.IToDoAppService
    {
        #region [-Ctor-]
        public ToDoAppService(IMapper mapper, IToDoRepository repository, ToDoFactory factory)
        {
            Mapper = mapper;
            Repository = repository;
            Factory = factory;
        }
        #endregion

        #region [-Props-]
        public IMapper Mapper { get; set; }
        public Domain.Repositories.IToDoRepository Repository { get; set; }
        public Domain.Factories.ToDoFactory Factory { get; set; }
        #endregion

        #region [-Methods-]

        #region [-DeleteAsync(Guid id)-]
        public async Task DeleteAsync(Guid id)
        {
            await Repository.DeleteAsync(id);
        }
        #endregion

        #region [-GetAllAsync()-]
        public async Task<List<ToDoDto>> GetAllAsync()
        {
            var q = await Repository.Select();
            return Mapper.Map<List<ToDoDto>>(q);
        }
        #endregion

        #region [-GetByIdAsync(Guid id)-]
        public async Task<ToDoDto> GetByIdAsync(Guid id)
        {
            var q = await Repository.FindByIdAsync(id);
            return Mapper.Map<ToDoDto>(q);
        }
        #endregion

        #region [-PostAsync(ToDoDto entity)-]
        public async Task PostAsync(ToDoNoneQueryDto entity)
        {
            var converted = Factory.DtoConvertor(entity);
            var insert= await Factory.CheckAndPass(converted.Title, converted.Done, converted.Created, converted.Updated, converted.BoardId);
            await Repository.InsertAsync(insert);   
        }
        #endregion

        #region [-PutAsync(ToDoDto entity)-]
        public async Task PutAsync(Guid id,ToDoNoneQueryDto entity)
        {
            var toDo =await Repository.FindByIdAsync(id);
            if (toDo!=null)
            {
                toDo.Title = entity.Title;
                toDo.Updated = entity.Updated;
                toDo.Created = entity.Created;
                toDo.BoardId = entity.BoardId;
                toDo.Done = entity.Done;
            }
            
        }
        #endregion

        #region [-GetUnCompletedItem()-]
        public async Task<Dtos.ToDoDto > GetUnCompletedItem()
        {
            var q = await Repository.GetUnCompletedItem();
            return Mapper.Map<ToDoDto>(q);
        }
        #endregion

        #region [-UpdateStatus(Guid Id)-]
        public async Task UpdateStatus(Guid id)
        {
            await Repository.UpdateStatus(id);
        }
        #endregion

        #endregion

    }
}
