

using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Data;

namespace Solid.data
{
    public class RecreationRepository: IRecreationRepository
    {
        private readonly DataContext _context;
        public RecreationRepository(DataContext context)
        {
            _context = context; 
        }
        public List<Recreation> GetAllRecreation()
        {
            return _context.recreations;
        }
    }
}