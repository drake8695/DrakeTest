using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakeTest.Core.Models
{
    public class Patient : BaseEntity
    {
        public string UserId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
       
        public string DOB { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }




    }
}
