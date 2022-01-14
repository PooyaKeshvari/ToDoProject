using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToDo.Application.Profiles
{
   public class AutoMapperProfile:Profile
    {
        #region [-Ctor-]
        public AutoMapperProfile()
        {
            CreateMap<Contract.Frameworks.Base.BaseToDoDto, Domain.Aggregations.ToDoAggregate.ToDo>().ReverseMap();
            CreateMap<Contract.Frameworks.Base.BaseBoardDto, Domain.Aggregations.BoardAggregate.Board>().ReverseMap();
        }
        #endregion

    }
}
