using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models
{
   public class EmployeeType
    {
       public int EmployeeTypeID { get; set; }
       public string Name { get; set; }

       public ICollection<Employee> Employees { get; set; }
       public ICollection<UserProfile> UserProfiles { get; set; }
    }
}
