using Solid.Core.Entities;
using Solid.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Solid.Data
{
    public class SaleAndRentingRepository: ISaleAndRentingRepository
    {
        public readonly DataContext _context;
        public SaleAndRentingRepository(DataContext context)
        {
            _context = context;
        }

        public void DeleteSaleAndRenting(int id)
        {
            _context.saleAndRenting.Remove(_context.saleAndRenting.Find(rec => rec.Id == id));
        }

        public List<SaleAndRenting> GetAllSaleAndRenting()
        {
            return _context.saleAndRenting;
        }

        public SaleAndRenting GetSaleAndRentingById(int id)
        {
            return _context.saleAndRenting.Find(s => s.Id == id);
        }

        public SaleAndRenting PostSaleAndRenting(SaleAndRenting saleAndRenting)
        {
            saleAndRenting.Id = _context.saleAndRenting.Count() + 1;
            _context.saleAndRenting.Add(saleAndRenting);
            return saleAndRenting;
        }

        public void PutSaleAndRanting(int id, SaleAndRenting saleAndRenting)
        {
            var sale=_context.saleAndRenting.Find(s => s.Id == id);
            sale.Name=saleAndRenting.Name;
        }
    }
}
