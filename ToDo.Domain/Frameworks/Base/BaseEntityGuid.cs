using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Frameworks.Base
{
    //we Can have many Type of pk in project
    public class BaseEntityGuid : Abstract.IEntity<Guid>
    {
        public Guid Id { get ; set ; }
    }
}
