using System;
using System.Collections.Generic;

namespace RateThePlate.Models
{
    public partial class Badge
    {
        public Badge()
        {
            Feedback = new HashSet<Feedback>();
        }

        public int Id { get; set; }
        public string Rating { get; set; }

        public ICollection<Feedback> Feedback { get; set; }
    }
}
