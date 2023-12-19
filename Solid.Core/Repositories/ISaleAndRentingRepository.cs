using Solid.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Core.Repositories
{
    public interface ISaleAndRentingRepository
    {
        List<SaleAndRenting> GetAllSaleAndRenting();
        SaleAndRenting GetSaleAndRentingById(int id);
        SaleAndRenting PostSaleAndRenting(SaleAndRenting saleAndRenting);
        void DeleteSaleAndRenting(int id);
        void PutSaleAndRanting(int id,SaleAndRenting saleAndRenting);

    }
}
