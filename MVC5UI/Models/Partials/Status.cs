using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC5UI.Models
{
    [MetadataType(typeof(StatusMetadata))]
    public partial class Status
    {
        public class StatusMetadata
        {
            public int Id { get; set; }

            [Required]
            [StringLength(255)]
            public string StatusName { get; set; }
        }
    }
}