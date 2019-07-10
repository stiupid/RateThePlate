using System;
using System.Collections.Generic;

namespace RateThePlate.Models
{
    public partial class CarPlate
    {
        public CarPlate()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string PlateNumber { get; set; }

        public ICollection<Feedback> Feedback { get; set; }
    }
}
