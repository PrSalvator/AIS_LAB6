using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AIS_LAB6.Models
{
    public class TPUSchool
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel { get; set; }
        public ICollection<TPUDirectionOfTraining> DirectionOfTrainings { get; set; }
        public TPUSchool()
        {
            DirectionOfTrainings = new List<TPUDirectionOfTraining>();
        }
    }
}
