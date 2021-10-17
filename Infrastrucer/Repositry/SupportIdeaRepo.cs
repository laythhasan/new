using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class SupportIdeaRepo : IBisnicity<SuppourtIdea>
    {
        DataContext db;

        public SupportIdeaRepo(DataContext _db)
        {
            db = _db;
        }
        public void Add(SuppourtIdea entity)
        {
            db.SuppourtIdea.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public SuppourtIdea Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<SuppourtIdea> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, SuppourtIdea entity)
        {
            throw new NotImplementedException();
        }
    }
}
