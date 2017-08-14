namespace MVC5UI.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Status
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string StatusName { get; set; }
    }
}
