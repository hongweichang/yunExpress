//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Context
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    using LMS.Data.Entity;
    
    
    internal partial class SenderInfo_Mapping : EntityTypeConfiguration<SenderInfo>
    {
        public SenderInfo_Mapping()
        {                        
              this.HasKey(t => t.SenderInfoID);        
              this.ToTable("SenderInfos");
              this.Property(t => t.SenderInfoID).HasColumnName("SenderInfoID");
              this.Property(t => t.CountryCode).HasColumnName("CountryCode").HasMaxLength(5);
              this.Property(t => t.SenderFirstName).HasColumnName("SenderFirstName").HasMaxLength(200);
              this.Property(t => t.SenderLastName).HasColumnName("SenderLastName").HasMaxLength(200);
              this.Property(t => t.SenderCompany).HasColumnName("SenderCompany").HasMaxLength(200);
              this.Property(t => t.SenderAddress).HasColumnName("SenderAddress").HasMaxLength(200);
              this.Property(t => t.SenderCity).HasColumnName("SenderCity").HasMaxLength(200);
              this.Property(t => t.SenderState).HasColumnName("SenderState").HasMaxLength(200);
              this.Property(t => t.SenderZip).HasColumnName("SenderZip").HasMaxLength(200);
              this.Property(t => t.SenderPhone).HasColumnName("SenderPhone").HasMaxLength(200);
         }
    }
}
