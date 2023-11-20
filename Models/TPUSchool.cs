using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Models
{
    public class TPUSchool
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Tel { get; set; }
        public ICollection<TPUDirectionOfTraining> DirectionsOfTraining { get; set; }
        public TPUSchool()
        {
            DirectionsOfTraining = new List<TPUDirectionOfTraining>();
        }
    }
}
