using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVC5UI.Models
{
    public class InitDatabase : DropCreateDatabaseAlways<MVC5UI_Model>
    {
        protected override void Seed(MVC5UI.Models.MVC5UI_Model context)
        {
            Role role1 = new Role { RoleName = "Admin" };
            Role role2 = new Role { RoleName = "Member" };

            context.Role.Add(role1);
            context.Role.Add(role2);

            context.SaveChanges();

            Status status1 = new Status { StatusName = "Enabled" };
            Status status2 = new Status { StatusName = "Not Enabled" };

            context.Status.Add(status1);
            context.Status.Add(status2);

            context.SaveChanges();

            Account acc1 = new Account { Username = "admin", Password = "admin", Name = "Kevin", Email = "admin@NPOT.com", Phone = "0000-0000", Cellphone = "0000-2222", RoleId = 1, StatusId = 1 };
            Account acc2 = new Account { Username = "user", Password = "user", Name = "Durant", Email = "user@NPOT.com", Phone = "0000-1111", Cellphone = "0000-3333", RoleId = 2, StatusId = 1 };

            context.Account.Add(acc1);
            context.Account.Add(acc2);

            context.SaveChanges();
        }
    }
}