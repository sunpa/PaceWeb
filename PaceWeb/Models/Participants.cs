using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaceWeb.Models
{
    public class Participants
    {
        [Key]
        public string AccountNumber { get; set; }

        public string Client { get; set; }

        public string Group { get; set; }

        public string Project { get; set; }

        public string FirstName { get; set; }

        public string MiddleName { get; set; }

        public string LastName { get; set; }

        public string FullName { get; set; }

        public string ParticipantID { get; set; }

        public string BondSeries { get; set; }

        public bool EnrollmentStatus { get; set; }

        public string LegalDescription { get; set; }

        public string EntityName { get; set; }

        public string Status { get; set; }
    }
}
