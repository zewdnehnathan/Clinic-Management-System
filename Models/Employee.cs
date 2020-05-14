using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models
{
   public class Employee
    {
       public int EmployeeID { get; set; }
       public string EmployeeName { get; set; }
       public string LastName { get; set; }
       public string Address { get; set; }
       public int Position { get; set; }


       public virtual EmployeeType EmployeeType { get; set; }
       public virtual ICollection<SpecialityType> SpecialityTypes { get; set; }
    }
}
