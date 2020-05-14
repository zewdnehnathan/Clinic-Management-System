using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Mapping
{
    public class EmployeeMap : EntityTypeConfiguration<Employee>
    {
       public EmployeeMap()
       {
           // Primary Key
           this.HasKey(t => t.EmployeeID);

           // Properties


           // Table & Column Mappings
           this.ToTable("Employee");
           this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");
           this.Property(t => t.EmployeeName).HasColumnName("EmployeeName");
           this.Property(t => t.LastName).HasColumnName("LastName");
           this.Property(t => t.Address).HasColumnName("Address");
           this.Property(t => t.Position).HasColumnName("Position");


           // Relationships

           this.HasRequired(t => t.EmployeeType)
               .WithMany(t => t.Employees)
               .HasForeignKey(d => d.Position);
       }
    }
}
