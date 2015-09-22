using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using StayCalm.Models;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace StayCalm.Infrastructure
{
    public class IdentityMigrationConfiguration : DbMigrationsConfiguration<ApplicationDbContext>
    {
        public IdentityMigrationConfiguration()
        {
            this.AutomaticMigrationsEnabled = true;
#if DEBUG
            this.AutomaticMigrationDataLossAllowed = true;
#endif
        }

        protected override void Seed(ApplicationDbContext context)
        {
            base.Seed(context);

#if DEBUG
            // Fill Data here
#endif
        }

    }
}