using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5UI.Models
{
    [MetadataType(typeof(RoleMetadata))]
    public partial class Role
    {
        public class RoleMetadata
        {
            public int Id { get; set; }

            [Required]
            [StringLength(255)]
            public string RoleName { get; set; }
        }
    }
}