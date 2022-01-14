using System;
using System.Collections.Generic;
using ToDo.Application.Contract.Frameworks.Abstract;

namespace ToDo.Application.Contract.Frameworks.Base
{
    public class BaseBoardDto : Frameworks.Abstract.IBoardDto
    {
        #region [-Ctor-]
        public BaseBoardDto()
        {

        }
        #endregion

        #region [-Props-]
        public Guid Id { get; set; }
        public string Title { get ; set ; }
        #endregion



    }
}
