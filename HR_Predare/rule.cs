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
    
    public partial class rule
    {
        public int id { get; set; }
        public int id_level { get; set; }
        public int view_form { get; set; }
    
        public virtual level level { get; set; }
    }
}