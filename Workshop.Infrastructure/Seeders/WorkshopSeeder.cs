using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Workshop.Infrastructure.Persistence;

namespace Workshop.Infrastructure.Seeders
{
    public class WorkshopSeeder
    {
        private readonly WorkshopDbContext dbContext;
        public WorkshopSeeder(WorkshopDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
       public async Task Seed()
        {
            if(await this.dbContext.Database.CanConnectAsync())
            {
                if(!this.dbContext.Workshop.Any())
                {
                    var Ip15 = new Domain.Entities.Workshop()
                    {
                        Name = "Iphone15",
                        Description = "Newest Iphone",
                        CreatedAt = DateTime.Now,
                        ContactDetails = new Domain.Entities.WorkshopContactDetails()
                        {
                            PhoneNumber = "212537420",
                            Mail = "apple@gmail.com",
                            City = " Cupertino",
                            PostalCode = "94-024"
                        },                       
                    };
                    Ip15.EncodeName();
                    this.dbContext.Workshop.Add(Ip15);
                    await this.dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
