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
    
    
    internal partial class InTrackingLogInfo_Mapping : EntityTypeConfiguration<InTrackingLogInfo>
    {
        public InTrackingLogInfo_Mapping()
        {                        
              this.HasKey(t => t.ID);        
              this.ToTable("InTrackingLogInfos");
              this.Property(t => t.ID).HasColumnName("ID");
              this.Property(t => t.WayBillNumber).HasColumnName("WayBillNumber").HasMaxLength(50);
              this.Property(t => t.ProcessDate).HasColumnName("ProcessDate");
              this.Property(t => t.ProcessContent).HasColumnName("ProcessContent").HasMaxLength(300);
              this.Property(t => t.ProcessLocation).HasColumnName("ProcessLocation").HasMaxLength(100);
              this.Property(t => t.CreatedOn).HasColumnName("CreatedOn");
              this.Property(t => t.CreatedBy).HasColumnName("CreatedBy").HasMaxLength(50);
              this.Property(t => t.LastUpdatedOn).HasColumnName("LastUpdatedOn");
              this.Property(t => t.LastUpdatedBy).HasColumnName("LastUpdatedBy").HasMaxLength(50);
              this.Property(t => t.Remarks).HasColumnName("Remarks").HasMaxLength(500);
         }
    }
}