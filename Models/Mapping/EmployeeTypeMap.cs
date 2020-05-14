using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Mapping
{
   public class EmployeeTypeMap:EntityTypeConfiguration<EmployeeType>
    {
       public EmployeeTypeMap()
       {
           this.HasKey(t => t.EmployeeTypeID);

           // Properties


           // Table & Column Mappings
           this.ToTable("EmployeeType");
           this.Property(t => t.EmployeeTypeID).HasColumnName("EmployeeTypeID");
           this.Property(t => t.Name).HasColumnName("Name");
          
       }
    }
}
