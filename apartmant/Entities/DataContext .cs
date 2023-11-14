namespace apartmant.Entities
{

                  
    public class DataContext
    {
        public List<Recreation> recreations { get; set; }
        public List<Renting> rentings { get; set; }
        public List<Sale> sales { get; set; }


        public DataContext()
        {
            recreations = new List<Recreation>();
            rentings= new List<Renting>();
            sales = new List<Sale>();   
        }
    }
}
