using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ITEA_Management.Models
{
    public class Office
    {
        public int OfficeId { get; set; }

        [Display(Name = "Office Location"), StringLength(70)]
        public string Location { get; set; }

        public ICollection<Teacher> Teachers { get; set; }
    }
}
