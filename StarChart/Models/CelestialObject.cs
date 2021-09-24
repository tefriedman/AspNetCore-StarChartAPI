using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StarChart.Models
{
    public class CelestialObject
    {
        //created by tom on 9/24/21
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int? OrbitedObjectId { get; set; }
        [NotMapped]
        public List<CelestialObject> Satellites { get; set; }
        public TimeSpan OrbitalPeriod { get; set; }


    }
}
