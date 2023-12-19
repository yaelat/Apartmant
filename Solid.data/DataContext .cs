using Solid.Core.Entities;

namespace Solid.Data
{

                  
    public class DataContext
    {
        public List<Recreation> recreations { get; set; }
        public List<Customer> customers { get; set; }
        public List<SaleAndRenting> saleAndRenting { get; set; }


        public DataContext()
        {
            recreations = new List<Recreation>();
            customers = new List<Customer>();
            saleAndRenting = new List<SaleAndRenting>();   
        }
    }
}
