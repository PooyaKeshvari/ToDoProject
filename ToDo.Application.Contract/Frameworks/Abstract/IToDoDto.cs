using System;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Contract.Frameworks.Abstract
{
    public interface IToDoDto
    {
        Guid Id { get; set; }
        string Title { get; set; }
        bool Done { get; set; }
        DateTime Created { get; set; }
        DateTime Updated { get; set; }
        Guid BoardId { get; set; }
        IBoardDto Board { get; set; }
    }
}
