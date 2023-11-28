using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Core.service;
using Solid.data;

namespace Solid.Service
{
    public class RecreationService: IRecreationService
    {
        private readonly IRecreationRepository _recreationRepository;

        public RecreationService(IRecreationRepository recreationRepository)
        {
            _recreationRepository = recreationRepository;
        }
        public List<Recreation> GetAllRecreation()
        {
            return _recreationRepository.GetAllRecreation();
        }

    }
}