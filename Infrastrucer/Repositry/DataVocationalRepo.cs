using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    
    public class DataVocationalRepo : IBisnicity<Datavocational>
    {
        DataContext db;

        public DataVocationalRepo(DataContext _db)
        {
            db = _db;
        }

        public void Add(Datavocational entity)
        {

            db.Datavocational.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Datavocational Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Datavocational> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Datavocational entity)
        {
            throw new NotImplementedException();
        }
    }
}
