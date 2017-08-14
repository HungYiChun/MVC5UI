namespace MVC5UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Account_Log
    {
        [Key]
        public int LogId { get; set; }

        [Required]
        [StringLength(6)]
        public string AType { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Username { get; set; }

        [Required]
        [StringLength(255)]
        public string Password { get; set; }

        [Required]
        [StringLength(255)]
        public string Email { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        [Required]
        [StringLength(255)]
        public string Phone { get; set; }

        [Required]
        [StringLength(255)]
        public string Cellphone { get; set; }

        public int RoleId { get; set; }

        public int StatusId { get; set; }

        public DateTime LogTime { get; set; }
    }
}
