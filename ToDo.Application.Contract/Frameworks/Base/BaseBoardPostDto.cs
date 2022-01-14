using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ToDo.Application.Contract.Frameworks.Abstract;

namespace ToDo.Application.Contract.Frameworks.Base
{
    public class BaseBoardNoneQueryDto : Abstract.IBoardNoneQueryDto
    {
        public string Title { get ; set ; }
    }
}
