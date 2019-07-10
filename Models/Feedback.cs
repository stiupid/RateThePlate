using System;

namespace RateThePlate.Models
{
    public partial class Feedback
    {
        public int Id { get; set; }
        public DateTime Created { get; set; }
        public int CarPlateId { get; set; }
        public int BadgeId { get; set; }

        public Badge Badge { get; set; }
        public CarPlate CarPlate { get; set; }
       
    }
}
