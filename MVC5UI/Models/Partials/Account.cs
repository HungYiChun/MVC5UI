using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5UI.Models
{
    [MetadataType(typeof(AccountMetadata))]
    public partial class Account
    {
        public class AccountMetadata
        {
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
        }
    }
}