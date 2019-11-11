using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PaceWeb.Models
{
    public class Address
    {
        [Key]
        public string AccountNumber { get; set; }

        public string BAddress1 { get; set; }

        public string BAddress2 { get; set; }

        public string BAddress3 { get; set; }

        public string BCity { get; set; }

        public string BState { get; set; }

        public string BZipCode { get; set; }

        public string PAddress1 { get; set; }

        public string PAddress2 { get; set; }

        public string PAddress3 { get; set; }

        public string PCity { get; set; }

        public string PState { get; set; }

        public string PZipCode { get; set; }

        public string ParcelNo { get; set; }

        public string County { get; set; }

        public string ClientNo { get; set; }

        public string ParcelNo2 { get; set; }

    }
}
