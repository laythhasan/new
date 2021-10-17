using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer;
using Infrastrucer.Repositry;
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
    public class SignUpController : Controller
    {
        DataContext db;
        private readonly IBisnicity<Info> bisnicity;
        private readonly IBisnicity<Person> person;
        private readonly IBisnicity<Gender> gender;
        private readonly IBisnicity<Educationlevel> edu;
        private readonly ILogin _login;
        private readonly ILoginPerson loginperson;
        private readonly IHostingEnvironment hosting;
        private readonly IBisnicity<Univircity> uni;
        private readonly IBisnicity<DataPerson> adddataperson;
     

        public SignUpController(IBisnicity<Info> obisnicity, ILogin login, IHostingEnvironment hosting  ,
            IBisnicity<Gender> _gender , IBisnicity<Educationlevel>_edu, IBisnicity<Person> _person,ILoginPerson _loginPerson,
            IBisnicity<Univircity> _uni, IBisnicity<DataPerson> _adddataperson,DataContext _db) 
        {
            bisnicity = obisnicity;
            _login = login;
            person = _person;
            loginperson = _loginPerson;
            edu = _edu;
            gender = _gender;
            this.hosting = hosting;
            uni = _uni;
            adddataperson = _adddataperson;
            db = _db;

        }
        public IActionResult SignUp()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken()]
        //public async Task<IActionResult> SignUp(SiginUpViewModel oInfo)
        //{
        //    string imageprofile = UploadedFile(oInfo);
        //    if (!ModelState.IsValid)
        //    {
        //        return PartialView("_Signup", oInfo);
        //    }
        //    var addinfo = new Info
        //        {

        //            FirstName = oInfo.FirstName,
        //            LastName = oInfo.LastName,
        //            Email = oInfo.Email,
        //            Password = oInfo.Password,
        //            PhoneNo = oInfo.PhoneNo,
        //            CompanyName = oInfo.CompanyName,
        //            Linklinkedin = oInfo.Linklinkedin,
        //            ImageProfile = imageprofile != string.Empty ? imageprofile : string.Empty,
        //            CreatedAt = oInfo.CreatedAt

        //       };

        //      if (addinfo != null)
        //        {
        //            this.bisnicity.Add(addinfo);
        //            return RedirectToAction("Login", "SignUp");
        //       }
        //    return View();
           

        //}
     

        private string UploadedFile(SiginUpViewModel model)
        {
            string uniqueFileName = null;

            if (model.ImageProfile != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "ProfilImage");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.ImageProfile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.ImageProfile.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Login(Login oInfo)
        {
            if (!ModelState.IsValid) { return PartialView("_Login"); }
        
            Info IsLooger = this._login.Login(oInfo.Email.Trim(), oInfo.Password.Trim());
            if(IsLooger !=null)
            {
                HttpContext.Session.SetString("infoID",Convert.ToString(IsLooger.InfoID));
                return RedirectToAction("EditProfile", "Home");
            }
            else
            {
                TempData["messsages"] = "user name or password in valid";

                return PartialView("_Login");
                //return RedirectToAction("Login", "SignUp");
            }
            
        }

        public IActionResult SignUpPerson()
        {
            var signview = new SignUpPersonViewModel
            {
                Genders = fillselectgender(),
                Educationlevels = fillselect(),
                univircitys = FillselectUni()
            };
            return View(signview);
        }

        [HttpPost]
        //public IActionResult SignUpPerson(SignUpPersonViewModel modelperson)
        //{
        //    if(modelperson.levelID ==-1 && modelperson.genderID ==-1 && modelperson.uniID ==-1)
        //    {
        //        TempData["messsages"] = "please chosee Gender and Level Educations and univircity";
        //        var osignview = new SignUpPersonViewModel
        //        {
        //            Genders = fillselectgender(),
        //            Educationlevels = fillselect(),
        //            univircitys=FillselectUni()
        //        };
        //        TempData["messsages"] = "please chosee Gender and Level Educations and univircity";
        //        return View(osignview);     

        //    }
        //    string cv = string.Empty;
        //    string imageprofile = string.Empty;
    
        //    if (!ModelState.IsValid)
        //    {
        //        return View();
        //    }
        //    if (modelperson.uploadscv != null )
        //    {
        //        cv = UploadedFileCv(modelperson);
        //    }

        //    if (modelperson.uploadpersonimage != null)
        //    {
        //        imageprofile = UploadedFileperson(modelperson);

        //    }
        //        var edufind = edu.Find(modelperson.levelID);
        //        var genderfind = gender.Find(modelperson.genderID);
        //        var unifind = uni.Find(modelperson.uniID);
        //        int genderid = genderfind.GenderID;
        //        int eduid = edufind.EducationlevelID;
        //        int uniID = unifind.UnivircityID;
        //        var signup = new Person
        //        {
        //            FirstName = modelperson.FirstName,
        //            LastName = modelperson.LastName,
        //            SecoundName = modelperson.SecoundName,
        //            ThirdName = modelperson.ThirdName,
        //            Email = modelperson.Email,
        //            Password = modelperson.Password,
        //            LinkedInLink = modelperson.LinkedInLink,
        //            phoneNo = modelperson.phoneNo,
        //            Age = modelperson.Age,
        //            GPA = modelperson.GPA,
        //            Address = modelperson.Address,
        //            PersonImage = imageprofile != string.Empty ? imageprofile : string.Empty,
        //            GenderID = genderid,
        //            EducationlevelID = eduid,
        //            UnivircityID = uniID,
        //            Major = modelperson.Major,
        //            Cvpdf = cv != string.Empty ? cv : string.Empty
        //        };

        //        if (signup != null)
        //        {
        //            person.Add(signup);
        //            return RedirectToAction("LoginPerson", "SignUp");
        //        }

           
        //    return View();
        //}
        public IActionResult LoginPerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult LoginPerson(Login ologinperson)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            Person Islogger = loginperson.Login(ologinperson.Email.Trim(), ologinperson.Password.Trim());
            if(Islogger !=null)
            {
                HttpContext.Session.SetString("PersonID", Convert.ToString(Islogger.PersonID));
                return RedirectToAction("indexPerson", "Person");
            }
            else
            {
                TempData["messsages"] = "user name or password in valid";
                return View();
            }
            

        }

        public IActionResult  DataPerson()
        {
            var dataperson = new DataPersonViewModel
            {
                Genders = fillselectgender(),
                Educationlevels = fillselect(),
                univircitys = FillselectUni()
            };
            return View(dataperson);
        }
        [HttpPost]
        public IActionResult DataPerson(DataPersonViewModel model)
        {
            if (model.levelID == -1 && model.genderID == -1 && model.uniID == -1)
            {
              
                var dataperson = new DataPersonViewModel
                {
                    Genders = fillselectgender(),
                    Educationlevels = fillselect(),
                    univircitys = FillselectUni()
                };
                TempData["messsages"] = "please chosee Gender and Level Educations and univircity";
                return View(dataperson);
            }
            if (!ModelState.IsValid)
            {
                return View();
            }
            var edufind = edu.Find(model.levelID);
            var genderfind = gender.Find(model.genderID);
            var unifind = uni.Find(model.uniID);
            int genderid = genderfind.GenderID;
            int eduid = edufind.EducationlevelID;
            int uniID = unifind.UnivircityID;

            var addData = new DataPerson
            {
                Name=model.Name,
                Email=model.Email,
                phoneeNo=model.phoneeNo,
                GenderID = genderid,
                EducationlevelID = eduid,
                UnivircityID = uniID
            };
            adddataperson.Add(addData);
            

            return RedirectToAction("ShowTran", "Home", TempData["messsages"] = "Join Successfuly ");
        }

        private string UploadedFileperson(SignUpPersonViewModel model)
        {
            string uniqueFileName = null;

            if (model.uploadpersonimage != null)
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "ProfilImage");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.uploadpersonimage.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.uploadpersonimage.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }


        private string UploadedFileCv(SignUpPersonViewModel model)
        {
            String FileExt = Path.GetExtension(model.uploadscv.FileName).ToUpper();
            string uniqueFileName = null;
            if (FileExt == ".PDF")
            {
                string uploadsFolder = Path.Combine(hosting.WebRootPath, "uploadsCV");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.uploadscv.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    model.uploadscv.CopyTo(fileStream);
                }
                
            }
            return uniqueFileName;



        }

        List<Gender> fillselectgender()
        {
            var genderlist = gender.List().ToList();
            genderlist.Insert(0, new Gender { GenderID = -1, GenderName = "----please select Gender------" });
            return genderlist;

        }
        List<Educationlevel> fillselect()
        {
            var edulist = edu.List().ToList();
            edulist.Insert(0, new Educationlevel { EducationlevelID = -1, levelName = "----please select an Education Level------" });
            return edulist;

        }

        List<Univircity> FillselectUni()
        {
            var unilist = uni.List().ToList();
            unilist.Insert(0, new Univircity { UnivircityID = -1, UniName = "------ please select Univircity Name" });
            return unilist;
        }

    }
   
}
