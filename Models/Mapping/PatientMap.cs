using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Mapping
{
   public class PatientMap:EntityTypeConfiguration<Patient>
   {
       public PatientMap()
       {
           // Primary Key
           this.HasKey(t => t.PatientID);

           // Properties
           this.Property(t => t.PatienName)
               .IsRequired()
               .HasMaxLength(50);


           // Table & Column Mappings
           this.ToTable("Patient");
           this.Property(t => t.PatientID).HasColumnName("PatientID");
           this.Property(t => t.PatienName).HasColumnName("PatienName");
           this.Property(t => t.LastName).HasColumnName("LastName");
           this.Property(t => t.Address).HasColumnName("Address");
       }
    }
}
