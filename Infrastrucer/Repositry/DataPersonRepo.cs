using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class DataPersonRepo : IBisnicity<DataPerson>
    {
        DataContext db;

        public DataPersonRepo(DataContext _db)
        {
            db = _db;
        }
        public void Add(DataPerson entity)
        {
            db.DataPerson.Add(entity);db.SaveChanges();        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public DataPerson Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<DataPerson> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, DataPerson entity)
        {
            throw new NotImplementedException();
        }
    }
}
