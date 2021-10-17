/*************************************************************************************************************/
/*Class Name    : E_BusinessController.cs                                                                       /
/*Created By    : samer sami                                                                            */
/*Ceation Date  :                                                                            */
/******************************************************************************************************/
using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Bisnicity.Controllers
{
    public class E_BusinessController : Controller
    {
        #region Members
        private readonly DataContext dataContext;
        private readonly IHostingEnvironment hosting;
        private readonly IBisnicity<OurServices> ourservi;
        private readonly IBisnicity<Templete> templet;
        private readonly IBisnicity<Services> services;

        public E_BusinessController(DataContext data,IHostingEnvironment hosting, IBisnicity<OurServices> _ourservi, IBisnicity<Templete> _templet, IBisnicity<Services> _services)
        {
            dataContext = data;
            this.hosting = hosting;
            ourservi = _ourservi;
            templet = _templet;
            services = _services;
        }
        #endregion

        #region Methods
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {
                return RedirectToAction("Login", "SignUp");

            }
           else
           {
                var data = dataContext.CatTemp.ToList();
                
                return View(data);

           }
        }
        public IActionResult OurService(int? id)
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {

                return RedirectToAction("Login", "SignUp");
            }
            else
            {
                HttpContext.Session.SetString("CatID", Convert.ToString(id));

                
                return View();
            }
   
        }
        [HttpPost]
        //public async Task <IActionResult> OurService(OurserviceModels model)
        //{
        //    string sLogoTemp = UploadedFile(model);
        //      string sback = UploadedFilebac(model);
        //   //if (!ModelState.IsValid)
        //   // {
        //   //      TempData["messsages"] = "Please fill in all fields ";
        //   //       return View(nameof(OurService), model);
        //   // }

        //    int sesioninfo = int.Parse(HttpContext.Session.GetString("infoID"));
        //    int sessoncatid = int.Parse(HttpContext.Session.GetString("CatID"));
        //    var our = new OurServices
        //    {
        //        AbuotServ = model.AbuotServ,
        //        AboutUs = model.AboutUs,
        //        City = model.City,
        //        Country = model.Country,
        //        LinkFace = model.LinkFace,
        //        LinkInsta = model.LinkInsta,
        //        LinkTwet = model.LinkTwet,
        //        LinkWats = model.LinkWats,
        //        GoogleMapLink = model.GoogleMapLink,
        //        CompanyNo = model.CompanyNo,
        //        DomainName = model.DomainName,
        //        InfoID = sesioninfo

        //    };

        //    var temp = new Templete
        //    {
        //        BackgroundTemp = sback != string.Empty ? sback  : string.Empty,
        //        LogoTemp = sLogoTemp != string.Empty ? sLogoTemp : string.Empty,
        //        InfoID = sesioninfo,
        //        ChoesePrice = model.ChoesePrice != string.Empty ? model.ChoesePrice : string.Empty,
        //        CatTempID = sessoncatid,
        //    };

        //    if (our != null && temp != null)
        //    {
        //        ourservi.Add(our);
        //        templet.Add(temp);

        //        return RedirectToAction("AddServices", "E_Business");
        //    }
        //    else
        //    {
        //        TempData["messsages"] = "Please fill in all fields ";
        //        return View(nameof(OurService), model);
                
        //    }

        //}
      
        public IActionResult AddServices()
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {
                return RedirectToAction("Login", "SignUp");
            }
            else
            {
               
                return View();
            }

        }
        [HttpPost]
        //public IActionResult AddServices(ServicesModel smodel)
        //{
        //    string imageserv = UploadedFileSevice(smodel);
        //    if (!ModelState.IsValid)
        //    {
        //        return View(nameof(AddServices), smodel);
        //    }
            
        //    var ser = new Services
        //    {
        //        Servicename = smodel.Servicename,
        //        paragraph = smodel.paragraph,
        //        Image = imageserv != string.Empty ? imageserv : string.Empty,
        //        InfoID = int.Parse(HttpContext.Session.GetString("infoID"))

        //    };
        //    if (ser != null)
        //    {
        //        services.Add(ser);
        //        TempData["messsages"] = "Add successful";
        //        //return View(nameof(AddServices))/*;*/
        //        return RedirectToAction("AddServices", "E_Business");
        //    }
        //    else
        //    {
        //        return View();

        //    }

          
        //}
        private string UploadedFile(OurserviceModels model)
        {
            string uniqueFileName = null;

            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.File.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.File.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        private string UploadedFilebac(OurserviceModels model)
        {
            string uniqueFileName = null;

            if (model.File != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "Uploads");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.background.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.background.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        private string UploadedFileSevice(ServicesModel model)
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
    }
    #endregion
}
