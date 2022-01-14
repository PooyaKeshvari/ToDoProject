using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Frameworks.Abstract
{
    //For Common Props between Entities
   public interface IEntity<P_PrimaryKey>
    {
        P_PrimaryKey Id { get; set; }
    }
}
