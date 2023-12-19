

using Solid.Core.Entities;
using Solid.Core.Repositories;
using Solid.Data;

namespace Solid.data
{
    public class RecreationRepository: IRecreationRepository
    {
        private readonly DataContext _context;
        public RecreationRepository(DataContext context)
        {
            _context = context; 
        }
        public List<Recreation> GetAllRecreation()
        {
            return _context.recreations;
        }

        public Recreation GetRecreationById(int id)
        {
            return _context.recreations.Find(re=>re.Id== id);
        }

        public Recreation PostRecreation(Recreation recreation)
        {
            recreation.Id=_context.recreations.Count()+1;
            _context.recreations.Add(recreation);
            return recreation;
        }

        public void PutRecreation(int id, Recreation recreation)
        {
            var rec = _context.recreations.Find(rec => rec.Id == id);
            rec.Number=recreation.Number;
            rec.Adress=recreation.Adress;
            rec.Price=recreation.Price;
            rec.NameOner=recreation.NameOner;
        } 
        public void DeleteRecreation(int id)
        {
            _context.recreations.Remove(_context.recreations.Find(rec => rec.Id == id));
        }
    }
}