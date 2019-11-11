using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaceWeb.Models
{
    public class Assessments
    {
        [Key]
        public string AccountNumber { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? FirstDueDate { get; set; }

        public decimal? AssessmentAmount { get; set; }

        public decimal? CurrentAssessmentAmount { get; set; }

        public decimal? InterestRate { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? MaturityDate { get; set; }

        public decimal? AssessmentReceived { get; set; }

        public decimal? AdminFee { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? InterestPaidDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? NextDueDate { get; set; }

        public decimal? PaymentAmount { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? CreatedDate { get; set; }

        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime? InterestStartDate { get; set; }

        public string AccountStatus { get; set; }

        public string LoanStatus { get; set; }

        public decimal? InterestReceived { get; set; }

        public decimal? UnappliedBalance { get; set; }

    }
}
