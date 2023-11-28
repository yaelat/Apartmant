using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class RentingRepository: IRentingRepository
    {
        private readonly DataContext _context;
        public RentingRepository(DataContext context)
        {
            _context = context;
        }
        public List<Renting> GetAllRenting()
        {
            return _context.rentings;
        }

    }
}
