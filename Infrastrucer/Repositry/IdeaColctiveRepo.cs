using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class IdeaColctiveRepo : IBisnicity<IdeaColctive>
    {
        DataContext db;

        public IdeaColctiveRepo(DataContext _db)
        {
            db = _db;
        }
        public void Add(IdeaColctive entity)
        {
            db.IdeaColctive.Add(entity);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IdeaColctive Find(int id)
        {
            throw new NotImplementedException();
        }

        public IList<IdeaColctive> List()
        {
            throw new NotImplementedException();
        }

        public void Update(int id, IdeaColctive entity)
        {
            throw new NotImplementedException();
        }
    }
}
