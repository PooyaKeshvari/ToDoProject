using AutoMapper;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using ToDo.Application.Dtos;
using ToDo.Domain.Factories;
using ToDo.Domain.Repositories;

namespace ToDo.Application.Services
{
    public class BoardAppService : Abstracts.IBoardAppService
    {
        #region [-Ctor-]
        public BoardAppService(IMapper mapper, IBoardRepository repository, BoardFactory factory)
        {
            Mapper = mapper;
            Repository = repository;
            Factory = factory;
        }
        #endregion

        #region [-Props-]
        public IMapper Mapper { get; set; }
        public Domain.Repositories.IBoardRepository Repository { get; set; }
        public Domain.Factories.BoardFactory Factory { get; set; }
        #endregion

        #region [-Methods-]

        #region [-DeleteAsync(Guid id)-]
        public async Task DeleteAsync(Guid id)
        {
            await Repository.DeleteAsync(id);
        }
        #endregion

        #region [-GetAllAsync()-]
        public async Task<List<BoardDto>> GetAllAsync()
        {
            var q = await Repository.Select();
            return Mapper.Map<List<BoardDto>>(q);
        }
        #endregion

        #region [-GetByIdAsync(Guid id)-]
        public async Task<BoardDto> GetByIdAsync(Guid id)
        {
            var q = await Repository.FindByIdAsync(id);
            return Mapper.Map<BoardDto>(q);
        }
        #endregion

        #region [-PostAsync(ToDoDto entity)-]
        public async Task PostAsync(BoardNoneQueryDto entity)
        {
            var created =await Factory.CreateAsync(entity.Title);
            await Repository.InsertAsync(created);
        }
        #endregion

        #region [-PutAsync(ToDoDto entity)-]
        public async Task PutAsync(Guid id,BoardNoneQueryDto entity)
        {
            var board = await Repository.FindByIdAsync(id);
            if (board!= null)
            {
                board.BoardTitle = entity.Title;
            }

        }
        #endregion

        #endregion

    }
}
