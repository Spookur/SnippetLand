using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CMS.Models
{
    public class CaseModel
    {
        public int CaseId { get; set; }
        public string Details { get; set; }
        public DateTime FilingDate { get; set; }
        public string Agency { get; set; }
        public string DefendantName { get; set; }
        public string DefendantAddress { get; set; }
        public string Charges { get; set; }
    }
}