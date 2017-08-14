namespace MVC5UI.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MVC5UI_Model : DbContext
    {
        public MVC5UI_Model()
            : base("name=MVC5UI_Model")
        {
            Database.SetInitializer(new InitDatabase());
        }

        public virtual DbSet<Account> Account { get; set; }
        public virtual DbSet<Account_Log> Account_Log { get; set; }
        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<Role_Log> Role_Log { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<Status_Log> Status_Log { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
