using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class IdeaRepo : IBisnicity<Idea>
    {

        DataContext db;

        public IdeaRepo(DataContext _db)
        {
            db = _db;
        }
        public void Add(Idea entity)
        {
            db.Idea.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Idea Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Idea> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, Idea entity)
        {
            throw new NotImplementedException();
        }
    }
}
