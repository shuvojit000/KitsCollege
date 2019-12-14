using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kits.CollegeMg.CollegeService.Request
{
    public class RegistrationReq
    {
        public string StudentName { get; set; }
        public string DOB { get; set; }
        public string MobileNo { get; set; }

        public string Email { get; set; }
        public string HSRollNo { get; set; }
        public string CURegNo { get; set; }
        public string ProgYear { get; set; }
        public DateTime CrtdOn { get; set; }
        public string Type { get; set; }
        public int Status { get; set; }

    }
}
