using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Models
{
    public class TPUDirectionOfTraining
    {
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public Guid? SchoolId { get; set; }
        public TPUSchool School { get; set; }
    }
}
