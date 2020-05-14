using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Mapping
{
   public class SpecialityTypeMap:EntityTypeConfiguration<SpecialityType>
    {
       public SpecialityTypeMap()
       {
           // Primary Key
           this.HasKey(t => t.SpecialityTypeID);

           // Properties


           // Table & Column Mappings
           this.ToTable("SpecialityType");
           this.Property(t => t.SpecialityTypeID).HasColumnName("SpecialityTypeID");
           this.Property(t => t.Specialization).HasColumnName("Specialization");
           this.Property(t => t.StudiedAt).HasColumnName("StudiedAt");
           this.Property(t => t.Description).HasColumnName("Description");
           this.Property(t => t.EmployeeID).HasColumnName("EmployeeID");


           // Relationships

           this.HasRequired(t => t.Employee)
               .WithMany(t => t.SpecialityTypes)
               .HasForeignKey(d => d.EmployeeID);
       }
    }
}
