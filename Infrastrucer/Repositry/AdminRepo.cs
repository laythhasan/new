using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastrucer.Repositry
{
    public class AdminRepo : IAdminLogin,AddAdmin<Admin>
    {
        DataContext db;
        public AdminRepo(DataContext _db)
        {
            db = _db;
        }

        public Admin LoginAdmin(string UserName, string Password)
        {
            var boollist = db.Admin.FirstOrDefault(a => a.UsernameAdmin == UserName && a.Password == Password);
            return boollist ?? null;
        }

        public void Add(Admin entity)
        {
            db.Admin.Add(entity);
            db.SaveChanges();
        }
    }
}
