using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Aggregations.BoardAggregate
{
    public class Board : Frameworks.Base.BaseEntityGuid
    {
        #region [-Ctor-]
        public Board(string boardTitle)
        {
            BoardTitle = boardTitle;
        }
        #endregion

        #region [-Props-]
        public string BoardTitle { get; set; }
        public ICollection<ToDoAggregate.ToDo> ToDos { get; set; }
        #endregion


    }
}
