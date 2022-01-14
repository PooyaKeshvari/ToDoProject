using System;

namespace ToDo.Application.Contract.Frameworks.Abstract
{
    public interface IToDoNoneQueryDto
    {
        string Title { get; set; }
        bool Done { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
        Guid BoardId { get; set; }
    }
}
