//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ALFMovers.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Employee
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Employee()
        {
            this.TransEmps = new HashSet<TransEmp>();
        }
    
        public int EmpID { get; set; }
        public string EmpFName { get; set; }
        public string EmpLName { get; set; }
        public string Position { get; set; }
        public Nullable<System.DateTime> EmpJoined { get; set; }
        public string Status { get; set; }
        public string EmpContact { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TransEmp> TransEmps { get; set; }
    }
}
