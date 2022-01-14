using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.CoreWebApp.Controllers
{
    public class BoardController : Controller
    {
        #region [-Ctor-]
        public BoardController(Application.Abstracts.IBoardAppService appService)
        {
            AppService = appService;
        }
        #endregion

        #region [-Props-]
        public Application.Abstracts.IBoardAppService AppService { get; set; }
        #endregion

        #region [-Actions-]
        
        #region [-GetAll()-]
        [HttpGet]
        public async Task<List<Application.Dtos.BoardDto>> GetAll()
        {
            var q = await AppService.GetAllAsync();
            return q;
        }
        #endregion

        #region [-GetById(Guid id)-]
        [HttpGet]
        public async Task<Application.Dtos.BoardDto> GetById(Guid id)
        {
            var q = await AppService.GetByIdAsync(id);
            return q;
        }
        #endregion

        #region [-PostAsync(BoardDto dto)-]
        [HttpPost]
        public async Task PostAsync(Application.Dtos.BoardDto dto)
        {
            await AppService.PostAsync(dto);
        }
        #endregion

        #region [-PutAsync(Guid id,BoardDto dto)-]
        [HttpPut]
        public async Task PutAsync(Guid id, Application.Dtos.BoardDto dto)
        {
            await AppService.PutAsync(id, dto);
        }
        #endregion

        #region [-DeleteAsync(Guid id-]
        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await AppService.DeleteAsync(id);
        }
        #endregion
        #endregion





    }
}