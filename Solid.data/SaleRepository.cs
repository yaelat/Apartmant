using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class SaleRepository: ISaleRepository
    {
        public readonly DataContext _Context;
        public SaleRepository(DataContext context)
        {
            _Context = context;
        }
        public List<Sale> GetAllSale()
        {
            return _Context.sales;
        }
    }
}
