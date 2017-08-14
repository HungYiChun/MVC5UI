namespace MVC5UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Role_Log
    {
        [Key]
        public int LogId { get; set; }

        [Required]
        [StringLength(6)]
        public string AType { get; set; }

        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string RoleName { get; set; }

        public DateTime LogTime { get; set; }
    }
}
