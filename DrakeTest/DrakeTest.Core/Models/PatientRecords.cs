using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakeTest.Core.Models
{
    
    public class PatientRecords:BaseEntity
    {
        public string UserId { get; set; }
        public Double height { get; set; }
        public Double weight { get; set; }

        public string test { get; set; }

    }
}
