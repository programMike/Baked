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
    
    public partial class Product
    {
        public Product()
        {
            this.SaleDetails = new HashSet<SaleDetail>();
        }
    
        public int ProductKey { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
    
        public virtual ICollection<SaleDetail> SaleDetails { get; set; }
    }
}
