//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Cursach3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Process
    {
        public int IdProcess { get; set; }
        public int MaterialId { get; set; }
        public int ProductType { get; set; }
        public int DepartmentNumber { get; set; }
        public System.DateTime StartDateWork { get; set; }
        public System.DateTime EndDateWork { get; set; }
        public string IsCompleted { get; set; }
    
        public virtual Department Department { get; set; }
        public virtual Material Material { get; set; }
        public virtual ProductType ProductType1 { get; set; }
    }
}
