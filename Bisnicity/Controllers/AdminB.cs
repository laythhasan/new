/*************************************************************************************************************/
/*Class Name    : AdminBController.cs                                                                       /
/*Created By    : samer sami                                                                            */
/*Ceation Date  :                                                                            */
/******************************************************************************************************/
using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;


namespace Bisnicity.Controllers
{

    public class AdminB : Controller
    {
        #region Members
        private readonly IAdminLogin _loginAdmin;
        private readonly AddAdmin<Admin>addAdmin;
        private readonly IBisnicity<Info> bisnicity;
        private readonly IBisnicity<OurServices> _ourservice;
        //private readonly IBisnicity<Templete> _temp;
        private readonly IBisnicity<Services> addservice;
        private readonly IBisnicity<CatTemp> _category;
        private readonly IBisnicity<jobVacancy> job;
        private readonly IHostingEnvironment hosting;
        private readonly RoleManager<IdentityRole> roleManger;
       
        public AdminB(IAdminLogin loginAdmin, IHostingEnvironment hosting, IBisnicity<Info> obisnicity,
          IBisnicity<OurServices> ourservice, /*IBisnicity<Templete> temp,*/ IBisnicity<Services> Addservice,
          IBisnicity<CatTemp> category, AddAdmin<Admin> _addAdmin, IBisnicity<jobVacancy> _job, RoleManager<IdentityRole> _roleManger)
        {
            _loginAdmin = loginAdmin;
            bisnicity = obisnicity;
            _ourservice = ourservice;
            //_temp = temp;
            addservice = Addservice;
            _category = category;
            this.hosting = hosting;
            addAdmin = _addAdmin;
            job = _job;
            roleManger = _roleManger;

        }
        #endregion

        #region CreateRole

        public IActionResult CreateRole()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> CreateRole(ProjectRole role)
        {
            var roleExist = await roleManger.RoleExistsAsync(role.RoleName);
            if(!roleExist)
            {
                var result = await roleManger.CreateAsync(new IdentityRole(role.RoleName));
                return RedirectToAction("AdminPanel", "AdminB", TempData["message"]="Add sucssfuly");
            } 
            
                return View(nameof(CreateRole), role);
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AdminPanel()
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;

            return View();
        }

        [HttpPost]
        public IActionResult Index(Admin admin)
        {
            var IsLogger = this._loginAdmin.LoginAdmin(admin.UsernameAdmin, admin.Password);
            if (IsLogger != null)
            {
                HttpContext.Session.SetString("AdminID", Convert.ToString(IsLogger.AdminID));
                HttpContext.Session.SetString("UsernameAdmin", Convert.ToString(IsLogger.UsernameAdmin));

                return RedirectToAction("AdminPanel", "AdminB");
            }

            return View();
        }

        public IActionResult HomeAdmin()
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            var iteminfo = this.bisnicity.List();
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;

