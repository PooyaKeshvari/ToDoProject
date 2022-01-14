using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contract.Frameworks.Abstract;

namespace ToDo.Application.Contract.Frameworks.Base
{
    public class BaseToDoDto : Frameworks.Abstract.IToDoDto
    {
        #region [-Ctor-]
        public BaseToDoDto()
        {

        }
        #endregion

        #region [-Props-]
        public Guid Id { get; set; }
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid BoardId { get; set; }
        public IBoardDto Board { get; set; }
        #endregion



    }
}
