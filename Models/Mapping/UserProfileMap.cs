using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cats.Models.Mapping
{
   public class UserProfileMap:EntityTypeConfiguration<UserProfile>
    {
       public UserProfileMap()
       {

           // Primary Key
           this.HasKey(t => t.UserProfileID);

           // Properties


           // Table & Column Mappings
           this.ToTable("UserProfile");
           this.Property(t => t.UserProfileID).HasColumnName("UserProfileID");
           this.Property(t => t.UserName).HasColumnName("UserName");
           this.Property(t => t.Password).HasColumnName("Password");
           this.Property(t => t.FirstName).HasColumnName("FirstName");
           this.Property(t => t.LastName).HasColumnName("LastName");
           this.Property(t => t.GrandFatherName).HasColumnName("GrandFatherName");
           this.Property(t => t.UserType).HasColumnName("UserType");


           // Relationships

           this.HasRequired(t => t.EmployeeType)
               .WithMany(t => t.UserProfiles)
               .HasForeignKey(d => d.UserType);
       }

    }
}
