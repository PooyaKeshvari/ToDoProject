using System;
using System.Collections.Generic;

namespace ToDo.Application.Contract.Frameworks.Abstract
{
    public interface IBoardDto
    {
        Guid Id { get; set; }
        string Title { get; set; }
    }
}
