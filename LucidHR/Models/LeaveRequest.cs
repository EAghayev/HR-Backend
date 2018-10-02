
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LucidHR.Models
{

using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;

    public partial class LeaveRequest
{

    public int Id { get; set; }

    public Nullable<int> EmployeeId { get; set; }
    public string Reason { get; set; }

    public Nullable<int> LeaveTypeId { get; set; }
    
    [Required]
    public Nullable<System.DateTime> StratDate { get; set; }
    
    [Required]
    public Nullable<System.DateTime> FinishDate { get; set; }

    public Nullable<bool> IsAccepted { get; set; }



    public virtual LeaveType LeaveType { get; set; }

    public virtual Employee Employee { get; set; }

}

}
