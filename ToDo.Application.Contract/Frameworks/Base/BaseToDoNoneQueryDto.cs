using System;
using ToDo.Application.Contract.Frameworks.Abstract;

namespace ToDo.Application.Contract.Frameworks.Base
{
    public class BaseToDoNoneQueryDto : Frameworks.Abstract.IToDoNoneQueryDto
    {
        #region [-Ctor-]
        public BaseToDoNoneQueryDto()
        {

        }
        #endregion

        #region [-Props-]
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid BoardId { get; set; }
        #endregion



    }
}
