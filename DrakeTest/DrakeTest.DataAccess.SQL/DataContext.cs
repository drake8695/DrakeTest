using DrakeTest.Core.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrakeTest.DataAccess.SQL
{
    public class DataContext : DbContext
    {

        public DataContext()
            : base("DefaultConnection")
        {

        }

        public DbSet<Patient> Patients { get; set; }

    }
}
