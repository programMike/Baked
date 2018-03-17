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
    
    public partial class Person
    {
        public Person()
        {
            this.Employees = new HashSet<Employee>();
            this.Sales = new HashSet<Sale>();
        }
    
        public int PersonKey { get; set; }
        public string PersonLastName { get; set; }
        public string PersonFirstName { get; set; }
        public string PersonEmail { get; set; }
        public string PersonPhone { get; set; }
        public Nullable<System.DateTime> PersonDateAdded { get; set; }
    
        public virtual ICollection<Employee> Employees { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}