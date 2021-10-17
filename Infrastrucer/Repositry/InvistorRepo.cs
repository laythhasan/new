using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class InvistorRepo : IBisnicity<Invistor>
    {
        DataContext db;

        public InvistorRepo(DataContext _db)
        {
            db = _db;
        }
        public void Add(Invistor entity)
        {
            db.Invistor.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Invistor Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Invistor> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Invistor entity)
        {
            throw new NotImplementedException();
        }
    }
}
