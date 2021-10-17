/*************************************************************************************************************/
/*Class Name    : AccountController.cs                                                                       /
/*Created By    : Hamza Nayef                                                                             */
/*Ceation Date  : 09-10-2021                                                                            */
/******************************************************************************************************/
using Bisnicity.Helper;
using Bisnicity.Models;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using NETCore.MailKit.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
namespace Bisnicity.Controllers
{
    [AllowAnonymous]
    public class AccountController : BaseController
    {
        #region Members
        /// <summary>
        /// 
        /// </summary>
        private readonly UserManager<ApplicationUser> ouserManager;
        private readonly SignInManager<ApplicationUser> osignInManager;
        private readonly ILogger _loggers;
        private readonly RoleManager<IdentityRole> roleManager;
        private readonly IBisnicity<Gender> gender;
        private readonly IHttpContextAccessor _httpContextAccessor;
        //private readonly IEmailService emailService;

        private LoginViewModel oLoginViewModel { get; set; } = new LoginViewModel();
        #endregion
        #region Constructor
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_UserManager"></param>
        /// <param name="_signInManager"></param>
        public AccountController(UserManager<ApplicationUser> _UserManager, SignInManager<ApplicationUser> _signInManager, ILogger<AccountController> logger, IBisnicity<Gender> _gender, RoleManager<IdentityRole> _roleManager, IHttpContextAccessor httpContextAccessor)
        {
            this.ouserManager = _UserManager;
            this.osignInManager = _signInManager;
            this._loggers = logger;
            this.gender = _gender;
            roleManager = _roleManager;
            _httpContextAccessor = httpContextAccessor;
        }
        #endregion
        #region Actions
        #region Action :: Login
        [ActionName(nameof(Login))]
        public async Task<IActionResult> Login(string sRetrunUrl)
        {
            if (sRetrunUrl == null)
            {
                return View(nameof(Login));
            }
            else if (!string.IsNullOrEmpty(sRetrunUrl))
            {
                oLoginViewModel.sRetrunUrl = sRetrunUrl.Trim();
                return View(nameof(Login), oLoginViewModel);
            }
            return View(nameof(Login));
        }
        #endregion
        #region Action ::Login
        [HttpPost]
        [ValidateAntiForgeryToken]
        [DisableRequestSizeLimit(Order = 3)]
        [ActionName(nameof(Login))]
        public async Task<IActionResult> Login(LoginViewModel oLoginViewModel)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    return View(nameof(Login), oLoginViewModel);
                }
                var result = await this.osignInManager.PasswordSignInAsync(
                                oLoginViewModel.sEmail,
                                oLoginViewModel.sPassword,
                                oLoginViewModel.bRemberMe,
                                true);
                if (result.Succeeded)
                {
                    string sRoleName = await this.GetUserRole(oLoginViewModel.sEmail);
                    if (!string.IsNullOrEmpty(sRoleName))
                    {
                        if (sRoleName == BisnicityKey.PersonRole)
                        {
                            ApplicationUser user = await ouserManager.FindByEmailAsync(oLoginViewModel.sEmail);
                            HttpContext.Session.SetObject("UserInfo", user);
                            return await this.CustomRedirect("CompleteProfilePerson", "Person");
                        }
                        else if (sRoleName == BisnicityKey.BusinessRole)
                        {
                            ApplicationUser user = await ouserManager.FindByEmailAsync(oLoginViewModel.sEmail);
                            HttpContext.Session.SetObject("UserInfo", user);
                            return await this.CustomRedirect("CompleteProfile", "Business");
                        }
                        else if(sRoleName==BisnicityKey.SuportIdeaRole)
                        {
                            ApplicationUser user = await ouserManager.FindByEmailAsync(oLoginViewModel.sEmail);
                            HttpContext.Session.SetObject("UserInfo", user);
                            return await this.CustomRedirect("SupportIdea", "Idea");
                        }
                        else if(sRoleName == BisnicityKey.InvistorRole)
                        {
                            ApplicationUser user = await ouserManager.FindByEmailAsync(oLoginViewModel.sEmail);
                            HttpContext.Session.SetObject("UserInfo", user);
                            return await this.CustomRedirect("InvestorEN", "Idea");
                        }
                    }
                    else
                    {
                        TempData["Message"] = BisnicityKey.InValidUserName;
                    }
                }
                this.ModelState.AddModelError(string.Empty, string.Concat(BisnicityKey.InValidUserName));
            }
            catch (Exception ex)
            {
                this._loggers.Log(LogLevel.Error, ex.StackTrace, ex);
            }
            return View(nameof(Login));
        }
        #endregion
        #region Action ::Register
        [ActionName(nameof(Register))]
        public async Task<IActionResult> Register()
        {
            var list = new RegiseterViewModel
            {
                Genders = lSelectgender(),
                Roles = lSelctRoles()
            };

            return this.View(nameof(Register), list);
        }
        #endregion
        #region Action :: Register
        [HttpPost]
        [ValidateAntiForgeryToken]
        [ActionName(nameof(Register))]
        public async Task<IActionResult> Register(RegiseterViewModel oRegiseterViewModel)
        {
            try
            {
                ApplicationUser oApplicationUser = null;
                var allErrors = ModelState.Values.SelectMany(v => v.Errors);
                if (allErrors != null && allErrors.Count() > 0)
                {
                    _loggers.LogError(allErrors.ToString(), string.Empty);
                }
                else if (!ModelState.IsValid)
                {
                    return View(nameof(Register), oRegiseterViewModel);
                }
                oApplicationUser = new ApplicationUser();
                oApplicationUser.UserName = oRegiseterViewModel.sEmail;
                oApplicationUser.Email = oRegiseterViewModel.sEmail;
                oApplicationUser.PhoneNumber = oRegiseterViewModel.sPhone;
                oApplicationUser.sFirstname = oRegiseterViewModel.sFirstname;
                oApplicationUser.sLastname = oRegiseterViewModel.sLastname;
                oApplicationUser.GenderID = gender.Find(oRegiseterViewModel.nGenderid).GenderID;

                var result = await this.ouserManager.CreateAsync(oApplicationUser, oRegiseterViewModel.sPassword);
                if (result.Succeeded)
                {
                    await this.ouserManager.AddToRoleAsync(oApplicationUser, oRegiseterViewModel.sRoles);
                    var token = await ouserManager.GenerateEmailConfirmationTokenAsync(oApplicationUser);
                    var confirmlink = Url.Action(nameof(ConfirmEmail), "Account", new { userid = oApplicationUser.Id, code = token },protocol:HttpContext.Request.Scheme);
                    ViewBag.token = confirmlink;
                   
                    return this.RedirectToAction("Login", "Account");
                }
                foreach (var Errors in result.Errors)
                {
                    this.ModelState.AddModelError(string.Empty, Errors.Description);
                }
            }
            catch (Exception ex)
            {
                this._loggers.Log(LogLevel.Error, ex.StackTrace, ex);
            }
            return View(nameof(Register), oRegiseterViewModel);
        }
        #region Action:: ConfirmEmail
        [HttpGet]
        public async Task<IActionResult> ConfirmEmail(string userid, string code)
        {
          if(userid ==null || code ==null)
            {
                return View("Error");
            }
            var user = await ouserManager.FindByIdAsync(userid);
            if(user==null)
            {
                return View("Error");
            }
            var result = await ouserManager.ConfirmEmailAsync(user, code);
            return View(result.Succeeded ? "ConfirmEmail" : "Error");
        }
        
        #endregion
        #endregion
        #endregion
        #region ListGender
        List<Gender> lSelectgender()
        {
            var genderlist = gender.List().ToList();
            genderlist.Insert(0, new Gender { GenderID = -1, GenderName = "----please select Gender------" });
            return genderlist;

        }
        #region ListRoles
        List<IdentityRole> lSelctRoles()
        {
            var roles = roleManager.Roles.ToList();
            //Where(x=>!x.Name.Contains("Admins"))
            return roles;
        }
        #endregion
        #endregion
        #region Method :: GetUserRole
        public async Task<string> GetUserRole(string sEmailID)
        {
            var user = await ouserManager.FindByEmailAsync(sEmailID);
            var rolename = await ouserManager.GetRolesAsync(user);
            return rolename.FirstOrDefault();
        }
        #endregion
    }
}
