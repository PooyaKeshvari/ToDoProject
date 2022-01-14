using System.Threading.Tasks;
using TanvirArjel.Extensions.Microsoft.DependencyInjection;
using ToDo.Domain.Aggregations.BoardAggregate;
using ToDo.Domain.Repositories;

namespace ToDo.Domain.Factories
{
    //For new Domain Side Dto for ApplicationLayer
    [ScopedService]
    public class BoardFactory
    {

        #region [-Ctor-]
        public BoardFactory(IBoardRepository boardRepository)
        {
            Repository = boardRepository;
        }
        #endregion

        #region [-Props-]
        public Repositories.IBoardRepository Repository { get; set; }
        #endregion

        #region [-Methods-]

        #region [-CreateAsync(string title)-]
        public async Task<Board> CreateAsync(string title)
        {
            var current =await Repository.FindByTitle(title);
            if (current == null)
            {
                return new Board(title);
            }
            else
            {
                return null;
            }
        }
        #endregion

        #endregion


    }
}
