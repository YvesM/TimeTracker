//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TimeTracker.Data
{
    [Table("Booking")]
    public class Booking : BaseEntity
    {

        public Booking() { }

        [Required]
        public DateTime BookingDate { get; set; }
        
        [Required]
        public float Duration { get; set; }
        
        public string Description { get; set; }

        public virtual User User { get; set; }

        public virtual Project Project { get; set; }
        

    }
}
