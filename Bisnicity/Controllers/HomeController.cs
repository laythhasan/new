/*************************************************************************************************************/
/*Class Name    : HomeController.cs                                                                       /
/*Created By    : samer sami                                                                            */
/*Ceation Date  :                                                                            */
/******************************************************************************************************/
using Bisnicity.Helper;
using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer;
using Infrastrucer.Models;
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
    public class HomeController : Controller
    {
        #region Members

        
        private readonly DataContext dataContext;
        private readonly IBisnicity<Info> infodata;
        private readonly IBisnicity<OurServices> ourservicedata;
        private readonly IBisnicity<jobVacancy> addjob;
        private readonly IBisnicity<Person> getperson;
        private readonly IBisnicity<DetailsPerson> getdetailperson;
        private readonly IBisnicity<PostCompany> addpost;
        private readonly IBisnicity<Idea> addidea;
        private readonly IBisnicity<SuppourtIdea> addsup;
        private readonly IBisnicity<TypeCompany> typecomp;
        private readonly IBisnicity<Targetsector> target;
        private readonly IBisnicity<yourstatus> status;
        private readonly IBisnicity<CareerPath> career;
        private readonly IBisnicity<Gender> gender;
        private readonly IBisnicity<Datavocational> addvocational ;
        private readonly IBisnicity<ContactUs> contactus;
        private readonly IBisnicity<Invistor> invistor;
        private readonly IBisnicity<IdeaColctive> addideacolctive;
        private readonly IBisnicity<volunteer> ovolunteer;
        private readonly IBisnicity<ApplayJob> applayjob;
        private readonly IHostingEnvironment hosting;
      
        public HomeController(IBisnicity<Info> oinfodata, IBisnicity<OurServices> _ourservicedata, IBisnicity<jobVacancy> oaddjob, IBisnicity<Person> _getperson,
            IBisnicity<DetailsPerson> _getdetailperson, DataContext _dataContext, IBisnicity<PostCompany> _addpost,
            IHostingEnvironment hosting, IBisnicity<Idea> _addidea, IBisnicity<TypeCompany> _typecomp, IBisnicity<Targetsector> _target,  
            IBisnicity<SuppourtIdea> _addsup, IBisnicity<yourstatus> _status, IBisnicity<CareerPath> _career, IBisnicity<Gender> _gender,
            IBisnicity<Datavocational> _addvocational , IBisnicity<ContactUs> _contactus, IBisnicity<Invistor> _addinvistor, IBisnicity<IdeaColctive> _addideacolctive,
            IBisnicity<volunteer> _volunteer, IBisnicity<ApplayJob> _applayjob)
        {


            infodata = oinfodata;
            ourservicedata = _ourservicedata;
            addjob = oaddjob;
            getperson = _getperson;
            getdetailperson = _getdetailperson;
            dataContext = _dataContext;
            addpost = _addpost;
            addidea = _addidea;
            this.hosting = hosting;
            typecomp = _typecomp;
            target =_target;
            addsup = _addsup;
            status = _status;
            career = _career;
            gender = _gender;
            addvocational = _addvocational;
            contactus = _contactus;
           invistor = _addinvistor;
            addideacolctive = _addideacolctive;
            ovolunteer = _volunteer;
            applayjob = _applayjob;

        }
        #endregion
        #region Methods

       
        public IActionResult Index1()
        {

            return View();
        }
        public IActionResult IndexAR()
        {
            return View();
            
        }
        public IActionResult BuntEN()
        {
            return View();

        }
        public IActionResult BuntAR()
        {
            return View();

        }

        public IActionResult itAR()
        {
            return View();

        }
         public IActionResult BlogsEN()
        {
            var listpost = addpost.List();

         
            return View(listpost);
        }

        public IActionResult BlogsAR()
        {
            return View();
        }
        public IActionResult InvestorAR()
        {
            var signview = new InvistorViewModel
            {
                Targetsectors = FillselectTarg()
            };
            return View(signview);
        }

        [HttpPost]
        //public IActionResult InvestorAR(InvistorViewModel model)
        //{
        //    if (model.targetsecid == -1)
        //    {

        //        var osignview = new InvistorViewModel
        //        {
        //            Targetsectors = FillselectTarg()
        //        };
        //        TempData["messsageserro"] = " يرجى تحديد المسار المتسهدف المناسب ";
        //        return View(osignview);
        //    }

        //    var targetfind = target.Find(model.targetsecid);
        //    var idtarget = targetfind.TargetsectorID;

        //    var addinvistor = new Invistor
        //    {
        //        FirstName = model.FirstName,
        //        LastName = model.LastName,
        //        Email = model.Email,
        //        PhoneNo = model.PhoneNo,
        //        CompanyName = model.CompanyName,
        //        TargetsectorID = idtarget
        //    };
        //    invistor.Add(addinvistor);
        //    TempData["messsages"] = "تمت الإضافة بنجاح ";
        //    return RedirectToAction("InvestorAR", "Home");
        //}
        public IActionResult InvestorEN()
        {
            var signview = new InvistorViewModel
            {
                Targetsectors = FillselectTarg()
            };
            return View(signview);
        }
        [HttpPost]
        //public IActionResult InvestorEN(InvistorViewModel model)
        //{
        //    if (model.targetsecid == -1)
        //    {
                
        //        var osignview = new InvistorViewModel
        //        {
        //            Targetsectors= FillselectTarg()
        //        };
        //        TempData["messsageserro"] = "Please Choese the target sector ";
        //        return View(osignview);
        //    }
        //    var targetfind = target.Find(model.targetsecid);
        //    var idtarget = targetfind.TargetsectorID;

        //    var addinvistor = new Invistor
        //    {
        //        FirstName=model.FirstName,
        //        LastName=model.LastName,
        //        Email=model.Email,
        //        PhoneNo=model.PhoneNo,
        //        CompanyName=model.CompanyName,
        //        TargetsectorID=idtarget
        //    };
        //    invistor.Add(addinvistor);
        //    TempData["messsages"] = "add sussfuly ";
        //    return RedirectToAction("InvestorEN", "Home");
        //}
        public IActionResult TraAndJobEn()
        {
            return View();
        }

        public IActionResult TraAndJobAR()
        {
            return View();
        }

        public IActionResult BenefitsOfTranning()
        {
            return View();
        }

        public IActionResult BenefitsOfTranningAR()
        {
            return View();
        }

       public IActionResult ShowTran()
        {
            return View();
        }
        public IActionResult ShowTranAR()
        {
            return View();
        }

        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index1", "Home");
        }

        public IActionResult LogoutPerson()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index1", "Home");
        }

        public IActionResult AboutUs()
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("AboutUs1", "Home");
            }   

        }

        public  IActionResult IdeashowEn()
        {
            return View();
        }

        public IActionResult IdeashowAR()
        {
            return View();
        }


        public IActionResult AddIdea()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddIdea(AddIdeaViewModel model)
        {
            string cv = UploadedFileidea(model);

            if (!ModelState.IsValid)
            {
                return View();
            }
            var addideamodel = new Idea
            {
                ideaname=model.ideaname,
                descreption=model.descreption,
                Email=model.Email,
                Name=model.Name,
                phoneno=model.phoneno,
                Fileidea = cv != string.Empty ? cv : string.Empty

            };

            addidea.Add(addideamodel);
            TempData["Message"] = "Add Idea Succsfuly";
            
            return RedirectToAction("AddIdea", "Home");
        }

        public IActionResult AddIdeacolctive()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddIdeacolctive(AddIdeaViewModel model)
        {
            string cv = string.Empty;

            if (!ModelState.IsValid)
            {
                return View();
            }
            if(model.Fileidea !=null)
            {
                cv = UploadedFileidea(model);
            }
            var addideamodel = new IdeaColctive
            {
                ideaname = model.ideaname,
                descreption = model.descreption,
                Email = model.Email,
                GroupName = model.Name,
                phoneno = model.phoneno,
                Fileidea = cv != string.Empty ? cv : string.Empty

            };

            addideacolctive.Add(addideamodel);
            TempData["Message"] = "Add Idea Succsfuly";

            return RedirectToAction("AddIdeacolctive", "Home");
        }
        public IActionResult AddIdeaAR()
        {
            return View();
        }

        [HttpPost]
      public IActionResult AddIdeaAR(AddIdeaViewModel model)
        {
            string cv = string.Empty;

            if (!ModelState.IsValid)
            {
                return View();
            }

            if (model.Fileidea != null)
            {
                cv = UploadedFileidea(model);
            }
            var addideamodel = new Idea
            {
                ideaname = model.ideaname,
                descreption = model.descreption,
                Email = model.Email,
                Name = model.Name,
                phoneno = model.phoneno,
                Fileidea = cv != string.Empty ? cv : string.Empty

            };

            addidea.Add(addideamodel);
            TempData["Message"] = "Add Idea Succsfuly";

            return RedirectToAction("AddIdeaAR", "Home");
        }

       public IActionResult AddIdeacolctiveAR()
       {
            return View();
       }
        [HttpPost]
        public IActionResult AddIdeacolctiveAR(AddIdeaViewModel model)
        {
            string cv = UploadedFileidea(model);

            if (!ModelState.IsValid)
            {
                return View();
            }
            var addideamodel = new IdeaColctive
            {
                ideaname = model.ideaname,
                descreption = model.descreption,
                Email = model.Email,
                GroupName = model.Name,
                phoneno = model.phoneno,
                Fileidea = cv != string.Empty ? cv : string.Empty

            };

            addideacolctive.Add(addideamodel);
            TempData["Message"] = "Add Idea Succsfuly";

            return RedirectToAction("AddIdeacolctiveAR", "Home");
        }

        private string UploadedFileidea(AddIdeaViewModel model)
        {
            String FileExt = Path.GetExtension(model.Fileidea.FileName).ToUpper();
            string uniqueFileName = null;
            if (FileExt == ".PDF")
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "UploadsFileIdea");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Fileidea.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Fileidea.CopyTo(fileStream);
                }
            }
            return uniqueFileName;

        }
        public IActionResult SupportIdea()
        {
            var signview = new SupportIdeaViewModel
            {
              
                TypeCompanys = fillselect(),
                Targetsectors = FillselectTarg()
            };
            return View(signview);
        }
        [HttpPost]
        //public IActionResult SupportIdea(SupportIdeaViewModel model)
        //{
        //    if (model.typecompid == -1 && model.targetsecid == -1)
        //    {
                
        //        var osignview = new SupportIdeaViewModel
        //        {
        //            TypeCompanys = fillselect(),
        //            Targetsectors = FillselectTarg()
        //        };
        //        TempData["messsages"] = "please chosee Target sector and TypeCompany ";
        //        return View(osignview);

        //    }
        //    string recod = string.Empty;
        //    string licence = string.Empty;
        //    string crt = string.Empty;
        //    var typefind = typecomp.Find(model.typecompid);
        //    int typecom = typefind.TypeCompanyID;
        //    var targetfind = target.Find(model.targetsecid);
        //    var idtarget = targetfind.TargetsectorID;
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }

        //    if(model.Filerecord !=null   )
        //    {
        //         recod = UploadedFile1(model);
        //    }
        //    if (model.Filelicense != null)
        //    {
        //        licence = UploadedFile2(model);

        //    }
        //    if (model.Filecrt != null)
        //    {
        //        crt = UploadedFile3(model);

        //    }
        //    var addsupport = new SuppourtIdea
        //    {
        //        FirstName=model.FirstName,
        //        Email=model.Email,
        //        CompanyName=model.CompanyName,
        //        LastName=model.LastName,
        //        PhoneNo=model.PhoneNo,
        //        TargetsectorID= idtarget,
        //        TypeCompanyID= typecom,
        //        Commercialrecord = recod != string.Empty ? recod : string.Empty,
        //        CertificateofRegistration  = crt != string.Empty ? crt : string.Empty,
        //        Careerslicense = licence != string.Empty ? licence : string.Empty
        //    };
        //    addsup.Add(addsupport);
        //    TempData["Message"] = "Add Support Idea Succsfuly";
        //    return RedirectToAction("IdeashowEn", "Home");
        //}


        public IActionResult SupportIdeaAR()
        {
            var signview = new SupportIdeaViewModel
            {

                TypeCompanys = fillselect(),
                Targetsectors = FillselectTarg()
            };
            return View(signview);
        }

        [HttpPost]
        //public IActionResult SupportIdeaAR(SupportIdeaViewModel model)
        //{
        //    if (model.typecompid == -1 && model.targetsecid == -1)
        //    {
               
        //        var osignview = new SupportIdeaViewModel
        //        {
        //            TypeCompanys = fillselect(),
        //            Targetsectors = FillselectTarg()
        //        };
        //        TempData["messsages"] = "please chosee Target sector and TypeCompany ";
        //        return View(osignview);

        //    }
        //    string recod = string.Empty;
        //    string licence = string.Empty;
        //    string crt = string.Empty;
        //    var typefind = typecomp.Find(model.typecompid);
        //    int typecom = typefind.TypeCompanyID;
        //    var targetfind = target.Find(model.targetsecid);
        //    var idtarget = targetfind.TargetsectorID;
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }


        //    if (model.Filerecord != null)
        //    {
        //        recod = UploadedFile1(model);
        //    }
        //    if (model.Filelicense != null)
        //    {
        //        licence = UploadedFile2(model);

        //    }
        //    if (model.Filecrt != null)
        //    {
        //        crt = UploadedFile3(model);

        //    }
        //    //var addsupport = new SuppourtIdea
        //    //{
        //    //    FirstName = model.FirstName,
        //    //    Email = model.Email,
        //    //    CompanyName = model.CompanyName,
        //    //    LastName = model.LastName,
        //    //    PhoneNo = model.PhoneNo,
        //    //    TargetsectorID = idtarget,
        //    //    TypeCompanyID = typecom,
        //    //    Commercialrecord = recod != string.Empty ? recod : string.Empty,
        //    //    CertificateofRegistration = crt != string.Empty ? crt : string.Empty,
        //    //    Careerslicense = licence != string.Empty ? licence : string.Empty
        //    //};
        //    //addsup.Add(addsupport);
        //    //TempData["Message"] = "Add Support Idea Succsfuly";
        //    //return RedirectToAction("IdeashowAR", "Home");
        //}

      
        private string UploadedFile1(SupportIdeaViewModel model)
        {
            String FileExt = Path.GetExtension(model.Filerecord.FileName).ToUpper();
            string uniqueFileName = null;
            if (FileExt == ".PDF")
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "UploadsCommercialrecord");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Filerecord.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Filerecord.CopyTo(fileStream);
                }
            }
            return uniqueFileName;

        }
        private string UploadedFile2(SupportIdeaViewModel model)
        {
            String FileExt = Path.GetExtension(model.Filelicense.FileName).ToUpper();
            string uniqueFileName = null;
            if (FileExt == ".PDF")
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "UploadsCareerslicense");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Filelicense.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Filelicense.CopyTo(fileStream);
                }
            }
            return uniqueFileName;

        }

        private string UploadedFile3(SupportIdeaViewModel model)
        {
            String FileExt = Path.GetExtension(model.Filecrt.FileName).ToUpper();
            string uniqueFileName = null;
            if (FileExt == ".PDF")
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "UploadsCertificateofRegistration");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Filecrt.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.Filecrt.CopyTo(fileStream);
                }
            }
            return uniqueFileName;

        }


        public IActionResult VocationalAR()
        {
            return View();
        }

        public IActionResult AddVocationalAR()
        {
            var signview = new DataVocationalViewModel
            {

                CareerPaths = fillselectcareer(),
                yourstatuses = fillselectstatus(),
                Genders=fillselectgender()
            };
            return View(signview);
        }

        [HttpPost]
        public IActionResult AddVocationalAR(DataVocationalViewModel model)
        {
            if (model.carereid == -1 && model.genderID == -1 && model.statusid == -1)
            {
                
                var osignview = new DataVocationalViewModel
                {
                    CareerPaths = fillselectcareer(),
                    yourstatuses = fillselectstatus(),
                    Genders = fillselectgender()
                };
                TempData["messsages"] = "please chosee ";
                return View(osignview);
            }

            var findcareer = career.Find(model.carereid);
            int careerid = findcareer.CareerPathID;

            var findstsatus = status.Find(model.statusid);
            int idstatus = findstsatus.yourstatusID;

            var findgender = gender.Find(model.genderID);
            int idgender = findgender.GenderID;

            var addvaco = new Datavocational
            {
                Name=model.Name,
                Email=model.Email,
                phoneeNo=model.phoneeNo,
                DateOfBirth=model.DateOfBirth,
                CareerPathID=careerid,
                GenderID=idgender,
                yourstatusID=idstatus
            };

            addvocational.Add(addvaco);
            TempData["message"] = "Sucssfuly";

            return RedirectToAction("VocationalAR", "Home");
        }

        public IActionResult VocationalEn()
        {
            return View();
        }

        public IActionResult volunteer()
        {
            var signview = new volunteerViewModel
            {
                Genders = fillselectgender()
            };
            return View(signview);
        }

        [HttpPost]
        public IActionResult volunteer(volunteerViewModel model)
        {
            if (model.genderID == -1)
            {
               
                var osignview = new volunteerViewModel
                {
                    Genders = fillselectgender()
                };
                TempData["messsages"] = "please chosee gender ";
                return View(osignview);
            }
            var findgender = gender.Find(model.genderID);
            int idgender = findgender.GenderID;
            var addovolunteer = new volunteer
            {
                Name=model.Name,
                NationalID=model.NationalID,
                Major=model.Major,
                GenderID=idgender,
                BirthDay=model.BirthDay,
                PhoneNo=model.PhoneNo,
                Email=model.Email,
                Address=model.Address,
                City=model.City,
                Descrption=model.Descrption
            };
            ovolunteer.Add(addovolunteer);
            TempData["message"] = "Sucssfuly";
            return RedirectToAction("volunteer", "Home");
        }
        public IActionResult volunteerAR()
        {
            var signview = new volunteerViewModel
            {
                Genders = fillselectgender()
            };
            return View(signview);
        }

        [HttpPost]
        public IActionResult volunteerAR(volunteerViewModel model)
        {
            if (model.genderID == -1)
            {

                var osignview = new volunteerViewModel
                {
                    Genders = fillselectgender()
                };
                TempData["messsages"] = "please chosee gender ";
                return View(osignview);
            }
            var findgender = gender.Find(model.genderID);
            int idgender = findgender.GenderID;
            var addovolunteer = new volunteer
            {
                Name = model.Name,
                NationalID = model.NationalID,
                Major = model.Major,
                GenderID = idgender,
                BirthDay = model.BirthDay,
                PhoneNo = model.PhoneNo,
                Email = model.Email,
                Address = model.Address,
                City = model.City,
                Descrption = model.Descrption
            };
            ovolunteer.Add(addovolunteer);
            TempData["message"] = "Sucssfuly";
            return RedirectToAction("volunteerAR", "Home");
        }

        public IActionResult TranningEN()
        {
            return View();
        }

        public IActionResult TranningAR()
        {
            return View();
        }
        public IActionResult AboutUsAR()
        {
            return View();
        }

        public IActionResult Software()
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Softwaret", "Home");

            }
        }

        public IActionResult Hardware()
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Hardwaret", "Home");

            }
        }

        public IActionResult ITsolution()
        {
            if (HttpContext.Session.GetString("infoID") == null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("ITsolutiont", "Home");

            }
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        [HttpPost]
        public IActionResult ContactUs(ContactUs model)
        {
            if(!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                contactus.Add(model);
                return RedirectToAction("ContactUs","Home", TempData["message"] = "Add Succ");
            }
          
        }

        public IActionResult ContactUsAR()
        {
            return View();
        }
        [HttpPost]
        public IActionResult ContactUsAR(ContactUs model)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            else
            {
                contactus.Add(model);
                return RedirectToAction("ContactUsAR", "Home", TempData["message"] = "تم الارسال بنجاح");
            }
        }


        //public IActionResult EditProfile()
        //{
        //    var objComplex = HttpContext.Session.GetObject<ApplicationUser>("UserInfo");

        //    if (HttpContext.Session.GetString("infoID") == null)
        //    {
        //        return RedirectToAction("Login", "SignUp");
        //    }
        //    else
        //    {
        //        int xx = int.Parse(HttpContext.Session.GetString("infoID"));
        //        var listinfo = infodata.Find(xx);


        //        var modelinfo = new SiginUpViewModel
        //        {
        //            InfoID = listinfo.InfoID,

        //            FirstName = listinfo.FirstName,
        //            LastName = listinfo.LastName,
        //            Linklinkedin = listinfo.Linklinkedin,
        //            Email = listinfo.Email,
        //            Password = listinfo.Password,
        //            CompanyName = listinfo.CompanyName,
        //            PhoneNo = listinfo.PhoneNo,
        //            pathimage = listinfo.ImageProfile


        //        };
        //        return View(modelinfo);
        //    }

        //}

        public IActionResult indexshowcomp()
        {
            return View();
        }

        //public IActionResult EditprofileComp()
        //{
        //    if (HttpContext.Session.GetString("infoID") == null)
        //    {
        //        return RedirectToAction("Login", "SignUp");
        //    }
        //    else
        //    {
        //        int xx = int.Parse(HttpContext.Session.GetString("infoID"));
        //        var listinfo = infodata.Find(xx);


        //        var modelinfo = new SiginUpViewModel
        //        {
        //            InfoID = listinfo.InfoID,
        //            FirstName = listinfo.FirstName,
        //            LastName = listinfo.LastName,
        //            Linklinkedin = listinfo.Linklinkedin,
        //            Email = listinfo.Email,
        //            Password = listinfo.Password,
        //            CompanyName = listinfo.CompanyName,
        //            PhoneNo = listinfo.PhoneNo,
        //            pathimage = listinfo.ImageProfile,
        //            CreatedAt = listinfo.CreatedAt
        //        };
        //        return View(modelinfo);
        //    }
        //}

        [HttpPost]
        //public IActionResult EditprofileComp(SiginUpViewModel model)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    var editinfo = new Info
        //    {
        //        InfoID = model.InfoID,
        //        FirstName = model.FirstName,
        //        LastName = model.LastName,
        //        Email = model.Email,
        //        Password = model.Password,
        //        Linklinkedin = model.Linklinkedin,
        //        PhoneNo = model.PhoneNo,
        //        CompanyName = model.CompanyName,
        //        ImageProfile = model.pathimage,
        //        CreatedAt = model.CreatedAt
        //    };
        //    int xx = int.Parse(HttpContext.Session.GetString("infoID"));
        //    if(editinfo !=null)
        //    {
        //        infodata.Update(xx, editinfo);
        //        TempData["qqq"] = "Edit Successfuly";
        //        ("EditprofileComp", "Home");
        //    }
        //    else
        //    {
        //        return View();
        //    }
            
        //}

        public IActionResult AddJob()
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
        //public IActionResult AddJob(jobVacancy job)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return View(nameof(AddJob), job);
        //    }
        //    int xx = int.Parse(HttpContext.Session.GetString("infoID"));
        //    var addjobs = new jobVacancy
        //    {
        //        JobType = job.JobType,
        //        JobName = job.JobName,
        //        Experience = job.Experience,
        //        Requirements = job.Requirements,
        //        Address = job.Address,
        //        Salary = job.Salary,
        //        InfoID = xx,
        //        Email=job.Email,
        //        PhoneNo=job.PhoneNo,
        //        CompanyName=job.CompanyName,
        //        LinkkedIn=job.LinkkedIn
        //    };
        //    if (addjobs != null)
        //    {
        //        addjob.Add(addjobs);
        //        TempData["messsages"] = "Add Job is successful";
        //        return RedirectToAction("AddJob", "Home");
        //    }
        //    return View();

        //}

        [HttpPost]
        //public IActionResult AddPost(SiginUpViewModel model)
        //{
        //    string imagePost = string.Empty;
        //    if(model.postimage !=null)
        //    {
        //        imagePost = UploadedFile(model);
        //    }
        //    var addpostdata = new PostCompany
        //    {
        //        DetailsPost=model.detailspost,
        //        ImagePost = imagePost != string.Empty ? imagePost : string.Empty,
        //        InfoID = int.Parse(HttpContext.Session.GetString("infoID")),
        //        TitelePost=model.Tittelpost

        //    };
        //    if (addpostdata != null)
        //    {
        //        addpost.Add(addpostdata);
        //        TempData["messsages"] = "Add successful";
        //    }
        //    return RedirectToAction("EditProfile","Home", TempData["messsages"] = "Add Post Successful");

            

        //}

        //public IActionResult MyPost()
        //{
        //    int session = int.Parse(HttpContext.Session.GetString("infoID"));
        //    var listpost = dataContext.PostCompany.Where(x => x.InfoID == session).ToList();
        //    return View(listpost);
        //}
        public IActionResult DeletePost(int id)
        {
            addpost.Delete(id);
            return RedirectToAction("MyPost","Home",TempData["Message"]="Delete Sucssfuly");
        }
        //public IActionResult ShowPersonOfCompany(string job)
        //{
        //    if (job != null)
        //    {
        //        List<ShowPersonViewModel> oShowPersonViewModel = new List<ShowPersonViewModel>();
        //        List<Person> lstPerson = dataContext.Person.ToList();
        //        DetailsPerson[] listdetailsperson = dataContext.DetailsPerson.ToList().ToArray();


        //        if (listdetailsperson != null && listdetailsperson.Length > 0)
        //        {
        //            foreach (var item in listdetailsperson.ToList())
        //            {
        //                oShowPersonViewModel.Add(new ShowPersonViewModel
        //                {
        //                    Address = lstPerson.Where(x => x.Address == item.Person.Address).Select(c => c.Address).FirstOrDefault(),
        //                    FirstName = lstPerson.Where(x => x.FirstName == item.Person.Address).Select(c => c.FirstName).FirstOrDefault(),
        //                    LastName = lstPerson.Where(x => x.LastName == item.Person.LastName).Select(c => c.LastName).FirstOrDefault(),
        //                    PhoneNo = lstPerson.Where(x => x.phoneNo == item.Person.phoneNo).Select(c => c.phoneNo).FirstOrDefault(),
        //                    Email = lstPerson.Where(x => x.Email == item.Person.Email).Select(c => c.Email).FirstOrDefault(),
        //                    Age = lstPerson.Where(x => x.Age == item.Person.Age).Select(c => c.Age).FirstOrDefault(),
        //                    LinkedIn = lstPerson.Where(x => x.LinkedInLink == item.Person.LinkedInLink).Select(c => c.LinkedInLink).FirstOrDefault(),
        //                    Major = lstPerson.Where(x => x.Major == item.Person.Major).Select(c => c.Major).FirstOrDefault(),
        //                    Pathimage = lstPerson.Where(x => x.PersonImage == item.Person.PersonImage).Select(c => c.PersonImage).FirstOrDefault(),
        //                    Expirence = item.Expirence,
        //                    AboutUs = item.AboutUs

        //                });  
        //            }
        //            return View(oShowPersonViewModel.ToList());

        //        }
        //    }

        //    return RedirectToAction("indexshowcomp", "Home");

        //}

        //public IActionResult ShowApplay()
        //{
        //    if (HttpContext.Session.GetString("infoID") == null)
        //    {
        //        return RedirectToAction("Login", "SignUp");
        //    }
        //    int idinfo = int.Parse(HttpContext.Session.GetString("infoID"));
        //    List<ShowPersonViewModel> oShowPersonViewModel = new List<ShowPersonViewModel>();
        //    var listjob = applayjob.List().Where(x=>x.InfoID == idinfo);
        //    ApplayJob[] applays = applayjob.List().Where(x=>x.InfoID ==idinfo ).ToArray();
        //    List<jobVacancy> job = dataContext.jobVacancy.ToList();
        //    List<Person> person = dataContext.Person.ToList();

        //    foreach(var item in applays.ToList())
        //    {
        //        oShowPersonViewModel.Add(new ShowPersonViewModel
        //        {
        //            jobName=job.Where(x=>x.JobName == item.JobVacancy.JobName).Select(x=>x.JobName).FirstOrDefault(),
        //            FirstName = person.Where(x => x.FirstName == item.Person.Address).Select(c => c.FirstName).FirstOrDefault(),
        //            Email = person.Where(x => x.Email == item.Person.Email).Select(c => c.Email).FirstOrDefault(),
        //            PhoneNo = person.Where(x => x.phoneNo == item.Person.phoneNo).Select(c => c.phoneNo).FirstOrDefault(),
        //            Major = person.Where(x => x.Major == item.Person.Major).Select(c => c.Major).FirstOrDefault(),
        //            Pathimage=person.Where(x=>x.PersonImage == item.Person.PersonImage).Select(c=>c.PersonImage).FirstOrDefault(),

        //        });
        //        //foreach(var i in listjob)
        //        //{
        //        //    oShowPersonViewModel.Add(new ShowPersonViewModel
        //        //    {
        //        //        jobName=i.JobVacancy.JobName,
        //        //        FirstName=i.Person.FirstName,
        //        //        Email=i.Person.Email,
        //        //        PhoneNo=i.Person.phoneNo,
        //        //        Major=i.Person.Major,
        //        //        Pathimage=i.Person.PersonImage

        //        //    });
        //        //}
        //    }
        //    return View(oShowPersonViewModel.ToList());
        //}

        //public IActionResult ShowJobcomp()
        //{
        //    int xx = int.Parse(HttpContext.Session.GetString("infoID"));
        //    List<ShowCompanyViewmodel> oShowCompanyViewModel = new List<ShowCompanyViewmodel>();

        //    jobVacancy[] listjob = dataContext.jobVacancy.Where(c => c.InfoID == xx).ToArray();

        //    if (listjob != null && listjob.Length > 0)
        //    {
        //        foreach (var item in listjob.ToList())
        //        {

        //            oShowCompanyViewModel.Add(new ShowCompanyViewmodel
        //            {
        //                Email = item.Email,
        //                CompanyName = item.CompanyName,
        //                PhoneNo = item.PhoneNo,
        //                Linklinkedin = item.LinkkedIn,
        //                Experience = item.Experience,
        //                Requirements = item.Requirements,
        //                City = item.Address,
        //                NameJob = item.JobName,
        //                jobvacancyid = item.jobVacancyID,
        //            });

        //        }

        //        return View(oShowCompanyViewModel.ToList());
        //    }
        //    return View();
        //}

      
        public IActionResult DeleteJob(int id)
        {
           addjob.Delete(id);
            return RedirectToAction("ShowJobcomp", "Home");
        }

        public IActionResult ShowAplledJob()
        { 
            return View();
        }
        private string UploadedFile(SiginUpViewModel model)
        {
            string uniqueFileName = null;

            if (model.postimage != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "postImages");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.postimage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.postimage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }
        #endregion
        #region List

       
        List<TypeCompany> fillselect()
        {
            var typelist = typecomp.List().ToList();
            typelist.Insert(0, new TypeCompany { TypeCompanyID = -1, Typename = "----please select an Education Level------" });
            return typelist;

        }

        List<Targetsector> FillselectTarg()
        {
            var targlist = target.List().ToList();
            targlist.Insert(0, new Targetsector { TargetsectorID = -1, namesector = "------ please select Univircity Name" });
            return targlist;
        }
        List<yourstatus> fillselectstatus()
        {
            var typelist = status.List().ToList();
            typelist.Insert(0, new yourstatus { yourstatusID = -1, NameStatus = "----please select an Your Status------" });
            return typelist;

        }

        List<CareerPath> fillselectcareer()
        {
            var typelist = career.List().ToList();
            typelist.Insert(0, new CareerPath { CareerPathID = -1, NameCareer = "----please select an Career Path------" });
            return typelist;

        }
        List<Gender> fillselectgender()
        {
            var genderlist = gender.List().ToList();
            genderlist.Insert(0, new Gender { GenderID = -1, GenderName = "----please select Gender------" });
            return genderlist;

        }
        #endregion

    }
}
