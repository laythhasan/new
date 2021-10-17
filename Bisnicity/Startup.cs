using Infrastrucer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BisnicityApp.Entites;
using BisnicityApp.InterFaces;
using Infrastrucer.Repositry;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.Authorization;
using Infrastrucer.Models;
using NETCore.MailKit.Extensions;
using NETCore.MailKit.Infrastructure.Internal;

namespace Bisnicity
{
    public class Startup
    {
        private readonly IConfiguration configuration;
        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllers();
            services.AddSession(options =>
            {
                options.IdleTimeout = TimeSpan.FromMinutes(10);
            });
            services.AddDbContext<DataContext>(options =>
            {
                options.UseSqlServer(configuration.GetConnectionString("MyBisnicityDB"));
            });

            services.AddIdentity<ApplicationUser, IdentityRole>(option =>
           {
               option.User.RequireUniqueEmail = true;
              // option.SignIn.RequireConfirmedEmail = true;
           }).AddRoles<IdentityRole>().AddEntityFrameworkStores<DataContext>()
           .AddDefaultTokenProviders();
            //services.AddMailKit(Opt=>Opt.UseMailKit(configuration.GetSection("Email").Get<MailKitOptions>()));
            services.AddRazorPages();
            services.AddScoped<IBisnicity<Info>, InfoDBRepo>();
            //services.AddScoped<ILogin, LoginService>();
            services.AddScoped<IBisnicity<OurServices>, OurServicedbRepo>();
            services.AddScoped<IBisnicity<Templete>, TempleteDbRepo>();
            services.AddScoped<IBisnicity<Services>, ServicesDbRepo>();
            services.AddScoped<IAdminLogin, AdminRepo>();
            services.AddScoped<IBisnicity<CatTemp>, CategoryRepo>();
            services.AddScoped<IBisnicity<jobVacancy>, JobVacancyRepo>();
            services.AddScoped<AddAdmin<Admin>, AdminRepo>();
            services.AddScoped<IBisnicity<Gender>, GenderRepo>();
            services.AddScoped<IBisnicity<Educationlevel>, EducationlevelRepo>();
            services.AddScoped<IBisnicity<Person>, PersonRepo>();
            services.AddScoped<IBisnicity<CatPerson>, CatPersonRepo>();
            services.AddScoped<IBisnicity<DetailsPerson>, DetailsPersonRepo>();
            services.AddScoped<IBisnicity<SkillsPerson>, SkillPersonRepo>();
            services.AddScoped<IBisnicity<Univircity>, univircityRepo>();
            services.AddScoped<IBisnicity<DataPerson>, DataPersonRepo>();
            services.AddScoped<IBisnicity<PostCompany>, postRepo>();
            services.AddScoped<IBisnicity<Idea>, IdeaRepo>();
            services.AddScoped<IBisnicity<SuppourtIdea>, SupportIdeaRepo>();
            services.AddScoped<IBisnicity<Targetsector>, TargetSectorRepo>();
            services.AddScoped<IBisnicity<TypeCompany>, TypeCompRepo>();
            services.AddScoped<IBisnicity<yourstatus>, yourstatusRepo>();
            services.AddScoped<IBisnicity<CareerPath>, CareerPathRepo>();
            services.AddScoped<IBisnicity<Datavocational>, DataVocationalRepo>();
            services.AddScoped<IBisnicity<ContactUs>, ContactUsRepo>();
            services.AddScoped<IBisnicity<Invistor>, InvistorRepo>();
            services.AddScoped<IBisnicity<ContactUs>, ContactUsRepo>();
            services.AddScoped<IBisnicity<IdeaColctive>, IdeaColctiveRepo>();
            services.AddScoped<IBisnicity<ApplayJob>, applayjobRepo>();
            services.AddScoped<IBisnicity<volunteer>, volunteerRepo>();
            services.AddScoped<IBisnicity<TypeIdea>, TypeIdeaRepo>();


        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseSession();
            app.UseEndpoints(endpoints =>
            {
                // endpoints.MapControllers();

                endpoints.MapControllerRoute(
                    "defultRoute",
                    "{controller=Home}/{action=Index1}/{id?}"
                    );
            });
        }
    }
}
