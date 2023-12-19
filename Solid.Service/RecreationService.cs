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

        public void DeleteRecreation(int id)
        {
            _recreationRepository.DeleteRecreation(id);
        }

        public List<Recreation> GetAllRecreation()
        {
            return _recreationRepository.GetAllRecreation();
        }

        public Recreation GetRecreationById(int id)
        {
            return _recreationRepository.GetRecreationById(id);
        }

        public Recreation PostRecreation(Recreation recreation)
        {
            return _recreationRepository.PostRecreation(recreation);
        }

        public void PutRecreation(int id, Recreation recreation)
        {
            _recreationRepository.PutRecreation(id, recreation);
        }
    }
}