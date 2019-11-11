using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaceWeb.Models
{
    public class BondSeries
    {
        [Key]
        public string BondSeriesId { get; set; } 

        public string Name { get; set; } 

        public string ClientNo { get; set; }

    }
}
