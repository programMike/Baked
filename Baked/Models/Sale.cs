//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Baked.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Sale
    {
        public Sale()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }
    
        public int SaleKey { get; set; }
        public Nullable<System.DateTime> SaleDate { get; set; }
        public Nullable<int> CustomerKey { get; set; }
        public Nullable<int> EmployeeKey { get; set; }
    
        public virtual Employee Employee { get; set; }
        public virtual Person Person { get; set; }
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}