using Kalamu_School_Management_System.Models.Entities;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kalamu_School_Management_System.Data
{
    public  static class SchoolDbInitializer
    {
        internal static void Initialize(IApplicationBuilder app)
        {
            using(var serviceScope = app.ApplicationServices.CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<SchoolDbContext>();
                context.Database.EnsureCreated();

                var school = context.School.Where(x => x.Id == 1).FirstOrDefault();
                if(school == null)
                {
                    school = new School
                    {
                        Name = "Kilimo Bora High School",
                        Address = "7888 Nairobi - Kenya",
                        PhonePrimary = "0721344344",
                        PhoneAlt = "0787232443",
                        Fax = "54655",
                        Email = "admin@kilimoborahighschool.com",
                        Logo = null
                    };
                    context.School.Add(school);
                }

                context.SaveChanges();
            }
        }
    }

}

//https://forums.asp.net/t/2153626.aspx?MVC+Core+2+2+DbInitializer+Seeding+Data+
//https://www.codeproject.com/Articles/5163367/Seeding-Data-MVC-6-NET-Core-Application
