using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToDo.CoreWebApp.Controllers
{
    public class ToDoController : Controller
    {
        #region [-Ctor-]
        public ToDoController(Application.Abstracts.IToDoAppService appService)
        {
            AppService = appService;
        }
        #endregion

        #region [-Props-]
        public Application.Abstracts.IToDoAppService AppService { get; set; }
        #endregion

        #region [-Actions-]

        #region [-GetAll()-]
        public async Task<IActionResult> GetAll()
        {
           var q = await AppService.GetAllAsync();
            return View(q);
        }
        #endregion

        #endregion


    }
}
