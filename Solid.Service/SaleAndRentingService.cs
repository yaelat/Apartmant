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
    public class SaleAndRentingService: ISaleAndRentingService
    {
        public readonly ISaleAndRentingRepository _saleAndRentingRepository;
        public SaleAndRentingService(ISaleAndRentingRepository saleAndrentingRepository)
        {
            _saleAndRentingRepository = saleAndrentingRepository;
        }

        public void DeleteSaleAndRenting(int id)
        {
            _saleAndRentingRepository.DeleteSaleAndRenting(id);
        }

        public List<SaleAndRenting> GetAllSaleAndRenting()
        {
            return _saleAndRentingRepository.GetAllSaleAndRenting();
        }

        public SaleAndRenting GetSaleAndRentingById(int id)
        {
            return _saleAndRentingRepository.GetSaleAndRentingById(id);
        }

        public SaleAndRenting PostSaleAndRenting(SaleAndRenting saleAndRenting)
        {
            return _saleAndRentingRepository.PostSaleAndRenting(saleAndRenting);
        }

        public void PutSaleAndRanting(int id, SaleAndRenting saleAndRenting)
        {
            _saleAndRentingRepository.PutSaleAndRanting(id, saleAndRenting);
        }
    }
}