            return View(iteminfo);
        }
        public IActionResult Editinfo(int id)
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var editinfo = this.bisnicity.Find(id);
            return View(editinfo);
        }
        [HttpPost]
        public IActionResult Editinfo(int id, Info info)
        {
            try
            {
                bisnicity.Update(id, info);
                return RedirectToAction(nameof(HomeAdmin));
            }
            catch
            {
                return View();

            }

        }
        public IActionResult Deleteinfo(int id)
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var deleteinfo = this.bisnicity.Find(id);
            return View(deleteinfo);
        }
        [HttpPost]
        public IActionResult Deleteinfo(int id,Info info)
        {
           bisnicity.Delete(id);
            return RedirectToAction(nameof(HomeAdmin));
        }
        public IActionResult OurServiceAdmin()
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var itemour = this._ourservice.List();

            return View(itemour);
        }
        public IActionResult Editourserv(int id)
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var editourser = this._ourservice.Find(id);

            return View(editourser);
        }
        [HttpPost]
        public IActionResult Editourserv(int id , OurServices ourServices)
        {
            try
            {
                _ourservice.Update(id, ourServices);
                return RedirectToAction(nameof(OurServiceAdmin));
            }
            catch
            {
                return View();

            }
        }
        public IActionResult Deleteourserv(int id)
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var deleteourserv = this._ourservice.Find(id);
            return View(deleteourserv);
        }
        [HttpPost]
        public IActionResult Deleteourserv(int id,OurServices ourServices)
        {
            _ourservice.Delete(id);
            return RedirectToAction(nameof(OurServiceAdmin));
        }

        //public IActionResult Templete()
        //{
        //    if (HttpContext.Session.GetString("AdminID") == null)
        //    {
        //        return RedirectToAction("Index", "AdminB");

        //    }
        //    string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
        //    TempData["sessionad"] = sessionadmin;
        //    var itemtemp = this._temp.List();
        //    return View(itemtemp);
        //}
        //public IActionResult EditTemp(int id)
        //{
        //    if (HttpContext.Session.GetString("AdminID") == null)
        //    {
        //        return RedirectToAction("Index", "AdminB");

        //    }
        //    string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
        //    TempData["sessionad"] = sessionadmin;

           
        //    var edittemp = this._temp.Find(id);
        //    var edittempviewmodel = new tempviewmodel
        //    {
        //        tempid =edittemp.TempleteID,
        //        infoid=edittemp.InfoID,
        //        catid=edittemp.CatTempID,
        //        choseprice=edittemp.ChoesePrice
        //    };

        //    return View(edittempviewmodel);
        //}

        [HttpPost]
        //public IActionResult EditTemp(int id , tempviewmodel temp)
        //{
        //    string imageserv = UploadedFiletempBAC(temp);
        //    string imageservLOGO = UploadedFiletempLOGO(temp);

        //    var tempdata = new Templete
        //    {
        //        TempleteID=temp.tempid,
        //        InfoID=temp.infoid,
        //        CatTempID=temp.catid,
        //        LogoTemp = imageservLOGO != string.Empty ? imageservLOGO : string.Empty,
        //        BackgroundTemp = imageserv != string.Empty ? imageserv : string.Empty,
        //        ChoesePrice=temp.choseprice
        //    };
        //    try
        //    {
        //        _temp.Update(id, tempdata);
        //        return RedirectToAction(nameof(Templete));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
           
        //}
        private string UploadedFiletempBAC(tempviewmodel model)
        {
            string uniqueFileName = null;

            if (model.backgroun != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.backgroun.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.backgroun.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        private string UploadedFiletempLOGO(tempviewmodel model)
        {
            string uniqueFileName = null;

            if (model.logo != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.logo.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.logo.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        //public IActionResult Deletetemp(int id)
        // {
        //    if (HttpContext.Session.GetString("AdminID") == null)
        //    {
        //        return RedirectToAction("Index", "AdminB");

        //    }
        //    string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
        //    TempData["sessionad"] = sessionadmin;
        //    var deletetemp = this._temp.Find(id);
        //    return View(deletetemp);
        // }
        [HttpPost]
        //public IActionResult Deletetemp(int id , Templete temp)
        //{
        //    try
        //    {
        //        _temp.Delete(id);
        //        return RedirectToAction(nameof(Templete));
        //    }
        //    catch
        //    {
        //        return View();

        //    }
        //}
        public IActionResult Service()
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var service = this.addservice.List();
            return View(service);
        }
        //public IActionResult Editser(int id)
        //{
        //    if (HttpContext.Session.GetString("AdminID") == null)
        //    {
        //        return RedirectToAction("Index", "AdminB");

        //    }
        //    string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
        //    TempData["sessionad"] = sessionadmin;

        //    var editserv = this.addservice.Find(id);

        //    var editservviewmodel = new serviceviewmodel
        //    {
        //        ServiceID=editserv.ServicesID,
        //        Servicename=editserv.Servicename,
        //        paragraph=editserv.paragraph,
        //        infoID=editserv.InfoID
                
                
        //    };
        //    return View(editservviewmodel);
        //}
        [HttpPost]
        //public IActionResult Editser(int id ,serviceviewmodel services)
        //{
        //    string imageserv = UploadedFile(services);

        //    var serv = new Services
        //    {
        //        ServicesID=services.ServiceID,
        //        Servicename=services.Servicename,
        //        paragraph=services.paragraph,
        //        Image = imageserv != string.Empty ? imageserv : string.Empty,
        //        InfoID=services.infoID
        //    };
        //    try
        //    {
        //        addservice.Update(id, serv);
        //        return RedirectToAction(nameof(Service));
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
        private string UploadedFile(serviceviewmodel model)
        {
            string uniqueFileName = null;

            if (model.Image != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        public IActionResult Deleteserv(int id)
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var deleteserv = this.addservice.Find(id);

            return View(deleteserv);
        }

        [HttpPost]
        public IActionResult Deleteserv(int id,Services services)
        {
            try
            {
                addservice.Delete(id);
                return RedirectToAction(nameof(Service));
            }
            catch
            {
                return View();

            }
        }
        public IActionResult CatTemp()
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var cat = this._category.List();
            return View(cat);
        }
          public IActionResult Editcat(int id)
          {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");
            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var editcat = this._category.Find(id);

            var editcatviewmodel = new catviewmodel
            {
                Name=editcat.Name,
                catid=editcat.CatTempID,
                url=editcat.url,
                OnMonth=editcat.OnMonth,
                SixMointh=editcat.SixMointh,
                OnYears=editcat.OnYears
            };
            return View(editcatviewmodel);
           }
        [HttpPost]
        public IActionResult Editcat(int id, catviewmodel catTemp)
        {
            string imageserv = UploadedFileEditcat(catTemp);

            var editcat = new CatTemp
            {
                CatTempID=catTemp.catid,
                Image= imageserv != string.Empty ? imageserv : string.Empty,
                Name=catTemp.Name,
                url=catTemp.url,
                OnMonth=catTemp.OnMonth,
                SixMointh=catTemp.SixMointh,
                OnYears=catTemp.OnYears

            };

            try
            {
                _category.Update(id, editcat);
                return RedirectToAction(nameof(CatTemp));
            }
            catch
            {
                return View();
            }
        }
        private string UploadedFileEditcat(catviewmodel model)
        {
            string uniqueFileName = null;

            if (model.image != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "UploadsCategory");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult Deletecat(int id)
        {
            if (HttpContext.Session.GetString("AdminID") == null)
            {
                return RedirectToAction("Index", "AdminB");

            }
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            var deletecat = this._category.Find(id);

            return View(deletecat);
        }
        [HttpPost]
        public IActionResult Deletecat(int id , CatTemp catTemp)
        {
            try
            {
                _category.Delete(id);
                return RedirectToAction(nameof(CatTemp));
            }
            catch
            {
                return View();

            }

        }

        public IActionResult CreateCat()
        {
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            return View();
        }
        [HttpPost]
        public IActionResult CreateCat(catviewmodel catTemp)
        {
            string imagecat = UploadedFileCat(catTemp);

            var cat = new CatTemp
            {
                CatTempID=catTemp.catid,
                Image = imagecat != string.Empty ? imagecat : string.Empty,
                url=catTemp.url,
                Name=catTemp.Name,
                OnMonth=catTemp.OnMonth,
                SixMointh=catTemp.SixMointh,
                OnYears=catTemp.OnYears

            };
            if (cat != null)
            {
                this._category.Add(cat);
                return RedirectToAction(nameof(CatTemp));

            }
            return View();
        }

        private string UploadedFileCat(catviewmodel model)
        {
            string uniqueFileName = null;

            if (model.image != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "UploadsCategory");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        public IActionResult Addadmin()
        {
            string sessionadmin = HttpContext.Session.GetString("UsernameAdmin");
            TempData["sessionad"] = sessionadmin;
            return View();
        }

        [HttpPost]
        public IActionResult Addadmin(Admin admin)
        {
            if(admin !=null)
            {
                this.addAdmin.Add(admin);
                return RedirectToAction(nameof(AdminPanel));

            }
            return View();
        }
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "AdminB");
        }

        public IActionResult AddJobAdmin()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddJobAdmin(jobVacancy model)
        {
            if(!ModelState.IsValid)
            {
                return View(nameof(AddJobAdmin), model);
            }
            else
            {
               
                job.Add(model);
                return RedirectToAction("AddJobAdmin", "AdminB");
               
            }
            
        }
    }
}

