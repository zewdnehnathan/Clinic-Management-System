using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Mapping
{
    public class PatientDiagnosisMap : EntityTypeConfiguration<PatientDiagnosis>
    {
       public PatientDiagnosisMap()
       {
           // Primary Key
           this.HasKey(t => t.DiagnosisID);

           // Properties
          

           // Table & Column Mappings
           this.ToTable("PatientDiagnosis");
           this.Property(t => t.DiagnosisID).HasColumnName("DiagnosisID");
           this.Property(t => t.Diagnosis).HasColumnName("Diagnosis");
           this.Property(t => t.Description).HasColumnName("Description");
           this.Property(t => t.PatientID).HasColumnName("PatientID");
          

           // Relationships
           
           this.HasRequired(t => t.Patient)
               .WithMany(t => t.PatientDiagnosises)
               .HasForeignKey(d => d.PatientID);
       }
    }
}
