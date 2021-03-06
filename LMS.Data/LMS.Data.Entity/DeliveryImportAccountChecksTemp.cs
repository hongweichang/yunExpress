//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LMS.Data.Entity
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using LighTake.Infrastructure.Seedwork;
    
    public partial class DeliveryImportAccountChecksTemp : Entity
    {
        public virtual int ID { get; set; }
        public virtual string OrderNumber { get; set; }
        public virtual string WayBillNumber { get; set; }
        public virtual Nullable<System.DateTime> ReceivingDate { get; set; }
        public virtual string VenderName { get; set; }
        public virtual string ShippingMethodName { get; set; }
        public virtual string CountryName { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual Nullable<decimal> SettleWeight { get; set; }
        public virtual Nullable<decimal> TotalFee { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual decimal OriginalSettleWeight { get; set; }
        public virtual decimal OriginalTotalFee { get; set; }
        public virtual decimal WeightDeviation { get; set; }
        public virtual decimal FeeDeviation { get; set; }
    }
}
