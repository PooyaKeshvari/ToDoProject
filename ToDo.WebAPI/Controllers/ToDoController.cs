using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToDo.Application.Abstracts;

namespace ToDo.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ToDoController : ControllerBase
    {
        #region [-Ctor-]
        public ToDoController(IToDoAppService appService)
        {
            AppService = appService;
        }
        #endregion

        #region [-Prop-]
        public IToDoAppService AppService { get; set; }
        #endregion

        #region [-Actions-]

        #region [-GetAll()-]
        [Route("wapi/v1/1")]
        [HttpGet]
        public async Task<List<Application.Dtos.ToDoDto>> GetAll()
        {
            var q = await AppService.GetAllAsync();
            return q;
        }
        #endregion

        #region [-GetById(Guid id)-]
        [Route("wapi/v1/2")]
        [HttpGet]
        public async Task<Application.Dtos.ToDoDto> GetById(Guid id)
        {
            var q = await AppService.GetByIdAsync(id);
            return q;
        }
        #endregion

        #region [-PostAsync()-]
        [Route("wapi/v1/3")]
        [HttpPost]
        public async Task PostAsync(Application.Dtos.ToDoNoneQueryDto dto)
        {
            await AppService.PostAsync(dto);

        }
        #endregion

        #region [-PutAsync(Guid id,ToDoDto dto)-]
        [Route("wapi/v1/4")]
        [HttpPut]
        public async Task PutAsync(Guid id, Application.Dtos.ToDoNoneQueryDto dto)
        {
            await AppService.PutAsync(id, dto);

        }
        #endregion

        #region [-DeleteAsync(Guid id)-]
        [Route("wapi/v1/5")]
        [HttpDelete]
        public async Task DeleteAsync(Guid id)
        {
            await AppService.DeleteAsync(id);

        }
        #endregion

        #region [-UpdateStatus()-]
        [Route("wapi/v1/6")]
        [HttpPost]
        public async Task UpdateStatus(Guid id)
        {
            await AppService.UpdateStatus(id);
        }
        #endregion

        #endregion
    }
}
