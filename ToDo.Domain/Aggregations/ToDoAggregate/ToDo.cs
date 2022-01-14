using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Domain.Aggregations.ToDoAggregate
{
    public class ToDo : Frameworks.Base.BaseEntityGuid
    {
        #region [-Ctor-]
        public ToDo()
        {

        }

        public ToDo(string title, bool done, DateTime created, DateTime updated, Guid boardId)
        {
            Title = title;
            Done = done;
            Created = created;
            Updated = updated;
            BoardId = boardId;
        }
        #endregion

        #region [-Props-]
        public string Title { get; set; }
        public bool Done { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
        public Guid BoardId { get; set; }
        public BoardAggregate.Board Board { get; set; }
        #endregion


    }
}
