//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HR_Predare
{
    using System;
    using System.Collections.Generic;
    
    public partial class employee
    {
        public int id { get; set; }
        public int id_personal { get; set; }
        public System.DateTime data_in { get; set; }
        public System.DateTime data_out { get; set; }
        public int registration_nr { get; set; }
    
        public virtual personal personal { get; set; }
    }
}
