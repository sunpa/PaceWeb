using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaceWeb.Models
{
    public class AssessmentsByBondSeries
    {
        public string BondSeries { get; set; }
        
        public string ParticipantID { get; set; }
        
        public string ParcelNo { get; set; }
        
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? FirstDueDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? AssessmentAmount { get; set; }

        public decimal? InterestRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? MaturityDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? PrincipalReceived { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? InterestReceived { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? AdministrativeFee { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? InterestPaidDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? NextDueDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}")]
        public decimal? CurrentAssessmentAmount { get; set; }
    }
}
