//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class Attendance
    {
        public int AttendanceId { get; set; }
        public int EmployeeId { get; set; }
        public Nullable<System.DateTime> InDateTime { get; set; }
        public Nullable<System.DateTime> OutDateTime { get; set; }
    
        public virtual Employee Employee { get; set; }
    }
}