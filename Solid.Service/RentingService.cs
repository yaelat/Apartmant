using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.service;
using Solid.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Service
{
    public class RentingService: IRentingService
    {
        public readonly IRentingRepository _rentingRepository;
        public RentingService(IRentingRepository rentingRepository)
        {
            _rentingRepository = rentingRepository; 
        }
        public List<Renting> GetAllRenting()
        {
            return _rentingRepository.GetAllRenting();
        }
    }
}
