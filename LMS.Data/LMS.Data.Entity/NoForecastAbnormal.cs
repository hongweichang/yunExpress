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
    
    public partial class NoForecastAbnormal : Entity
    {
        public virtual int NoForecastAbnormalId { get; set; }
        public virtual string CustomerCode { get; set; }
        public virtual string Number { get; set; }
        public virtual int ShippingMethodId { get; set; }
        public virtual Nullable<decimal> Weight { get; set; }
        public virtual System.DateTime CreatedOn { get; set; }
        public virtual string CreatedBy { get; set; }
        public virtual System.DateTime LastUpdatedOn { get; set; }
        public virtual string LastUpdatedBy { get; set; }
        public virtual bool IsReturn { get; set; }
    }
}