using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaceWeb.Models
{
    public class ProjectInfo
    {
        [Key]
        public string ProjectNo { get; set; }

        public string ProjectName { get; set; }

        public string ClientNo { get; set; }
    }
}
